Create database Projeto_RHotelaria;

use Projeto_RHotelaria;

-----------------------------
-- REGIÃO: LOCALIZAÇÃO
-----------------------------
CREATE TABLE SYS_Pais (
    PaisId INT IDENTITY(1,1) PRIMARY KEY,
    Nome NVARCHAR(100) NOT NULL,
    Sigla CHAR(3) NOT NULL UNIQUE
);

CREATE TABLE SYS_Estado (
    EstadoId INT IDENTITY(1,1) PRIMARY KEY,
    Nome NVARCHAR(100) NOT NULL,
    Sigla CHAR(2) NOT NULL,
    PaisId INT NOT NULL,
    FOREIGN KEY (PaisId) REFERENCES SYS_Pais(PaisId)
);

CREATE TABLE SYS_Cidade (
    CidadeId INT IDENTITY(1,1) PRIMARY KEY,
    Nome NVARCHAR(150) NOT NULL,
    EstadoId INT NOT NULL,
    FOREIGN KEY (EstadoId) REFERENCES SYS_Estado(EstadoId)
);

-----------------------------
-- REGIÃO: ENDEREÇO
-----------------------------
CREATE TABLE RH_Endereco (
    EnderecoId INT IDENTITY(1,1) PRIMARY KEY,
    Logradouro NVARCHAR(200) NOT NULL,
    Numero NVARCHAR(10) NULL,
    Complemento NVARCHAR(100) NULL,
    Bairro NVARCHAR(100) NOT NULL,
    CEP CHAR(8) NOT NULL,
    CidadeId INT NOT NULL,
    FOREIGN KEY (CidadeId) REFERENCES SYS_Cidade(CidadeId)
);
GO

-----------------------------
-- REGIÃO: PESSOAS
-----------------------------
CREATE TABLE RH_Pessoa (
    PessoaId INT IDENTITY(1,1) PRIMARY KEY,
    Nome NVARCHAR(200) NOT NULL,
    DataNascimento DATE NOT NULL,
    Genero CHAR(1) NULL, -- M/F/O
    Nacionalidade NVARCHAR(100) NULL,
    EstadoCivil NVARCHAR(50) NULL,
    EnderecoId INT NULL,
    DataCriacao DATETIME DEFAULT SYSDATETIME(),
    FOREIGN KEY (EnderecoId) REFERENCES RH_Endereco(EnderecoId)
);
GO

-----------------------------
-- REGIÃO: DOCUMENTOS
-----------------------------
CREATE TABLE RH_DocumentosPessoa (
    DocumentoId INT IDENTITY(1,1) PRIMARY KEY,
    PessoaId INT NOT NULL,
    RG NVARCHAR(15) NOT NULL UNIQUE,
    CPF NVARCHAR(11) NOT NULL UNIQUE,
    TituloEleitor NVARCHAR(20) NULL,
    CTPS_Numero NVARCHAR(20) NULL,
    CTPS_Serie NVARCHAR(10) NULL,
    CNH_Numero NVARCHAR(15) NULL,
    CNH_Categoria NVARCHAR(5) NULL,
    CNH_Validade DATE NULL,
    PIS NVARCHAR(20) NULL,
    DataEmissao DATETIME DEFAULT SYSDATETIME(),
    FOREIGN KEY (PessoaId) REFERENCES RH_Pessoa(PessoaId)
);
GO

-----------------------------
-- REGIÃO: FUNCIONÁRIO
-----------------------------
CREATE TABLE RH_Funcionario (
    FuncionarioId INT IDENTITY(1,1) PRIMARY KEY,
    PessoaId INT NOT NULL,
    Cargo NVARCHAR(100) NOT NULL,
    Departamento NVARCHAR(100) NOT NULL,
    DataAdmissao DATE NOT NULL,
    DataDemissao DATE NULL,
    Salario DECIMAL(12,2) NOT NULL,
    Ativo BIT DEFAULT 1,
    Foto VARBINARY(MAX) NULL,
    FOREIGN KEY (PessoaId) REFERENCES RH_Pessoa(PessoaId)
);
GO

-----------------------------
-- REGIÃO: USUÁRIO
-----------------------------
CREATE TABLE SYS_Usuario (
    UsuarioId INT IDENTITY(1,1) PRIMARY KEY,
    FuncionarioId INT NOT NULL,
    Login NVARCHAR(100) NOT NULL UNIQUE,
    SenhaHash NVARCHAR(200) NOT NULL,
    Role NVARCHAR(50) NOT NULL,
    Ativo BIT DEFAULT 1,
    Foto VARBINARY(MAX) NULL,
    UltimoLogin DATETIME NULL,
    CriadoEm DATETIME DEFAULT SYSDATETIME(),
    FOREIGN KEY (FuncionarioId) REFERENCES RH_Funcionario(FuncionarioId)
);
GO

-----------------------------
-- REGIÃO: AUDITORIA
-----------------------------
CREATE TABLE SYS_Auditoria (
    AuditoriaId INT IDENTITY(1,1) PRIMARY KEY,
    UsuarioId INT NULL,
    Acao NVARCHAR(100) NOT NULL,
    TabelaAfetada NVARCHAR(100) NOT NULL,
    ChaveRegistro NVARCHAR(100) NULL,
    DataHora DATETIME DEFAULT SYSDATETIME(),
    EnderecoIP NVARCHAR(50) NULL,
    FOREIGN KEY (UsuarioId) REFERENCES SYS_Usuario(UsuarioId)
);
GO

CREATE OR ALTER PROC usp_RH_Pessoa
    @Acao INT, -- 1=INSERT | 2=UPDATE | 3=DELETE | 4=SELECT
    @PessoaId INT = NULL,
    @Nome NVARCHAR(200) = NULL,
    @DataNascimento DATE = NULL,
    @Genero CHAR(1) = NULL,
    @Nacionalidade NVARCHAR(100) = NULL,
    @EstadoCivil NVARCHAR(50) = NULL,
    @EnderecoId INT = NULL
AS
BEGIN
    SET NOCOUNT ON;

    IF @Acao = 1
        INSERT INTO RH_Pessoa (Nome, DataNascimento, Genero, Nacionalidade, EstadoCivil, EnderecoId)
        VALUES (@Nome, @DataNascimento, @Genero, @Nacionalidade, @EstadoCivil, @EnderecoId);

    ELSE IF @Acao = 2
        UPDATE RH_Pessoa
        SET Nome = @Nome,
            DataNascimento = @DataNascimento,
            Genero = @Genero,
            Nacionalidade = @Nacionalidade,
            EstadoCivil = @EstadoCivil,
            EnderecoId = @EnderecoId
        WHERE PessoaId = @PessoaId;

    ELSE IF @Acao = 3
        DELETE FROM RH_Pessoa WHERE PessoaId = @PessoaId;

    ELSE IF @Acao = 4
        SELECT PessoaId, Nome, DataNascimento, Genero, Nacionalidade, EstadoCivil, EnderecoId, DataCriacao
        FROM RH_Pessoa
        WHERE (@PessoaId IS NULL OR PessoaId = @PessoaId)
          AND (@Nome IS NULL OR Nome LIKE '%' + @Nome + '%');
END;
GO

CREATE OR ALTER PROC usp_RH_Endereco
    @Acao INT,
    @EnderecoId INT = NULL,
    @Logradouro NVARCHAR(200) = NULL,
    @Numero NVARCHAR(10) = NULL,
    @Complemento NVARCHAR(100) = NULL,
    @Bairro NVARCHAR(100) = NULL,
    @CEP CHAR(8) = NULL,
    @CidadeId INT = NULL
AS
BEGIN
    SET NOCOUNT ON;

    IF @Acao = 1
        INSERT INTO RH_Endereco (Logradouro, Numero, Complemento, Bairro, CEP, CidadeId)
        VALUES (@Logradouro, @Numero, @Complemento, @Bairro, @CEP, @CidadeId);

    ELSE IF @Acao = 2
        UPDATE RH_Endereco
        SET Logradouro = @Logradouro,
            Numero = @Numero,
            Complemento = @Complemento,
            Bairro = @Bairro,
            CEP = @CEP,
            CidadeId = @CidadeId
        WHERE EnderecoId = @EnderecoId;

    ELSE IF @Acao = 3
        DELETE FROM RH_Endereco WHERE EnderecoId = @EnderecoId;

    ELSE IF @Acao = 4
        SELECT EnderecoId, Logradouro, Numero, Complemento, Bairro, CEP, CidadeId
        FROM RH_Endereco
        WHERE (@EnderecoId IS NULL OR EnderecoId = @EnderecoId)
          AND (@Bairro IS NULL OR Bairro LIKE '%' + @Bairro + '%');
END;
GO

CREATE OR ALTER PROC usp_RH_DocumentosPessoa
    @Acao INT,
    @DocumentoId INT = NULL,
    @PessoaId INT = NULL,
    @RG NVARCHAR(15) = NULL,
    @CPF NVARCHAR(11) = NULL,
    @TituloEleitor NVARCHAR(20) = NULL,
    @CTPS_Numero NVARCHAR(20) = NULL,
    @CTPS_Serie NVARCHAR(10) = NULL,
    @CNH_Numero NVARCHAR(15) = NULL,
    @CNH_Categoria NVARCHAR(5) = NULL,
    @CNH_Validade DATE = NULL,
    @PIS NVARCHAR(20) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    IF @Acao = 1
        INSERT INTO RH_DocumentosPessoa (PessoaId, RG, CPF, TituloEleitor, CTPS_Numero, CTPS_Serie, CNH_Numero, CNH_Categoria, CNH_Validade, PIS)
        VALUES (@PessoaId, @RG, @CPF, @TituloEleitor, @CTPS_Numero, @CTPS_Serie, @CNH_Numero, @CNH_Categoria, @CNH_Validade, @PIS);

    ELSE IF @Acao = 2
        UPDATE RH_DocumentosPessoa
        SET RG = @RG,
            CPF = @CPF,
            TituloEleitor = @TituloEleitor,
            CTPS_Numero = @CTPS_Numero,
            CTPS_Serie = @CTPS_Serie,
            CNH_Numero = @CNH_Numero,
            CNH_Categoria = @CNH_Categoria,
            CNH_Validade = @CNH_Validade,
            PIS = @PIS
        WHERE DocumentoId = @DocumentoId;

    ELSE IF @Acao = 3
        DELETE FROM RH_DocumentosPessoa WHERE DocumentoId = @DocumentoId;

    ELSE IF @Acao = 4
        SELECT DocumentoId, PessoaId, RG, CPF, TituloEleitor, CTPS_Numero, CTPS_Serie, CNH_Numero, CNH_Categoria, CNH_Validade, PIS, DataEmissao
        FROM RH_DocumentosPessoa
        WHERE (@PessoaId IS NULL OR PessoaId = @PessoaId)
          AND (@RG IS NULL OR RG = @RG)
          AND (@CPF IS NULL OR CPF = @CPF);
END;
GO

CREATE OR ALTER PROC usp_RH_Funcionario
    @Acao INT,
    @FuncionarioId INT = NULL,
    @PessoaId INT = NULL,
    @Cargo NVARCHAR(100) = NULL,
    @Departamento NVARCHAR(100) = NULL,
    @DataAdmissao DATE = NULL,
    @DataDemissao DATE = NULL,
    @Salario DECIMAL(12,2) = NULL,
    @Ativo BIT = 1,
    @Foto VARBINARY(MAX) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    IF @Acao = 1
        INSERT INTO RH_Funcionario (PessoaId, Cargo, Departamento, DataAdmissao, DataDemissao, Salario, Ativo, Foto)
        VALUES (@PessoaId, @Cargo, @Departamento, @DataAdmissao, @DataDemissao, @Salario, @Ativo, @Foto);

    ELSE IF @Acao = 2
        UPDATE RH_Funcionario
        SET Cargo = @Cargo,
            Departamento = @Departamento,
            DataAdmissao = @DataAdmissao,
            DataDemissao = @DataDemissao,
            Salario = @Salario,
            Ativo = @Ativo,
            Foto = @Foto
        WHERE FuncionarioId = @FuncionarioId;

    ELSE IF @Acao = 3
        DELETE FROM RH_Funcionario WHERE FuncionarioId = @FuncionarioId;

    ELSE IF @Acao = 4
        SELECT f.FuncionarioId, f.PessoaId, p.Nome, f.Cargo, f.Departamento, f.DataAdmissao, f.DataDemissao, f.Salario, f.Ativo
        FROM RH_Funcionario f
        INNER JOIN RH_Pessoa p ON f.PessoaId = p.PessoaId
        WHERE (@FuncionarioId IS NULL OR f.FuncionarioId = @FuncionarioId)
          AND (@Ativo IS NULL OR f.Ativo = @Ativo);
END;
GO

CREATE OR ALTER PROC usp_SYS_Usuario
    @Acao INT,
    @UsuarioId INT = NULL,
    @FuncionarioId INT = NULL,
    @Login NVARCHAR(100) = NULL,
    @SenhaHash NVARCHAR(200) = NULL,
    @Role NVARCHAR(50) = NULL,
    @Ativo BIT = 1,
    @Foto VARBINARY(MAX) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    IF @Acao = 1
        INSERT INTO SYS_Usuario (FuncionarioId, Login, SenhaHash, Role, Ativo, Foto)
        VALUES (@FuncionarioId, @Login, @SenhaHash, @Role, @Ativo, @Foto);

    ELSE IF @Acao = 2
        UPDATE SYS_Usuario
        SET Login = @Login,
            SenhaHash = @SenhaHash,
            Role = @Role,
            Ativo = @Ativo,
            Foto = @Foto
        WHERE UsuarioId = @UsuarioId;

    ELSE IF @Acao = 3
        DELETE FROM SYS_Usuario WHERE UsuarioId = @UsuarioId;

    ELSE IF @Acao = 4
        SELECT u.UsuarioId, u.Login, u.Role, u.Ativo, u.CriadoEm, f.FuncionarioId, p.Nome
        FROM SYS_Usuario u
        INNER JOIN RH_Funcionario f ON u.FuncionarioId = f.FuncionarioId
        INNER JOIN RH_Pessoa p ON f.PessoaId = p.PessoaId
        WHERE (@UsuarioId IS NULL OR u.UsuarioId = @UsuarioId)
          AND (@Login IS NULL OR u.Login LIKE '%' + @Login + '%');
END;
GO

CREATE OR ALTER PROC usp_SYS_Auditoria
    @Acao INT,
    @AuditoriaId INT = NULL,
    @UsuarioId INT = NULL,
    @AcaoTexto NVARCHAR(100) = NULL,
    @TabelaAfetada NVARCHAR(100) = NULL,
    @ChaveRegistro NVARCHAR(100) = NULL,
    @EnderecoIP NVARCHAR(50) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    IF @Acao = 1
        INSERT INTO SYS_Auditoria (UsuarioId, Acao, TabelaAfetada, ChaveRegistro, EnderecoIP)
        VALUES (@UsuarioId, @AcaoTexto, @TabelaAfetada, @ChaveRegistro, @EnderecoIP);

    ELSE IF @Acao = 4
        SELECT a.AuditoriaId, a.UsuarioId, u.Login, a.Acao, a.TabelaAfetada, a.ChaveRegistro, a.DataHora, a.EnderecoIP
        FROM SYS_Auditoria a
        LEFT JOIN SYS_Usuario u ON a.UsuarioId = u.UsuarioId
        WHERE (@UsuarioId IS NULL OR a.UsuarioId = @UsuarioId)
        ORDER BY a.DataHora DESC;
END;
GO

