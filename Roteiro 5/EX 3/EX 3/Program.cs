using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_3 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("                 Pontifícia Universidade Católica");

            int i, multi3 = 0, rest = 0;
            int[] vet = new int[6];
            int[] multiplo = new int[6];
            int[] resto = new int[6];
            for (i = 0; i < 6; i++) {
                Console.Write($"\nDigite o {i + 1}º número: ");
                int aux = int.Parse(Console.ReadLine());
                if (aux > 0) {
                    vet[i] = aux;
                    if (vet[i] % 3 == 0) {
                        multiplo[multi3] = vet[i];
                        multi3++;
                        }
                    else {
                        resto[rest] = vet[i];
                        rest++;
                        }
                    }
                else {
                    Console.WriteLine("\nNúmero inválido");
                    i--;
                    }
                }
            Console.Write("\nMultiplos de 3: ");
            for (i = 0; i < multi3; i++) {
                Console.Write(multiplo[i] + " | ");
                }
            Console.Write("\n\nResto dos valores: ");
            for (i = 0; i < rest; i++) {
                Console.Write(resto[i] + " | ");
                }
            Console.ReadKey();
            }
        }
    }
