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