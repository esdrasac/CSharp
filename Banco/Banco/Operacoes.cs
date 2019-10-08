using System;
using System.Collections.Generic;
using System.Text;

namespace Banco {
    class Operacoes {
        private Dados MeuDado;

        public Operacoes() {
            MeuDado = new Dados();
        }

        private void CadastrarCliente(Cliente cliente) {
            do {
                Console.WriteLine("             Cadastro de Cliente");
                Console.WriteLine("============================================");
                Console.WriteLine($"Código.....: {cliente.Numero}");
                Console.Write("Nome:......: ");
                cliente.NomeTitular = Console.ReadLine();
                Console.WriteLine($"Saldo......: {MeuSaldo(cliente.ContaCorrente)}");

            } while();
        }

        public double MeuSaldo(Cliente x) {
            double saldo;
            if(x.GetType() == typeof(ContaPoup)) {
                saldo = x.ContaPoupanca.Saldo;
            }
            else {
                saldo = x.ContaCorrente.Saldo;
            }
            return saldo;
        }
    }
}
