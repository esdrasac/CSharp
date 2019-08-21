using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complementar2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("                Pontifícia Universidade Católica");
            Console.WriteLine("\nPara organizar os números em forma crescente digite-os");
            Console.Write("\nPrimeiro número: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Segundo número: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Terceiro número: ");
            c = int.Parse(Console.ReadLine());
            if (a > b && b > c)
            {
                Console.WriteLine($"\nOs números em ordem decrescente são: {a}, {b} e {c}");
            }
            else if (a > c && c > b)
            {
                Console.WriteLine($"\nOs números em ordem decrescente são: {a}, {c} e {b}");
            }
            else if (b > a && a > c)
            {
                Console.WriteLine($"\nOs números em ordem decrescente são: {b}, {a} e {c}");
            }
            else if (b > c && c > a)
            {
                Console.WriteLine($"\nOs números em ordem decrescente são: {b}, {c} e {a}");
            }
            else if (c > a && a > b)
            {
                Console.WriteLine($"\nOs números em ordem decrescente são: {c}, {a} e {b}");
            }
            else
            {
                Console.WriteLine($"\nOs números em ordem decrescente são: {c}, {b} e {a}");
            }
            Console.ReadKey();
        }
    }
}
