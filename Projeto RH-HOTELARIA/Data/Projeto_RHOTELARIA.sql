Create database Projeto_RHotelaria;

use Projeto_RHotelaria;

BEGIN -- Regi�o: Localiza��o

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

BEGIN -- Regi�o: Endere�os

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

BEGIN -- Regi�o: Documentos

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

BEGIN --Regi�o: Login

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
        SELECT UsuarioId, RG, Login, Role, CriadoEm
		FROM SYS_Usuario
		WHERE (@Id IS NULL OR UsuarioId = @Id)
			AND (@RG IS NULL OR LTRIM(RTRIM(RG)) = LTRIM(RTRIM(@RG)))
			AND (@Login IS NULL OR Login = @Login);
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
		SELECT RG, Nome, DataNascimento, Cargo, Departamento, DataAdmissao, DataDemissao, Salario
		FROM RH_Funcionario
		WHERE (@RG IS NULL OR LTRIM(RTRIM(RG)) = LTRIM(RTRIM(@RG)))
			AND (@Nome IS NULL OR Nome LIKE '%' + @Nome + '%')
			AND (@DataNascimento IS NULL OR DataNascimento = @DataNascimento)
			AND (@DataAdmissao IS NULL OR DataAdmissao = @DataAdmissao);
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

	ELSE IF (@acao = 4) -- SELECT (Read)
	BEGIN
		SELECT RG, CPF, TituloEleitor, CTPS_Numero, CTPS_Serie, CNH_Numero, CNH_Categoria, CNH_Validade, Passaporte, PIS, DataCriacao
		FROM RH_DocumentosFuncionario
		WHERE (@RG IS NULL OR LTRIM(RTRIM(RG)) = LTRIM(RTRIM(@RG)))
			AND (@CPF IS NULL OR LTRIM(RTRIM(CPF)) = LTRIM(RTRIM(@CPF)));
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
		SELECT EnderecoId, CidadeNome, EstadoSigla, PaisSigla, Logradouro, Numero, Complemento, Bairro, CEP
		FROM RH_Endereco
		WHERE (@CidadeNome IS NULL OR CidadeNome LIKE '%' + @CidadeNome + '%')
			AND (@EstadoSigla IS NULL OR RTRIM(PaisSigla) = @PaisSigla)
			AND (@PaisSigla IS NULL OR RTRIM(PaisSigla) = @PaisSigla)
			AND (@CEP IS NULL OR RTRIM(CEP) = @CEP)
			AND (@Bairro IS NULL OR Bairro LIKE '%' + @Bairro + '%');
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
		SELECT de.RG, e.EnderecoId, e.Logradouro, e.Numero, e.Bairro, e.CEP, e.CidadeNome
		FROM RH_DocumentoEndereco de
			INNER JOIN RH_Endereco e ON de.EnderecoId = e.EnderecoId
		WHERE (@RG IS NULL OR de.RG = @RG)
			AND (@EnderecoId IS NULL OR e.EnderecoId = @EnderecoId);
	END;
END;
GO
