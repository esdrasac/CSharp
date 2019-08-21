using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace outros2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            double idade = 0, total = 0, preco = 0;
            Console.WriteLine("Desconto equivalente à metade da sua idade ");
            while (i == 0)
            {
                Console.Write("\nDigite sua idade: ");
                idade = double.Parse(Console.ReadLine());
                if (idade >= 0)
                {
                    idade = idade / 2;
                    preco = 1000 - (1000 * idade) / 100;
                    total += preco;
                    Console.WriteLine($"\nO valor da máquina é de R$" + preco);
                }
                else if (idade == -1)
                {
                    i++;
                }
                else
                {
                    Console.WriteLine("\nERRO");
                }
            }
            Console.WriteLine($"\nO Faturamento total é de R$" +total);
            Console.ReadKey();
        }
    }
}
