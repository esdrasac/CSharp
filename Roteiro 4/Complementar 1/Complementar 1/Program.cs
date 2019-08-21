using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complementar_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double menor = 9999999999999999999, maior = 0, op;
            int i = 1, aux;
            Console.WriteLine("               Pontifícia Universidade Católica");
            Console.WriteLine("               Cálculo de maior e menor número");
            Console.Write("\nQuantos números você deseja inserir? ");
            aux = int.Parse(Console.ReadLine());
            while (i == 1 || i <= aux)
            {
                Console.Write($"\nDigite o {i}º número: ");
                op = double.Parse(Console.ReadLine());
                if (op > maior)
                {
                    maior = op;
                }
                if (op < menor)
                {
                    menor = op;
                }
                i++;
            }
            Console.WriteLine($"\nO maior número entre os digitados é: {maior}");
            Console.WriteLine($"\nO menor número entre os digitados é: {menor}");
            Console.ReadKey();
        }
    }
}
