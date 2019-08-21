using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Complementar3
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, media;
            Console.WriteLine("                      Pontifícia Universidade Católica");
            Console.WriteLine("                     Calcule sua média e conceito final");
            Console.Write("\nNota trabalho de laboratório: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.Write("Nota avaliação trimestral: ");
            nota2 = double.Parse(Console.ReadLine());
            Console.Write("Nota exame final: ");
            nota3 = double.Parse(Console.ReadLine());
            media = ((nota1 * 2) + (nota2 * 3) + (nota3 * 5)) / (2 + 3 + 5);
            if (media >= 8 && media <= 10)
            {
                Console.WriteLine($"\nNota: {media:F1}                               Conceito: A");
            }
            else if (media >= 7 && media < 8)
            {
                Console.WriteLine($"\nNota: {media:F1}                               Conceito: B");
            }
            else if (media >= 6 && media < 7)
            {
                Console.WriteLine($"\nNota: {media:F1}                               Conceito: C");
            }
            else if (media >= 5 && media < 6)
            {
                Console.WriteLine($"\nNota: {media:F1}                               Conceito: D");
            }
            else
            {
                Console.WriteLine($"\nNota: {media:F1}                               Conceito: B");
            }
            Console.ReadKey();
        }
    }
}
