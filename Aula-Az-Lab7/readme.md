# Resumo do Lab — Banco de Dados no Microsoft Azure (DIO)

> **Objetivo:** Criar e configurar um banco de dados gerenciado no Azure e documentar os aprendizados em um repositório público no GitHub.

## O que aprendi
- Diferença entre **Azure SQL Database** (rápido/econômico para POCs) e **SQL Managed Instance** (maior compatibilidade e rede privada).
- Organização de recursos: **Resource Group**, **região**, **padrões de nome**.
- **Rede e segurança**: VNet/Sub-rede (para MI), **firewall por IP** no Azure SQL Database, autenticação com **SQL Login** e noções de **Azure AD**.
- **Custos**: quando usar **Serverless + Auto-pause**; remover recursos ao final do estudo.
- Ferramentas: **Azure Data Studio/SSMS** para conectar e validar.
- **Git/GitHub**: como estruturar README, imagens e scripts para replicar o lab.

## Passo a passo que executei (resumo)
1. Criei **Resource Group** em `Brazil South`.
2. Provisionei **servidor lógico** e **database** (modo **serverless**).
3. Liberei meu **IP** no **firewall** do servidor.
4. Conectei via **Azure Data Studio** e rodei um **SQL de validação**.
5. Registrei prints e publiquei o resumo no GitHub.

## SQL de validação (opcional)
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
VALUES ('Ana Lima','ana@example.com'),
       ('João Souza','joao@example.com');
SELECT * FROM demo.Clientes;
