CREATE DATABASE Projeto_RHotelaria;
USE Projeto_RHotelaria;
GO

-----------------------------
-- REGIÃO: LOCALIZAÇÃO
-----------------------------
CREATE TABLE SYS_Pais (
    Nome NVARCHAR(100) PRIMARY KEY,
    Sigla CHAR(3) NOT NULL UNIQUE
);

CREATE TABLE SYS_Estado (
    Nome NVARCHAR(100) PRIMARY KEY,
    Sigla CHAR(2) NOT NULL,
    PaisNome NVARCHAR(100) NOT NULL,
    FOREIGN KEY (PaisNome) REFERENCES SYS_Pais(Nome)
);

CREATE TABLE SYS_Cidade (
    Nome NVARCHAR(150) PRIMARY KEY,
    EstadoNome NVARCHAR(100) NOT NULL,
    FOREIGN KEY (EstadoNome) REFERENCES SYS_Estado(Nome)
);
GO

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
    CidadeNome NVARCHAR(150) NOT NULL,
    FOREIGN KEY (CidadeNome) REFERENCES SYS_Cidade(Nome)
);
GO

-----------------------------
-- REGIÃO: PESSOAS
-----------------------------
CREATE TABLE RH_Pessoa (
    Nome NVARCHAR(200) PRIMARY KEY,
    DataNascimento DATE NOT NULL,
    Genero CHAR(1) NULL,
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
    RG NVARCHAR(15) PRIMARY KEY,
    PessoaNome NVARCHAR(200) NOT NULL,
    CPF NVARCHAR(11) NOT NULL UNIQUE,
    TituloEleitor NVARCHAR(20) NULL,
    CTPS_Numero NVARCHAR(20) NULL,
    CTPS_Serie NVARCHAR(10) NULL,
    CNH_Numero NVARCHAR(15) NULL,
    CNH_Categoria NVARCHAR(5) NULL,
    CNH_Validade DATE NULL,
    PIS NVARCHAR(20) NULL,
    DataEmissao DATETIME DEFAULT SYSDATETIME(),
    FOREIGN KEY (PessoaNome) REFERENCES RH_Pessoa(Nome)
);
GO

-----------------------------
-- REGIÃO: FUNCIONÁRIO
-----------------------------
CREATE TABLE RH_Funcionario (
    FuncionarioId INT IDENTITY(1,1) PRIMARY KEY,
    PessoaNome NVARCHAR(200) NOT NULL,
    Cargo NVARCHAR(100) NOT NULL,
    Departamento NVARCHAR(100) NOT NULL,
    DataAdmissao DATE NOT NULL,
    DataDemissao DATE NULL,
    Salario DECIMAL(12,2) NOT NULL,
    Ativo BIT DEFAULT 1,
    Foto VARBINARY(MAX) NULL,
    FOREIGN KEY (PessoaNome) REFERENCES RH_Pessoa(Nome)
);
GO

-----------------------------
-- REGIÃO: USUÁRIO
-----------------------------
CREATE TABLE SYS_Usuario (
    UsuarioId INT IDENTITY(1,1) PRIMARY KEY,
    Rg NVARCHAR(15) NOT NULL,
    Login NVARCHAR(100) NOT NULL UNIQUE,
    SenhaHash NVARCHAR(200) NOT NULL,
    Role NVARCHAR(50) NOT NULL,
    Ativo BIT DEFAULT 1,
    Foto VARBINARY(MAX) NULL,
    UltimoLogin DATETIME NULL,
    CriadoEm DATETIME DEFAULT SYSDATETIME(),
    FOREIGN KEY (Rg) REFERENCES RH_DocumentosPessoa(RG)
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

-----------------------------
-- REGIÃO: PROCEDURES
-----------------------------

-- =============================================
-- RH_Pessoa
-- =============================================
CREATE OR ALTER PROC usp_RH_Pessoa
    @Acao INT, -- 1=INSERT | 2=UPDATE | 3=DELETE | 4=SELECT
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
        SET DataNascimento = @DataNascimento,
            Genero = @Genero,
            Nacionalidade = @Nacionalidade,
            EstadoCivil = @EstadoCivil,
            EnderecoId = @EnderecoId
        WHERE Nome = @Nome;

    ELSE IF @Acao = 3
        DELETE FROM RH_Pessoa WHERE Nome = @Nome;

    ELSE IF @Acao = 4
        SELECT Nome, DataNascimento, Genero, Nacionalidade, EstadoCivil, EnderecoId, DataCriacao
        FROM RH_Pessoa
        WHERE (@Nome IS NULL OR Nome LIKE '%' + @Nome + '%');
END;
GO

-- =============================================
-- RH_Endereco
-- =============================================
CREATE OR ALTER PROC usp_RH_Endereco
    @Acao INT,
    @EnderecoId INT = NULL,
    @Logradouro NVARCHAR(200) = NULL,
    @Numero NVARCHAR(10) = NULL,
    @Complemento NVARCHAR(100) = NULL,
    @Bairro NVARCHAR(100) = NULL,
    @CEP CHAR(8) = NULL,
    @CidadeNome NVARCHAR(150) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    IF @Acao = 1
        INSERT INTO RH_Endereco (Logradouro, Numero, Complemento, Bairro, CEP, CidadeNome)
        VALUES (@Logradouro, @Numero, @Complemento, @Bairro, @CEP, @CidadeNome);

    ELSE IF @Acao = 2
        UPDATE RH_Endereco
        SET Logradouro = @Logradouro,
            Numero = @Numero,
            Complemento = @Complemento,
            Bairro = @Bairro,
            CEP = @CEP,
            CidadeNome = @CidadeNome
        WHERE EnderecoId = @EnderecoId;

    ELSE IF @Acao = 3
        DELETE FROM RH_Endereco WHERE EnderecoId = @EnderecoId;

    ELSE IF @Acao = 4
        SELECT EnderecoId, Logradouro, Numero, Complemento, Bairro, CEP, CidadeNome
        FROM RH_Endereco
        WHERE (@EnderecoId IS NULL OR EnderecoId = @EnderecoId)
          AND (@Bairro IS NULL OR Bairro LIKE '%' + @Bairro + '%');
END;
GO

-- =============================================
-- RH_DocumentosPessoa
-- =============================================
CREATE OR ALTER PROC usp_RH_DocumentosPessoa
    @Acao INT,
    @RG NVARCHAR(15) = NULL,
    @PessoaNome NVARCHAR(200) = NULL,
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
        INSERT INTO RH_DocumentosPessoa (RG, PessoaNome, CPF, TituloEleitor, CTPS_Numero, CTPS_Serie, CNH_Numero, CNH_Categoria, CNH_Validade, PIS)
        VALUES (@RG, @PessoaNome, @CPF, @TituloEleitor, @CTPS_Numero, @CTPS_Serie, @CNH_Numero, @CNH_Categoria, @CNH_Validade, @PIS);

    ELSE IF @Acao = 2
        UPDATE RH_DocumentosPessoa
        SET PessoaNome = @PessoaNome,
            CPF = @CPF,
            TituloEleitor = @TituloEleitor,
            CTPS_Numero = @CTPS_Numero,
            CTPS_Serie = @CTPS_Serie,
            CNH_Numero = @CNH_Numero,
            CNH_Categoria = @CNH_Categoria,
            CNH_Validade = @CNH_Validade,
            PIS = @PIS
        WHERE RG = @RG;

    ELSE IF @Acao = 3
        DELETE FROM RH_DocumentosPessoa WHERE RG = @RG;

    ELSE IF @Acao = 4
        SELECT RG, PessoaNome, CPF, TituloEleitor, CTPS_Numero, CTPS_Serie, CNH_Numero, CNH_Categoria, CNH_Validade, PIS, DataEmissao
        FROM RH_DocumentosPessoa
        WHERE (@PessoaNome IS NULL OR PessoaNome = @PessoaNome)
          AND (@RG IS NULL OR RG = @RG)
          AND (@CPF IS NULL OR CPF = @CPF);
END;
GO

-- =============================================
-- RH_Funcionario
-- =============================================
CREATE OR ALTER PROC usp_RH_Funcionario
    @Acao INT,
    @FuncionarioId INT = NULL,
    @PessoaNome NVARCHAR(200) = NULL,
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
        INSERT INTO RH_Funcionario (PessoaNome, Cargo, Departamento, DataAdmissao, DataDemissao, Salario, Ativo, Foto)
        VALUES (@PessoaNome, @Cargo, @Departamento, @DataAdmissao, @DataDemissao, @Salario, @Ativo, @Foto);

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
        SELECT 
            f.FuncionarioId, 
            f.PessoaNome, 
            f.Cargo, 
            f.Departamento, 
            f.DataAdmissao, 
            f.DataDemissao, 
            f.Salario, 
            f.Ativo,
            f.Foto 
        FROM RH_Funcionario f
        INNER JOIN RH_Pessoa p ON f.PessoaNome = p.Nome
        WHERE (@FuncionarioId IS NULL OR f.FuncionarioId = @FuncionarioId)
          AND (@Ativo IS NULL OR f.Ativo = @Ativo);
END;
GO

-- =============================================
-- SYS_Usuario
-- =============================================
CREATE OR ALTER PROC usp_SYS_Usuario
    @Acao INT,
    @UsuarioId INT = NULL,
    @RG NVARCHAR(15) = NULL,
    @Login NVARCHAR(100) = NULL,
    @SenhaHash NVARCHAR(200) = NULL,
    @Role NVARCHAR(50) = NULL,
    @Ativo BIT = 1,
    @Foto VARBINARY(MAX) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    IF @Acao = 1
        INSERT INTO SYS_Usuario (RG, Login, SenhaHash, Role, Ativo, Foto)
        VALUES (@RG, @Login, @SenhaHash, @Role, @Ativo, @Foto);

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
        SELECT u.UsuarioId, u.Login, u.Role, u.Ativo, u.CriadoEm, d.RG, p.Nome
        FROM SYS_Usuario u
        INNER JOIN RH_DocumentosPessoa d ON u.RG = d.RG
        INNER JOIN RH_Pessoa p ON d.PessoaNome = p.Nome
        WHERE (@UsuarioId IS NULL OR u.UsuarioId = @UsuarioId)
          AND (@Login IS NULL OR u.Login LIKE '%' + @Login + '%');
END;
GO

-- =============================================
-- SYS_Auditoria
-- =============================================
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

-- =============================================
-- Trigger de Auditoria
-- =============================================
CREATE TRIGGER trg_Auditoria_SYS_Usuario
ON SYS_Usuario
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @Acao NVARCHAR(50);
    DECLARE @Tabela NVARCHAR(100) = 'SYS_Usuario';
    DECLARE @UsuarioId INT;
    DECLARE @ChaveRegistro NVARCHAR(100);

    IF EXISTS (SELECT * FROM inserted) AND EXISTS (SELECT * FROM deleted)
        SET @Acao = 'UPDATE';
    ELSE IF EXISTS (SELECT * FROM inserted)
        SET @Acao = 'INSERT';
    ELSE
        SET @Acao = 'DELETE';

    SELECT TOP 1 @ChaveRegistro = CONVERT(NVARCHAR(100), ISNULL(i.UsuarioId, d.UsuarioId))
    FROM inserted i
    FULL JOIN deleted d ON 1=1;

    SET @UsuarioId = NULL;

    INSERT INTO SYS_Auditoria (UsuarioId, Acao, TabelaAfetada, ChaveRegistro)
    VALUES (@UsuarioId, @Acao, @Tabela, @ChaveRegistro);
END;
GO
