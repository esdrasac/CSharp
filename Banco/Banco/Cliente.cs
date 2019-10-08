using System;
using System.Collections.Generic;
using System.Text;

namespace Banco {
    class Cliente {
        public string Numero { get; set; }
        public string NomeTitular { get; set; }

        public ContaMov ContaCorrente;
        public ContaPoup ContaPoupanca;

        public Cliente() {
            ContaCorrente = new ContaMov();
            ContaPoupanca = new ContaPoup();
            Numero = Guid.NewGuid().ToString().Substring(9, 4).ToUpper();

        }
    }
}
