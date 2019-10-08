using System;

namespace Interface {
    class Program {
        static void Main(string[] args) {
            Agenda MinhaAgenda = new Agenda();
            DateTime DataHora1, DataHora2;
            string Data, Hora;
            Console.Write("Data 1: ");
            Data = Console.ReadLine();
            Console.Write("Hora 1: ");
            Hora = Console.ReadLine();

            DataHora1 = MinhaAgenda.InicializaDataHora(Data, Hora);

            Console.Write("\nData 2: ");
            Data = Console.ReadLine();
            Console.Write("Hora 2: ");
            Hora = Console.ReadLine();

            DataHora2 = MinhaAgenda.InicializaDataHora(Data, Hora);

            Console.WriteLine($"\nDiferença entre datas: {MinhaAgenda.SubtraiDatas(DataHora1, DataHora2)} dias e {MinhaAgenda.SubtraiHoras(DataHora1, DataHora2)} Horas!");
            Console.ReadKey();

        }
    }
}
