# 🏨 Projeto RH - Hotelaria

## 📌 Descrição
O **Projeto RH - Hotelaria** é um sistema desenvolvido em **C# WinForms** com banco de dados **SQL Server**, voltado para a gestão de **Recursos Humanos** e **Hotelaria**.  

O sistema possibilita:  
- Cadastro e gerenciamento de **funcionários**.  
- Controle de **documentos e endereços**.  
- Registro de **ponto eletrônico**.  
- Sistema de **login com roles** (RH, Funcionário, Admin).  
- Organização hierárquica de **País, Estado e Cidade**.  
- Módulo de **Hotelaria** integrado ao RH.  

---

## 🛠️ Tecnologias utilizadas
- **C# WinForms (.NET)**  
- **SQL Server**  
- **Dapper / ADO.NET** (acesso a dados)  
- **BCrypt.Net-Next** (hash de senhas)  
- **FastReport** (relatórios)  
- **Git & GitHub** (controle de versão)  

---
## 📌 Estrutura do Projeto

- **Models**: Representam as entidades do banco de dados (RH_Funcionario, SYS_Usuario, RH_Endereco, etc.).
- **Data (Repository & Interfaces)**: Responsável pela comunicação com o banco de dados via Procedures.
- **Services**: Contém as regras de negócio que utilizam os repositories.
- **Utils**: Funções utilitárias como validações e criptografia (BCrypt).
- **Forms (UI)**: Camada de apresentação (Windows Forms).

---

## 🗄️ Procedures Criadas no SQL Server

### 🔹 SYS_Usuario (`usp_UserCRUD`)
- **INSERT**: Criação de novos usuários.
- **UPDATE**: Alteração de dados de usuários existentes.
- **DELETE**: Exclusão de usuários.
- **SELECT**: Busca de usuários por Id, RG ou Login.

### 🔹 RH_Funcionario (`usp_RH_FuncionarioCRUD`)
- **INSERT**: Cadastro de funcionários.
- **UPDATE**: Alteração de dados de funcionários.
- **DELETE**: Exclusão de funcionários.
- **SELECT**: Consulta de funcionários por RG, Nome, DataNascimento ou DataAdmissao.

### 🔹 RH_DocumentosFuncionario (`usp_RH_DocumentosFuncionario`)
- **INSERT**: Cadastro de documentos (RG, CPF, CNH, CTPS, etc.).
- **UPDATE**: Alteração de documentos.
- **DELETE**: Exclusão de documentos.
- **SELECT**: Consulta de documentos por RG ou CPF.

### 🔹 RH_Endereco (`usp_RH_Endereco`)
- **INSERT**: Cadastro de endereços.
- **UPDATE**: Alteração de endereços.
- **DELETE**: Exclusão de endereços.
- **SELECT**: Consultas filtradas (Cidade, Estado, País, CEP ou Bairro).

### 🔹 RH_DocumentoEndereco (`usp_RH_DocumentoEndereco`)
- **INSERT**: Vincula um funcionário a um endereço.
- **UPDATE**: Atualiza vínculo de endereço de funcionário.
- **DELETE**: Remove vínculo entre funcionário e endereço.
- **SELECT**: Lista endereços de um funcionário específico ou todos os vínculos.

---

## 📂 Interfaces Criadas

- `IRH_Funcionario`
- `ISYS_Usuario`
- `IRH_DocumentosFuncionario`
- `IRH_Endereco`
- `IRH_DocumentoEndereco`

Cada interface define os métodos CRUD necessários para acessar os dados, garantindo separação de responsabilidades e fácil manutenção.

---

## 📚 Repositories Criados

- `RH_FuncionarioRepository`
- `SYS_UsuarioRepository`
- `RH_DocumentosFuncionarioRepository`
- `RH_EnderecoRepository`
- `RH_DocumentoEnderecoRepository`

Os repositories implementam as interfaces e executam as **Stored Procedures** utilizando ADO.NET (`SqlConnection`, `SqlCommand`, `SqlDataReader`).

---

## 🔐 Criptografia (Utils)

A classe `Criptografia` implementa o **BCrypt** para garantir a segurança das senhas dos usuários:

- `HashSenha(string senha)` → Gera o hash seguro da senha.
- `Verificar(string senha, string hashDB)` → Verifica se a senha informada corresponde ao hash armazenado.

---

## 🏗️ Arquitetura Final

- **Models** → Representação das tabelas.
- **Repositories** → Comunicação com o banco via Procedures.
- **Services** → Regras de negócio.
- **Utils** → Funções auxiliares (Validações, Criptografia).
- **UI (Forms)** → Camada de apresentação.

---

## 🚀 Próximos Passos

- Implementar os **Services** para conectar UI ↔ Repository.
- Criar formulários de cadastro e login.
- Testar a integração com o banco de dados.
- Documentar casos de uso.

---

## 📖 Tecnologias Utilizadas

- C# (.NET Framework 4.8, Windows Forms)
- SQL Server (Procedures e Relacionamentos)
- BCrypt.Net (Criptografia)
- Git & GitHub

---
