/* ======================================================
   Script de Popula��o Inicial
   Projeto: Projeto_RHotelaria
   Autor: Jansen & Vinicius
   Data: 2025-09-20
   ====================================================== */

USE Projeto_RHotelaria;
GO

/* ======================================================
   1. Inserindo Pa�s
   ====================================================== */
IF NOT EXISTS (SELECT 1 FROM SYS_Pais WHERE Sigla = 'BRA')
BEGIN
    INSERT INTO SYS_Pais (Sigla, Nome) VALUES ('BRA', 'Brasil');
END
GO

/* ======================================================
   2. Inserindo Estados
   ====================================================== */
INSERT INTO SYS_Estado (Sigla, PaisSigla, Nome) VALUES ('RJ', 'BRA', 'Rio de Janeiro');
INSERT INTO SYS_Estado (Sigla, PaisSigla, Nome) VALUES ('SP', 'BRA', 'S�o Paulo');
INSERT INTO SYS_Estado (Sigla, PaisSigla, Nome) VALUES ('MG', 'BRA', 'Minas Gerais');
INSERT INTO SYS_Estado (Sigla, PaisSigla, Nome) VALUES ('RS', 'BRA', 'Rio Grande do Sul');
INSERT INTO SYS_Estado (Sigla, PaisSigla, Nome) VALUES ('BA', 'BRA', 'Bahia');
INSERT INTO SYS_Estado (Sigla, PaisSigla, Nome) VALUES ('PR', 'BRA', 'Paran�');
GO

/* ======================================================
   3. Inserindo Cidades principais
   ====================================================== */
INSERT INTO SYS_Cidade (Nome, EstadoSigla, PaisSigla) VALUES ('Rio de Janeiro', 'RJ', 'BRA');
INSERT INTO SYS_Cidade (Nome, EstadoSigla, PaisSigla) VALUES ('Niter�i', 'RJ', 'BRA');
INSERT INTO SYS_Cidade (Nome, EstadoSigla, PaisSigla) VALUES ('S�o Paulo', 'SP', 'BRA');
INSERT INTO SYS_Cidade (Nome, EstadoSigla, PaisSigla) VALUES ('Campinas', 'SP', 'BRA');
INSERT INTO SYS_Cidade (Nome, EstadoSigla, PaisSigla) VALUES ('Belo Horizonte', 'MG', 'BRA');
INSERT INTO SYS_Cidade (Nome, EstadoSigla, PaisSigla) VALUES ('Porto Alegre', 'RS', 'BRA');
INSERT INTO SYS_Cidade (Nome, EstadoSigla, PaisSigla) VALUES ('Salvador', 'BA', 'BRA');
INSERT INTO SYS_Cidade (Nome, EstadoSigla, PaisSigla) VALUES ('Curitiba', 'PR', 'BRA');
GO

/* ======================================================
   4. Criando Role Admin
   ====================================================== */
IF NOT EXISTS (SELECT 1 FROM SYS_Role WHERE Nome = 'Admin')
BEGIN
    INSERT INTO SYS_Role (Nome) VALUES ('Admin');
END
GO

/* ======================================================
   5. Criando Documentos do Admin
   ====================================================== */
IF NOT EXISTS (SELECT 1 FROM RH_DocumentosFuncionario WHERE RG = '1234567890')
BEGIN
    INSERT INTO RH_DocumentosFuncionario (RG, CPF, TituloEleitor, CTPS_Numero, CTPS_Serie, PIS, DataCriacao)
    VALUES ('1234567890', '12345678901', '123456789012', '12345', '001', '12345678901', GETDATE());
END
GO

/* ======================================================
   6. Criando Endere�o do Admin
   ====================================================== */
DECLARE @EnderecoId INT;

INSERT INTO RH_Endereco (CidadeNome, EstadoSigla, PaisSigla, Logradouro, Numero, Complemento, Bairro, CEP)
VALUES ('Rio de Janeiro', 'RJ', 'BRA', 'Av. Atl�ntica', '1000', 'Apto 101', 'Copacabana', '22070000');

SET @EnderecoId = SCOPE_IDENTITY();

-- Vincular o endere�o ao documento
IF NOT EXISTS (SELECT 1 FROM RH_DocumentoEndereco WHERE RG = '1234567890')
BEGIN
    INSERT INTO RH_DocumentoEndereco (RG, EnderecoId)
    VALUES ('1234567890', @EnderecoId);
END
GO

/* ======================================================
   7. Criando Funcion�rio Admin
   ====================================================== */
IF NOT EXISTS (SELECT 1 FROM RH_Funcionario WHERE RG = '1234567890')
BEGIN
    INSERT INTO RH_Funcionario (RG, Nome, DataNascimento, Cargo, Departamento, DataAdmissao, Salario)
    VALUES ('1234567890', 'Administrador do Sistema', '1990-01-01', 'Administrador', 'TI', GETDATE(), 5000.00);
END
GO

/* ======================================================
   8. Criando Usu�rio Admin
   ====================================================== */
IF NOT EXISTS (SELECT 1 FROM SYS_Usuario WHERE Login = 'admin')
BEGIN
    INSERT INTO SYS_Usuario (RG, Login, Senha, Role, CriadoEm)
    VALUES ('1234567890', 'admin', '$2a$11$SenhaHashGeradaPeloBCryptAqui', 'Admin', SYSDATETIME());
END
GO
