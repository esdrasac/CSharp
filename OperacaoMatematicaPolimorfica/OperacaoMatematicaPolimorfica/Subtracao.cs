using System;
using System.Collections.Generic;
using System.Text;

namespace OperacaoMatematicaPolimorfica {
    public class Subtracao:OperacaoMatematica {
        public override double Calcular(double x, double y) {
            return x - y;
        }
    }
}
