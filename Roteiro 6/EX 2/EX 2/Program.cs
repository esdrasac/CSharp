using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_2 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("                 Pontifícia Universidade Católica\n\n");
            int[,] matriz = new int[4, 4];
            int aux = 1, numerico = 0;
            for (int i = 0; i < 4; i++) {
                for (int j = 0; j < 4; j++) {
                    Console.Write($" > Digite o {j + aux}º número: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                    }
                aux += 4;
                }

            Console.Write("\n   > Informe uma valor numérico: ");
            numerico = int.Parse(Console.ReadLine());
            for (int i = 0; i < 4; i++) {
                for (int j = 0; j < 4; j++) {

                    matriz[i, j] = matriz[i, j] * numerico;
                    }
                }
            Console.WriteLine($"\nA matriz resultante multiplicada pelo valor numérico informado é:\n ");
            aux = 1;
            for (int i = 0; i < 4; i++) {
                for (int j = 0; j < 4; j++) {

                    Console.WriteLine($"        > Resultado do {j + aux}º valor: {matriz[i, j]}");
                    }
                aux += 4;
                }
            Console.ReadKey();
            }
        }
    }
