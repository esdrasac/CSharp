using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao5
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("                     Pontifícia Universidade Católica");
            int[,] matriz = new int[4, 5];
            int i, j;
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    matriz[i, j] = j;
                }
            }
            m(matriz);
            Console.ReadKey();

        }
        static void m(int[,] a) {
            int[] v = new int[4];
            int cont = 0;
            for (int i = 0; i < 4; i++) {
                Console.WriteLine();
                for (int j = 0; j < 5; j++) {
                    v[i] += a[i, j];
                }
            }
            for (int i = 0; i < 4; i++) {
                if (v[i] >= 10) {
                    cont++;
                    Console.WriteLine(v[i]);
                }
            }
            if (cont == 0) Console.WriteLine("Nenhum valor maior que 10");
        }
    }
}
