using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao17
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, soma = 0, aux = 0, canal4 = 0, canal5 = 0, canal7 = 0, canal12 = 0;
            double p1 = 0, p2 = 0, p3 = 0, p4 = 0;

            while (i == 1)
            {
                Console.WriteLine($"\nQual o canal assistido pela família?: ");
                aux = int.Parse(Console.ReadLine());

                if (aux == 4) {

                    Console.WriteLine("\nQuantas pessoas estão assistindo o canal? ");
                    canal4 += int.Parse(Console.ReadLine());
                }
                else if (aux == 5)
                {

                    Console.WriteLine("\nQuantas pessoas estão assistindo o canal? ");
                    canal5 += int.Parse(Console.ReadLine());
                }
                else if (aux == 7)
                {

                    Console.WriteLine("\nQuantas pessoas estão assistindo o canal? ");
                    canal7 += int.Parse(Console.ReadLine()); 
                }
                else if (aux == 12)
                {

                    Console.WriteLine("\nQuantas pessoas estão assistindo o canal? ");
                    canal12 += int.Parse(Console.ReadLine());
                }
                else if (aux == 0)
                {
                    i++;
                }
                else
                {
                    Console.WriteLine("Canal inválido");
                }
                
            }
            soma = canal4 + canal5 + canal7 + canal12;
            p1 = (100 * canal4) / soma;
            p2 = (100 * canal5) / soma;
            p3 = (100 * canal7) / soma;
            p4 = (100 * canal12) / soma;
            Console.WriteLine("\nA audiência do canal 4 é de " + p1 + "%");
            Console.WriteLine("\nA audiência do canal 5 é de " + p1 + "%");
            Console.WriteLine("\nA audiência do canal 7 é de " + p1 + "%");
            Console.WriteLine("\nA audiência do canal 12 é de "+ p1 + "%");
            Console.ReadKey();

        }
    }
}
