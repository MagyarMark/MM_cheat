using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.feladat
{
    internal class Program
    {
        static int Szamoleletkor(int szuletesiev)
        {
            int aktualisev = DateTime.Now.Year;
            return aktualisev - szuletesiev;
        }
        static void Main(string[] args)
        {
            Console.Write("szuletesi evszam: ");
            int szuletesiev = Convert.ToInt32(Console.ReadLine());

            int eletkor = Szamoleletkor(szuletesiev);
            Console.WriteLine($"{eletkor} éves.");

            

            Console.ReadKey();
        }
    }
}
