using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao23
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 0, aux = 0, meses = 0;
            double salario = 0, novosalario = 0, ferias = 0, decimoterceiro = 0;

            while (i == 0)
            {

                Console.WriteLine("\nDigite 1 para calcular novo salário");
                Console.WriteLine("Digite 2 para calcular férias");
                Console.WriteLine("Digite 3 para calcular decimo terceiro salário");
                Console.WriteLine("4.Sair");
                aux = int.Parse(Console.ReadLine());
                if (aux == 1)
                {
                    Console.WriteLine("\nQual o seu salario? ");
                    salario = double.Parse(Console.ReadLine());

                    if (salario > 0 && salario <= 210)
                    {
                        novosalario = salario + (salario * 0.15);
                        Console.WriteLine("\nSeu novo salário é: R$" + novosalario);
                    }
                    else if (salario > 210 && salario <= 600)
                    {
                        novosalario = salario + (salario * 0.1);
                        Console.WriteLine("\nSeu novo salário é: R$" + novosalario);
                    }
                    else if (salario > 600)
                    {
                        novosalario = salario + (salario * 0.05);
                        Console.WriteLine("\nSeu novo salário é: R$" + novosalario);
                    }
                    else
                    {
                        Console.WriteLine("ERRO");
                    }
                }
                else if (aux == 2)
                {
                    Console.Write("\nQual o seu salário atual? ");
                    salario = double.Parse(Console.ReadLine());
                    ferias = salario + (salario / 3);
                    Console.Write("\nSeu salário de férias é: R$" + ferias);
                }
                else if (aux == 3)
                {
                    Console.Write("\nQual o seu salário atual? ");
                    salario = double.Parse(Console.ReadLine());
                    Console.Write("Meses trabalhados nesse ano: ");
                    meses = int.Parse(Console.ReadLine());
                    decimoterceiro = (salario * meses) / 12;
                    Console.Write("\nSeu decimo terceiro salário é: R$" + decimoterceiro);
                }
                else if (aux == 4)
                {
                    i++;
                }
                else
                {
                    Console.WriteLine("ERRO");
                }
            }
        }
    }
}
