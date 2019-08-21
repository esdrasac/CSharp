using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_1 {
    class Program {
        static void Main(string[] args) {
            int aux = 1, i = 0, j = 0, x = 0, y = 0, numelementos = 0;
            Console.WriteLine("                 Pontifícia Universidade Católica");
            Console.WriteLine("Digite as dimensões da matriz, em seguida a preencha");
            Console.Write("\nDigite o número de linhas: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Digite o número de colunas: ");
            y = int.Parse(Console.ReadLine());
            int[,] matriz = new int[x, y];
            
            for (i = 0; i < x; i++) {
                
                for(j = 0; j < y; j++) {
                    Console.Write($"\nDigite o {j+aux}º número: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                    if (matriz[i,j]> 15 && matriz[i,j] < 25) {
                        numelementos++;
                        }
                    }
                aux += j;
                }
            Console.WriteLine($"\nO número de elementos maiores que 15 e menores que 25 é: {numelementos}");
            Console.ReadKey();
            }
        }
    }
