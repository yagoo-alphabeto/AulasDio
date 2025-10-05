# 📘 Passo a Passo — Entrega do Desafio (DIO)

> Este guia em **Markdown** está pronto para você copiar e colar no seu repositório. Ele cobre desde a criação do repositório até a publicação do seu resumo do lab.

## 1) Criar uma conta no GitHub (se ainda não tiver)
1. Acesse **https://github.com/**
2. Clique em **Sign up** e siga as instruções (email, senha, usuário).
3. Confirme seu email para ativar a conta.

## 2) Criar um novo repositório
1. No GitHub (logado), clique no ícone **+** (canto superior direito) → **New repository**.
2. Defina um **nome** (ex.: `resumo-do-lab`).
3. Adicione uma **descrição** (ex.: “Resumo das lições aprendidas durante o desenvolvimento do lab na DIO”).
4. Marque **Initialize this repository with a README** para criar o `README.md` automaticamente.
5. Clique em **Create repository**.

## 3) Editar o arquivo `README.md`
1. No repositório recém-criado, clique no arquivo **README.md**.
2. Clique no ícone de lápis (**🖉**) para **editar**.
3. Cole o **resumo do que você aprendeu** (modelo abaixo em _“Modelo de Resumo”_).
4. Role a página até **Commit changes** e confirme a alteração (opcionalmente adicione uma mensagem de commit).

## 4) Obter o link do repositório
1. Na **página principal** do seu repositório, copie o link da barra de endereços (ex.: `https://github.com/seu-usuario/resumo-do-lab`).
2. Guarde este link para **entregar na DIO**.

## 5) Entregar o link na DIO
1. Volte à página do desafio na DIO.
2. Clique em **Entregar Projeto** e cole o link do seu repositório.
3. Envie a entrega.

---

## 📝 Modelo de Resumo (cole no README.md)

# Resumo do Lab — Configurando Banco de Dados no Microsoft Azure (DIO)

> **Objetivo do lab:** praticar a criação e a configuração de um banco de dados gerenciado no Azure, documentando o processo e publicando um resumo no GitHub.

## O que eu aprendi
- Diferença entre **Azure SQL Database** (POC, rápido e mais barato) e **SQL Managed Instance** (compatibilidade maior, rede privada).
- Organização dos recursos: **Resource Group**, **região**, **nomenclatura padronizada**.
- Conceitos de **rede e segurança**: VNet/Sub-rede (MI), firewall por IP (SQL Database), autenticação (SQL Login / Azure AD).
- **Custos**: uso de **serverless** + **auto-pause**; remover recursos ao final do estudo.
- Ferramentas: **Azure Data Studio** / **SSMS** para conectar e validar.
- **Git/GitHub**: como documentar e versionar o aprendizado.

## Passo a passo que executei (exemplo)
1. Criei o **Resource Group** `rg-db-lab` em `Brazil South`.
2. Criei o **Servidor Lógico** `sqlsrv-<meu-usuario>` e o **Database** `sqldb-demo` (serverless).
3. Liberei meu **IP** no **firewall** do servidor.
4. Conectei via **Azure Data Studio** com o usuário admin.
5. Rodei este SQL de validação:
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
6. Registrei prints (criação do servidor/DB, firewall, SELECT) e publiquei no GitHub.

## CLI (opcional) — comandos que usei/testei
```bash
LOCATION="brazilsouth"
RG="rg-db-lab"
SQL_SERVER="sqlsrv-<meu-usuario>"
SQL_DB="sqldb-demo"
ADMIN_USER="sqladmin"
ADMIN_PASS="<DefinaUmaSenhaForte!123>"
CLIENT_IP="<meu_IP_publico>"

az group create -n $RG -l $LOCATION

az sql server create -l $LOCATION -g $RG -n $SQL_SERVER \
  -u $ADMIN_USER -p $ADMIN_PASS

az sql server firewall-rule create -g $RG -s $SQL_SERVER -n allow-client-ip \
  --start-ip-address $CLIENT_IP --end-ip-address $CLIENT_IP

az sql db create -g $RG -s $SQL_SERVER -n $SQL_DB \
  --service-objective GP_S_Gen5_2 --compute-model Serverless --auto-pause-delay 60
```

## Problemas & soluções (exemplos)
- **Conexão negada** → Atualizei a regra de **firewall** com meu IP atual.
- **Senha inválida** → Ajustei para política de complexidade.
- **Timeout** → Confirmei o **hostname** `<servidor>.database.windows.net` e porta **1433**.

## Próximos passos
- Repetir com **SQL Managed Instance** (VNet/Sub-rede delegada) e comparar.
- Ativar **Automatic Tuning** e **Query Performance Insight**.
- Testar **Azure AD** e **Private Endpoint**.

## Links úteis
- Azure SQL Database — Quickstart  
- Azure SQL Managed Instance — Quickstart  
- Azure CLI (az sql, az network)  
- GitHub Docs — Git e Markdown  

---


