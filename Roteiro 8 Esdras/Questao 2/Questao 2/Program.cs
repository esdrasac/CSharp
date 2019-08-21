using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                     Pontifícia Universidade Católica");
            double nota;
            String nome;
            Console.Write("\nDigite o nome: ");
            nome = Console.ReadLine();
            Console.Write("\nDigite a nota: ");
            nota = double.Parse(Console.ReadLine());
            Console.WriteLine($"\nO aluno {nome} teve nota {nota} e conteito {Conceito(nota)}");
            Console.ReadKey();



        }
        static String Conceito(double nota) {
            String saida = "";
            if (nota >= 90) saida = "A";
            else if (nota >= 80 && nota < 90) saida = "B";
            else if (nota >= 70 && nota < 80) saida = "C";
            else if (nota >= 60 && nota < 70) saida = "D";
            else if (nota < 60) saida = "E";
            return saida;



        }
    }
}
