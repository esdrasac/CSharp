using System;

namespace IComparador {
    class Program {
        static void Main(string[] args) {
            int num;
            int pos;
            Vetor MeuVetor = new Vetor();
            MeuVetor.Mostra();
            MeuVetor.Ordena(new Comparador());
            MeuVetor.Mostra();

            Console.Write("\n\nProcurar número: ");
            num = int.Parse(Console.ReadLine());
            pos = MeuVetor.BuscaBinaria(new Comparador(), num);
            if(pos < 0)
                Console.WriteLine("\nElemento não encontrado");
            else
                Console.WriteLine($"\nElemento encontrado na posição: {pos}");

        }
    }
}
