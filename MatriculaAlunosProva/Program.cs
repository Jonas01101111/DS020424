using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
/*Faça um programa para matricular alunos nos seguintes cursos. 
(D)esenvolvimento, (A)dministração, (M)ecatrônicae (E)dificações. Informando a opção do curso desejada. 
Cada curso terá 5 vagas, a cada solicitação de matrícula verificar se existe vagas disponíveis,
quando o usuário encerrar a matrícula exibir uma mensagem com o total de matrículas de cada curso.
 */
namespace MatriculaAlunosProva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contD = 0, contA = 0, contM = 0, contE = 0;
            string curso="0", check="S";

            while (check=="S") 
            {
                Console.WriteLine("Deseja realizar matrícula para qual curso.D = DesSist. A = Adm. M = Meca. E = Edf");
                curso = Console.ReadLine();
                curso = curso.ToUpper();


                switch (curso)
                {
                    case "D":
                        if (contD < 5)
                        {
                            contD++;
                            Console.WriteLine("Matircula em Desenvolvimento de Sistemas realizada!");
                        }
                        else
                        {
                            Console.WriteLine("Curso Lotado");
                        }
                        break;
                    case "A":
                        if (contA < 5)
                        {
                            contA++;
                            Console.WriteLine("Matircula em Administração realizada");
                        }
                        else
                        {
                            Console.WriteLine("Curso Lotado");
                        }
                        break;
                    case "M":
                        if (contM < 5)
                        {
                            contM++;
                            Console.WriteLine("Matircula em Mecatronica realizada");
                        }
                        else
                        {
                            Console.WriteLine("Curso Lotado");
                        }
                        break;
                    case "E":
                        if (contE < 5)
                        {
                            contE++;
                            Console.WriteLine("Matircula em Edificações realizada");
                        }
                        else
                        {
                            Console.WriteLine("Curso Lotado");
                        }
                        break;
                    default:
                        Console.WriteLine("Curso Inválido \n Adote o formato:\n D = DesSist. A = Adm. M = Meca. E = Edf");
                        break;
                }
                Console.WriteLine("Deseja Continuar? S ou N?");
                check= Console.ReadLine();
                check = check.ToUpper();
                Console.Clear();
            }
            Console.WriteLine("--Matriculas--\n"+"DS:"+contD+"\nADM:"+contA+"\nMECA"+contM+"\nEDF"+contE);
            Console.ReadKey();

        }
    }
}
