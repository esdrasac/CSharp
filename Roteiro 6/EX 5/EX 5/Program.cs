using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_5 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("                 Pontifícia Universidade Católica\n\n");
            int[,] matriz = new int[4, 5];
            int[] vet = new int[5];
            int aux = 1;
            for (int i = 0; i < 4; i++) {
                for (int j = 0; j < 5; j++) {
                    Console.Write($" > Digite o {j + aux}º número: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                    }
                aux += 5;
                }

            for (int j = 0; j < 5; j++) {
                for (int i = 0; i < 4; i++) {
                    vet[j] += matriz[i , j];
                    }
                }
            Console.WriteLine("\n > Matriz:");
            for (int i = 0; i < 4; i++) {
                for (int j = 0; j < 5; j++) {
                    Console.Write($" {matriz[i , j]} |");
                    }
                Console.WriteLine("\n");
                }
            Console.WriteLine("\n > Vetor: ");
            for (int i = 0; i < 5; i++) {
                Console.Write($" {vet[i]} |");
                }
            Console.ReadKey();
            }
        }
    }
