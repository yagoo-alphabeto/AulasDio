# 📦 Entrega do Desafio — Guia de README e Portfólio

> Use este arquivo como **modelo** para publicar seu repositório da DIO. Preencha os blocos abaixo com as suas informações.

## 🎯 Visão Geral do Projeto
- **Título do desafio**: Configuração de Instância de Banco de Dados no Azure
- **Objetivo**: praticar a configuração e documentar o passo a passo.
- **Stack**: Azure, Azure SQL / SQL Managed Instance, Azure CLI, Git/GitHub.

## ✅ Checklist de Entrega
- [ ] Repositório **público** no GitHub
- [ ] `README.md` com **descrição do passo a passo**
- [ ] Pasta `images/` com **prints** das etapas
- [ ] Scripts/artefatos relevantes (`/scripts`, `.sql`, etc.)
- [ ] **Links úteis** (doc, aulas, referências)
- [ ] **Breve descrição** incluída na DIO ao clicar “Entregar Projeto”

## 🛠️ Passo a Passo que Executei
> Resuma abaixo o que você **de fato** fez (portal/CLI), incluindo decisões e aprendizados.

1. Criei o **Resource Group** `rg-db-lab` na região `Brazil South`.
2. [Se MI] Criei `vnet-db-lab` e `snet-mi` com delegação `Microsoft.Sql/managedInstances`.
3. [Se SQL Database] Criei o servidor lógico `sqlsrv-<seu-nome>` e o DB `sqldb-demo` (serverless).
4. Abri o firewall para meu IP e conectei via Azure Data Studio.
5. Rodei o script SQL de teste e validei os dados.
6. Organizei os **prints** em `/images` e **scripts** em `/scripts`.
7. Publiquei no GitHub e enviei o link na DIO.

## 🖼 Evidências (prints)
> Anexe as imagens na pasta `/images` e referencie-as aqui:

- ![Resource Group](./images/01-rg.png)
- ![VNet + Subnet](./images/02-vnet-subnet.png)
- ![SQL Server + DB](./images/04-sql-server-db.png)
- ![Query OK](./images/teste-select.png)

## 🔗 Links Úteis
- Doc Azure SQL Managed Instance (Quickstart): <cole aqui>
- Doc Azure SQL Database (Quickstart): <cole aqui>
- Azure CLI — az sql, az network: <cole aqui>
- GitHub Docs — Git e Markdown: <cole aqui>
- Curso “Como Entregar o Seu Desafio de Projeto”: <cole aqui>

> Opcional: adicione links para repositório de referência (fork), anotações pessoais, template no Figma etc.

## 🧭 Decisões e Aprendizados
- Por que escolhi **Managed Instance** ou **SQL Database**?
- Como tratei **custos** e **segurança**?
- 3 coisas que eu faria diferente em uma próxima versão.

## 🧰 Portfólio
> Copie este bloco no seu README principal do GitHub ou no seu site:
**Projeto:** Configuração de Banco de Dados no Azure — *Hands-on*  
**Skills:** Azure, Redes (VNets), Segurança (firewall/IP), CLI, SQL, Git  
**Destaques:** passo a passo claro, scripts reusáveis, prints de evidência

---
**Autor:** *Seu Nome* — [LinkedIn](#) · [GitHub](#)
