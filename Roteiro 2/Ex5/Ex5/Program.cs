using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, resultado;
            int opcao;
            Console.WriteLine("                   Pontifícia Universidade Católica");
            Console.WriteLine("\nSiga as instruções, digite os os números e escolha a operação desejada.");
            Console.Write("\nDigite um numero: ");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero: ");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("\nEscolha a operação: ");
            Console.WriteLine("\n1. Média aritmética");
            Console.WriteLine("2. Diferença do maior pelo menor");
            Console.WriteLine("3. Produto entre os dois números");
            Console.WriteLine("4. Divisão do primeiro pelo segundo");
            Console.Write("\nQual operação você deseja realizar? ");
            opcao = int.Parse(Console.ReadLine());
            while (opcao > 4)
            {
                Console.WriteLine("\nOpção inválida");
                Console.Write("\nDigite outro número: ");
                opcao = int.Parse(Console.ReadLine());
            }
            if (opcao == 1)
            {
                resultado = (num1 + num2) / 2;
                Console.WriteLine($"\nA média dos dois numeros é igual a: {resultado}");
            }
            else if (opcao == 2)
            {
                if (num1 > num2)
                {
                    resultado = num1 - num2;
                    Console.WriteLine($"\nA diferença do maior pelo menor número é igual a: {resultado}");
                }
                else
                {
                    resultado = num2 - num1;
                    Console.WriteLine($"\nA diferença do maior pelo menor número é igual a: {resultado}");
                }

            }
            else if (opcao == 3)
            {
                resultado = num1 * num2;
                Console.WriteLine($"\nO produto entre os dois numeros é igual a: {resultado}");
            }
            else if (opcao == 4)
            {
                if (num2 != 0)
                {
                    resultado = num1 / num2;
                    Console.WriteLine($"\nA divisão do primeiro pelo segundo número é igual a: {resultado.ToString("F2")}");
                }
                else
                {
                    Console.WriteLine("\nNão é possível dividir por 0");
                }
            }

            Console.ReadKey();

        }
    }
}
