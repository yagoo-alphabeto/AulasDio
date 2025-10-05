using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafioprojeto1.Models
{
    public class Pessoa
    {
        public Pessoa() { }

        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = Sobrenome;
        }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string NomeCompleto { get; set; }
    }
}