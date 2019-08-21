using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex17
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, n = 0, aux = 0, aux2 = 0, canal4 = 0, canal5 = 0, canal7 = 0, canal12 = 0;
            double pc1 = 0, pc2 = 0, pc3 = 0, pc4 = 0;
            Console.WriteLine("                   Pontifícia Universidade Católica");
            Console.WriteLine("                        Pesquisa de audiência");
            
            while (i > 0)
            {
                Console.WriteLine($"\nQual o canal assistido pela {i}ª família?: ");
                Console.WriteLine("1.Canal 4");
                Console.WriteLine("2.Canal 5");
                Console.WriteLine("3.Canal 7");
                Console.WriteLine("4.Canal 12");
                Console.WriteLine("0.Encerrar");
                aux = int.Parse(Console.ReadLine());
                switch (aux)
                {
                    case 1:
                        Console.Write("\nPessoas assistindo o canal: ");
                        aux2 = int.Parse(Console.ReadLine());
                        canal4 = canal4 + aux2;
                        break;
                    case 2:
                        Console.Write("\nPessoas assistindo o canal: ");
                        aux2 = int.Parse(Console.ReadLine());
                        canal5 = canal5 + aux2;
                        break;
                    case 3:
                        Console.Write("\nPessoas assistindo o canal: ");
                        aux2 = int.Parse(Console.ReadLine());
                        canal7 = canal7 + aux2;
                        break;
                    case 4:
                        Console.Write("\nPessoas assistindo o canal: ");
                        aux2 = int.Parse(Console.ReadLine());
                        canal12 = canal12 + aux2;
                        break;
                    case 0:
                        i = 0;
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
            n = canal4 + canal5 + canal7 + canal12;
            pc1 = (100 * canal4) / n;
            pc2 = (100 * canal5) / n;
            pc3 = (100 * canal7) / n;
            pc4 = (100 * canal12) / n;
            Console.WriteLine($"\nA audiência do canal 4 é de {pc1}%");
            Console.WriteLine($"\nA audiência do canal 5 é de {pc2}%");
            Console.WriteLine($"\nA audiência do canal 7 é de {pc3}%");
            Console.WriteLine($"\nA audiência do canal 12 é de {pc4}%");
            Console.WriteLine("\n\nObrigado");
            Console.ReadKey();

        }
    }
}
