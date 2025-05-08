using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TryCatchPéldák
{
    internal class Program
    {
        class Adat
        {
            
            public int ora;
            public int perc;
            public int mp;
            public int ido;
            public string irany;

            public Adat(string igeny)
            {
                try
                {
                    string[] igenyek = igeny.Split(' ');

                    this.ora = int.Parse(igenyek[0]);
                    this.perc = int.Parse(igenyek[1]);
                    this.mp = int.Parse(igenyek[2]);
                    this.ido = int.Parse(igenyek[3]);
                    this.irany = igenyek[4];
                }
                catch (Exception)
                {
                    this.ora = 33;
                }
                
            }
        }
        static void Main(string[] args)
        {
            try
            {
                string[] fileAdat = File.ReadAllLines("forgalom hibas.txt", Encoding.UTF8);
                int adatokSzama  = int.Parse(fileAdat[0]);
                List<Adat> adats = new List<Adat>();

                int hibas = 0;

                for (int i = 0; i <= adatokSzama; i++)
                {
                    Adat tmp = new Adat(fileAdat[i]);
                    if (tmp.ora != 33)
                    {
                        adats.Add(tmp);
                    }
                    else 
                    {
                        hibas++;
                    }
                }

                //sorozatszámítás (összegzés)
                int osszesido = 0;
                foreach (Adat item in adats)
                {
                    osszesido += item.ido;
                }
                Console.WriteLine("Az összes idő: " + osszesido + " mp");

                int osszesidoF = 0;
                foreach (Adat item in adats)
                {
                    if (item.irany == "F")
                    {
                        osszesidoF += item.ido;
                    }
                }
                Console.WriteLine("Az összes idő F irányból: " + osszesidoF + " mp");

                //megszámlálás 

                int dbF = 0;
                foreach (Adat item in adats)
                {
                    if (item.irany == "F")
                    {
                        dbF++;
                    }
                }
                Console.WriteLine("F irányból: " + dbF + " autó érkezett");

                //szélsőérték keresés
                int legnagyobbIndexe = 0;
                for (int i = 0; i < adats.Count; i++)
                {
                    if (adats[i].ido > adats[legnagyobbIndexe].ido)
                    {
                        legnagyobbIndexe = i;
                    }
                }
                Console.WriteLine("A leglassabban " + adats[legnagyobbIndexe].ora + " óra " + adats[legnagyobbIndexe].perc +" perckor érkezett" );

                //Eldöntés (idő = 47mp)
                int ii = 0;
                while (ii<adats.Count && adats[ii].ido !=47)
                {
                    ii++;
                }
                if (ii == adats.Count/*47*/)
                {
                    Console.WriteLine("Nincs ilyen adat");
                }
                else
                {
                    Console.WriteLine("Van ilyen adat");
                    //Kiválasztás
                    ii = 0;
                    while (adats[ii].ido != 47)
                    {
                        ii++;
                    }
                    Console.WriteLine("A keresett elem indexe: " + ii);
                }
                //lineáris keresés
                ii = 0;
                while (ii < adats.Count && adats[ii].ido != 47)
                {
                    ii++;
                }
                if (ii == adats.Count)
                {
                    Console.WriteLine("Nincs ilyen adat");
                }
                else
                {
                    Console.WriteLine("A keresett elem indexe: " + ii);
                }
                //másolás
                List<Adat> masoltAdats = new List<Adat>();
                foreach (Adat adat in adats)
                {
                    masoltAdats.Add(adat);
                }
                //kiválogatás 
                List<Adat> ora10ig = new List<Adat>();
                foreach (var item in adats)
                {
                    if (item.ora <10)
                    {
                        ora10ig.Add(item);
                    }
                }
                //szétválogatás
                List<Adat> a = new List<Adat>();
                List<Adat> b = new List<Adat>();
                foreach (var item in adats)
                {
                    if (item.ora < 12)
                    {
                        a.Add(item);
                    }
                    else
                    {
                        b.Add(item);
                    }
                }
                //metszet ora10ig - a
                List<Adat> ora10ig_a = new List<Adat>();
                foreach(var item in ora10ig_a)
                {
                    ii = 0;
                    while (ii < a.Count && a[ii] != item)
                    {
                        ii++;
                    }
                    if (ii == a.Count)
                    {
                        ora10ig_a.Add(item);
                    }
                }

                //unio ora10ig - a 
                List<Adat> ora10igUa = new List<Adat>();
                ora10igUa = ora10ig;
                foreach (var item in ora10igUa)
                {
                    ii = 0;
                    while (ii < a.Count && a[ii] != item)
                    {
                        ii++;
                    }
                    if (ii == a.Count)
                    {
                        ora10igUa.Add(item);
                    }
                }

                Console.ReadKey(true);
            }
            catch (Exception e)
            {
                Console.WriteLine("Hiba" + e);
            }


            Console.ReadKey();
        }
    }
}
