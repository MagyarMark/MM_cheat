using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_jarmu
{
    

    internal class Program
    {
        class Jármű
    {
        public Jármű(int seb)
        {
            sebesség = seb;
        }
        public int sebesség;
        public int Megy(double idő)
        {
                return Convert.ToInt32(Math.Round(idő * sebesség));
        }

    }
    class Autó : Jármű
    {
        public Autó(int seb, int ajtóksz, int cst) : base(seb)
        {
            ajtókSzáma = ajtóksz; Csomagtér = cst;
        }
        public int ajtókSzáma;
        public int Csomagtér;

    }
        static void JárműKiír(Jármű j, double idő)
        {
            Console.WriteLine($"A jármű sebessége: {j.sebesség}");
            Console.WriteLine($"A megtett távolság: {j.Megy(idő)}km");
        }
        static void JárműKiír_1(Jármű j, int h)
        {
            Console.WriteLine(j.sebesség);
            Console.WriteLine(j.Megy(h));
            if (j is Autó)
            {
                Autó a = (Autó)j;
                Console.WriteLine(a.ajtókSzáma);
                Console.WriteLine(a.Csomagtér);
            }
        }
        static void JárműKiír_2(Jármű j, int h)
        {
            Console.WriteLine(j.sebesség);
            Console.WriteLine(j.Megy(h));
            Autó a = j as Autó;
            if (a != null)
            {
                Console.WriteLine(a.ajtókSzáma);
                Console.WriteLine(a.Csomagtér);
            }
        }
        static void Main(string[] args)
        {
            Random random = new Random();

            //Jármű j = new Jármű(30);
            Jármű j = new Jármű(random.Next(1,250));
            Console.Write("add meg more(út idő): ");
            double idő = Convert.ToDouble(Console.ReadLine());
            JárműKiír(j, 10);

            Console.WriteLine();

            //Autó a = new Autó(120, 5, 20);
            //nincs szintaktikai hiba, hiába Jármű példányt vár az eljárás:
            //JárműKiír(a, 10);

            Console.ReadKey();
        }
    }
}
