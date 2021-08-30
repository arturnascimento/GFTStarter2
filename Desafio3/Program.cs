using System;

namespace Desafio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o multiplicador: ");
            int multiplicando = int.Parse(Console.ReadLine());

            while(multiplicando < 0 || multiplicando >= 1500)
            {
                Console.WriteLine("Digite um multiplicador válido entre 0 e 1500");
                Console.WriteLine("Digite o multiplicador: ");
                multiplicando = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite o ínicio do intervalo: ");
            int inicio = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o fim do intervalo: ");
            int fim = int.Parse(Console.ReadLine());

            while((fim - inicio) > 10 || fim < inicio)
            {
                Console.WriteLine("Você nao pode ter um intevalo maior do que 10 ou o fim de intervalo maior que início!");
                Console.WriteLine("Digite o ínicio do intervalo: ");
                inicio = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o fim do intervalo: ");
                fim = int.Parse(Console.ReadLine());
            }

            for (int i  = inicio; i <= fim; i++)
            {
                Console.WriteLine($"{multiplicando} x {i} = {multiplicando * i}");
            }


        }
    }
}
