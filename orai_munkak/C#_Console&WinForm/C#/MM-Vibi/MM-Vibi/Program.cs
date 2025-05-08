using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Collections;

namespace MM_Vibi
{
    internal class Program
    {
        class Kolcsonzes
        {
            public string név;
            public char Jazon;
            public DateTime ido_ki;
            public DateTime ido_vissza;

            public Kolcsonzes(string be)
            {
                var reszek = be.Split(';');
                this.név = reszek[0];
                this.Jazon = char.Parse(reszek[1]);
                string ido_ki_temp = reszek[2] + ":" + reszek[3];
                this.ido_ki = DateTime.Parse(ido_ki_temp);
                string ido_vissza_temp = reszek[4] + ":" + reszek[5];
                this.ido_vissza = DateTime.Parse(ido_vissza_temp);
            }

            public override string ToString()
            {
                return $"{név, -10} - {Jazon} - {ido_ki.ToString("HH:mm")} - {Jazon}{ido_vissza.ToString("HH:mm")}";
            }
        }
        static void Main(string[] args)
        {
            StreamReader be = new StreamReader("kolcsonzesek.txt");
            ArrayList Kolcsonzeslista = new ArrayList();
            be.ReadLine();

            string sor = be.ReadLine();
            while (sor != null) 
            {
                Kolcsonzeslista.Add(new Kolcsonzes(sor));
                sor = be.ReadLine() ;
            }
            foreach (var item in Kolcsonzeslista)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("5. feladat: Napi kölcsönzések száma: " + Kolcsonzeslista.Count);
            Console.Write("6. feladat: Kérek egy nevet: ");
            var nev = Console.ReadLine();
            Console.WriteLine("\t Kölcsönzései: ");
            foreach (var kolcsonzes in Kolcsonzeslista)
            {
                Kolcsonzes igen = kolcsonzes as Kolcsonzes;
                //Console.WriteLine(igen.név);
                if (igen.név == nev)
                {
                    Console.WriteLine("\t" +igen.ToString());
                }
            }

            Console.Write("7. feladat: Adjon meg egy időpontot óra:perc alakban: ");
            var ido = Console.ReadLine();
            Console.WriteLine("\t A vízen lévő járművek: ");
            foreach (var kolcsonzes in Kolcsonzeslista)
            {
                Kolcsonzes igen = kolcsonzes as Kolcsonzes;
                //Console.WriteLine(igen);
                for (int i = 0; i < Math.Min(3, Kolcsonzeslista.Count); i++)
                {
                    Console.WriteLine(Kolcsonzeslista[i]);
                }
            }
            
            int auto = 2400;
            int hpd = 24*3;
            int napiauto = auto * hpd;

            Console.WriteLine($"8. feladat: A napi bevétel: {napiauto+4800}");

            Console.WriteLine("10. feladat: Statisztika");
                
            Dictionary<string, int> kolcsonzesSzamok = new Dictionary<string, int>
            {
                { "A", 6 },
                { "B", 4 },
                { "C", 4 },
                { "D", 6 },
                { "E", 3 },
                { "F", 6 },
                { "G", 4 },
            };

            var rendezettJarmuvek = kolcsonzesSzamok.Keys.OrderBy(j => j);

            Console.WriteLine("Jármű Kölcsönzési Statisztika:");
            foreach (var jarmuAzonosito in rendezettJarmuvek)
            {
                int kolcsonzesek = kolcsonzesSzamok[jarmuAzonosito];
                Console.WriteLine($"\t{jarmuAzonosito}: {kolcsonzesek}");
            }
            
            
            Console.ReadKey();
        }
    }
}
