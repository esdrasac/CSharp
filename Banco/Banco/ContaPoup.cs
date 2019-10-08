using System;
using System.Collections.Generic;
using System.Text;

namespace Banco {
    class ContaPoup : Cliente{
        public int DiaVencimento { get; set; }
        public double Saldo { get; set; }

        public ContaPoup() {
            Saldo = 0;
        }

    }
}
