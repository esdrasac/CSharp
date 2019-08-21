using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13
{
    class Program
    {
        static void Main(string[] args)
        {
            double precoatual, preconovo;
            Console.WriteLine("                    Pontifícia Universinade Católica");
            Console.WriteLine("\n                          Ajuste de preços");
            Console.Write("\nDigite o preço atual do produto:");
            precoatual = double.Parse(Console.ReadLine());
            if (precoatual <= 50)
            {
                preconovo = precoatual + (precoatual * 0.05);
                if (preconovo <= 80)
                {
                    Console.WriteLine("\n  Novo preço:                                    Classificação:");
                    Console.WriteLine($"  R${preconovo:F2}                                        Barato");
                }
            }
            else if (precoatual > 50 && precoatual <= 100)
            {
                preconovo = precoatual + (precoatual * 0.1);
                if (preconovo <= 80)
                {
                    Console.WriteLine("\n  Novo preço:                                    Classificação:");
                    Console.WriteLine($"  R${preconovo:F2}                                        Barato");
                }
                if (preconovo > 80 && preconovo <= 120)
                {
                    Console.WriteLine("\n  Novo preço:                                    Classificação:");
                    Console.WriteLine($"  R${preconovo:F2}                                        Normal");
                }
            }
            else if (precoatual > 100)
            {
                preconovo = precoatual + (precoatual * 0.15);
                if (preconovo > 80 && preconovo <= 120)
                {
                    Console.WriteLine("\n  Novo preço:                                    Classificação:");
                    Console.WriteLine($"  R${preconovo:F2}                                        Normal");
                }
                else if (preconovo > 120 && preconovo <= 200)
                {
                    Console.WriteLine("\n  Novo preço:                                    Classificação:");
                    Console.WriteLine($"  R${preconovo:F2}                                       Caro");
                }
                else if (preconovo >= 201)
                {
                    Console.WriteLine("\n  Novo preço:                                    Classificação:");
                    Console.WriteLine($"  R${preconovo:F2}                                       Muito caro");
                }
            }            
           Console.ReadLine();
        }
    }
}
