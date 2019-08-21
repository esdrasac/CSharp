using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_6 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("                 Pontifícia Universidade Católica");

            int i = 0, aux = 0, idade50 = 0, peso70 = 0, mediaaux = 0, media = 0;

            int[] idade = new int[10];
            int[] peso = new int[10];

            for (i = 0; i < 10; i++) {
                Console.WriteLine($"\nDigite os dados da {i + 1}ª pessoa");

                Console.Write("Idade: ");
                aux = int.Parse(Console.ReadLine());
                while (aux <= 0 ) {
                    Console.WriteLine("Número inválido, digite outro número");
                    Console.Write("Idade: ");
                    aux = int.Parse(Console.ReadLine());
                    }
                idade[i] = aux;
                if (idade[i] > 50) {
                    idade50++;
                    }
                

                Console.Write("Peso: ");
                aux = int.Parse(Console.ReadLine());
                while (aux <= 0) {
                    Console.WriteLine("Número inválido, digite outro número");
                    Console.Write("Peso: ");
                    aux = int.Parse(Console.ReadLine());
                    }
                peso[i] = aux;
                if (peso[i] > 70) {
                    peso70++;
                    }
                if (idade[i] >= 20 && idade[i] <= 30) {
                    mediaaux++;
                    media += peso[i];
                    }

                }
            media = media / mediaaux;
            Console.WriteLine($"\nA quantidade de pessoas com idade superior à 50 anos é: {idade50}");
            Console.WriteLine($"A quantidade de pessoas com peso superior à 70 quilos é: {peso70}");
            Console.WriteLine($"A média do peso das pessoas com idades entre 20 e 30 anos é: {media}");

            }
        }
    }
    
