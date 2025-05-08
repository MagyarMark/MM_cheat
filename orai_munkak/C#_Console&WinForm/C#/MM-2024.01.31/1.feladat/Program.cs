using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.feladat
{
    internal class Program
    {
        static int szoveghossz(string szoveg)
        {
            return szoveg.Length;
        }
        static void Main(string[] args)
        {
            string szo = "C#";

            int hossz = szoveghossz(szo);
            Console.WriteLine("A szöveg: " + szo  + " hossza: "  + hossz);

            Console.ReadKey();
        }
    }
}
