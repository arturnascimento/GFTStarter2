using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1.Models
{
    public abstract class Animal
    {
        public string nome { get; set; }
        public int peso { get; set; }

        public Animal(string _nome, int _peso)
        {
            nome = _nome;
            peso = _peso;
        }

        public abstract string som();
        public abstract int quantidadeDeRacao(int peso);


    }
}
