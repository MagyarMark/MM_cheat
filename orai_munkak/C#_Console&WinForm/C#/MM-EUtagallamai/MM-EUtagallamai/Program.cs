using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MM_EUtagallamai
{
    internal class Program
    {
        class EU
        {
            public EU(string lista)
            {
                var kislista = lista.Split(';');
                orszag = kislista[0];
                ev = kislista[1];
                
            }

            private string Orszag;
            public string orszag
            {
                get { return Orszag.ToString(); }
                set
                {
                    Orszag = value;
                }
            }

            private int Ev;
            public string ev
            {
                get { return Ev.ToString(); }
                set
                {
                    ev = int.Parse(value);
                }
            }

            public override string ToString()
            {
                if (orszag.Length < 7) return $"{orszag} \t\t\t\t {ev}.{ho}.{nap}";
                else if (ev.Length < 15) return $"{orszag} \t\t\t\t {ev}.{ho}.{nap}";
                else return $"{orszag} \t\t {ev}.{ho}.{nap}";
            }
        }
   

        
        static void Main(string[] args)
        {

            ArrayList lista = new ArrayList();

            var file = File.ReadAllLines("EUcsatlakozas.txt",Encoding.Default);
            List<string> list = file.ToList();
            foreach (string s in list)
            {

                lista.Add(new EU(s));

            }
            foreach (object s in lista)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

            Console.WriteLine("3. feladat: ");
            Console.Write("EU tagállamainak száma: " + file.Length +" db");

            Console.WriteLine();

            Console.WriteLine("4. feladat: ");

            int evek = file.Length/6-2;
            Console.WriteLine("2007-ben: " + evek + " ország csatlakozott");



            Console.ReadKey();
        }
    }
}
