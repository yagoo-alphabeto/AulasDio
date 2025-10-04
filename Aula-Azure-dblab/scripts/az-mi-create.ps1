# scripts/az-mi-create.ps1
param(
  [string]$Location = "brazilsouth",
  [string]$ResourceGroup = "rg-db-lab",
  [string]$Vnet = "vnet-db-lab",
  [string]$Subnet = "snet-mi",
  [string]$SubnetCidr = "10.10.0.0/24",
  [string]$MiName = "mi-demo",
  [string]$AdminUser = "sqladmin",
  [string]$AdminPass = "<DefinaUmaSenhaForte!123>",
  [string]$SubscriptionId = "<SUB_ID>"
)

az group create -n $ResourceGroup -l $Location

az network vnet create -g $ResourceGroup -n $Vnet --address-prefixes 10.10.0.0/16 `
  --subnet-name $Subnet --subnet-prefixes $SubnetCidr

az network vnet subnet update -g $ResourceGroup --vnet-name $Vnet -n $Subnet `
  --delegations "Microsoft.Sql/managedInstances"

az network nsg create -g $ResourceGroup -n "nsg-mi"
az network vnet subnet update -g $ResourceGroup --vnet-name $Vnet -n $Subnet `
  --network-security-group "nsg-mi"

$subnetId = "/subscriptions/$SubscriptionId/resourceGroups/$ResourceGroup/providers/Microsoft.Network/virtualNetworks/$Vnet/subnets/$Subnet"

az sql mi create -g $ResourceGroup -n $MiName -l $Location `
  --admin-user $AdminUser --admin-password $AdminPass `
  --subnet $subnetId --license-type BasePrice `
  --compute-model Provisioned --capacity 4 --storage 32 --tier GeneralPurpose
