using System;

namespace Exercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco, precoNovo = 0;
            Console.WriteLine("Digite o valor do produto:");
            preco = double.Parse(Console.ReadLine());
            if (preco <= 50)
            {
                precoNovo = (preco * 0.05) + preco;
            }
            else if (preco > 50 && preco <= 100)
            {
                precoNovo = (preco * 0.10) + preco;
            }
            else if (preco > 100)
            {
                precoNovo = (preco * 0.15) + preco;
            }
            if (precoNovo <= 80)
            {
                Console.WriteLine("O novo preço é:" + precoNovo + "\nClassificado como: Barato");
            }
            else if (precoNovo > 80 && precoNovo < 120)
            {
                Console.WriteLine("O novo preço é:" + precoNovo + "\nClassificado como: Normal");
            }
            else if (precoNovo >= 120 && precoNovo < 200)
            {
                Console.WriteLine("O novo preço é:" + precoNovo + "\nClassificado como: Caro");
            }
            else if (precoNovo >= 200)
            {
                Console.WriteLine("O novo preço é:" + precoNovo + "\nClassificado como: Muito Caro");
            }
            Console.ReadKey();
        }
    }
}
