using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DioProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var crmService = new conection().ObterConexao(); 
        }
    }
}
