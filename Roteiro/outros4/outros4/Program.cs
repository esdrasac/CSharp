using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace outros4
{
    class Program
    {
        static void Main(string[] args)
        {
            char sexo = 'A';
            int i = 0, pesquisa = 0, mediapeso = 0, mediaaltura = 0, olho = 0, olhocabelo = 0, olhoazul = 0, olhoverde = 0, olhocastanho = 0, cabelo = 0, cabelolouro = 0, cabelocastanho = 0, cabelopreto = 0, masculino = 0, feminino = 0;
            double peso = 0, altura = 0, idade = 0, mediaidade = 0, mediah = 0, mediam = 0; ;

            while (i == 0)
            {
                Console.WriteLine("Sexo:");
                Console.WriteLine("M. Masculino");
                Console.WriteLine("F. Feminino");
                sexo = char.Parse(Console.ReadLine().ToUpper());
                if (sexo == 'M')
                {
                    masculino++;
                }
                else if (sexo == 'F')
                {
                    feminino++;
                }
                else
                {
                    Console.WriteLine("ERRO");
                }

                Console.WriteLine("Olhos:");
                Console.WriteLine("1. Azuis");
                Console.WriteLine("2. Verdes");
                Console.WriteLine("3. Castanhos");
                olho = int.Parse(Console.ReadLine());
                if (olho == 1)
                {
                    olhoazul++;
                }
                else if (olho == 2)
                {
                    olhoverde++;
                }
                else if (olho == 3)
                {
                    olhocastanho++;
                }
                else
                {
                    Console.WriteLine("ERRO");
                }

                Console.WriteLine("Cabelo:");
                Console.WriteLine("1. Louro");
                Console.WriteLine("2. Castanho");
                Console.WriteLine("3. Preto");
                cabelo = int.Parse(Console.ReadLine());
                if (cabelo == 1)
                {
                    cabelolouro++;
                }
                else if (cabelo == 2)
                {
                    cabelocastanho++;
                }
                else if (cabelo == 3)
                {
                    cabelopreto++;
                }
                else
                {
                    Console.WriteLine("\nOpção inválida");
                }

                if (olho == 2 && cabelo == 1)
                {
                    olhocabelo++;
                }

                Console.WriteLine("Idade: ");
                idade += double.Parse(Console.ReadLine());
                mediaidade++;

                Console.WriteLine("Altura: ");
                altura += double.Parse(Console.ReadLine());
                mediaaltura++;

                Console.WriteLine("Peso: ");
                peso += double.Parse(Console.ReadLine());
                mediapeso++;

                Console.WriteLine("Nova pesquisa:");
                Console.WriteLine("1. Sim");
                Console.WriteLine("2. Não");
                pesquisa = int.Parse(Console.ReadLine());
                if (pesquisa == 1)
                {
                    Console.WriteLine("Nova pesquisa");
                }
                else
                {
                    i++;
                }
            }

            
                idade = idade / mediaidade;
                peso = peso / mediapeso;
                altura = altura / mediaaltura; 
                mediah = (100 * masculino) / (masculino + feminino);
                mediam = (100 * feminino) / (masculino + feminino);
                Console.WriteLine("A média das idades dos participantes é: " + idade);
                Console.WriteLine("A média do peso dos participantes é: " + peso );
                Console.WriteLine("A média da altura dos participantes é: " + altura);
                Console.WriteLine("A porcentagem de homens é de " + mediah + "% e das mulheres é de " + mediam + "%");
                Console.WriteLine("A Pessoas com olhos verdes e cabelo louro é: " + olhocabelo);
                Console.ReadKey();
            
        }
    }
}
