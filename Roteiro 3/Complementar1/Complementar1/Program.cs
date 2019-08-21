using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complementar1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=1, i2=0, aux = 0, aux2 = 0, masculino = 0, feminino = 0, comxp = 0, semxp = 0, auxpct = 0, auxpct2 = 0, menoridade = 20000;
            double mediaid = 0, mediaidf = 0, contadoridf = 0, contadorid = 0, porcentagemid = 0, porcentagemtotal = 0;

            Console.WriteLine("                   Pontifícia Universidade Católica");
            Console.WriteLine("                           JS Recrutamento");
           
            while (i2 < 1 || i2 > 30)
            {
                Console.Write("Digite a meta diaria de numero de cadastros a serem feitos (max. 30):");
                i2 = int.Parse(Console.ReadLine());
            }
            int i3 = i2 + 1;
            int[] sexo, xp, idade;
            string[] nome;
            idade = new int[i3];
            xp = new int[i3];
            sexo = new int[i3];
            nome = new string[i3];

            for (i = 1; i <= i2; i++)
            {
                Console.Write("Nome do candidato: ");
                nome[i] = Console.ReadLine();
                Console.Write("Idade: ");
                idade[i] = int.Parse(Console.ReadLine());
                Console.Write("Selecione alguns dados do candidato:");
                Console.WriteLine("Sexo:");
                Console.WriteLine("1.Masculino");
                Console.WriteLine("2.Feminino");
                aux = int.Parse(Console.ReadLine());
                switch (aux)
                {
                    case 1:
                        sexo[i] = 1; // 1 = Masculino
                        masculino++;
                        break;
                    case 2:
                        sexo[i] = 2; // 2 = Feminino
                        feminino++;
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                Console.WriteLine("Possui experiencia? ");
                Console.WriteLine("1.Sim");
                Console.WriteLine("2.Não");
                aux2 = int.Parse(Console.ReadLine());
                switch (aux2)
                {
                    case 1:
                        xp[i] = 1; // Com experiência
                        comxp++;
                        break;
                    case 2:
                        xp[i] = 2; // Sem experiência
                        semxp++;
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
            i = 1;
            for (i = 1; i <= i2; i++)
            {
               
                if (sexo[i] == 1)
                {
                    mediaid += idade[i];
                    contadorid++;
                    if (idade[i] >= 35 && idade[i] <= 45)
                    {
                        auxpct++;
                    }
                }
                if (sexo[i] == 2)
                {
                    contadoridf += 1;
                    if (xp[i] == 1)
                    {
                        mediaidf += idade[i];
                    }
                    if (idade[i] < menoridade)
                    {
                        menoridade = idade[i];
                    }
                }
                if (xp[i] == 1)
                {
                    auxpct2++;
                }
                

            }
            Console.WriteLine(auxpct2);
            
            mediaid = mediaid / contadorid;
            
            mediaidf = mediaidf / contadoridf;
            porcentagemid = (100 * auxpct) / contadorid;
            porcentagemtotal = (100 * auxpct2) / 30;

            Console.WriteLine("             Relatório diário");
            Console.WriteLine($"\nCandidatos do sexo feminino: {feminino}");
            Console.WriteLine($"Candidatos do sexo masculino: {masculino}");
            Console.WriteLine($"A média da idade dos homens é: {mediaid}");
            Console.WriteLine($"A média da idade das mulheres com experiência é: {mediaidf}");
            Console.WriteLine($"A menor idade entre as mulheres é: {menoridade}");
            Console.WriteLine($"A porcentagem dos homens entre 35 e 45 anos entre o total dos homens é: {porcentagemid}");
            Console.WriteLine($"A porcentagem total (homens e mulheres) com experiência no serviço é: {porcentagemtotal}");

            Console.ReadKey();
        }
    }
}
