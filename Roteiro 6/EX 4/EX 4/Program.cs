using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_4 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("                 Pontifícia Universidade Católica\n\n");
            int[,] matriz = new int[5, 5];
            int aux = 1, somalinha4 = 0, somalinha2 = 0, soma = 0;
            for (int i = 0; i < 5; i++) {
                for (int j = 0; j < 5; j++) {
                    Console.Write($" > Digite o {j + aux}º número: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                    }
                aux += 5;
                }
            for(int i = 0; i < 5; i++) {
                somalinha4 += matriz[3, i];
                }
            for (int i = 0; i < 5; i++) {
                somalinha2 += matriz[1, i];
                }
            for (int i = 0; i < 5; i ++) {
                for (int j = 0; j < 5; j++) {
                    soma += matriz[i, j];
                    
                    }
                }
            Console.WriteLine($"\nA soma dos elementos da linha 4 é: {somalinha4}");
            Console.WriteLine($"Asoma dos elementos da linha 2 é: {somalinha2}");
            Console.WriteLine($"A soma de todos os elementos da matriz é: {soma}");

            Console.ReadKey();
            }
        }
    }
