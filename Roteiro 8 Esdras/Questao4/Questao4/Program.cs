using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("                     Pontifícia Universidade Católica");
            double altura;
            char s;
            Console.Write("\nAltura: ");
            altura = double.Parse(Console.ReadLine());
            Console.Write("\nSexo: ");
            s = char.Parse(Console.ReadLine());
            Console.Write("\nPeso ideal" + PesoIdeal(s, altura));
            Console.ReadKey();

        }
        static double PesoIdeal(char sexo, double altura) {
            if (sexo == 'm') return (72.7 * altura) - 58;
            else if (sexo == 'f') return (62.1 * altura) - 44.7;
            return 0;
        }
    }
}
