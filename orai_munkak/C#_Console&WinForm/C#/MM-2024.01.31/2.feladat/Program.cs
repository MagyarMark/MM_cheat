using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.feladat
{
    internal class Program
    {
        static int szamjegyekosszege(int szam)
        {
            szam = Math.Abs(szam);

            int osszeg = 0;

            while(osszeg > 0)
            {
                osszeg += szam % 10;

                szam /= 10;
            }
            return osszeg;
        }
        static void Main(string[] args)
        {
            int szam = 123;

            int osszeg = szamjegyekosszege(szam);
            Console.WriteLine(osszeg);

            Console.ReadKey();
        }
    }
}
