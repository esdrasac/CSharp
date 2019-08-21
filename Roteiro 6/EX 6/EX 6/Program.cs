using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_6 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("                 Pontifícia Universidade Católica\n\n");
            int[,] matriz = new int[3, 3];
            int aux = 1, media = 0, cont = 0;
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    Console.Write($" > Digite o {j + aux}º número: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                    }
                aux += 3;
                }
            for (int i = 0; i < 3; i++) {
                    media += matriz[i, i];
                    cont++;
                }
            media = media / cont;
            Console.WriteLine($"\nA média dos elementos da diagonal principal é: {media}");
            Console.ReadKey();

            }
        }
    }
