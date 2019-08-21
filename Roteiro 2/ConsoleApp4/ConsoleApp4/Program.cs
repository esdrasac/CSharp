using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("              Esdras Aguilar Enterprise");
            Console.WriteLine("\n  Menu");
            Console.WriteLine("1. Se estiver triste comigo");
            Console.WriteLine("2. Se estiver cansada de brigar");
            Console.WriteLine("3. Se quiser conversar");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine("\nMe perdoa?");
                    break;
                case 2:
                    Console.WriteLine("\nSaiba que eu te amo");
                    break;
          
                default:
                    break;
            }
        }
    }
}
