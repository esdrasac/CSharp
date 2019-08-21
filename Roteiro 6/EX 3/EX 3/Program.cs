using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_3 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("                 Pontifícia Universidade Católica\n\n");
            int[,] matriz = new int[8, 6];
            int aux = 1, media = 0, cont = 0;
            for (int i = 0; i < 8; i++) {
                for (int j = 0; j < 6; j++) {
                    Console.Write($" > Digite o {j + aux}º número: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                    }
                aux += 6;
                }

            for (int i = 1; i < 8; i+=2) {
                for (int j = 0; j < 6; j++) {
                    media += matriz[i, j];
                    cont++;
                    }
                }
            media = media / cont;
            Console.WriteLine($"\nA média dos elementos das linhas pares é: {media}");
            Console.ReadKey();
            }
        }
    }
