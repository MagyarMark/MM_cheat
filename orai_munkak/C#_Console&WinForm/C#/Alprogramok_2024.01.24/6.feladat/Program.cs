using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.feladat
{
    internal class Program
    {
        static double szamolafaertek(double vegosszeg, double afaszazalek)
        {
                
            return vegosszeg * afaszazalek;
        }
        static void Main(string[] args)
        {
            Console.Write("végösszeg: ");
            double vegosszeg = Convert.ToDouble(Console.ReadLine());

            Console.Write("Áfa értéke: ");
            double afaszazalek = Convert.ToDouble(Console.ReadLine());

            double afaertek = szamolafaertek(vegosszeg, afaszazalek / 100);
            Console.WriteLine(afaertek);

            Console.ReadKey();
        }
    }
}
