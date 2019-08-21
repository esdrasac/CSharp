using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcadastro;
            int opcadastro2 = 2;
            int opcadastro3 = 1;
            Console.WriteLine("                      Udemy");
            Console.WriteLine("\n     Curso de C# Programação Orientada a Objeto");
            Console.WriteLine("\nNão é cadastrado? Inscreva-se já");
            Console.Write("\n1. Inscrever-se");
            Console.WriteLine("        2. Sair");
            opcadastro = int.Parse(Console.ReadLine());
            switch (opcadastro)
            {
                case 1:
                    Console.WriteLine("\nVamos começar?");
                    break;
                case 2:
                    Console.WriteLine("\nObrigado!");
                    Console.ReadKey();
                    Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("\nComando inválido");
                    break;
            }

            while (opcadastro3 == 1) {
                while (opcadastro2 == 2)
                {
                    Pessoas x;
                    x = new Pessoas();

                    Console.Write("\n     Nome: ");
                    x.A = (Console.ReadLine());
                    Console.WriteLine("     Idade: ");
                    x.B = int.Parse(Console.ReadLine());
                    Console.WriteLine("     CPF(apenas números): ");
                    x.C = long.Parse(Console.ReadLine());
                    Console.WriteLine($"    Nome: {x.A}");
                    Console.WriteLine($"    Idade: {x.B}");
                    Console.WriteLine($"    CPF: {x.C}");
                    Console.WriteLine("\nConfirmar dados? ");
                    Console.WriteLine("\n1. Sim");
                    Console.WriteLine("2. Não");
                    opcadastro2 = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("\nDeseja realizar um novo cadastro?");
                Console.WriteLine("\n1. Sim");
                Console.WriteLine("2. Não");
                opcadastro3 = int.Parse(Console.ReadLine());
                if (opcadastro3 == 1)
                {
                    opcadastro2 = 2;
                }
                else
                {
                    Console.WriteLine(" \nObrigado");
                }
                
            }
            Console.ReadKey();
        }
    }
}
