using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoComReturn
{
    internal class Program
    {
        static int MetodoTop(int x, int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(MetodoTop(5, 2));
            Console.ReadKey();
        }
    }
}
