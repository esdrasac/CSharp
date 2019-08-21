using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex23
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, aux = 0;
            double salario; 

            Console.WriteLine("              Pontifícia Universidade Católica");
            Console.WriteLine("                 Atendimento ao funcionário");

            while (i == 0)
            {
                Console.WriteLine("\nEm que posso ajudar?");
                Console.WriteLine("\n1.Calcular novo salário");
                Console.WriteLine("2.Calcular férias");
                Console.WriteLine("3.Calcular decimo terceiro salário");
                Console.WriteLine("4.Sair");
                aux = int.Parse(Console.ReadLine());
                switch (aux)
                {
                    case 1:
                        Console.Write("\nPor favor, me informe seu salário atual? ");
                        salario = double.Parse(Console.ReadLine());
                        double salarionovo;
                        if (salario > 0 && salario <= 210)
                        {
                            salarionovo = salario + (salario * 0.15);
                            Console.WriteLine($"\nSeu novo salário é: R${salarionovo:F2} ");
                        }
                        else if (salario > 210 && salario <= 600)
                        {
                            salarionovo = salario + (salario * 0.1);
                            Console.WriteLine($"\nSeu novo salário é: R${salarionovo:F2} ");
                        }
                        else if (salario > 600)
                        {
                            salarionovo = salario + (salario * 0.05);
                            Console.WriteLine($"\nSeu novo salário é: R${salarionovo:F2} ");
                        }
                        else
                        {
                            Console.WriteLine("Salário inválido\n\n\n");
                        }
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Write("\nPor favor, me informe seu salário atual? ");
                        salario = double.Parse(Console.ReadLine());
                        double ferias;
                        ferias = salario + (salario / 3);
                        Console.Write($"\nSeu salário de férias é: R${ferias:F2}");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Write("\nPor favor, me informe seu salário atual? ");
                        salario = double.Parse(Console.ReadLine());
                        int meses;
                        double decimo;
                        Console.Write("Por favor, infome a quantidade de meses trabalhados este ano: ");
                        meses = int.Parse(Console.ReadLine());
                        decimo = (salario * meses) / 12;
                        Console.Write($"\nSeu decimo terceiro salário é: R${decimo:F2}");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("\n\n       Obrigado!");
                        i++;
                        break;
                    default:
                        Console.WriteLine("\nOperação inválida");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
