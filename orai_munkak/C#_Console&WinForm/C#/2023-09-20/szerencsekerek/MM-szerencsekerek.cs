using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Szerencsekerek
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        ///[STAThread]
        static void Main()
        {
            // Alaptét kerekítése ezerre
            Random random = new Random();
            int p1bal = random.Next(10000, 501000) / 1000 * 1000;
            int p2bal = random.Next(10000, 501000) / 1000 * 1000;

            Console.WriteLine($"Játékos 1 = {p1bal} | Játékos 2 = {p2bal}");

            for (int porgetes = 1; porgetes <= 3; porgetes++)
            {
                Console.WriteLine($"Pörgetés {porgetes}:");

                // alaptét kerekítése ezerre
                int p1tet = random.Next(1000, 20001) / 1000 * 1000;
                int p2tet = random.Next(1000, 20001) / 1000 * 1000;

                // véletlenszerűen nyer vagy veszít
                int p1gyoz = random.Next(2) == 0 ? p1tet : -p1tet;
                int p2gyoz = random.Next(2) == 0 ? p2tet : -p2tet;

                p1bal += p1gyoz;
                p2bal += p2gyoz;

                Console.WriteLine($"1. játékos téte: {p1tet}");
                Console.WriteLine($"2. játkos téte: {p2tet}");
                Console.WriteLine($"1. játékos nyereménye: {p1gyoz}");
                Console.WriteLine($"2. játékos nyereménye: {p2gyoz}");
                Console.WriteLine($"1. játékos össztéte: {p1bal}");
                Console.WriteLine($"2. játékos össztéte: {p2bal}");
            }

            Console.WriteLine("A játék véget ért!");
            Console.WriteLine($"Eredmény: 1. játékos pénze: {p1bal}");
            Console.WriteLine($"2.játékos pénze: {p2bal}");
            if (p1bal > p2bal)
            {
                Console.WriteLine("játékos 1 nyert");
            }
            else if (p1bal < p2bal)
            {
                Console.WriteLine("játékos 2 nyert");
            }
            else
            {
                Console.WriteLine("döntetlen");
            }
        }
    }
}