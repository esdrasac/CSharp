using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, N, i = 0, soma = 0; //Declaração de variaveis
            Console.WriteLine("Quantos numeros deseja digitar: ");
            N = int.Parse(Console.ReadLine()); // definição de quantos numeros inteiros eu pretendo digitar
            while (i < N)
            {
                Console.WriteLine("\n Entre um valor inteiro: "); //Digito N valores, predefinidos anteriormente
                num = int.Parse(Console.ReadLine());
                soma = soma + num;// soma de todos os numeors digitados
                i++;
            }
            Console.Write("\n Foram digitados " + i + " numeros");
            Console.Write("\n A soma dos numeros digitados e: " + soma);// dados de saida
            Console.ReadKey();
        }
    }
}
