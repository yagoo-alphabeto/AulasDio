Dashboard de Vendas em Excel

Transformar dados brutos em decisões: este repositório entrega um dashboard de vendas em Excel, com foco em organização, clareza visual e atualização simples.

🎯 Objetivo

Criar um dashboard de vendas no Excel que permita:

acompanhar o desempenho por período, canal, produto e região;

destacar KPIs essenciais (faturamento, ticket médio, volume, margem, etc.);

filtrar e cruzar informações rapidamente (segmentação por slicers).



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


