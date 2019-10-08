using System;

namespace OperacaoMatematicaPolimorfica {
    class Program {
        static void Main(string[] args) {
            double x, y;
            double Result;
            Console.Write("X = ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Y = ");
            y = double.Parse(Console.ReadLine());

            Result = SetaOperacao(new Soma(), x, y);
            Console.WriteLine($"\nSoma = {Result:F2}");

            Result = SetaOperacao(new Subtracao(), x, y);
            Console.WriteLine($"\nSubtração = {Result:F2}");
            Console.ReadKey();
        }
        static double SetaOperacao(OperacaoMatematica Oper, double x, double y) {
            return Oper.Calcular(x, y);
        }
    }
}
