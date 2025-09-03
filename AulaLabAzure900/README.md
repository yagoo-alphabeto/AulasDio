
## 🎯 Objetivo do Lab
- Entender o que é a **nuvem da Microsoft (Azure)** e seus benefícios (escala, elasticidade, segurança, pagamento sob demanda).
- Reconhecer **componentes fundamentais** (tenant, assinatura, grupos de gerenciamento, grupos de recursos).
- Visão geral das **categorias de serviços** (compute, storage, networking, dados, segurança, observabilidade, DevOps).
- Aplicar **boas práticas** de governança, segurança, custos e automação.

---

## 🗺️ Conceitos de Plataforma

### Estrutura Lógica (Governança)
- **Tenant (Microsoft Entra ID)**: diretório de identidades da organização.
- **Management Groups**: agrupam **assinaturas** para aplicar políticas em escala.
- **Assinatura (Subscription)**: escopo de **cobrança/limites/quotas**.
- **Resource Groups (RGs)**: contêiner lógico para recursos relacionados.
- **Recursos**: VMs, bancos, redes, storages, etc.

### Regiões e Alta Disponibilidade
- **Regiões** e **Availability Zones (AZs)**: distribuem carga e toleram falhas.
- **Region Pairs**: pares de regiões para DR.
- **SLA, SKUs e Redundância**: escolha impacta **resiliência e custo**.

---

## 🧩 Principais Categorias de Serviço

### Compute
- **Azure VMs**: controle total do SO.
- **App Service**: hospeda apps web/APIs gerenciados.
- **Azure Functions**: *serverless* por evento.
- **AKS (Kubernetes)**: orquestração de containers.

### Storage
- **Blob Storage** (objetos), **File Shares** (SMB), **Queue** (mensageria), **Table** (NoSQL simples).
- **Redundância**: LRS/ZRS/GRS para continuidade de negócio.

### Networking
- **VNet/Subnet**: redes privadas.
- **NSG**: regras de tráfego (L3/L4).
- **Load Balancer / App Gateway**: balanceamento L4/L7.
- **Firewall / DDoS Protection / Private Link**: segurança e acesso privado.
- **DNS / Front Door**: roteamento global e aceleração.

### Dados e Analytics
- **Azure SQL**, **PostgreSQL/MySQL (PaaS)**, **Cosmos DB** (NoSQL distribuído).
- **Data Factory** (ETL/ELT), **Synapse**/**Microsoft Fabric** (analytics unificado).
- **Event Hub / Kafka / Service Bus**: *streaming* e mensageria.

### Identidade e Acesso
- **Microsoft Entra ID** (ex-Azure AD): identidade, SSO, MFA.
- **RBAC**: permissões por papel no escopo certo (MG/Subscription/RG/Recurso).
- **Managed Identities**: credenciais gerenciadas para workloads.
- **Key Vault**: segredos, chaves e certificados.

### Segurança
- **Defender for Cloud**: postura de segurança, recomendações e proteção.
- **Policy**: conformidade e *guardrails* (tagging, SKUs, regiões permitidas).
- **Private Endpoints**: tráfego privado para serviços PaaS.

### Observabilidade
- **Azure Monitor** + **Log Analytics Workspace**: métricas, logs e consultas (KQL).
- **Application Insights**: *APM* (telemetria de apps), *dashboards* e alertas.
- **Alerts/Action Groups**: notificações (e-mail, webhook, ITSM).

### DevOps & IaC
- **Bicep/ARM** e **Terraform**: infraestrutura como código.
- **GitHub Actions / Azure DevOps**: CI/CD, Repos, Boards, Test Plans.
- **Padrões de *branching*** e *pipelines* para entrega contínua.

---



