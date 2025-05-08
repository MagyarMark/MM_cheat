using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MM_bizonyitvany
{
    internal class Program
    {
        class Diák
        {
            public string név;
            public int magyar;
            public int történelem;
            public int matek;
            public int angol;
            public int igazolt;
            public int igazolatlan;

            public void Adatsor()
            {
                Console.WriteLine($"{név,-15}Magyar: {magyar} Tört.: {történelem} Matek: {matek} Nyelv: {angol} Ig.: {igazolt}, NemIg.: {igazolatlan}");
                /*
                Console.Write(név + "\t");
                Console.Write("Magyar: " + magyar);
                Console.Write(" Tört.: " + történelem);
                Console.Write(" Matek: " + matek);
                Console.Write(" Nyelv: " + angol);
                Console.Write(" Ig.: " + igazolt);
                Console.WriteLine(", NemIg.: " + igazolatlan);
                */
            }

            public Diák(string nev, int mag, int tort, int mat, int ang, int iga, int nig)
            {
                this.név = nev; this.magyar = mag; this.történelem = tort;
                this.matek = mat; this.angol = ang;
                this.igazolt = iga; this.igazolatlan = nig;
            }

            public override string ToString()
            {
                return
                  $"{név,-15}Magyar: {magyar} Tört.: {történelem} Matek: {matek} Nyelv: {angol} Ig.: {igazolt,-2}, NemIg.: {igazolatlan}";
            }
        }
        static void Main(string[] args)
        {
            ArrayList diaklista = new ArrayList();
            diaklista.Add(new Diák("Kázmér", 3, 2, 5, 5, 10, 0));
            // diaklista[0].Adatsor();

            var file = File.ReadAllLines("osztaly.txt");
            List<string> osztalyadatok = file.ToList();
            foreach (var item in osztalyadatok)
            {
                var kislista = item.Split(',');
                diaklista.Add(new Diák(kislista[0], int.Parse(kislista[1]),
                    int.Parse(kislista[2]), int.Parse(kislista[3]),
                    int.Parse(kislista[4]), int.Parse(kislista[5]),
                    int.Parse(kislista[6])));
            }



            Console.WriteLine("Az osztály naplója: ");
            int szamlalo = 1;
            foreach (var item2 in diaklista)
            {
                Console.WriteLine(szamlalo + ".: " + item2);
                szamlalo++;
            }

            Console.ReadKey();

            /*StreamReader sr = new StreamReader("osztaly.txt");
            Diák _1 = new Diák("XY", 5, 4, 2, 4, 50, 1);
            Diák _2 = new Diák("Linda", 3, 5, 5, 2, 30, 1);
            Diák _3 = new Diák("Eduárd", 5, 5, 5, 5, 0, 0);
            Diák _4 = new Diák("Zénó", 4, 4, 3, 5, 12, 3);
            Diák _5 = new Diák("Teofil", 2, 3, 4, 4, 8, 1);
            Diák _6 = new Diák("Auguszta", 4, 3, 3, 3, 22, 2);
            Diák _7 = new Diák("Bendegúz", 5, 5, 5, 4, 0, 0);
            Diák _8 = new Diák("Előd", 4, 5, 4, 5, 3, 1);

            
            diaklista.Add(_1);
            diaklista.Add(_2);
            diaklista.Add(_3);
            diaklista.Add(_4);
            diaklista.Add(_5);
            diaklista.Add(_6);
            diaklista.Add(_7);
            diaklista.Add(_8);
            foreach (var i in diaklista) 
            { 
                Console.WriteLine(i); 
            }*/
        }
    }
}
