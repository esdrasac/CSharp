using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace outros3
{
    class Program
    {
        static void Main(string[] args)
        {
            char aux = 'A';
            int i = 0;
            double salario;
           
            while (i == 0)
            {

                Console.WriteLine("\nDigite a opção desejada: ");
                Console.WriteLine("A. Escolha para aumento de 8%");
                Console.WriteLine("B. Escolha para aumento de 11%");
                Console.WriteLine("C. Escolha para aumento fixo de R$450,00");
                Console.WriteLine("D. Escolha para sair do programa");
                aux = char.Parse(Console.ReadLine().ToUpper());

                if (aux == 'A')
                {
                    Console.Write("Qual o seu salario: ");
                    salario = double.Parse(Console.ReadLine());
                    salario = salario + (salario * 0.08);
                    Console.WriteLine("Novo salario: " + salario);
                }
                else if (aux == 'B')
                {
                    Console.Write("Qual o seu salario: ");
                    salario = double.Parse(Console.ReadLine());
                    salario = salario + (salario * 0.11);
                    Console.WriteLine("Novo salario: " + salario);
                }
                else if (aux == 'C')
                {
                    Console.Write("Qual o seu salario: ");
                    salario = double.Parse(Console.ReadLine());
                    salario = salario + 450;
                    Console.WriteLine("Novo salario: " + salario);
                }
                else if (aux == 'D')
                {
                    i++;
                }
                else
                {
                    Console.WriteLine("ERRO");
                }
            }
            Console.ReadKey();
        }
    }
}
