using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao1
{
    class Program
    {
        static void Main(string[] args)
        {

            //O programa pede uma quantidade de numeros q eu quero digitar, em seguida eu digito os valores, 
            //o programa soma os numeros e retorna para o usuário



            int num, N, i = 0, soma = 0; 
            Console.WriteLine("Quantos numeros deseja digitar: ");
            N = int.Parse(Console.ReadLine()); 
            while (i < N)
            {
                Console.WriteLine("\n Entre um valor inteiro: "); 
                num = int.Parse(Console.ReadLine());
                soma = soma + num;
                i++;
            }
            Console.Write("\n Foram digitados " + i + " numeros");
            Console.Write("\n A soma dos numeros digitados e: " + soma);
            Console.ReadKey();
        }
    }
}
