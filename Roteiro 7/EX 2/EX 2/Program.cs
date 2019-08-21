using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_2 {
    class Program {
        static void Main(string[] args) {
            FileStream arq = new FileStream("teste2.txt", FileMode.Create); //Abertura de arquivo (criação)
            StreamWriter escreve = new StreamWriter(arq); // Implementação
            string frase, tudo; // Declaração de variáveis tipo string
            int i = 0, contA = 0, contO = 0; // Declaração de variáveis tipo int
            Console.Write("Digite uma frase:");
            frase = Console.ReadLine(); // atribuição valor digitado pelo usuário
            escreve.WriteLine(frase); // arquivo é atribuído com valor de variável
            escreve.Close(); // fechamento de arquivo
            FileStream arq1 = new FileStream("teste2.txt", FileMode.Open); // Abertura de arquivo ( leitura)
            StreamReader ler = new StreamReader(arq1); // Implementação
            tudo = ler.ReadToEnd(); // Variável é atribuida com valor contido no arquivo
            Console.WriteLine("Tudo que foi escrito no arquivo: " + tudo); // retorno de variável
            for (i = 0; i < tudo.Length; i++) { // Estrutura  de repetição para contar quantidade de determinados caracteres
                if (tudo[i] == 'a') {
                    contA++;
                    }
                if (tudo[i] == 'o') {
                    contO++;
                    }
                }
            Console.WriteLine("A quantidade de letra a é:" + contA); // Retorno de variável
            Console.WriteLine("A quantidade de letra o é:" + contO); // Retorno de variável
            Console.ReadKey();
            }
        }
    }
