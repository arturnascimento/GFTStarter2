using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1.Models
{
    class Gato : Animal
    {
        public Gato(string nome, int peso) : base(nome, peso)
        {

        }

        public override int quantidadeDeRacao(int peso)
        {
            if (peso <= 3)
            {
                return 10 * peso;
            }
            else 
            {
                return 13 * peso;
            }
           
        }

        public override string som()
        {
            return "miau";
        }
    }
}
