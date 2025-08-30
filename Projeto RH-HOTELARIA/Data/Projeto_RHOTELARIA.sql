Create database Projeto_RHotelaria;

use Projeto_RHotelaria;

BEGIN -- Região: Localização

    CREATE TABLE SYS_Pais(
        Sigla CHAR(3) PRIMARY KEY,
        Nome VARCHAR(100) NOT NULL
    );

    CREATE TABLE SYS_Estado(
        Sigla CHAR(2) NOT NULL,
        PaisSigla CHAR(3) NOT NULL,
        Nome VARCHAR(100) NOT NULL,
        PRIMARY KEY(Sigla, PaisSigla),
        FOREIGN KEY(PaisSigla) REFERENCES SYS_Pais(Sigla)
    );

    CREATE TABLE SYS_Cidade(
        Nome VARCHAR(150) NOT NULL,
        EstadoSigla CHAR(2) NOT NULL,
        PaisSigla CHAR(3) NOT NULL,
        PRIMARY KEY(Nome, EstadoSigla, PaisSigla),
        FOREIGN KEY(EstadoSigla, PaisSigla) REFERENCES SYS_Estado(Sigla, PaisSigla)
    );

END
GO

BEGIN -- Região: Endereços

    CREATE TABLE RH_Endereco(
        EnderecoId INT PRIMARY KEY IDENTITY(1,1),
        CidadeNome VARCHAR(150) NOT NULL,
        EstadoSigla CHAR(2) NOT NULL,
        PaisSigla CHAR(3) NOT NULL,
        Logradouro VARCHAR(200) NOT NULL,
        Numero VARCHAR(10) NOT NULL,
        Complemento VARCHAR(100) NOT NULL,
        Bairro VARCHAR(100) NOT NULL,
        CEP CHAR(8) NOT NULL,
        FOREIGN KEY(CidadeNome, EstadoSigla, PaisSigla) 
            REFERENCES SYS_Cidade(Nome, EstadoSigla, PaisSigla)
    );

END
GO

BEGIN -- Região: Documentos

CREATE TABLE RH_DocumentosFuncionario(
	RG CHAR(15) PRIMARY KEY,
	CPF CHAR(11) NOT NULL UNIQUE,
	TituloEleitor CHAR(12) NULL,
	CTPS_Numero VARCHAR(20) NULL,
	CTPS_Serie VARCHAR(10) NULL,
	CNH_Numero VARCHAR(15) NULL,
	CNH_Categoria VARCHAR(3) NULL,
	CNH_Validade DATE NULL,
	Passaporte VARCHAR(20) NULL,
	PIS CHAR(11) NULL,
	DataCriacao DATETIME DEFAULT GETDATE()
);

CREATE TABLE RH_DocumentoEndereco(
	RG CHAR(15) NOT NULL,
	EnderecoId INT NOT NULL,
	PRIMARY KEY(RG, EnderecoId),
	FOREIGN KEY (EnderecoId) 
		REFERENCES RH_Endereco(EnderecoId),
	FOREIGN KEY (RG)
		REFERENCES RH_DocumentosFuncionario(RG)
);

CREATE TABLE RH_Funcionario(
	RG CHAR(15) PRIMARY KEY,
	Nome VARCHAR(200) NOT NULL,
	DataNascimento DATE NOT NULL,
	Cargo VARCHAR(100) NOT NULL,
	Departamento VARCHAR(100) NOT NULL,
	DataAdmissao DATE NOT NULL,
	DataDemissao DATE NULL,
	Salario DECIMAL(12,2) NOT NULL,
	FOREIGN KEY(RG)
		REFERENCES RH_DocumentosFuncionario(RG)
);

END;
GO

BEGIN --Região: Login

CREATE TABLE SYS_Role(
	Nome VARCHAR(50) PRIMARY KEY
);

CREATE TABLE SYS_Usuario(
	UsuarioId INT PRIMARY KEY IDENTITY(1,1),
	RG CHAR(15) NOT NULL UNIQUE,
	Login VARCHAR(100) NOT NULL UNIQUE,
	Senha VARCHAR(200) NOT NULL,
	Role VARCHAR(50) NOT NULL,
	CriadoEm DATETIME DEFAULT SYSDATETIME(),
	FOREIGN KEY (RG)
		REFERENCES RH_DocumentosFuncionario(RG),
	FOREIGN KEY(Role)
		REFERENCES SYS_Role(Nome)
);

END;
GO


CREATE PROC usp_UserCRUD
    @acao INT,
    @Id INT = NULL,
    @RG CHAR(15) = NULL,
    @Login VARCHAR(100) = NULL,
    @SenhaHash VARCHAR(200) = NULL,
    @Role VARCHAR(100) = NULL
AS
BEGIN
    IF (@acao = 1) -- INSERT
    BEGIN
        INSERT INTO SYS_Usuario(RG, Login, Senha, Role, CriadoEm)
        VALUES (@RG, @Login, @SenhaHash, @Role, SYSDATETIME());
    END;
    ELSE IF (@acao = 2) -- UPDATE
    BEGIN
        UPDATE SYS_Usuario 
        SET
            RG = @RG,
            Login = @Login,
            Senha = @SenhaHash,
            Role = @Role
        WHERE UsuarioId = @Id;
    END;
    ELSE IF (@acao = 3) -- DELETE
    BEGIN
        DELETE FROM SYS_Usuario
        WHERE UsuarioId = @Id;
    END;
    ELSE IF (@acao = 4) -- SELECT (Read)
    BEGIN
        IF @Id IS NULL AND @RG IS NULL AND @Login IS NULL
			SELECT UsuarioId, RG, Login, Role, CriadoEm
			FROM SYS_Usuario;

		ELSE IF @Id IS NOT NULL
			SELECT UsuarioId, RG, Login, Role, CriadoEm
			FROM SYS_Usuario
			WHERE UsuarioId = @Id;

		ELSE IF @RG IS NOT NULL
			SELECT UsuarioId, RG, Login, Role, CriadoEm
			FROM SYS_Usuario
			WHERE RG = @RG;

		ELSE IF @Login IS NOT NULL
			SELECT UsuarioId, RG, Login, Role, CriadoEm
			FROM SYS_Usuario
			WHERE Login = @Login;
    END;
END;
GO

CREATE PROC usp_RH_FuncionarioCRUD
    @acao INT,
    @RG CHAR(15) = NULL,
    @Nome VARCHAR(200) = NULL,
    @DataNascimento DATE = NULL,
    @Cargo VARCHAR(100) = NULL,
    @Departamento VARCHAR(100) = NULL,
    @DataAdmissao DATE = NULL,
    @DataDemissao DATE = NULL,
    @Salario DECIMAL(12, 2) = NULL
AS
BEGIN
    IF (@acao = 1) -- INSERT
    BEGIN
        INSERT INTO RH_Funcionario 
        (RG, Nome, DataNascimento, Cargo, Departamento, DataAdmissao, DataDemissao, Salario)
        VALUES
        (@RG, @Nome, @DataNascimento, @Cargo, @Departamento, @DataAdmissao, @DataDemissao, @Salario);
    END;

    ELSE IF (@acao = 2) -- UPDATE
    BEGIN
        UPDATE RH_Funcionario
        SET
            Nome = @Nome,
            DataNascimento = @DataNascimento,
            Cargo = @Cargo,
            Departamento = @Departamento,
            DataAdmissao = @DataAdmissao,
            DataDemissao = @DataDemissao,
            Salario = @Salario
        WHERE RG = @RG;
    END;

    ELSE IF (@acao = 3) -- DELETE
    BEGIN
        DELETE FROM RH_Funcionario
        WHERE RG = @RG;
    END;

    ELSE IF (@acao = 4) -- SELECT (Read)
    BEGIN
        IF @RG IS NULL AND @Nome IS NULL AND @DataNascimento IS NULL AND @DataAdmissao IS NULL
            SELECT RG, Nome, DataNascimento, Cargo, Departamento, DataAdmissao, DataDemissao, Salario
            FROM RH_Funcionario;

        ELSE IF @RG IS NOT NULL
            SELECT RG, Nome, DataNascimento, Cargo, Departamento, DataAdmissao, DataDemissao, Salario
            FROM RH_Funcionario
            WHERE RG = @RG;

        ELSE IF @Nome IS NOT NULL
            SELECT RG, Nome, DataNascimento, Cargo, Departamento, DataAdmissao, DataDemissao, Salario
            FROM RH_Funcionario
            WHERE Nome LIKE '%' + @Nome + '%';

        ELSE IF @DataNascimento IS NOT NULL
            SELECT RG, Nome, DataNascimento, Cargo, Departamento, DataAdmissao, DataDemissao, Salario
            FROM RH_Funcionario
            WHERE DataNascimento = @DataNascimento;

        ELSE IF @DataAdmissao IS NOT NULL
            SELECT RG, Nome, DataNascimento, Cargo, Departamento, DataAdmissao, DataDemissao, Salario
            FROM RH_Funcionario
            WHERE DataAdmissao = @DataAdmissao;
    END;
END;
GO

CREATE PROC usp_RH_DocumentosFuncionario
	@acao INT,
	@RG CHAR(15) = NULL,
	@CPF CHAR(11) = NULL,
	@TituloEleitor CHAR(12) = NULL,
	@CTPS_Numero VARCHAR(20) = NULL,
	@CTPS_Serie VARCHAR(10) = NULL,
	@CNH_Numero VARCHAR(15) = NULL,
	@CNH_Categoria VARCHAR(3) = NULL,
	@CNH_Validade DATE = NULL,
	@Passaporte VARCHAR(20) = NULL,
	@PIS CHAR(11) = NULL
AS
BEGIN
	IF (@acao = 1) -- INSERT
	BEGIN
		INSERT INTO RH_DocumentosFuncionario 
		(RG, CPF, TituloEleitor, CTPS_Numero, CTPS_Serie, CNH_Numero, CNH_Categoria, CNH_Validade, Passaporte, PIS, DataCriacao)
		VALUES
		(@RG, @CPF, @TituloEleitor, @CTPS_Numero, @CTPS_Serie, @CNH_Numero, @CNH_Categoria, @CNH_Validade, @Passaporte, @PIS, GETDATE())
	END;
	ELSE IF (@acao = 2) -- UPDATE
	BEGIN
		UPDATE RH_DocumentosFuncionario
		SET
			CPF = @CPF,
			TituloEleitor = @TituloEleitor,
			CTPS_Numero = @CTPS_Numero,
			CTPS_Serie = @CTPS_Serie,
			CNH_Numero = @CNH_Numero,
			CNH_Categoria = @CNH_Categoria,
			CNH_Validade = @CNH_Validade,
			Passaporte = @Passaporte,
			PIS = @PIS
		WHERE RG = @RG;
	END;
	ELSE IF (@acao = 3) -- DELETE
	BEGIN
		DELETE FROM RH_DocumentosFuncionario
		WHERE RG = @RG;
	END;
	ELSE IF (@acao = 4) -- SELECT(READ)
	BEGIN
		IF @RG IS NULL AND @CPF IS NULL
			SELECT RG, CPF, TituloEleitor, CTPS_Numero, CTPS_Serie, CNH_Numero, CNH_Categoria, CNH_Validade, Passaporte, PIS, DataCriacao
			FROM RH_DocumentosFuncionario;

		ELSE IF @RG IS NOT NULL
			SELECT RG, CPF, TituloEleitor, CTPS_Numero, CTPS_Serie, CNH_Numero, CNH_Categoria, CNH_Validade, Passaporte, PIS, DataCriacao
			FROM RH_DocumentosFuncionario
			WHERE RG = @RG;

		ELSE IF @CPF IS NOT NULL
			SELECT RG, CPF, TituloEleitor, CTPS_Numero, CTPS_Serie, CNH_Numero, CNH_Categoria, CNH_Validade, Passaporte, PIS, DataCriacao
			FROM RH_DocumentosFuncionario
			WHERE CPF = @CPF;
	END;
END;
GO

CREATE PROC usp_RH_Endereco
	@acao int,
	@EnderecoId INT = NULL,
	@CidadeNome VARCHAR(150) = NULL,
	@EstadoSigla CHAR(2) = NULL,
	@PaisSigla CHAR(3) = NULL,
	@Logradouro VARCHAR(200) = NULL,
	@Numero VARCHAR(10) = NULL,
	@Complemento VARCHAR(100) = NULL,
	@Bairro VARCHAR(100) = NULL,
	@CEP CHAR(8) = NULL
AS
BEGIN

	IF (@acao = 1) -- INSERT
	BEGIN
		INSERT INTO RH_Endereco
		(EnderecoId, CidadeNome, EstadoSigla, PaisSigla, Logradouro, Numero, Complemento, Bairro, CEP)
		VALUES
		(@EnderecoId, @CidadeNome, @EstadoSigla, @PaisSigla, @Logradouro, @Numero, @Complemento, @Bairro, @CEP);
	END;

	ELSE IF (@acao = 2) -- UPDATE
	BEGIN
		UPDATE RH_Endereco
		SET
			CidadeNome = @CidadeNome,
			EstadoSigla = @EstadoSigla,
			PaisSigla = @PaisSigla,
			Logradouro = @Logradouro,
			Numero = @Numero,
			Complemento = @Complemento,
			Bairro = @Bairro,
			CEP = @CEP
		WHERE EnderecoId = @EnderecoId;
	END;

	ELSE IF (@acao = 3) -- DELETE
	BEGIN 
		DELETE FROM RH_Endereco
		WHERE EnderecoId = @EnderecoId;
	END;

	ELSE IF (@acao = 4) -- SELECT (Read)
	BEGIN
		
		IF @CidadeNome IS NULL AND @EstadoSigla IS NULL AND @PaisSigla IS NULL 
		AND @CEP IS NULL AND @Bairro IS NULL
			SELECT CidadeNome, EstadoSigla, PaisSigla, Logradouro, Numero, Complemento, Bairro, CEP
			FROM RH_Endereco;
		
		ELSE IF @CidadeNome IS NOT NULL
			SELECT CidadeNome, EstadoSigla, PaisSigla, Logradouro, Numero, Complemento, Bairro, CEP
			FROM RH_Endereco WHERE CidadeNome LIKE '%' + @CidadeNome + '%';

		ELSE IF @EstadoSigla IS NOT NULL
			SELECT CidadeNome, EstadoSigla, PaisSigla, Logradouro, Numero, Complemento, Bairro, CEP
			FROM RH_Endereco WHERE RTRIM(EstadoSigla) = @EstadoSigla;

		ELSE IF @PaisSigla IS NOT NULL
			SELECT CidadeNome, EstadoSigla, PaisSigla, Logradouro, Numero, Complemento, Bairro, CEP
			FROM RH_Endereco WHERE RTRIM(PaisSigla) = @PaisSigla;

		ELSE IF @CEP IS NOT NULL
			SELECT CidadeNome, EstadoSigla, PaisSigla, Logradouro, Numero, Complemento, Bairro, CEP
			FROM RH_Endereco WHERE RTRIM(CEP) = @CEP;

		ELSE IF @Bairro  IS NOT NULL
			SELECT CidadeNome, EstadoSigla, PaisSigla, Logradouro, Numero, Complemento, Bairro, CEP
			FROM RH_Endereco WHERE Bairro LIKE '%' + @Bairro + '%';
	END;
END;
GO

CREATE PROC usp_RH_DocumentoEndereco
	@acao int,
	@RG CHAR(15) = NULL,
	@EnderecoId INT = NULL
AS
BEGIN

	IF (@acao = 1) -- INSERT
	BEGIN
		INSERT INTO RH_DocumentoEndereco (RG, EnderecoId)
		VALUES
		(@RG, @EnderecoId);
	END;

	ELSE IF (@acao = 2) -- UPDATE
	BEGIN
		UPDATE RH_DocumentoEndereco
		SET EnderecoId = @EnderecoId
		WHERE RG = @RG;
	END;

	ELSE IF (@acao = 3) -- DELETE
	BEGIN
		DELETE FROM RH_DocumentoEndereco
        WHERE RG = @RG AND EnderecoId = @EnderecoId;
	END;

	ELSE IF (@acao = 4) -- SELECT (READ)
	BEGIN
		IF @RG IS NULL
        BEGIN
            -- Lista todos os vínculos
            SELECT RG, EnderecoId
            FROM RH_DocumentoEndereco;
        END
        ELSE
        BEGIN
            -- Lista todos os endereços de um funcionário específico
            SELECT de.RG, e.EnderecoId, e.Logradouro, e.Numero, e.Bairro, e.CEP, e.CidadeNome
            FROM RH_DocumentoEndereco de
            INNER JOIN RH_Endereco e ON de.EnderecoId = e.EnderecoId
            WHERE de.RG = @RG;
        END
	END;

END;
GO
