using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio4.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }


        public Pessoa(string nome, string cargo)
        {
            Nome = nome;
            Cargo = cargo;
        }


    }
}
