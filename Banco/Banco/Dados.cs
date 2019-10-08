using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Banco {
    class Dados {
        public ArrayList MeusClientes;


        public Dados() {
            MeusClientes = new ArrayList();
        }

        public void InserirDados(Cliente x) {
            MeusClientes.Add(x);
        }
    }
}
