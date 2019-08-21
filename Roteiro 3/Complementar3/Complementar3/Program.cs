using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complementar3
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor, resultado;
            int meses;
            Console.WriteLine("                Pontifícila Universidade Católica");
            Console.WriteLine("Cálculo de juros sobre o imposto em atraso");
            Console.WriteLine("\nQual o valor do imposto? ");
            valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantas meses de atraso?");
            meses = int.Parse(Console.ReadLine());
            if (valor < 0 )
            {
                
                Console.WriteLine("Valor incorreto");
            }
            else if (valor >0 && valor <= 50)
            {
                resultado = valor + (valor * 0.01);
                resultado = resultado * meses;
                Console.WriteLine($"\nTotal a pagar: {resultado}");
            }
            else if (valor > 50 && valor <= 180)
            {
                resultado = valor + (valor * 0.02);
                resultado = resultado * meses;
                Console.WriteLine($"\nTotal a pagar: {resultado}");
            }
            else if (valor > 180 && valor <= 500)
            {
                resultado = valor + (valor * 0.04);
                resultado = resultado * meses;
                Console.WriteLine($"\nTotal a pagar: {resultado}");
            }
            else if (valor > 500 && valor <= 1200)
            {
                resultado = valor + (valor * 0.07);
                resultado = resultado * meses;
                Console.WriteLine($"\nTotal a pagar: {resultado}");
            }
            else 
            {
                resultado = valor + (valor * 0.1);
                resultado = resultado * meses;
                Console.WriteLine($"\nTotal a pagar: {resultado}");
            }
            Console.ReadKey();
        }
    }
}
