using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eljaras_gyak
{
    internal class Program
    {
        /*
        static void koszontes(string nev) 
        {
            Console.WriteLine($"Szia {nev}!");
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
        */

        /*
        static void tomb_feltoltes(int[] tomb, int mettol, int meddig)
        {
            Random rnd = new Random();
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rnd.Next(mettol, meddig);
            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine("|---------------|");
            Console.WriteLine("|Tömb feltöltése|");
            Console.WriteLine("|---------------|");

            Console.Write("Add meg a tömb elem számát: ");
            int t_elemszam = int.Parse(Console.ReadLine());
            int[] tombb = new int[t_elemszam];
            tomb_feltoltes(tombb, 500, 1200);
            Console.Write(string.Join(System.Environment.NewLine, tombb));



            Console.ReadKey();
        }
        */

        static int EllBekerf(string bekeresuzi, int mettol, int meddig)
        {
            int szam;
            do
            {
                Console.Write(bekeresuzi + mettol + "-" + meddig +" " + "között:");
            } while (!int.TryParse(Console.ReadLine(), out szam) || !(szam > mettol && szam < meddig));
            return szam;
        }

        static void Main(string[] args)
        {

            int a = 0;
            int b = 1000;

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("|-------------------|");
            Console.WriteLine("|Bekérés ellenörzése|");
            Console.WriteLine("|-------------------|");

            string tajekoztato = "Adj meg egy számot: ";

            EllBekerf(tajekoztato,a,b);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(string.Join(System.Environment.NewLine, tajekoztato));



            Console.ReadKey();
        }

    }
}
