using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_6 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("                 Pontifícia Universidade Católica");
            FileStream arq = new FileStream("entrada.txt", FileMode.Create);
            StreamWriter escreve = new StreamWriter(arq);
            int i = 0, j = 0;
            double[,] matriz = new double[3, 3];
            for (i = 0; i < 3; i++) {
                for (j = 0; j < 3; j++) {
                    Console.Write("Digite um número: ");
                    matriz[i, j] = double.Parse(Console.ReadLine());
                    escreve.WriteLine(matriz[i, j]);
                }
            }
            escreve.Close();

            FileStream arq1 = new FileStream("saida.txt", FileMode.Create);
            StreamWriter saida = new StreamWriter(arq1);
            Console.Write("Digite um multiplicador: ");
            double x = int.Parse(Console.ReadLine());
            double resultado = 0;
            for (i = 0; i < 3; i++) {
                for(j = 0; j < 3; j++) {
                    resultado = matriz[i, j] * x;
                    saida.Write(resultado + " ");
                }
                saida.WriteLine();
            }
            saida.Close();

            FileStream arq2 = new FileStream("saida.txt", FileMode.Open);
            StreamReader ler = new StreamReader(arq2);
            string linha;
            do {
                linha = ler.ReadLine();
                Console.WriteLine(linha);
            } while (linha != null);
        }
    }
}
