using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao6
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("                     Pontifícia Universidade Católica");
            int[] v = new int[10];
            int i,j;
            for (i = 0, j = 9; i<9 && j>0;i++,j--) v[i] = j;

            
            Selecao(v, 10);
            Imprime(v);
            Console.ReadKey();


        }
        static void Selecao(int[] vet, int tam) {
            int i, j, min, x;
            for (i = 1; i <= 10 - 1; i++) {
                min = i;
                for (j = i + 1; j <= 9; j++) {
                    if (vet[j] < vet[min])
                        min = j;
                }
                x = vet[min];
                vet[min] = vet[i];
                vet[i] = x;
            }

        }
        static void Imprime(int[] vet) {
            for (int i = 0; i < 10; i++) {
                Console.Write(vet[i] + " ");
            }
        }
    }
}
