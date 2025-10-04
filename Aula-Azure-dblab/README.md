# Configurando uma Instância de Banco de Dados no Microsoft Azure — Guia + Repositório de Estudos

> **Objetivo**: praticar a criação de uma instância de **banco de dados gerenciado no Azure** e documentar o processo em um repositório público, com resumos, anotações e dicas.

## 📚 Sumário
- [Por que este projeto?](#-por-que-este-projeto)
- [Pré-requisitos](#-pré-requisitos)
- [Arquitetura e opções](#-arquitetura-e-opções)
- [Caminho A — Instância Gerenciada do SQL do Azure (Managed Instance)](#-caminho-a--instância-gerenciada-do-sql-do-azure-managed-instance)
- [Caminho B — Banco de Dados SQL do Azure (opção mais rápida/barata)](#-caminho-b--banco-de-dados-sql-do-azure-opção-mais-rápidabarata)
- [Conectando e testando](#-conectando-e-testando)
- [Boas práticas e custos](#-boas-práticas-e-custos)
- [Problemas comuns (troubleshooting)](#-problemas-comuns-troubleshooting)
- [Como publicar este repositório](#-como-publicar-este-repositório)
- [Screenshots](#-screenshots)
- [Referências úteis](#-referências-úteis)
- [Licença](#-licença)

---

## 💡 Por que este projeto?
Este laboratório foi feito para consolidar sua prática com **serviços de banco de dados gerenciados no Azure**, exercitando:
- Criação de recursos via **Portal** e/ou **CLI**;
- Registro de **passo a passo** com **prints**;
- Publicação no **GitHub** em formato claro e reaproveitável.

> **Dica**: se sua assinatura do Azure tiver limites de custo/quota, execute o **Caminho B (SQL Database)** que é mais simples e barato. Documente ambos no seu README, explicando a escolha.

---

## ✅ Pré-requisitos
- Assinatura do **Microsoft Azure** com permissões de *Owner* ou *Contributor* no Resource Group usado.
- **Azure CLI** instalada (ou use o Cloud Shell do Azure).
- Uma ferramenta cliente para SQL (ex.: **Azure Data Studio** ou **SQL Server Management Studio**).
- Conceitos básicos de **rede** (VNets, sub-redes) e **segurança**.

---

## 🏗 Arquitetura e opções

```mermaid
flowchart LR
  subgraph Azure
    RG[Resource Group]
    VNET[VNet + Subnet]
    NSG[NSG / Regras]
    RT[Route Table (opcional)]
    MI[SQL Managed Instance]:::db
    SQLDB[Azure SQL Database]:::db
  end

  RG --> VNET
  VNET --> NSG
  VNET --> RT
  VNET --> MI
  RG --> SQLDB

classDef db fill:#e8f5ff,stroke:#4da3ff,stroke-width:1px
```
- **Caminho A — SQL Managed Instance (MI)**: máxima compatibilidade com SQL Server e rede privada (requer VNet/sub-rede delegada). *Provisionamento pode levar horas*.
- **Caminho B — Azure SQL Database**: mais simples e barato, ideal para estudo rápido e POCs.

---

## 🅰️ Caminho A — Instância Gerenciada do SQL do Azure (Managed Instance)

### Opção 1: Portal (passo a passo resumido)
1. **Resource Group** → *Create resource* > *Resource group* → Ex.: `rg-db-lab` (Região próxima de você).
2. **Rede** → *Virtual networks* → *Create* → `vnet-db-lab` com **sub-rede dedicada** para MI (ex.: `snet-mi` / 10.10.0.0/24) e **delegação** `Microsoft.Sql/managedInstances`.
3. **Segurança** → NSG associado à sub-rede (entradas/saídas conforme necessidade). Se for acessar via jumpbox/Bastion, ajuste regras.
4. **Managed Instance** → *Create* → configure:
   - **General**: nome `mi-demo`, compute (ex.: 4 vCores), storage (ex.: 32–64 GB).
   - **Network**: selecione **sua VNet** e a **sub-rede delegada**.
   - **Authentication**: crie usuário **SQL** (ex.: `sqladmin`) e senha forte. (Opcional: Azure AD auth.)
   - **Backup/Manutenção**: padrões do serviço são ok no laboratório.
5. **Review + Create** → o deploy pode levar **2–6 horas**. Documente o status.

> Coloque *screenshots* de cada etapa na pasta `/images` e referencie aqui.

### Opção 2: CLI (script de exemplo)
> Use o **Azure Cloud Shell** (bash) ou sua CLI local. Ajuste **nomes, regiões e ranges de IP** conforme o seu ambiente.
```bash
# Login
az login

# Variáveis
LOCATION="brazilsouth"
RG="rg-db-lab"
VNET="vnet-db-lab"
SUBNET="snet-mi"
SUBNET_RANGE="10.10.0.0/24"
MI_NAME="mi-demo"
ADMIN_USER="sqladmin"
ADMIN_PASS="<DefinaUmaSenhaForte!123>"

# Resource Group
az group create -n $RG -l $LOCATION

# VNet + Sub-rede delegada para MI
az network vnet create -g $RG -n $VNET --address-prefixes 10.10.0.0/16 \
  --subnet-name $SUBNET --subnet-prefixes $SUBNET_RANGE

# Delegação da sub-rede para Microsoft.Sql/managedInstances
az network vnet subnet update -g $RG --vnet-name $VNET -n $SUBNET \
  --delegations "Microsoft.Sql/managedInstances"

# (Opcional) NSG + associação
az network nsg create -g $RG -n nsg-mi
az network vnet subnet update -g $RG --vnet-name $VNET -n $SUBNET \
  --network-security-group nsg-mi

# Criar a Managed Instance (provisionamento demorado)
az sql mi create -g $RG -n $MI_NAME -l $LOCATION \
  --admin-user $ADMIN_USER --admin-password $ADMIN_PASS \
  --subnet /subscriptions/<SUB_ID>/resourceGroups/$RG/providers/Microsoft.Network/virtualNetworks/$VNET/subnets/$SUBNET \
  --license-type BasePrice --compute-model Provisioned --capacity 4 --storage 32 --tier GeneralPurpose
```

> **Importante**: substitua `<SUB_ID>` pela sua Subscription ID. Em alguns cenários, rotas/UDRs e DNS privado podem ser necessários dependendo do padrão de rede da sua organização.

---

## 🅱️ Caminho B — Banco de Dados SQL do Azure (opção mais rápida/barata)

### Portal
1. *Create resource* → **Azure SQL** → **SQL database**.
2. **Basics**: RG `rg-db-lab`, nome `sqldb-demo`, **Server**: *Create new* (ex.: `sqlsrv-yagoo`), tipo **SQL Authentication** (usuário/senha).
3. **Compute + Storage**: `Basic` ou `General Purpose serverless` (economiza quando ocioso).
4. **Networking**: para laboratório, habilite **Allow public access** e **Add current client IP** (fácil para conectar).
5. **Review + Create**.

### CLI (script de exemplo)
```bash
LOCATION="brazilsouth"
RG="rg-db-lab"
SQL_SERVER="sqlsrv-yagoo"
SQL_DB="sqldb-demo"
ADMIN_USER="sqladmin"
ADMIN_PASS="<DefinaUmaSenhaForte!123>"
CLIENT_IP=$(curl -s https://ifconfig.me)  # se estiver em shell local

az group create -n $RG -l $LOCATION

# Servidor lógico
az sql server create -l $LOCATION -g $RG -n $SQL_SERVER \
  -u $ADMIN_USER -p $ADMIN_PASS

# Regra de firewall para seu IP (simples)
az sql server firewall-rule create -g $RG -s $SQL_SERVER -n allow-client-ip \
  --start-ip-address $CLIENT_IP --end-ip-address $CLIENT_IP

# Banco de dados
az sql db create -g $RG -s $SQL_SERVER -n $SQL_DB \
  --service-objective GP_S_Gen5_2 --compute-model Serverless --auto-pause-delay 60
```

> **Nota**: troque o *service-objective* por um mais barato se preferir (ex.: `Basic` em regiões que suportem).

---

## 🧪 Conectando e testando
Use **Azure Data Studio** ou **SSMS** para conectar com o usuário admin criado.

Exemplo de script SQL para validar o ambiente:
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

> Faça um print do resultado da query e salve em `/images/teste-select.png`.

---

## 🧭 Boas práticas e custos
- **Naming**: padronize (`rg-`, `vnet-`, `sqlsrv-`, `sqldb-`, `mi-`).
- **Segurança**: evite exposição ampla. Use **firewall por IP**, **Azure AD** e **Private Endpoints** quando possível.
- **Custos**: para laboratório, prefira *Serverless* com *auto-pause*. **Delete** recursos após concluir para evitar cobranças.
- **Backups/DR**: entenda *PITR*, *LRS/ZRS/GZRS* e políticas de retenção.
- **Observabilidade**: ative *Query Performance Insight*, *Automatic tuning* e *Alerts*.

---

## 🆘 Problemas comuns (troubleshooting)
- **MI demorando para provisionar**: é normal levar horas. Documente o status; verifique delegação de sub-rede e cotas.
- **Conexão negada (SQL Database)**: confira regra de firewall do servidor e o IP do cliente.
- **Erro de senha inválida**: políticas de complexidade; evite caracteres bloqueados pelo shell.
- **Timeouts**: verifique NSG/rotas, endpoints privados e DNS, conforme topologia.

---

## 🚀 Como publicar este repositório

```bash
# 1) Crie um repositório vazio no GitHub (público).
# 2) No seu projeto local:
git init
git add .
git commit -m "docs: laboratório Azure DB (DIO)"
git branch -M main
git remote add origin https://github.com/<seu-usuario>/<seu-repo>.git
git push -u origin main
```

Em seguida, clique em **“Entregar Projeto”** na plataforma da DIO e cole o link do seu repositório.

---

## 🖼 Screenshots
Coloque seus prints aqui e referencie no texto:
- `/images/01-rg.png`
- `/images/02-vnet-subnet.png`
- `/images/03-mi-create.png`
- `/images/04-sql-server-db.png`
- `/images/05-azure-data-studio.png`
- `/images/teste-select.png`

---

## 🔗 Referências úteis
- **Azure SQL Managed Instance — Quickstart** (criar via portal/CLI)
- **Azure SQL Database — Quickstart**
- **Azure CLI** (`az sql`, `az network`)
- **GitHub Docs** (Git, Markdown, Issues, Projects)
- **GitHub Markdown Guide**

> Dica: cole links diretos que você usou e anote *o que aprendeu* em cada etapa.

---

## 📝 Licença
Este material é disponibilizado sob a licença MIT. Ajuste conforme sua necessidade.
