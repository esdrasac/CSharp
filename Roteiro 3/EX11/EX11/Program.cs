using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX11
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor, resultado;
            int aux;
            Console.WriteLine("                Pontifícia Universidade Católica");
            Console.WriteLine("                   Calculo de juros veicular");
            Console.Write("\nQual o valor do carro? ");
            valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Forma de pagamento: ");
            Console.WriteLine("1. À vista");
            Console.WriteLine("2. Financiamento em 6x");
            Console.WriteLine("3. Financiamento em 12x");
            Console.WriteLine("4. Financiamento em 18x");
            Console.WriteLine("5. Financiamento em 24x");
            Console.WriteLine("6. Financiamento em 30x");
            Console.WriteLine("7. Financiamento em 36x");
            Console.WriteLine("8. Financiamento em 42x");
            Console.WriteLine("9. Financiamento em 48x");
            Console.WriteLine("10. Financiamento em 54x");
            Console.WriteLine("11. Financiamento em 60x");
            aux = int.Parse(Console.ReadLine());
            
            switch (aux)
            {
                case 1:
                    resultado = valor - (valor * 0.20);
                    Console.WriteLine($"\nO valor final à ser pago pelo veículo é de: {resultado}");
                    break;
                case 2:
                    resultado = valor + (valor * 0.03);
                    Console.WriteLine($"\nO valor final à ser pago pelo veículo é de: {resultado}");
                    break;
                case 3:
                    resultado = valor + (valor * 0.06);
                    Console.WriteLine($"\nO valor final à ser pago pelo veículo é de: {resultado}");
                    break;
                case 4:
                    resultado = valor + (valor * 0.09);
                    Console.WriteLine($"\nO valor final à ser pago pelo veículo é de: {resultado}");
                    break;
                case 5:
                    resultado = valor + (valor * 0.012);
                    Console.WriteLine($"\nO valor final à ser pago pelo veículo é de: {resultado}");
                    break;
                case 6:
                    resultado = valor + (valor * 0.15);
                    Console.WriteLine($"\nO valor final à ser pago pelo veículo é de: {resultado}");
                    break;
                case 7:
                    resultado = valor + (valor * 0.18);
                    Console.WriteLine($"\nO valor final à ser pago pelo veículo é de: {resultado}");
                    break;
                case 8:
                    resultado = valor + (valor * 0.21);
                    Console.WriteLine($"\nO valor final à ser pago pelo veículo é de: {resultado}");
                    break;
                case 9:
                    resultado = valor + (valor * 0.24);
                    Console.WriteLine($"\nO valor final à ser pago pelo veículo é de: {resultado}");
                    break;
                case 10:
                    resultado = valor + (valor * 0.27);
                    Console.WriteLine($"\nO valor final à ser pago pelo veículo é de: {resultado}");
                    break;
                case 11:
                    resultado = valor + (valor * 0.30);
                    Console.WriteLine($"\nO valor final à ser pago pelo veículo é de: {resultado}");
                    break;
                
                default:
                    Console.WriteLine("\nForma de Pagamento inválida");
                    break;
            }
            Console.ReadKey();
        }
    }
}
