using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complementar5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                Pontifícia Universidade Católica");
            Console.WriteLine("\n                    Equação de Segundo Grau");
            double a, b, c, delta, baskara, x1, x2;
            Console.WriteLine("\nDigite o valor de A: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B:");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de C:");
            c = double.Parse(Console.ReadLine());



            if (a == 0 && b == 0 && c == 0)
            {
                Console.WriteLine("A, B e C devem ser diferentes de 0");
            }
            else
            {
                delta = Math.Pow(b, 2) -4 * a * c;
                if (delta < 0)
                {
                    Console.WriteLine("Delta não pode ser menor que 0");
                }
                else
                {
                    x1 = -b + Math.Sqrt(delta) / (2 * a);
                    Console.WriteLine($"1º Valor da Equação do segundo grau:{x1:F2}");
                    x2 = -b - Math.Sqrt(delta) / (2 * a);
                    Console.WriteLine($"2º Valor da Equação do segundo grau:{x2:F2}");
                }
            }
            Console.ReadKey();
        }
    }
}
