using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("               Pontifícia Universidade Católica");
            Console.WriteLine("\nPara que eu mostre o menor número siga as instruções abaixo:");
            Console.Write("\n1. Digite o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("\nDigite o segundo número: ");
            num2 = int.Parse(Console.ReadLine());
            if (num1 < num2)
            {
                Console.WriteLine($"\nO menor número é: {num1}");
            }
            else if (num1 == num2)
            {
                Console.WriteLine($"\nOs números são iguais.");
            }
            else Console.WriteLine($"\nO menor número é: {num2}");
            Console.ReadKey();
        }
    }
}
