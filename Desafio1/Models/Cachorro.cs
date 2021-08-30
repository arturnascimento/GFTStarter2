using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1.Models
{
    class Cachorro : Animal
    {

        public Cachorro(string nome, int peso) : base(nome, peso)
        {

        }

        public override int quantidadeDeRacao(int peso)
        {
            if(peso <= 4)
            {
                return 40 * peso;
            }
            else if (peso > 4 && peso <= 12)
            {
                return 45 * peso;
            }
            else
            {
                return 55 * peso;
            }
        }

        public override string som()
        {
            return "auau";
        }
    }
}
