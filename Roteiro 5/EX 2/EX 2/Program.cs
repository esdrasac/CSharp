using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_2 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("                 Pontifícia Universidade Católica");

            int i, iguala2 = 0;
            int[] vet = new int[15];
            

            for (i = 0; i < 15; i++) {
                Console.Write($"\nDigite o {i+1}º número: ");
                vet[i] = int.Parse(Console.ReadLine());
                if (vet[i] == 2) {
                    iguala2 ++;
                    }
                };
            Console.WriteLine($"\nA quantidade de elemenos iguais a 2 é: {iguala2}");
            Console.Write($"\nOs elementos múltiplos de 3 são: ");
            for (i = 0; i < 15; i++) {
                if (vet[i] % 3 == 0) {
                    Console.Write(vet[i] + " | ");
                    }
                }
            Console.Write("\n\nAs posições que possuem elementos múltiplos de 2 são: ");
            for (i = 0; i < 15; i++) {
                if (vet[i] % 2 == 0) {
                    Console.Write(i + " | ");
                    }
                }
            Console.ReadKey();
            }
        }
    }
