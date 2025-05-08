using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.feladat
{
    internal class Program
    {
        static int osszeadas(int szam1, int szam2)
        {
            return szam1 + szam2;
        }
        static void Main(string[] args)
        {
            int eredmeny = osszeadas(5, 7);
            Console.WriteLine("az összeg: " + eredmeny);

            Console.ReadKey();
        }
    }
}
