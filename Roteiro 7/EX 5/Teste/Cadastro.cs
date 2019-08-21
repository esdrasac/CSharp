using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste {
    class Cadastro {

        public string Nome;
        public string Endereco;
        public long Cpf;
        public int Telefone;
        
        public Cadastro(string nome, string endereco, long cpf, int telefone) {
            Nome = nome;
            Endereco = endereco;
            Cpf = cpf;
            Telefone = telefone;
            }

        public static string nome { get; private set; }
        public static string endereco { get; private set; }
        public static long cpf { get; private set; }
        public static int telefone { get; private set; }

        public static void CadastroCliente() {
            FileStream arq = new FileStream("cadastro.txt", FileMode.OpenOrCreate);
            StreamWriter escreve = new StreamWriter(arq);
            Cadastro cad = new Cadastro(nome, endereco, cpf, telefone);
            Console.WriteLine("\n             Cadastro - Novo Cliente");
            Console.Write("\nNome: ");
            nome = Console.ReadLine();
            Console.Write("CPF: ");
            cpf = long.Parse(Console.ReadLine());
            Console.Write("Endereço: ");
            endereco = Console.ReadLine();
            Console.Write("Telefone: ");
            telefone = int.Parse(Console.ReadLine());
            
            escreve.WriteLine("* Nome :" + nome + "," + "* CPF: " + cpf + "," + "* Endereço: " + endereco + "," + "* Telefone: " + telefone + ",");
            
            escreve.WriteLine("-------------------------------------------------------------------\n");
            escreve.Close();

            }
        public static void PesquisaCliente() {
            FileStream arq1 = new FileStream("cadastro.txt", FileMode.Open);
            StreamReader ler = new StreamReader(arq1);
            string linha;
            string[] texto;
            Console.WriteLine("\n             Pesquisa - Cliente");
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            do {
                linha = ler.ReadLine();
                if (linha != null) {
                    if (linha.Contains(nome)) {
                        texto = linha.Split(',');
                       
                        Console.WriteLine(texto[0]);
                        Console.WriteLine(texto[1]);
                        Console.WriteLine(texto[2]);
                        Console.WriteLine(texto[3]);
                        }
                    }
                } while (linha != null);
                
                
                }
            }
        }
    
