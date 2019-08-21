using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complementar2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, aux1 = 1, aux2 = 1, n = 0, sequencia;
            Console.WriteLine("                  Pontifícia Universidade Católica");
            Console.WriteLine("Digite o a o enesimo número para encontrar a sequencia de Fibonacci: ");
            n = int.Parse(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    Console.Write(aux1);
                }
                else if (i == 1)
                {
                    Console.Write($", {aux2}");
                }
                else
                {
                    sequencia = aux1 + aux2;
                    aux2 = aux1;
                    aux1 = sequencia;
                    Console.Write(", " + sequencia);
                }
            }
            Console.ReadKey();
        }
    }
}
