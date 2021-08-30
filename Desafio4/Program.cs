using Desafio4.Models;
using System;
using System.Collections.Generic;

namespace Desafio4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> PessoasStarter = new List<Pessoa>();
            List<Pessoa> PessoasSenior = new List<Pessoa>();
            List<Pessoa> PessoasJunior = new List<Pessoa>();

            
           
            
            Console.WriteLine("Digite o nome da 1º Pessoa: ");
            var nome1 = Console.ReadLine();
            Console.WriteLine("Digite o cargo da 1º Pessoa: ");
            var cargo1 = Console.ReadLine();
            Pessoa pessoa1 = new Pessoa(nome1, cargo1);
            if (cargo1 == "Starter")
            {
                
                PessoasStarter.Add(pessoa1);
            } else if (cargo1 == "Junior")
            {
                
                PessoasJunior.Add(pessoa1);
            }
            else
            {
                PessoasSenior.Add(pessoa1);
            }
            Console.WriteLine("Digite o nome da 2º Pessoa: ");
            var nome2 = Console.ReadLine();
            Console.WriteLine("Digite o cargo da 2º Pessoa: ");
            var cargo2 = Console.ReadLine();
            Pessoa pessoa2 = new Pessoa(nome2, cargo2);
            if (cargo2 == "Starter")
            {

                PessoasStarter.Add(pessoa2);
            }
            else if (cargo2 == "Junior")
            {

                PessoasJunior.Add(pessoa2);
            }
            else
            {
                PessoasSenior.Add(pessoa2);
            }
            Console.WriteLine("Digite o nome da 3º Pessoa: ");
            var nome3 = Console.ReadLine();
            Console.WriteLine("Digite o cargo da 3º Pessoa: ");
            var cargo3 = Console.ReadLine();
            Pessoa pessoa3 = new Pessoa(nome3, cargo3);
            if (cargo3 == "Starter")
            {

                PessoasStarter.Add(pessoa3);
            }
            else if (cargo3 == "Junior")
            {

                PessoasJunior.Add(pessoa3);
            }
            else
            {
                PessoasSenior.Add(pessoa3);
            }
            Console.WriteLine("Digite o nome da 4º Pessoa: ");
            var nome4 = Console.ReadLine();
            Console.WriteLine("Digite o cargo da 4º Pessoa: ");
            var cargo4 = Console.ReadLine();
            Pessoa pessoa4 = new Pessoa(nome4, cargo4);
            if (cargo4 == "Starter")
            {

                PessoasStarter.Add(pessoa4);
            }
            else if (cargo4 == "Junior")
            {

                PessoasJunior.Add(pessoa4);
            }
            else
            {
                PessoasSenior.Add(pessoa4);
            }
            Console.WriteLine("Digite o nome da 5º Pessoa: ");
            var nome5 = Console.ReadLine();
            Console.WriteLine("Digite o cargo da 5º Pessoa: ");
            var cargo5 = Console.ReadLine();
            Pessoa pessoa5 = new Pessoa(nome5, cargo5);
            if (cargo5 == "Starter")
            {

                PessoasStarter.Add(pessoa5);
            }
            else if (cargo5 == "Junior")
            {

                PessoasJunior.Add(pessoa5);
            }
            else
            {
                PessoasSenior.Add(pessoa5);
            }

            Console.WriteLine("total de pessoas:");
            Console.WriteLine($"Starter: {PessoasStarter.Count}");
            Console.WriteLine($"Starter: {PessoasJunior.Count}");
            Console.WriteLine($"Starter: {PessoasSenior.Count}");
        }
    }
}
