using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_halmaz_gyak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("|----------------|");
            Console.WriteLine("|Halmaz gyakorlás|");
            Console.WriteLine("|----------------|");

            HashSet<string> kavek = new HashSet<string>() { "Omnia", "Paloma", "Jacob" };
            Console.Write("Add meg a kávé nevét: ");
            string kave1 = Console.ReadLine();
            kavek.Add(kave1);
            Console.Write("Add meg a kávé nevét: ");
            string kave2 = Console.ReadLine();
            kavek.Add(kave2);
            foreach (string kavee in kavek)
            {
                Console.WriteLine(" - " + kavee);
            }

            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine();

            List<string> halak = new List<string>() { "ponty", "keszeg", "csuka", "harcsa","süllő","kárász","angolna","márna","fogasponty","sügér","amur","menyhal","domolykó","keszeg","garda","paduc","compó","bodorka","nyúldomolykó" }; 

            Random rand = new Random();
            HashSet<string> kivalasztotthalak = new HashSet<string>();
            while(kivalasztotthalak.Count < 4)
            {
                int i = rand.Next(halak.Count);
                kivalasztotthalak.Add(halak[i]);
            }
            Console.Write("A kiválasztott halak: ");

            foreach (string hal in kivalasztotthalak) 
            {
                Console.Write(hal+ " ");
            }

            Console.ReadKey();
        }
    }
}
