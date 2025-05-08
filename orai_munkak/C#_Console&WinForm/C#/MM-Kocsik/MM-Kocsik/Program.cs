using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace MM_Kocsik
{
    internal class Program
    {
        private static string marka;

        static int Szamoleletkor(int szuletesiev)
        {
            int aktualisev = DateTime.Now.Year;
            return aktualisev - szuletesiev;
        }
        static string randomszin(Random random)
        {
            List<string> szinek = new List<string>
            {
                "Piros", "Kék", "Zöld", "Fekete", "Fehér"
            };
            return szinek[random.Next(szinek.Count)];
        }
        class Kocsi
        {
            //Ha a tulajdonságokkal adjuk meg a konstruktort akkor is ellenörzést végez
            public Kocsi(string rendszam, string marka, int evjarat, string szin, int ertek)
            {
                rendszám = rendszam; márka = marka; évjárat = this.evjarat; szín = this.szin; érték = ertek;
            }

            public Kocsi(string rendszám)
            {
                this.rendszám = rendszám;
            }

            private string rendszam;
            public string rendszám
            {
                get { return rendszam; }
                set
                {
                    if (value.Length == 9) rendszam = value;
                    else Exception("A rendszám 9 karakter hosszú lehet!");
                }
            }
            private string marka;
            public string márka
            {
                get { return marka; }
                set
                {
                    string[] markak = new string[] { "BMW", "Fiat", "Volvo", "Peugeot", "Volkswagen" };
                    Random rnd = new Random();
                    marka = markak[rnd.Next(markak.Length)];
                }
            }
            private int evjarat;
            public int évjárat
            {
                get { return evjarat; }
                set
                {
                    Random random = new Random();
                    int randomm = random.Next(2010, 2019);
                    int[] evjarat = new int[] { randomm };
                    Console.WriteLine(evjarat[evjarat.Length - 1]);

                }
            }

            private string szin;
            public string szín
            {
                get { return szin; }
                set
                {
                    szin = value;
                }
            }

            private int ertek;
            public int érték
            {
                get { return ertek; }
                set
                {
                    ertek = value;
                }
            }
            private void Exception(string s)
            {
                throw new FormatException(s);
            }

            public override string ToString()
            {
                return $"Rendszám: {rendszam,15} Márka: {marka,5} Évjárat: {evjarat,5} Szín: {szin,5} Érték: {ertek,5}";
            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine("\t/-------------\\");
            Console.WriteLine("\t|MM-Kocsik-OOP|");
            Console.WriteLine("\t\\-------------/");

            Console.Write("írj be egy rendszámot (PL:AA-AA-123):");
            string rendszám = Console.ReadLine();
            Kocsi k = new Kocsi(rendszám);
            //Console.WriteLine(k.ToString());

            Random random = new Random();
            string szin = randomszin(random);

            string[] markak = new string[] { "BMW", "Fiat", "Volvo", "Peugeot", "Volkswagen" };
            Random rnd = new Random();
            marka = markak[rnd.Next(markak.Length)];

            int randomm = random.Next(2010, 2019);
            int[] evjarat = new int[] { randomm };

            decimal ertek = random.Next(500000, 12000000);

            //Console.WriteLine("Rendszám: " + rendszám + " Márka: " + marka  + " Szín: " + v[random.Next(v.Count)] + " Évjárat: " + evjarat[evjarat.Length - 1] + " Érték: " + ertek );

            Console.WriteLine($"Rendszám: {rendszám} Márka:{marka} Szín: {szin} Évjárat: {evjarat[evjarat.Length - 1]} Érték: {ertek:n0}Ft".ToString());
            Console.WriteLine();
            
            
            
            
            Console.ReadKey();
        }
    }
}
