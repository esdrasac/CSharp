using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, nota4, media;
            nota1 = 1;
            Console.WriteLine("            Pontifícia Universidade Católica ");
            Console.WriteLine("\n Para saber o resultado final digite suas notas a seguir");
            Console.Write("\n     > Nota 1: ");
                 if (nota1>10)
                    {
                Console.WriteLine("\nSua nota não pode ser maior que 10. Por favor digite uma nota válida"); 
                    }
                 else
                     nota1 = double.Parse(Console.ReadLine());
            Console.Write("     > Nota 2: ");
            nota2 = double.Parse(Console.ReadLine());
            Console.Write("     > Nota 3: ");
            nota3 = double.Parse(Console.ReadLine());
            Console.Write("     > Nota 4: ");
            nota4 = double.Parse(Console.ReadLine());
            media = (nota1 + nota2 + nota3 + nota4) / 4;
                 if (media >= 7)
                       {

                            Console.WriteLine("\nParabéns você foi aprovado nesse semestre com nota " + media);
                       }
                 else
                            Console.WriteLine("\nQue pena, você não atingiu a média necessaria para aprovação, sua nota foi: " + media);
            Console.ReadKey();
            }   

    }
}
