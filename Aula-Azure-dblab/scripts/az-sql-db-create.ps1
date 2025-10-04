# scripts/az-sql-db-create.ps1
param(
  [string]$Location = "brazilsouth",
  [string]$ResourceGroup = "rg-db-lab",
  [string]$SqlServer = "sqlsrv-yagoo",
  [string]$SqlDb = "sqldb-demo",
  [string]$AdminUser = "sqladmin",
  [string]$AdminPass = "<DefinaUmaSenhaForte!123>",
  [string]$ClientIp = ""
)

az group create -n $ResourceGroup -l $Location

az sql server create -l $Location -g $ResourceGroup -n $SqlServer `
  -u $AdminUser -p $AdminPass

if (-not $ClientIp -or $ClientIp -eq "") {
  try {
    $ClientIp = (Invoke-RestMethod -Uri "https://ifconfig.me/ip").Trim()
  } catch {
    Write-Host "Defina -ClientIp manualmente."
    exit 1
  }
}

az sql server firewall-rule create -g $ResourceGroup -s $SqlServer -n allow-client-ip `
  --start-ip-address $ClientIp --end-ip-address $ClientIp

az sql db create -g $ResourceGroup -s $SqlServer -n $SqlDb `
  --service-objective GP_S_Gen5_2 --compute-model Serverless --auto-pause-delay 60
