using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                     Pontifícia Universidade Católica");

            Primo();
            Console.ReadKey();
        }
        static void Primo() {
            int n = 0, cont = 0;
            for (int i = 0; i < 1000; i++) {
                n++;
                for (int j = 1; j <= n; j++) {
                    if (n % j == 0) {

                        cont++;
                    }
                }
                if (cont < 2) Console.WriteLine(n + " ");

            }
        }
    }
}
