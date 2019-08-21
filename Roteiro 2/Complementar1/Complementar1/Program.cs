using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complementar1
{
    class Program
    {
        static void Main(string[] args)
        {
            double peso, resultado;
            int condicao;
            Console.WriteLine("                  Pontifícia Universidade Católica");
            Console.Write("\nDigite o seu peso: ");
            peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual o resuldade desejado? ");
            Console.WriteLine("1. Engordar 15%");
            Console.WriteLine("2. Emagrecer 20%");
            condicao = int.Parse(Console.ReadLine());
            switch (condicao)
            {
                case 1:
                    resultado = peso + (peso * 0.15);
                    Console.WriteLine($"Se você engordar 15%, seu novo peso será de: {resultado}");
                    break;
                case 2:
                    resultado = peso - (peso * 0.20);
                    Console.WriteLine($"Se vc emagrecer 20%, seu novo peso será de: {resultado}");
                    break;
                default:
                    Console.WriteLine("Comando Inválido");
                    break;
            }
            Console.ReadKey();
        }
    }
}
