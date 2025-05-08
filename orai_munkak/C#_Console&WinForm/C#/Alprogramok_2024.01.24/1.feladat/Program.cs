using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.feladat
{
    internal class Program
    {
        static void koszontes(string nev)
            {
                Console.WriteLine(nev);
            }
        static void Main(string[] args)
        {
            
            Console.WriteLine("|---------|");
            Console.WriteLine("|Köszöntés|");
            Console.WriteLine("|---------|");

            Console.Write("írd ide a neved: ");
            string nev = Console.ReadLine();
            koszontes(nev);
            Console.ReadKey();
        }
    }
}
