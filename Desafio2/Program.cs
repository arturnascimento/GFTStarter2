using System;

namespace Desafio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número para saber se ele é divisível por : 3, 6 ou 7");
            int n = int.Parse(Console.ReadLine());

            
            if(n % 3 == 0)
            {
                Console.WriteLine("Número divisível por 3!");
            }
            if(n%6 == 0)
            {
                Console.WriteLine("Número divisível por 6!");
            }
            if(n%7 == 0)
            {
                Console.WriteLine("Número divisível por 7!");
            }

            if(n% 3 != 0 && n%6 != 0 && n%7 != 0)
            {
                Console.WriteLine("Número não divisível por nenhuma das opções oferecidas");
            }
        }
    }
}
