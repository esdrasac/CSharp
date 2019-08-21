using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complementar6
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, resultado;
            int op;
            Console.WriteLine("                    Pontifícia Universidade Católica");
            Console.WriteLine("\nEntre com dois números, em seguida escolha a operação");
            Console.Write("\nDigite o primeiro número: ");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("\nEscolha uma operação:");
            Console.WriteLine("1. Potência (o primeiro elevado ao segundo)");
            Console.WriteLine("2. Raíz quadrada de cada número");
            op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    resultado = Math.Pow(num1, num2);
                    Console.WriteLine($"\nO primeiro número elevado pelo segundo é: {resultado}");
                    break;
                case 2:
                    if (num1 < 0)
                    {
                        Console.WriteLine("\nNão foi possível calcular a raíz do primeiro número, pois nao existe raíz de número negativo");
                    }
                    else
                    {
                        resultado = Math.Sqrt(num1);
                        Console.WriteLine($"\nA raíz quadrada do primeiro número ({num1}) é {resultado}");
                    }
                    if (num2 < 0)
                    {
                        Console.WriteLine("\nNão foi possível calcular a raíz do segundo número, pois nao existe raíz de número negativo");
                    }
                    else
                    {
                        resultado = Math.Sqrt(num2);
                        Console.WriteLine($"\nA raíz quadrada do segundo número ({num2}) é {resultado}");
                    }
                    break;
                default:
                    Console.WriteLine("\nOperação inválida");
                    break;
            }
            Console.ReadKey();
        }
    }
}
