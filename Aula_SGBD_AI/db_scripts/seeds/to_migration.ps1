# to_migration.ps1
# Script para rodar arquivos de seed como migrations

# Caminho para a pasta de seeds
$seedsPath = Join-Path $PSScriptRoot "seeds"

# Obter todos os arquivos .sql na pasta de seeds
$seedFiles = Get-ChildItem -Path $seedsPath -Filter *.sql | Sort-Object Name

# String de conexão (ajuste conforme necessário)
$connectionString = "Server=localhost;Database=SeuBanco;User Id=SeuUsuario;Password=SuaSenha;"

foreach ($seed in $seedFiles) {
    Write-Host "Executando seed: $($seed.Name)"
    $sql = Get-Content $seed.FullName -Raw

    # Usando sqlcmd para executar o seed (ajuste conforme seu SGBD)
    sqlcmd -S "localhost" -d "SeuBanco" -U "SeuUsuario" -P "SuaSenha" -i $seed.FullName

    # Para outros SGBDs, adapte o comando acima conforme necessário
}

Write-Host "Seeds executadas com sucesso."