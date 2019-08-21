using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_8 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("\t\t\tPontifícia Universidade Católica");
            int[] vet1 = new int[10];
            int[] vet2 = new int[10];
            int[] vet3 = new int[10];

            Console.WriteLine("\nPreencha o primeiro vetor");
            for (int i = 0; i < 10; i++) {
                Console.Write($"Digite o {i + 1}º número: ");
                vet1[i] = int.Parse(Console.ReadLine());
                }

            Console.WriteLine("\nPreencha o segundo vetor");
            for (int i = 0; i < 10; i++) {
                Console.Write($"Digite o {i + 1}º número: ");
                vet2[i] = int.Parse(Console.ReadLine());
                }

            Console.WriteLine("\nPreencha o terceiro vetor");
            for (int i = 0; i < 10; i++) {
                Console.Write($"Digite o {i + 1}º número: ");
                vet3[i] = int.Parse(Console.ReadLine());
                }

            int[,] matriz = new int[3, 10];
            int aux = 0;
            for (int i = 1; i < vet1.Length; i++) {
                aux = vet1[i];
                int j = i;
                while ((j > 0) && (vet1[j - 1] > aux)) {
                    vet1[j] = vet1[j - 1];
                    j = j - 1;
                    }
                vet1[j] = aux;

                }

            for (int i = 1; i < vet2.Length; i++) {
                aux = vet2[i];
                int j = i;
                while ((j > 0) && (vet2[j - 1] < aux)) {
                    vet2[j] = vet2[j - 1];
                    j = j - 1;
                    }
                vet2[j] = aux;
                }

            for (int i = 1; i < vet3.Length; i++) {
                aux = vet3[i];
                int j = i;
                while ((j > 0) && (vet3[j - 1] > aux)) {
                    vet3[j] = vet3[j - 1];
                    j = j - 1;
                    }
                vet3[j] = aux;
                }

            for (int i = 0; i < 10; i++) {
                matriz[0, i] = vet1[i];
                matriz[1, i] = vet2[i];
                matriz[2, i] = vet3[i];
                }
            Console.WriteLine("Linha 1");
            for (int i = 0; i < 10; i++) {
                Console.WriteLine(matriz[0, i]);

                }
            Console.WriteLine("Linha 2");
            for (int i = 0; i < 10; i++) {
                Console.WriteLine(matriz[1, i]);

                }
            Console.WriteLine("Linha 3");
            for (int i = 0; i < 10; i++) {
                Console.WriteLine(matriz[2, i]);

                }
            }
        }
    }
