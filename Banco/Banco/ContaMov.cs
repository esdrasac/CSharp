using System;
using System.Collections.Generic;
using System.Text;

namespace Banco {
    class ContaMov: Cliente {
        
        public double Saldo { get; set; }

        public ContaMov() {
            Saldo = 0;
        }

        public void Sacar(double x) {
            if(Saldo < x) {
                return;
            }
            else {
                this.Saldo -= x;
            }
        }

        public void Depositar(double x) {
            this.Saldo += x;
        }

        public double MeuSaldo() {
            return Saldo;
        }
    }
}
