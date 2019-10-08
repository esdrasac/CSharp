using System;
using System.Collections.Generic;
using System.Text;

namespace IComparador {
    class Vetor {
        public int[] V { get; set; }
        public Vetor() {
            V = new int[10];
            Random x = new Random();
            for(int i = 0; i < 10; i++) {
                V[i] = x.Next(0, 50);
            }
        }

        public void Mostra() {
            Console.Clear();
            foreach(int x in V) {
                Console.Write($"{x,5}");
            }
        }

        public void Ordena(Comparador comp) {
            int troca = 1;
            int i = 1;
            int aux;
            while(i <= 10 && troca == 1) {
                troca = 0;
                for(int j = 0; j < 10 - 2; j++) {
                    if(comp.Comparar(V[j], V[j + 1]) == 1) {
                        troca = 1;
                        aux = V[j];
                        V[j] = V[j + 1];
                        V[j + 1] = aux;
                    }
                }
                i++;
            }
        }

        public int BuscaBinaria(Comparador comp, int num) {
            bool Achou = false;
            int inicio = 0;
            int fim = 9;
            int Meio = (inicio + fim) / 2;
            while(inicio <= fim && !Achou) {
                if(V[Meio] == num)
                    Achou = true;
                else {
                    if(comp.Comparar(num, V[Meio]) == -1)
                    fim = Meio - 1;
                    else
                        inicio = Meio + 1;
                    Meio = (inicio + fim) / 2;
                }
            }
            if(!Achou)
                return -1;
            else
                return Meio + 1;
        }
    }
}
