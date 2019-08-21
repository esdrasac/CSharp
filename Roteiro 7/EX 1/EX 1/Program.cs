using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_1 {
    class Program {
        static void Main(string[] args) {
            FileStream arq = new FileStream("teste.txt", FileMode.Create); //Abertura de um arquivo (criação)
            StreamWriter escreve = new StreamWriter(arq); // instanciamento de arquivo
            string nome, linha, endereco; // declaração de variáveis
            for (int i = 0; i < 5; i++) {  // estrutura de repetição para entrada de dados
                Console.Write("Digite seu nome:");
                nome = Console.ReadLine(); // variável recebe o nome digitado pelo usuário
                Console.Write("Digite seu endereço:");
                endereco = Console.ReadLine(); // variável recebe o endereço digitado pelo usuário
                escreve.WriteLine("Nome: " + nome + "," + "Endereço: " + endereco + ","); // arquivo recebe os valores das variáveis
                }
            escreve.Close(); // fechamento de arquivo
            FileStream arq1 = new FileStream("teste.txt", FileMode.Open); // Abertura de um arquivo (leitura)
            StreamReader ler = new StreamReader(arq1); // instanciamento de arquivo
            string[] resultado; // declaração de um vetor
            do {                                        // estrutura do while que faz a leitura e mostra na tela os dados coletados na estrutura anterior
                linha = ler.ReadLine();
                if (linha != null) {
                    resultado = linha.Split(',');
                    Console.WriteLine(resultado[0]);
                    Console.WriteLine(resultado[1]);
                    }
                } while (linha != null);
            Console.ReadKey();
            }
        }
    }
