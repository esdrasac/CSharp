using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_3 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("                         Pontifícia Universidade Católica");
            Console.WriteLine("Para finalizar a digitação do texto insira o comando '/1' na linha abaixo da ultima digitada");
            FileStream arq = new FileStream("texto.txt", FileMode.Append);
            StreamWriter escreve = new StreamWriter(arq);
            string texto;
            Console.WriteLine("\nDigite um texto:");
            do {
                texto = Console.ReadLine();
                if (texto != "/1") {
                    escreve.WriteLine(texto);
                    }
                } while (texto != "/1");
            escreve.Close();

            FileStream arq1 = new FileStream("texto.txt", FileMode.Open);
            StreamReader ler = new StreamReader(arq1);
            string resultado;
            int contadorlinha = 0;
            do {
                resultado = ler.ReadLine();
                if (resultado != null) {
                    Console.WriteLine(resultado);
                    contadorlinha++;
                    }
                } while (resultado != null);
            Console.ReadKey();
            }
        }
    }
