using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Add meg a Vezetékneved: ");
            string vezeteknev = Console.ReadLine();
            Console.WriteLine(vezeteknev);

            Console.WriteLine();

            Console.ForegroundColor= ConsoleColor.Green;
            Console.Write("Add meg a Keresztneved: ");
            string keresztnev = Console.ReadLine();
            Console.WriteLine(keresztnev);

            Console.WriteLine();

            Console.BackgroundColor= ConsoleColor.Black;
            Console.ForegroundColor= ConsoleColor.White;
            Console.WriteLine(vezeteknev + " " + keresztnev);

            Console.ReadKey();
        }
    }
}
