using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_Zaroprojekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t|----------------|");
            Console.WriteLine("\t\t\t\t Napló alkalmazás ");
            Console.WriteLine("\t\t\t\t|----------------|");

            Console.WriteLine("feladat: ");
            Console.WriteLine("Készíts egy napló alkalmazást, amely lehetővé teszi a felhasználók számára, hogy rögzítsék a gondolataikat, érzéseiket és eseményeiket. Használhatsz osztályokat a bejegyzések kezeléséhez.\r\n");

            List<string> list = new List<string>();
            Console.Write("Add meg a neved: ");
            var nev = Console.ReadLine();



            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Szia " + nev);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            int choice;
            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Mit szeretnél rögzíteni?");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("1. - Gondolat");
                Console.WriteLine("2. - Érzés");
                Console.WriteLine("3. - Esemény");
                Console.WriteLine("4. - Ki íratás");
                Console.WriteLine("0 - Kilépés a programból");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Választott opció: ");
                Console.ForegroundColor = ConsoleColor.White;

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Érvénytelen választás. Kérem, válasszon újra.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("írd ide a gondolatodat: ");
                        string gondolat = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Megőrzöm!");
                        list.Add(gondolat);
                        break;

                    case 2:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("írd ide az érzésed: ");
                        string erzes = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Megőrzöm!");
                        list.Add(erzes);
                        break;
                    case 3:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("írd ide az Eseményed: ");
                        string esemeny = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Megőrzöm!");
                        list.Add(esemeny);
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("Ki íratva txt állományban!");
                        StreamWriter lista = new StreamWriter("lista.txt", append: true);
                        
                        lista.WriteLine(nev + " Gondolata: " + list[0]);
                        lista.WriteLine(nev + " Érzése: "    + list[1]);
                        lista.WriteLine(nev + " Eseménye: "  + list[2]);
                        lista.WriteLine(" ");

                        //Megszámlálás tétele: 
                        string[] l = { list[0], list[1], list[2] };
                        var n = l;
                        var c = 0;
                        for (int i = 0; i < n.Length; i++)
                        {
                            if (l[i] == n[i]) { c++; }
                        }
                        Console.WriteLine("Listában lévő adatok száma: {0}", c);

                        lista.Close();

                        break;

                    case 0:
                        Console.Clear();
                        Console.WriteLine("Köszi, hogy megosztottad velem!");
                        Console.WriteLine("Kilépés a programból...");
                        break;

                    default:
                        Console.WriteLine("Ez a választás nem jött össze!");
                        break;
                }
                Console.WriteLine();
            } while (choice != 0);

            Console.ReadKey();
        }
    }
}
