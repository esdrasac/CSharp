using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                     Pontifícia Universidade Católica");
            int hora;
            Console.WriteLine("\nDigite as horas: ");
            hora = int.Parse(Console.ReadLine());
            Console.WriteLine("\nEm minutos: " + Min(hora));
            Console.WriteLine("Em segundos: " + Seg(hora));
            Console.WriteLine("Em milisegundos: " + MiliSeg(hora));
            Console.ReadKey();



        }
        static double Min(int hora) {
            return hora * 60;
        }
        static double Seg(int hora) {
            return hora * 3600;
        }
        static double MiliSeg(int hora) {
            return hora * 3600000;
        }
    }
}
