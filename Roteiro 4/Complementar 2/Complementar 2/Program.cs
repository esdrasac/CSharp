using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complementar_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            double idade = 0, faturamento = 0, preco = 0;
            Console.WriteLine("              Pontifícia Universidade Católica");
            Console.WriteLine("        FEIRÃO DA MAQUINA DE LAVAR NO MINAS SHOPPING");
            Console.WriteLine("\nSua idade vale desconto, o valor de sua idade dividido por dois, " +
                "\nserá o percentual de desconto em sua máquina de lavar nova que custa R$1000,00");
            while (i == 0)
            {
                Console.Write("\nDigite sua idade: ");
                idade = double.Parse(Console.ReadLine());
                if (idade >= 0)
                {
                    idade = idade / 2;
                    preco = 1000 - (1000 * idade) / 100;
                    faturamento += preco;
                    Console.WriteLine($"\nO valor a pagar pela máquina é de R${preco}");
                }
                else if (idade == -1)
                {
                    i++;
                }
                else
                {
                    Console.WriteLine("\nIdade inválida");
                }
            }
            Console.WriteLine($"\nO Faturamento total é de R${faturamento}");
            Console.WriteLine("\n\n         Obrigado!");
            Console.ReadKey();
        }
    }
}
