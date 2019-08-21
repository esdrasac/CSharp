using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX8
{
    class Program
    {
        static void Main(string[] args)
        {
            double mediaidade = 0, porcentagem = 0;
            double[] peso, altura;
            int[]  idade, cabelo, cor;
            cor = new int[7];
            cabelo = new int[7];
            idade = new int[7];
            peso = new double[7];
            altura = new double[7];
            int i = 1, maior50 = 0, auxcor = 0, auxcorcabelo = 0, mediacor = 0, mediacorcabelo = 0, contadoraltura = 0;


            Console.WriteLine("                  Pontifícia Universidade Católica");
            Console.WriteLine("Entre com os dados de seis pessoas: ");
            for (i = 1; i <= 6; i++)
            {
                Console.Write($"\nIdade da {i}ª pessoa: ");
                idade[i] = int.Parse(Console.ReadLine());
                Console.Write($"\nPeso da {i}ª pessoa: ");
                peso[i] = int.Parse(Console.ReadLine());
                Console.Write($"\nAltura da {i}ª pessoa: ");
                altura[i] = double.Parse(Console.ReadLine());
                Console.WriteLine($"\n Qual a cor dos olhos da {1}ª pessoa?");
                Console.WriteLine("1.Azul");
                Console.WriteLine("2.Preto");
                Console.WriteLine("3.Castanho");
                auxcor = int.Parse(Console.ReadLine());
                switch (auxcor)
                {
                    case 1:
                        cor[i] = 1; //Azul
                        break;
                    case 2:
                        cor[i] = 2; //Preto
                        break;
                    case 3:
                        cor[i] = 3; //Castanho
                        break;
                    default:
                        Console.WriteLine("Comando inválido");
                        break;
                }
                Console.WriteLine($"\n Qual a cor dos cabelos da {1}ª pessoa?");
                Console.WriteLine("1.Preto");
                Console.WriteLine("2.Castanho");
                Console.WriteLine("3.Loiro");
                Console.WriteLine("4.Ruivo");
                auxcorcabelo = int.Parse(Console.ReadLine());
                switch (auxcorcabelo)
                {
                    case 1:
                        cabelo[i] = 1; //Preto
                        break;
                    case 2:
                        cabelo[i] = 2; //Castanho
                        break;
                    case 3:
                        cabelo[i] = 3; //Loiro
                        break;
                    case 4:
                        cabelo[i] = 4; //Ruivo
                        break;
                    default:
                        Console.WriteLine("Comando inválido");
                        break;
                }
            }

            i = 1;
            for (i = 1; i <= 6; i++)
            {
                if (idade[i] > 50 && peso[i] < 60)
                {
                    maior50 += 1;
                }
                if (altura[i] < 1.5)
                {
                    contadoraltura += 1;
                    mediaidade += idade[i];
                }
                if (cor[i] == 1)
                {
                    mediacor += 1;
                }
                if (cabelo[i] == 4 && cor[i] != 1)
                {
                    mediacorcabelo += 1;
                }

            }
            mediaidade = mediaidade / contadoraltura;

            porcentagem = (100 * mediacor) / 6;
           
            Console.WriteLine($"\nA quantidade de pessoas com mais de 50 anos peso inferior à 60kg é: {maior50}");
            Console.WriteLine($"\nA média das idades das pessoas com altura inferior à 1.50m é: {mediaidade:F2} ");
            Console.WriteLine($"\nA porcentagem de pessoas com olhos azuis entre todas analisadas é: {porcentagem}% ");
            Console.WriteLine($"\nA quantidade de pessoas ruivas e que não possuem olhos azuis é: {mediacorcabelo}");

            Console.ReadLine();
        }
    }
}
