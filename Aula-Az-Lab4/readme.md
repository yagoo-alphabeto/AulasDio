# 🧭 Entrega do Desafio — Passo a Passo + Modelo de Resumo (DIO)

Este arquivo reúne **o passo a passo de entrega** e um **modelo pronto de resumo** para você colocar no seu repositório público no GitHub.

---

## ✅ Passo a Passo (GitHub)

### 1) Crie uma conta no GitHub (se ainda não tiver)
- Acesse **https://github.com/**
- Clique em **Sign up** e siga as instruções para criar sua conta.

### 2) Crie um novo repositório
- No seu perfil do GitHub, clique no ícone **“+”** (canto superior direito).
- Selecione **New repository**.
- Defina um nome (ex.: `resumo-do-lab`).
- Adicione uma descrição (ex.: “Este repositório contém o resumo das lições aprendidas durante o desenvolvimento do lab na DIO”).  
- Marque **Initialize this repository with a README** para criar o arquivo `README.md` automaticamente.
- Clique em **Create repository**.

### 3) Edite o arquivo `README.md`
- No repositório recém-criado, clique no arquivo **README.md**.
- Clique no ícone de lápis (**🖉**) para editar.
- No editor, **cole seu resumo** (use o modelo abaixo).
- Role até **Commit changes** e confirme para salvar.

### 4) Obtenha o link do repositório
- Na página principal do repositório, copie o link da barra de endereços (ex.: `https://github.com/seu-usuario/resumo-do-lab`).

### 5) Compartilhe o link na DIO
- Volte à página do desafio.
- Clique em **Entregar Projeto** e cole o link do repositório.
- Envie.

---

## 📝 Modelo de Resumo (cole no seu `README.md`)

# Resumo do Lab — Banco de Dados no Microsoft Azure (DIO)

> **Objetivo:** Criar e configurar um banco de dados gerenciado no Azure e documentar os aprendizados em um repositório público no GitHub.

## O que aprendi
- Diferenças entre **Azure SQL Database** (rápido/econômico para POCs) e **SQL Managed Instance** (maior compatibilidade e rede privada).
- Organização de recursos no Azure: **Resource Group**, **região** e **padrões de nome**.
- Noções de **rede e segurança**: VNet/Sub-rede (para MI), **firewall por IP** no Azure SQL Database, autenticação com **SQL Login** e **Azure AD**.
- **Custos**: quando usar **Serverless + Auto-pause**; importância de **excluir** recursos ao final do estudo.
- Ferramentas de conexão (**Azure Data Studio/SSMS**) e validações básicas de conectividade.
- Como usar **Git/GitHub** para versionar e apresentar o aprendizado.

## Passo a passo que executei (resumo)
1. Criei **Resource Group** em `Brazil South`.
2. Provisionei **servidor lógico** e **database** (serverless).
3. Liberei meu **IP** no **firewall** do servidor.
4. Conectei via **Azure Data Studio** e validei com um `SELECT`.
5. Registrei prints e publiquei este resumo no GitHub.

## Script SQL de validação (opcional)
```sql
CREATE SCHEMA demo AUTHORIZATION dbo;
GO

CREATE TABLE demo.Clientes (
  Id INT IDENTITY PRIMARY KEY,
  Nome NVARCHAR(120) NOT NULL,
  Email NVARCHAR(200) UNIQUE,
  CriadoEm DATETIME2 DEFAULT SYSUTCDATETIME()
);
GO

INSERT INTO demo.Clientes (Nome, Email)
VALUES ('Ana Lima', 'ana@example.com'),
       ('João Souza', 'joao@example.com');

SELECT * FROM demo.Clientes;
```

## Próximos passos
- Repetir com **SQL Managed Instance** e comparar com SQL Database.
- Ativar **Automatic Tuning** e explorar **Query Performance Insight**.
- Testar **Azure AD** e **Private Endpoint** para cenários de produção.

## Links úteis
- Azure SQL Database — Quickstart  
- Azure SQL Managed Instance — Quickstart  
- Azure CLI (az sql / az network)  
- GitHub Docs — Git e Markdown  

