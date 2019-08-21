using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complementar5
{
    class Program
    {
        static void Main(string[] args)
        {
            int eleitores, i = 0, aux = 0, c1 = 0, c2 = 0, c3 = 0, total = 0;
            double pc1 = 0, pc2 = 0, pc3 = 0;
            string municipio, candidato1, candidato2, candidato3;
            Console.WriteLine("                Pontifícia Universidade Católica");
            Console.WriteLine("                         Eleições 2019");
            Console.WriteLine("\nQual o municipio das eleições: ");
            municipio = Console.ReadLine();
            Console.WriteLine("Digite o nome dos candidatos: ");
            Console.Write("1º: ");
            candidato1 = Console.ReadLine();
            Console.Write("2º: ");
            candidato2 = Console.ReadLine();
            Console.Write("3º: ");
            candidato3 = Console.ReadLine();
            Console.WriteLine("Quantos dos eleitores desse municipio são aptos para a Eleição");
            eleitores = int.Parse(Console.ReadLine());
            for (i = 0; i < eleitores; i++)
            {
                Console.WriteLine("                         Eleições 2019");
                Console.WriteLine("             Escolha o seu candidato e confirme");
                Console.WriteLine($"1.{candidato1} - Pior que tá num fica");
                Console.WriteLine($"2.{candidato2} - Para um novo tempo com mais feriados");
                Console.WriteLine($"3.{candidato3} - bolsa sono, um beneficio enquanto você dorme");
                aux = int.Parse(Console.ReadLine());
                switch (aux)
                {
                    case 1:
                        c1++;
                        break;
                    case 2:
                        c2++;
                        break;
                    case 3:
                        c3++;
                        break;
                    default:
                        Console.WriteLine("Candidato inválido");
                        break;
                }
            }
            total = c1 + c2 + c3;
            pc1 = (100 * c1) / total;
            pc2 = (100 * c2) / total;
            pc3 = (100 * c2) / total;

            if (pc1 > pc2 && pc1 > pc3)
            {
                if (total > 20000)
                {
                    if (pc1 > (pc2 + pc3))
                    {
                        Console.WriteLine($"\nO candidato {candidato1} venceu as eleições no 1º turno com {pc1}% dos votos");
                    }
                    else
                    {
                        Console.WriteLine($"\nO candidato irá para o segundo turno com {pc1}% dos votos");
                    }
                }
                else
                {
                    Console.WriteLine($"\nO candidato {candidato1} venceu as eleições no 1º turno com {pc1}% dos votos");
                }
            }
            else if (pc2 > pc1 && pc2 > pc3)
            {
                if (total > 20000)
                {
                    if (pc2 > (pc1 + pc3))
                    {
                        Console.WriteLine($"\nO candidato {candidato2} venceu as eleições no 1º turno com {pc2}% dos votos");
                    }
                    else
                    {
                        Console.WriteLine($"\nO candidato {candidato2} irá para o segundo turno com {pc2}% dos votos");
                    }
                }
                else
                {
                    Console.WriteLine($"\nO candidato {candidato2} venceu as eleições no 1º turno com {pc2}% dos votos");
                }
            }
            else if (pc3 > pc2 && pc3 > pc1)
            {
                if (total > 20000)
                {
                    if (pc3 > (pc2 + pc1))
                    {
                        Console.WriteLine($"\nO candidato {candidato3} venceu as eleições no 1º turno com {pc3}% dos votos");
                    }
                    else
                    {
                        Console.WriteLine($"\nO candidato {candidato3} irá para o segundo turno com {pc3}% dos votos");
                    }
                }
                else
                {
                    Console.WriteLine($"\nO candidato {candidato3} venceu as eleições no 1º turno com {pc3}% dos votos");
                }
            }
            Console.ReadKey();
        }
    }
}
