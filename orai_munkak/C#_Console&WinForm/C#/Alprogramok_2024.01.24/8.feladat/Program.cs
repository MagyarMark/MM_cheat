using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.feladat
{
    internal class Program
    {
        static string osszefuzott(string resz1, string resz2, string resz3)
        {
            return $"{resz1}#{resz2}#{resz3}";
        }
        static void Main(string[] args)
        {
            Console.Write("első szöveg: ");
            string resz1 = Console.ReadLine();

            Console.Write("második szöveg: ");
            string resz2 = Console.ReadLine();

            Console.Write("harmadik szöveg: ");
            string resz3 = Console.ReadLine();

            string eredmeny = osszefuzott(resz1, resz2, resz3);

            Console.WriteLine(eredmeny);

            Console.ReadKey();
        }
    }
}
