using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario;
            Console.WriteLine("                    Pontifícia Universidade Católica");
            Console.WriteLine("\nCalculo total liquido a receber (+ gratificação - imposto de 7%) ");
            Console.Write("\nDigite seu salário bruto: ");
            salario = double.Parse(Console.ReadLine());
            if (salario <= 350)
            {
                salario = (salario + 100) - ((salario + 100) * 0.07);
                Console.WriteLine($"\nO seu salário somado à gratifcação e descontando o imposto é: {salario}");
            }
            else if (salario > 350 && salario < 600)
            {
                salario = (salario + 75) - ((salario + 75) * 0.07);
                Console.WriteLine($"\nO seu salário somado à gratifcação e descontando o imposto é: {salario}");
            }
            else if (salario >= 600 && salario <= 900)
            {
                salario = (salario + 50) - ((salario + 50) * 0.07);
                Console.WriteLine($"\nO seu salário somado à gratifcação e descontando o imposto é: {salario}");
            }
            else if (salario > 900)
            {
                salario = (salario + 35) - ((salario + 35) * 0.07);
                Console.WriteLine($"\nO seu salário somado à gratifcação e descontando o imposto é: {salario}");
            }
            Console.ReadKey();
        }
    }
}
