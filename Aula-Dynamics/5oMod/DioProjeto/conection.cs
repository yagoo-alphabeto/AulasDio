using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Microsoft.Xrm.Tooling.Connector;

namespace DioProjeto
{
    public class conection
    {
        private static CrmSereviceClient crmSereviceClientTreinamento;

        public CrmServiceClient ObterConexao ()
        {
            var connectionStringCRM = @"Authtype=OAuth;
            Username = userdyn365@treinodio.onmicrosoft.com;
            Password = Pass@world99;
            SkipDiscovery = True;
            Appid = 51f81489-12ee4a9e-aaaee-a291f48987d;
            RedirectUri = app://51f81489-12ee4a9e-aaaee-a291f48987d;
            Url = https://org07de2ee3.crm2.dynamics.com/main.aspx;";

            if (crmSereviceClientTreinamento == null) 
            {   
                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                crmSereviceClientTreinamento = new CrmSereviceClient (connectionStringCRM);
            }
            return crmSereviceClientTreinamento;
        }
    }
}
