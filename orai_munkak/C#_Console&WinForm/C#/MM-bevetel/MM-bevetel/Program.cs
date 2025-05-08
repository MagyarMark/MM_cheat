using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_bevetel
{
    class elem
    {
        public elem(string lista)
        {
            var bevetel_lista = lista.Split(';');
            eredmeny = int.Parse(bevetel_lista[0]);

        }
        public int eredmeny;

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList lista = new ArrayList();
            var file = File.ReadAllLines("bevetel.csv");
            List<string> list = file.ToList();
            foreach (string s in list)
            {

                lista.Add(new elem(s));

            }
            foreach (object s in lista)
            {

                elem teszt = s as elem;

                Console.WriteLine(teszt.eredmeny);
            }
            Console.WriteLine();

            Console.WriteLine("1. feladat: ");
            int db = 0;
            int ossz_db = 0;

            foreach (object s in lista)
            {
                
                elem teszt = s as elem;
                ossz_db += teszt.eredmeny;
                db++;
            }
            Console.WriteLine("teljes éves bevétel: " + ossz_db);
            Console.WriteLine("napi átlag: " + ossz_db/db);
            Console.WriteLine();

            Console.WriteLine("2. feladat: ");

            int hetveg_db = 0;
            foreach (object s in lista)
            {
                elem teszt = s as elem;
                db++;
                if (db % 6 == 0 || db % 7 == 0)
                {
                    ossz_db += teszt.eredmeny;
                    hetveg_db++;
                }
            }
            Console.WriteLine("hétvégi átlag: " + ossz_db / hetveg_db);
            Console.WriteLine();

            Console.WriteLine("3. feladat: ");

            int legnagyobb = 0;
            foreach (object s in lista)
            {
                elem teszt = s as elem;
                legnagyobb = (teszt.eredmeny / 30) + 1;
            }
            Console.WriteLine("A legnagyobb bevételü nap a hónapban: " + legnagyobb);

            List<DateTime> datum = new List<DateTime>();

            DateTime Base = new DateTime(2023, 01, 1);

            for (int i = 0; i < 365; i++)
            {
                datum.Add(Base.AddDays(i));
                foreach (object s in lista)
                {
                    elem teszt = s as elem;
                    int valami = teszt.eredmeny;
                    DateTime szam = DateTime.Parse(valami.ToString());
                    datum.Add(szam);
                }
            }
            Console.WriteLine(string.Join(System.Environment.NewLine,datum));
            
            Console.WriteLine();

            Console.WriteLine("4. feladat: ");

            Console.ReadKey();
        }
    }
}
