using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halmaz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("|------|");
            Console.WriteLine("|Halmaz|");
            Console.WriteLine("|------|");
            /*
            HashSet<int> halmaz = new HashSet<int>() { 17, 10, 20, 43 };
            Console.WriteLine("Hozzáadás előtt: " + halmaz.Count);
            halmaz.Add(17);
            halmaz.Add(60);
            Console.WriteLine("Hozzáadás után: " + halmaz.Count);
            */

            HashSet<string> nevek = new HashSet<string>() { "nev1", "nev2", "nev3", "nev4" };
            Console.Write("Add meg a nevedet: ");
            string uj_nev =Console.ReadLine();
            foreach (string nev in nevek)
            {
                Console.WriteLine(" - " + nev);
            }
            while(nevek.Contains(uj_nev))
            {
                Console.WriteLine($"A {uj_nev} már szerepel a nevek között");
                Console.Write("Add meg a nevedet: ");
                uj_nev=Console.ReadLine();
            }
            nevek.Add(uj_nev);

            Console.WriteLine("----------------------");

            Random r = new Random();
            HashSet<int> lottószámok = new HashSet<int>();
            while (lottószámok.Count < 5)
            {
                lottószámok.Add(r.Next(0, 91));
            }
            Console.WriteLine("A sorsolt lottószámok: ");
            foreach (int item in lottószámok)
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine();
            HashSet<int> unio = new HashSet<int>() { 10, 32, 4, 8 };
            HashSet<int> halmaz1 = new HashSet<int>() { 20, 32, 12, 4 };
            unio.UnionWith(halmaz1);
            Console.WriteLine("----------------------");
            Console.Write("Unió: ");
            foreach (int u in unio)
            {
                Console.Write(u + "\t");
            }
                
            foreach (int h in halmaz1)
            {
                Console.Write(h + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("----------------------");

            HashSet<int> alaphalmaz = new HashSet<int>() { 10, 32, 4, 8 };
            HashSet<int> halmazz1 = new HashSet<int>() { 20, 32, 12, 4 };
            alaphalmaz.SymmetricExceptWith(halmazz1);
            Console.Write("Halmazok metszetén kívüli elemek: ");
            foreach (int v in alaphalmaz)
            { 
                Console.Write(v + "\t");
            }

            Console.WriteLine();
            Console.WriteLine("----------------------");

            HashSet<int> alaphalmaza = new HashSet<int>() { 10, 32, 4, 8 };
            HashSet<int> halmaz11 = new HashSet<int>() { 20, 32, 12, 4 };
            alaphalmaza.ExceptWith(halmaz11);            Console.Write("megmaradt érték: ");
            foreach(int k in alaphalmaza)
            {
                Console.Write(k + "\t");
            }

            Console.WriteLine();
            Console.WriteLine("---------------------");

            HashSet<int> alaphalmaaz = new HashSet<int>() { 10, 32, 4, 8 };
            HashSet<int> halmaaz1 = new HashSet<int>() { 20, 32, 12, 4 };
            alaphalmaaz.IntersectWith(halmaaz1);            Console.Write("Csak a közös elemek: ");

            foreach (int q in alaphalmaaz)
            {
                Console.Write(q + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("---------------------");

            Console.ReadKey();
        }
    }
}
