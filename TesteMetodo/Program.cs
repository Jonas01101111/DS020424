using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteMetodo // fiz isso só pra passar o tempo
{
    internal class Program
    {
        static void MaiorCem(int numero) //isso aqui é um método; numero é um parametro dele; se eu chamar ele, ele executa o codigo!!
        {
            if (numero > 100)
            {
                Console.WriteLine("Número maior que 100!!!");
            }
            else
            {
                Console.WriteLine("Número menor que 100 :(");
            }
        }


        static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("Digite um número!!!!!!");
            num = int.Parse(Console.ReadLine());

            MaiorCem(num);//num usado como parametro pro metodo maior cem é chamado de argumento!

            Console.ReadKey();
        }
    }
}
