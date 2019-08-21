using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3
{
    class Program
    {
        static void Main(string[] args)
        {
            double porcentagem1, porcentagem2;
            int[] pessoas, etaria;
            pessoas = new int[9];
            etaria = new int[6];
            int i = 1;
            Console.WriteLine("                  Pontifícia Universidade Católica");
            Console.WriteLine("Digite a idade de 8 pessoas:");
            for (i = 1; i <= 8; i++) 
            {
                Console.Write($"\nIdade da {i}ª pessoa: ");
                pessoas[i] = int.Parse(Console.ReadLine());
            }
            i = 1;

            for (i = 1; i <= 8; i++)
            {
                if (pessoas[i] <= 15)
                {
                    etaria[1] += 1;
                }
                else if (pessoas[i] >= 16 && pessoas[i] <= 30)
                {
                    etaria[2] += 1;
                }
                else if (pessoas[i] >= 31 && pessoas[i] <= 45)
                {
                    etaria[3] += 1;
                }
                else if (pessoas[i] >= 46 && pessoas[i] <= 60)
                {
                    etaria[4] += 1;
                }
                else 
                {
                    etaria[5] += 1;
                }
            }
            i = 1;

            Console.WriteLine("\nA quantidade de pessoas em cada faixa etaria é:");
            Console.WriteLine($"Até 15 anos: {etaria[1]}");
            Console.WriteLine($"De 16 à 30 anos: {etaria[2]}");
            Console.WriteLine($"De 31 à 45 anos: {etaria[3]}");
            Console.WriteLine($"De 46 à 60 anos: {etaria[4]}");
            Console.WriteLine($"Acima de 60 anos: {etaria[5]}");

            porcentagem1 = etaria[1] + etaria[2] + etaria[3] + etaria[4] + etaria[5];
            porcentagem1 = (100 * etaria[1]) / porcentagem1;
            Console.WriteLine($"\nA porcetagem de pessoas na primeira faixa etaria em relação ao total de pessoas é: {porcentagem1}%");

            porcentagem2 = etaria[1] + etaria[2] + etaria[3] + etaria[4] + etaria[5];
            porcentagem2 = (100 * etaria[5]) / porcentagem2;
            Console.WriteLine($"\nA porcetagem de pessoas na ultima faixa etaria em relação ao total de pessoas é: {porcentagem2}%");

            Console.ReadKey();
        }
    }
}
