using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            double mediasalario;
            Console.WriteLine("                    Pontifícia Universidade Católica");
            Console.WriteLine("\nO Banco está disponibilizando um bônus de crédito para clientes");
            Console.Write("Para saber se vc é um beneficiado, informe sua média salarial do ano passado: ");
            mediasalario = double.Parse(Console.ReadLine());
            if (mediasalario <= 350)
            {
                Console.WriteLine("\nVocê foi contemplado com um crédito de R$100,00.");
            }
            else if (mediasalario > 350 && mediasalario <= 600)
            {
                Console.WriteLine("\nVocê foi contemplado com um crédito de R$75,00.");
            }
            else if (mediasalario > 600 && mediasalario <= 900)
            {
                Console.WriteLine("\nVocê foi contemplado com um crédito de R$50,00.");
            }
            else
            {
                Console.WriteLine("\nVocê foi contemplado com um crédito de R$35,00.");
            }
            Console.ReadKey();
        }
    }
}
