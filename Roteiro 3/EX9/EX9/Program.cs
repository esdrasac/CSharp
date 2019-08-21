using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX9
{
    class Program
    {
        static void Main(string[] args)
        {
            double mediaidade = 0, porcentagem = 0;
            double[] peso, altura;
            int[] idade;
            idade = new int[11];
            peso = new double[11];
            altura = new double[11];
            int i = 1, maior90 = 0, contadoraltura = 0, contadoraltura2 = 0;

            Console.WriteLine("                  Pontifícia Universidade Católica");
            Console.WriteLine("Entre com os dados de seis pessoas: ");

            for (i = 1; i <= 10; i++)
            {
                Console.Write($"\nIdade da {i}ª pessoa: ");
                idade[i] = int.Parse(Console.ReadLine());
                Console.Write($"Peso da {i}ª pessoa: ");
                peso[i] = int.Parse(Console.ReadLine());
                Console.Write($"Altura da {i}ª pessoa: ");
                altura[i] = double.Parse(Console.ReadLine());
            }
            i = 1;
            for (i = 1; i <= 10; i++) 
            {
                mediaidade += idade[i];

                if (peso[i] > 90 && altura[i] < 1.50)
                {
                    maior90 += 1;
                }
                if (altura[i] > 1.9)
                {
                    contadoraltura++;
                    if(idade[i] >= 10 && idade[i] <= 30)
                    {
                        contadoraltura2++;
                    }
                }
            }

            mediaidade = mediaidade / 10;

            porcentagem = (100 * contadoraltura2) / contadoraltura;

            Console.WriteLine($"\nA média da idade das dez pessoas é: {mediaidade}");
            Console.WriteLine($"\nA quantidade de pessoas com peso superior à 90kg altura inferior à 1.50m é: {maior90} ");
            Console.WriteLine($"\nA porcentagem de pessoas com idade entre 10 e 30 anos dentre as que medem mais de 1,90m é: {porcentagem}% ");

            Console.ReadLine();
        }
    }
}
