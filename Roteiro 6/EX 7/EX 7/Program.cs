using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_7 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("\t\t\tPontifícia Universidade Católica\n\n");
            
            
            double media = 0;
            int aux = 1, cont = 0, mediamais = 0;
            Console.Write("\nDeseja fazer o relatório de quantas semanas? ");
            int semana = int.Parse(Console.ReadLine());
            double[,] matriz = new double[semana, 7];
            int[] semanamenor = new int[semana];
            Console.WriteLine("\nNota: Use '.' para separar casas decimais\n");
            for (int i = 0; i < semana; i++) {
                for (int j = 0; j < 7; j++) {
                    Console.Write($" > Digite a produção diária do {j + aux}º dia correspondente à {i+1}ª semana: ");
                    matriz[i, j] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    }
                }
            Console.WriteLine("");
            Console.WriteLine("\n             Dia 1     |     Dia 2     |     Dia 3     |     Dia 4     |     Dia 5     |     Dia 6     |     Dia 7     |");
            
            for (int i = 0; i < semana; i++) {
                Console.Write($"\nSemana {i + 1}: ");
                for (int j = 0; j < 7; j++) {
                    Console.Write(matriz[i,j].ToString("R$ "+"000000.00", CultureInfo.InvariantCulture) + " |  " );
                    }
                
                }
            for (int i = 0; i < semana; i ++) {             // Produção Media 
                for (int j = 0; j < 7; j++) {
                    media += matriz[i,j];
                    cont++;
                    }
                }
            media = media / cont;

            for (int i = 0; i < semana; i++) {    // Dias com produção acima da média
                for (int j = 0; j < 7; j++) {
                    if(matriz[i,j] > media) {
                        mediamais++;
                        }
                    }
                }
            double menor = 9999999999999999999;

            for (int i = 0; i < semana; i++) {
                for (int j = 0; j < 7; j++) {
                   
                    if (matriz[i,j] < menor) {
                        menor = matriz[i, j];
                        semanamenor[i] = j + 1;
                        }
                    }
                }

            Console.WriteLine($"\nRELATÓRIO DE PRODUÇÃO RELATIVO À {semana} SEMANAS");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine($"Produção média: R${media:F2}");
            Console.WriteLine($"Número de dias com produção acima da média: {mediamais}");
            Console.WriteLine($"\nIndicação dos dias de mínima produção");
            Console.WriteLine("------------------------------------------------------------");
            for (int i = 0; i < semana; i++) {
                Console.WriteLine($"Semana {i+1}: {semanamenor[i]}");
                }

            }
        }
    }
