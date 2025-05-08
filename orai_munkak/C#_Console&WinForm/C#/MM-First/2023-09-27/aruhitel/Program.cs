using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aruhitel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // MM- 2023-09-27
            //aruhitel

            Console.WriteLine("aruhitel");
            Console.WriteLine("--------");

            Console.Write("Adja meg a termék árát: ");
            int termek_ar = int.Parse(Console.ReadLine());

            Console.Write("Adja meg a számlája fedezetét: ");
            int szamla_fedezet = int.Parse(Console.ReadLine());

            if (szamla_fedezet >= termek_ar) 
            {
                Console.WriteLine("Sikeres vásárlás");
            }
            else
            {
                Console.Write("Van hitel kártyája? [Van/Nincs]: ");
                string hitelkartya_van = Console.ReadLine();
                if (hitelkartya_van == "Van" || hitelkartya_van == "van") 
                {
                    Console.WriteLine("Sikeres vásárlás");
                }
                else 
                {
                    Console.WriteLine("Nincs fedezet a hitelkártyán");
                }
            }

            Console.ReadKey();
        }
    }
}
