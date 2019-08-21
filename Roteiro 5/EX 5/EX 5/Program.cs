using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_5 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("                 Pontifícia Universidade Católica");

            int[] vet = new int[10];
            int i, aux = 0, j = 0;
            for (i = 0; i < 10; i++) {
                Console.Write($"\nDigite o {i+1}º número: ");
                vet[i] = int.Parse(Console.ReadLine());
                }
            
            for (i = 1; i < 10; i++) {
                aux = vet[i];
                j = i - 1;
                while ((j >= 0) && vet[j] > aux) {
                    vet[j + 1] = vet[j];
                    j--;
                    }
                vet[j + 1] = aux;
                }
            Console.Write("\nA sequência ordenada dos números é: ");
            for (i = 0; i < 10; i++) {
                Console.Write(vet[i] + " | ");
                }
            Console.WriteLine("\n");
            Console.ReadKey();
            }
        }
    }
