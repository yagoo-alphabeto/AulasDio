# Resumo do Lab — Banco de Dados no Microsoft Azure (DIO)

> **Objetivo:** Criar e configurar um banco de dados gerenciado no Azure e documentar os aprendizados em um repositório público no GitHub.

## O que aprendi
- Diferenças práticas entre **Azure SQL Database** (rápido e econômico para POCs) e **SQL Managed Instance** (maior compatibilidade com SQL Server e rede privada).
- Organização de recursos no **Azure**: uso de **Resource Groups**, escolha de **região** e **padrões de nomenclatura**.
- **Rede e segurança**: VNet/Sub-rede (para MI), **firewall por IP** no Azure SQL Database, autenticação com **SQL Login** e noções de **Azure AD**.
- **Custos**: quando optar por **Serverless + Auto-pause**; importância de **excluir** recursos após o uso.
- Ferramentas de conexão (**Azure Data Studio/SSMS**) e boas práticas para validação de conectividade/performance.
- **Git/GitHub**: como estruturar um repositório com README, imagens e scripts para replicar o lab.

## Passo a passo que executei (exemplo)
1. Criei **Resource Group** `rg-db-lab` na região `Brazil South`.
2. Provisionei **Azure SQL Server** `sqlsrv-<meu-usuario>` e o **Database** `sqldb-demo` (serverless).
3. Liberei meu **IP** no **firewall** do servidor.
4. Conectei via **Azure Data Studio** com a credencial de admin.
5. Validei com o SQL abaixo e registrei prints (criação, firewall, SELECT):

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

## Problemas & soluções (que encontrei ou antecipei)
- **Conexão negada**: atualizei regra de **firewall** com meu IP atual.
- **Senha inválida**: corrigi para atender às regras de complexidade.
- **Timeout/Hostname**: conferi `<servidor>.database.windows.net` e porta **1433**.

## Próximos passos
- Repetir o exercício com **SQL Managed Instance** (VNet/Sub-rede delegada) para comparar com SQL Database.
- Ativar **Automatic Tuning** e explorar **Query Performance Insight**.
- Testar **Azure AD** e **Private Endpoint** para cenários de produção.

## Links úteis
- Azure SQL Database — Quickstart
- Azure SQL Managed Instance — Quickstart
- Azure CLI (az sql / az network)
- GitHub Docs — Git e Markdown