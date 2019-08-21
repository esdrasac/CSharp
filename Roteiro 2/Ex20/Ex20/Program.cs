using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex20
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            Console.WriteLine("                      Pontifícia Universidade Católica");
            Console.WriteLine("\nPara saber a categoria do nadador digite sua idade: ");
            idade = int.Parse(Console.ReadLine());
            if (idade >= 5 && idade <= 7)
            {
                Console.WriteLine("\nSua categoria é infantil");
            }
            else if (idade >= 8 && idade <= 10)
            {
                Console.WriteLine("\nSua categoria é juvenil");
            }
            else if (idade >= 11 && idade <= 15)
            {
                Console.WriteLine("\nSua categoria é adolecente");
            }
            else if (idade >= 16 && idade <= 30)
            {
                Console.WriteLine("\nSua categoria é adulto");
            }
            else if (idade > 30)
            {
                Console.WriteLine("\nSua categoria é sênior");
            }
            Console.ReadKey();
        }
    }
}
            
        
    

