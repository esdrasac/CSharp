using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complementar_4
{
    class Program
    {
        static void Main(string[] args)
        {
            char sexo = 'o';
            int i = 0, novapesquisa = 0, mediapeso = 0, mediaaltura = 0, olho = 0, olhocabelo = 0, olhoazul = 0, olhoverde = 0, olhocastanho = 0, cabelo = 0, cabelolouro = 0, cabelocastanho = 0, cabelopreto = 0, masculino = 0, feminino = 0;
            double peso = 0, altura = 0, idade = 0, mediaidade = 0;
            Console.WriteLine("               Pontifícia Universidade Católica");
            Console.WriteLine("             Pesquisa de características físicas");
            while (i == 0)
            {
                Console.WriteLine("\nSexo:");
                Console.WriteLine("     M. Masculino");
                Console.WriteLine("     F. Feminino");
                sexo = char.Parse(Console.ReadLine().ToUpper());
                switch (sexo)
                {
                    case 'M':
                        masculino++;
                        break;
                    case 'F':
                        feminino++;
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                Console.WriteLine("\nCor dos olhos:");
                Console.WriteLine("     1. Azuis");
                Console.WriteLine("     2. Verdes");
                Console.WriteLine("     3. Castanhos");
                olho = int.Parse(Console.ReadLine());
                switch (olho)
                {
                    case 1:
                        olhoazul++;
                        break;
                    case 2:
                        olhoverde++;
                        break;
                    case 3:
                        olhocastanho++;
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida");
                        break;
                }
                Console.WriteLine("\nCor do cabelo:");
                Console.WriteLine("     1. Louro");
                Console.WriteLine("     2. Castanho");
                Console.WriteLine("     3. Preto");
                cabelo = int.Parse(Console.ReadLine());
                switch (cabelo)
                {
                    case 1:
                        cabelolouro++;
                        break;
                    case 2:
                        cabelocastanho++;
                        break;
                    case 3:
                        cabelopreto++;
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida");
                        break;
                }
                if (olho == 2 && cabelo == 1)
                {
                    olhocabelo++;
                }

                Console.Write("\nIdade: ");
                idade += double.Parse(Console.ReadLine());
                mediaidade++;

                Console.Write("\nAltura: ");
                altura += double.Parse(Console.ReadLine());
                mediaaltura++;

                Console.Write("\nPeso: ");
                peso += double.Parse(Console.ReadLine());
                mediapeso++;

                Console.WriteLine("\n\nDeseja realizar uma nova pesquisa?");
                Console.WriteLine("     1. Sim");
                Console.WriteLine("     2. Não");
                novapesquisa = int.Parse(Console.ReadLine());
                switch (novapesquisa)
                {
                    case 1:
                        Console.WriteLine("\n\nNova pesquisa solicitada.");
                        break;
                    case 2:
                        i++;
                        Console.WriteLine("\n\nObrigado!");
                        break;
                    default:
                        break;
                }
            }

            idade = idade / mediaidade;
            peso = peso / mediapeso;
            altura = altura / mediaaltura;
            double mediahomem = 0, mediamulher = 0;
            mediahomem = (100 * masculino) / (masculino + feminino);
            mediamulher = (100 * feminino) / (masculino + feminino);
            Console.WriteLine($"\nA média das idades dos participantes é: {idade:F2}");
            Console.WriteLine($"\nA média do peso dos participantes é: {peso:F2} ");
            Console.WriteLine($"\nA média da altura dos participantes é: {altura:F2}");
            Console.WriteLine($"\nA porcentagem de homens é de {mediahomem}% e das mulheres é de {mediamulher}%");
            Console.WriteLine($"\nA quantidade de pessoas com olhos verdes e cabelo louro é: {olhocabelo}");
            Console.ReadKey();
        }
    }
}
