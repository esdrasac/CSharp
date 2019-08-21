using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_4 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("                 Pontifícia Universidade Católica");
            Console.WriteLine("\n             Preencha 2 grupos de 5 números cada");
            int i;

            int[] vet1 = new int[5];
            int[] vet2 = new int[5];
            int[] resultante = new int[10];

            for (i = 0; i < 5; i++) {
                Console.Write($"\nDigite o {i+1}º número do grupo 1:");
                vet1[i] = int.Parse(Console.ReadLine());
                }
            for (i = 0; i < 5; i++) {
                Console.Write($"\nDigite o {i + 1}º número do grupo 2:");
                vet2[i] = int.Parse(Console.ReadLine());
                }
            Console.WriteLine("\nOs números intercalados entre grupo 1 e 2 resultam na seguinte sequência:\n");
            for (i = 0; i < 5; i++) {
                int j = 0;
                resultante[j] = vet1[i];
                resultante[j + 1] = vet2[i];
                Console.Write(resultante[j] + " | " + resultante[j+1] + " | ");
                j += 2;
                }
            Console.WriteLine("\n");
            Console.ReadKey();
            }
        }
    }
