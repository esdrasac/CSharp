using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("\t\t\tPontifícia Universidade Católica");
            int aux = 0;
            Console.WriteLine(" > Escolha uma opção:");
            Console.WriteLine("1. Cadastrar Cliente");
            Console.WriteLine("2. Pesquisar Cliente");
            Console.WriteLine("3. Sair");
            aux = int.Parse(Console.ReadLine());
            switch (aux) {
                case 1:
                    Cadastro.CadastroCliente();
                    break;
                case 2:
                    Cadastro.PesquisaCliente();
                    break;
                case 3:
                    
                    break;
                default:
                    Console.WriteLine("\n         Opção inválida");
                    break;
                }
            }
        }
    }
