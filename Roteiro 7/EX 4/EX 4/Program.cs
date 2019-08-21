using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EX_4 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("\t\t\tPontifícia Universidade Católica");
            FileStream arq = new FileStream("letras.txt", FileMode.Create);
            StreamWriter escreve = new StreamWriter(arq);
            string letras, texto;
            int vogal_a = 0, vogal_e = 0, vogal_i = 0, vogal_o = 0, vogal_u = 0;
            Console.WriteLine("\nDigite um texto (100 letras): ");
            letras = Console.ReadLine();
            escreve.WriteLine(letras);
            escreve.Close();

            FileStream arq1 = new FileStream("letras.txt", FileMode.Open);
            StreamReader ler = new StreamReader(arq1);
            texto = ler.ReadToEnd();
            for (int i = 0; i < 100; i++) {
                if (texto[i] == 'a' || texto[i] == 'A') {
                    vogal_a++;
                    }
                if (texto[i] == 'e' || texto[i] == 'E') {
                    vogal_e++;
                    }
                if (texto[i] == 'i' || texto[i] == 'I') {
                    vogal_i++;
                    }
                if (texto[i] == 'o' || texto[i] == 'O') {
                    vogal_o++;
                    }
                if (texto[i] == 'u' || texto[i] == 'U') {
                    vogal_u++;
                    }
                }
            Console.WriteLine($"\nA quantidade de vogais 'a' é: {vogal_a}");
            Console.WriteLine($"A quantidade de vogais 'e' é: {vogal_e}");
            Console.WriteLine($"A quantidade de vogais 'i' é: {vogal_i}");
            Console.WriteLine($"A quantidade de vogais 'o' é: {vogal_o}");
            Console.WriteLine($"A quantidade de vogais 'u' é: {vogal_u}");
            Console.ReadKey();
            }
        }
    }
