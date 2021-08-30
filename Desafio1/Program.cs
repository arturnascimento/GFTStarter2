using Desafio1.Models;
using System;

namespace Desafio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Gato Daphne = new Gato("Daphne", 20);
            
            Gato Artemis = new Gato("Artemis", 3);
          
            Cachorro Xereta = new Cachorro("Xereta", 10);
            
            Gato VictorHugo = new Gato("Victor Hugo", 5);

            var qntRacao = Daphne.quantidadeDeRacao(Daphne.peso) + Artemis.quantidadeDeRacao(Artemis.peso)
                 + Xereta.quantidadeDeRacao(Xereta.peso) + VictorHugo.quantidadeDeRacao(VictorHugo.peso);

            Console.WriteLine($"A quantidade de ração para alimentar todos os animais é de: {qntRacao} gramas.");


        }
    }
}
