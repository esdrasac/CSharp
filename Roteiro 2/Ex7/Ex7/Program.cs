using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, salarionovo;
            Console.WriteLine("                    Pontifícia Universidade Católica");
            Console.WriteLine("\nPara caucular seu novo salario com base no aumento de 30% siga as instruções");
            Console.Write("\nDigite seu salário atual: ");
            salario = double.Parse(Console.ReadLine());
            if (salario >= 500)
            {
                Console.WriteLine("\nO aumento só aplicável à salários inferiores à R$500,00");
            }
            else
            {
                salarionovo = salario + (salario * 0.3);
                Console.WriteLine("\nSeu novo salário é de: " + salarionovo);
            }
            Console.ReadKey();
        }
    }
}
