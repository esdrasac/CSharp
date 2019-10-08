using System;
using System.Collections.Generic;
using System.Text;

namespace IComparador {
    class Comparador:iComparador {
        public int Comparar(int x, int y) {
            if(x == y)
                return 0;
            else if(x < y)
                return -1;
            else
                return 1;
        }
    }
}
