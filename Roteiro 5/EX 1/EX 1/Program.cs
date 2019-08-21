using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_1 {
    class Program {
        static void Main(string[] args) {

            double[] num = new double[10]; // Declaração e implementação de um vetor de 10 posições do tipo double
            int qtde = 0; // Declaração de variável do tipo inteiro
            double soma = 0, media; // Declaração de variável do tipo double

            for (int x = 0; x < 10; x++) { // Estrutura for para solicitar e armazenar os números a serem fornecidos pelo usuário
                Console.WriteLine("Digite o valor " + x + ": ");
                num[x] = int.Parse(Console.ReadLine());
                }
            for (int x = 0; x < 10; x++) { // Estrutura for para atribuir (qtde++) e somar os 5 últimos números

                if (x > 5) {
                    qtde++;
                    soma = soma + num[x];
                    }
                }
            Console.WriteLine("Valores do vetor: "); // Imprime todos os valores do vetor
            for (int x = 0; x < 10; x++) {
                Console.Write(num[x] + " | ");

                }
            media = soma / qtde; // Calcula a média dos 5 últimos números do vetor
            Console.WriteLine("\nA media é: " + media); // Imprime a média
            Console.ReadKey();
            }
        }
    }
