using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complementar_3
{
    class Program
    {
        static void Main(string[] args)
        {
            char op = 'A';
            int i = 0;
            double salario;
            Console.WriteLine("                Pontifícia Universidade Católica");
            Console.WriteLine("\nSiga as instruções para calcular o novo salário");


            while (i == 0)
            {
               
                Console.WriteLine("\nDigite a opção desejada: ");
                Console.WriteLine("A. Para aumento de 8%");
                Console.WriteLine("B. Para aumento de 11%");
                Console.WriteLine("C. Para aumento fixo de R$450,00");
                Console.WriteLine("D. Sair do programa");
                op = char.Parse(Console.ReadLine().ToUpper());
                switch (op)
                {
                    case 'A':
                        Console.Write("\nDigite seu salário: ");
                        salario = double.Parse(Console.ReadLine());
                        salario = salario + (salario * 0.08);
                        Console.WriteLine($"\nSeu novo salário é: {salario}");
                        Console.ReadKey();
                        break;
                    case 'B':
                        Console.Write("\nDigite seu salário: ");
                        salario = double.Parse(Console.ReadLine());
                        salario = salario + (salario * 0.11);
                        Console.WriteLine($"\nSeu novo salário é: {salario}");
                        Console.ReadKey();
                        break;
                    case 'C':
                        Console.Write("\nDigite seu salário: ");
                        salario = double.Parse(Console.ReadLine());
                        salario = salario + 450;
                        Console.WriteLine($"\nSeu novo salário é: {salario}");
                        Console.ReadKey();
                        break;
                    case 'D':
                        Console.WriteLine("\n\nObrigado!");
                        i++;
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
