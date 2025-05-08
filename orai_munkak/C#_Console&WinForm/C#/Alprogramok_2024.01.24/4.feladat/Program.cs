using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.feladat
{
    internal class Program
    {
        static void tobbszoros()
        {
            Console.Write("Add meg a többszöröst: ");

            double szam = Convert.ToDouble(Console.ReadLine());
            double tizes = (szam * 10);
            double szazas = (szam * 100);
            double ezres = (szam * 1000);
            Console.WriteLine($"A többszörös szorzatának eredménye: {szam}*10 = {tizes} ");
            Console.WriteLine($"A többszörös szorzatának eredménye: {szam}*100 = {szazas} ");
            Console.WriteLine($"A többszörös szorzatának eredménye: {szam}*1000 = {ezres} ");
        }
        static void Main(string[] args)
        {

            tobbszoros();

            Console.ReadKey();
        }
    }
}
