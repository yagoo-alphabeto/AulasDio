using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafioprojeto1.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes {get; set;}

        public Suite Suite { get; set; }

        public int DiasReservados { get; set; }

        public Reserva() { }
        
        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {


        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valorTotal = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10)
            {
                valorTotal *= 0.9m;
            }

            return valorTotal;
        }


    }
}