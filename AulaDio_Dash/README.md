Dashboard de Vendas em Excel

Transformar dados brutos em decisões: este repositório entrega um dashboard de vendas em Excel, com foco em organização, clareza visual e atualização simples.

🎯 Objetivo

Criar um dashboard de vendas no Excel que permita:

acompanhar o desempenho por período, canal, produto e região;

destacar KPIs essenciais (faturamento, ticket médio, volume, margem, etc.);

filtrar e cruzar informações rapidamente (segmentação por slicers).

🗂️ Estrutura do Repositório
.
├─ data/
│  └─ base.xlsx                      # Base de dados bruta (fornecida)
├─ dashboard/
│  └─ dashboard_xbox_finalizado.xlsx # Arquivo Excel com o dashboard pronto (fornecido)
├─ assets/
│  └─ screenshots/                   # Imagens do dashboard (opcional)
└─ README.md                         # Este arquivo


Dica: mantenha o nome dos arquivos conforme acima para facilitar a reprodução.

📊 Principais Métricas e Visualizações

KPIs (no topo do dashboard):

Faturamento (R$)

Quantidade vendida (unidades)

Ticket médio (R$/pedido)

Margem (% ou R$) (se disponível na base)

Gráficos e análises:

Vendas por período (linha/colunas)

Vendas por categoria/produto

Vendas por canal (ex.: e-commerce, loja, marketplace)

Vendas por região/vendedor (se disponível)

Top N produtos/categorias

Mapa (opcional, se houver UF/cidade padronizada)

Controles (Slicers):

Período (ano/mês/data)

Canal

Categoria/Produto

Região/Vendedor

🧱 Dados Utilizados

Arquivo: data/base.xlsx

Aba esperada: Base (recomendado)

Colunas mínimas (exemplo):

data — data da venda

pedido_id — identificador do pedido

produto — nome/sku

categoria — agrupamento do produto

quantidade — unidades vendidas

preco_unitario — valor por unidade

valor_total — quantidade * preco_unitario (pode ser calculado)

canal — origem da venda (ex.: Loja, E-commerce)

regiao/uf — localização

vendedor — responsável (opcional)

custo/margem — se houver

Importante: Caso sua base tenha outros nomes/colunas, ajuste os Power Queries e Tabelas Dinâmicas conforme necessário.

🛠️ Como Reproduzir (Passo a Passo)

Requisitos: Excel 2019+ ou Microsoft 365 (recomendado).
Recursos usados: Power Query (Get & Transform), Tabelas Dinâmicas, Gráficos, Slicers.

Baixe/clonar este repositório

git clone https://github.com/<seu-usuario>/<seu-repo>.git
cd <seu-repo>


Abra o dashboard

Arquivo: dashboard/dashboard_xbox_finalizado.xlsx.

Conecte/atualize a base

Certifique-se de que data/base.xlsx está no caminho indicado.

No Excel, acesse Dados > Atualizar Tudo para recarregar a fonte no Power Query e atualizar as visões.

Verifique os filtros

Use os Slicers para navegar por período, canal, categoria, etc.

(Opcional) Ajustes

Caso renomeie colunas/abas, edite as consultas em Dados > Consultas e Conexões (Power Query).

Para adicionar novas métricas, inclua colunas calculadas no Power Query ou medidas (se usar Tabela Dinâmica/Power Pivot).

🔄 Como Atualizar com Novos Dados

Substitua o arquivo data/base.xlsx por uma versão nova com o mesmo layout (mesmas colunas e tipos de dados).

Abra dashboard/dashboard_xbox_finalizado.xlsx.

Clique em Dados > Atualizar Tudo.

As visualizações serão recalculadas automaticamente.

Se o layout mudar (colunas novas/removidas), ajuste as consultas no Power Query e os campos nas Tabelas Dinâmicas.

🧪 Validação Rápida (Checklist)

 KPIs batem com somatórios esperados da base

 Filtros (Slicers) afetam todos os gráficos corretamente

 Período (datas) está como data válida (sem textos/formatos ambíguos)

 Não há linhas/colunas em branco “quebrando” as Tabelas Dinâmicas

 Atualizar Tudo não gera erros

📝 Metodologia (Resumo)

Ingestão (Power Query):

Importa data/base.xlsx

Padroniza tipos (data, número, texto)

Cria colunas calculadas (ex.: valor_total, ano, mês)

Remove duplicidades e trata valores nulos

Modelo/Análise:

Tabela (ou Modelo de Dados) para servir Tabelas Dinâmicas

KPIs via campos calculados (no PQ ou na pivô)

Relacionamentos (se houver múltiplas tabelas)

Visualização:

Gráficos (linha/coluna/pizza/barras horizontais)

Slicers para navegação

Layout limpo, com ênfase nos KPIs principais

💡 Boas Práticas Usadas

Tipos de dados corretos no Power Query

Colunas derivadas para facilitar filtros (ex.: Ano, MêsNome)

Nomeação clara de consultas/campos

Slicers conectados a todas as Tabelas Dinâmicas relevantes

Formatação consistente (moeda, separadores, rótulos)

📷 Screenshots (opcional)

Inclua imagens em assets/screenshots/ e referencie aqui:

Visão geral do dashboard

KPIs

Exemplo de filtro por categoria

![Visão Geral](assets/screenshots/overview.png)

🚀 Como Entregar o Desafio

Suba este repositório no seu GitHub com:

README.md (este arquivo)

data/base.xlsx (ou um link claro de onde obter)

dashboard/dashboard_xbox_finalizado.xlsx

Compartilhe o link do repositório como entrega final.

❓FAQ

1) Não aparece a opção “Atualizar Tudo”.
Certifique-se de estar em Dados e de que o arquivo está habilitado (conteúdo externo habilitado).

2) O gráfico não muda quando uso os Slicers.
Conecte os Slicers às Tabelas Dinâmicas corretas (Analisar Tabela Dinâmica > Conexões de Relatório).

3) Colunas novas na base quebraram o refresh.
Abra o Power Query, ajuste as etapas (índices/nomes de colunas) e salve.

🧾 Licença

Este projeto é distribuído sob a licença MIT. Sinta-se livre para usar e adaptar.

👤 Autor(a)

Seu Nome — seu GitHub
 • seu LinkedIn

Se precisar, posso adaptar o README com screenshots do seu dashboard, ajustar os KPIs à sua base real e incluir instruções específicas da sua organização.