using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace outros1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, aux;
            double menor = 1000000000000000000, maior = 0, cont;
            Console.Write("\nQuantos números você quer digitar? ");
            aux = int.Parse(Console.ReadLine());
            while (i == 1 || i <= aux)
            {
                Console.Write($"\nDigite um número: ");
                cont = double.Parse(Console.ReadLine());
                if (cont > maior)
                {
                    maior = cont;
                }
                if (cont < menor)
                {
                    menor = cont;
                }
                i++;
            }
            Console.WriteLine("O maior número entre os digitados é: " + maior);
            Console.WriteLine("O menor número entre os digitados é: " + menor);
            Console.ReadKey();
        }
    }
}
