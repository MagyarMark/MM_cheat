using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace muvelt_es_szep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("|------------------|");
            Console.WriteLine("|Műveltek és szépek|");
            Console.WriteLine("|------------------|");

            HashSet<string> muveltt = new HashSet<string>() { "Szikla Szilárd", "Citad Ella", "Malt Ernő", "Dőri Dóra", "Parady Csoma", "Illemta Nóra", "Bakt Ernő", "Kor Mihály", "Emanci Pál", "Lapos Elemér", "Patta Nóra" };
            HashSet<string> szepp = new HashSet<string>() { "Dőri Dóra", "Bakt Ernő", "Parady Csoma", "Citad Ella", "Illemta Nóra", "Szikla Szilárd", "Bekre Pál", "Ka Pál", "Kor Mihály", "Mángor Olga", "Emanci Pál", "Patkóm Ágnes", "Veg Eta" };
            muveltt.IntersectWith(szepp);
            Console.WriteLine("1.feladat: ");
            foreach (string u in muveltt)
            {
                Console.Write(u + ", " +"\n");
            }

            foreach (string a in szepp)
            {
                Console.Write(a + ", " + "\n");
            }
            muveltt.Clear();
            szepp.Clear();

            Console.WriteLine("\n");
            Console.WriteLine("2.feladat: ");
            Console.WriteLine("txt állományban");

            

            string muveltek = "muvelt.txt";
            string szepek = "szep.txt";
            string ki = "batrak.txt";
            string[] muveltekk = File.ReadAllLines(muveltek);
            string[] szepekk = File.ReadAllLines(szepek);

            var mind = muveltekk.Intersect(szepekk);
            using (StreamWriter file = new StreamWriter(ki))
            {
                file.WriteLine("|------|");
                file.WriteLine("|Bátrak|");
                file.WriteLine("|------|");

                foreach (var emberek in mind)
                {
                    file.WriteLine(emberek);
                }
            }

            Console.WriteLine("3.feladat: ");

            string[] szeep = File.ReadAllLines("szep.txt");
            string[] muvelt_sor = File.ReadAllLines("muvelt.txt");
            HashSet<string> muvellt = new HashSet<string>(muvelt_sor);
            muvellt.UnionWith(szeep);
            Console.WriteLine("Versenyzők: ");

            foreach (string sor in muvellt)
            {
                Console.WriteLine(sor);
                StreamWriter k = new StreamWriter("Versenyzok.txt", append:true);
                k.WriteLine(sor);
            }

            Console.ReadKey();
        }
    }
}
