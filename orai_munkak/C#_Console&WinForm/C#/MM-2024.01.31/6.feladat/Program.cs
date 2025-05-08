using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.feladat
{
    internal class Program
    {
        static int karakterszamlalo(string szoveg)
        {
            return szoveg.Length;
        }
        static void Main(string[] args)
        {
            string be = "Szia te";

            int karakterszam = karakterszamlalo(be);
            Console.WriteLine("A szöveg: " + be + " karakterszáma: " + karakterszam);

            Console.ReadKey();
        }
    }
}
