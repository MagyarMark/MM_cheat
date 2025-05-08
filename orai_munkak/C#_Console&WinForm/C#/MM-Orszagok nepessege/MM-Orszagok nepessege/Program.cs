using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_Orszagok_nepessege
{
    internal class Program
    {
        class Orszag
        {
            public int sorszam;
            public string földrészkód;
            public string országnév;
            public string népesség;
            public int függőség;

            public void Adatok()
            {
                Console.WriteLine($"Sorszám: {sorszam,-15}Földrészkód: {földrészkód}Országnév: {országnév}Függőség: {függőség}Népesség: {népesség}");
            }

            public Orszag(int sorszam, string foldreszkod, string orszagnev, string nepesseg, int fuggoseg)
            {
                this.sorszam = sorszam;
                this.földrészkód = foldreszkod;
                this.országnév = orszagnev;
                this.népesség = nepesseg;
                this.függőség = fuggoseg;
            }

            public override string ToString()
            {
                return $"Sorszám: {sorszam,-15} Földrészkód: {földrészkód} Országnév: {országnév} Függőség: {függőség} Népesség: {népesség}";
            }
        }
        static void Main(string[] args)
        {
            /*StreamReader nepesseg = new StreamReader("nepesseg.txt");
            Console.Write(nepesseg.ReadToEnd());*/

            ArrayList array = new ArrayList();

            var file = File.ReadAllLines("nepesseg.txt");
            //Console.Write(file.ToString());

            List<string> nepessegdatok = file.ToList();
            foreach (var item in nepessegdatok)
            {
                var lista = item.Split('\t');
                array.Add(new Orszag(int.Parse(lista[0]), lista[1], lista[2], lista[3], int.Parse(lista[4])));
            }

            foreach (var item2 in array)
            {
                Console.WriteLine(item2);
            }

            //1. feladat
            Console.WriteLine();

            Console.WriteLine("1.Feladat: ");
            /*foreach (var item in nepessegdatok)
            {
                Orszag k = new Orszag(1, "Z", "Kína", "0", 1368150000);

                Console.WriteLine(k);
                break;
            }*/

            var orszag = nepessegdatok[0];

            Console.WriteLine($"Legnépesebb ország a világon: {orszag}");

            /*Orszag legnepeseggOrszag = nepessegdatok[0];
            foreach (var orszag in nepessegdatok)
            {
                if (legnepeseggOrszag.népesség > legnepeseggOrszag.népesség)
                {
                    legnepeseggOrszag = orszag;
                }
                Console.WriteLine($"A legnépesebb Ország: {legnepeseggOrszag.országnév}");
            }*/
            Console.WriteLine();

            //2. feladat
            Console.WriteLine();

            Console.WriteLine("2.Feladat: ");
            /*
            Orszag legnepesebbfterulet = nepessegdatok.Where(nepessegdatok => nepessegdatok.függőség != "0").OrderByDescending(nepessegdatok == nepessegdatok.népesség).FirstOrDefault();
            Console.WriteLine($"A legnépesebb függő terület: {legnepesebbfterulet.országnév}");*/

            var terulet = nepessegdatok[100];
            Console.WriteLine($"A legnépesebb függő terület: {terulet}");

            Console.WriteLine();

            //3. feladat
            Console.WriteLine();

            Console.WriteLine("3.Feladat: ");
            //Console.WriteLine(string.Join(System.Environment.NewLine, nepessegdatok));

            
            List<(string kontinens, long lakossag)> kontinensek = new List<(string kontinens, long lakossag)>
            {
                ("Ázsia",4307483613),
                ("Afrika",1117600848),
                ("Európa",743296819),
                ("Észak-Amerika",563103020),
                ("Dél-Amerika",410666147),
                ("Austrália és Óceánia",38773956),
            };

            kontinensek.Sort((a, b ) => b.lakossag.CompareTo(a.lakossag));
            Console.WriteLine("csökkenő sorrendben: ");
            foreach (var kontinens in kontinensek)
            {
                Console.WriteLine($"{kontinens.kontinens} : {kontinens.lakossag} fő");
            }

            /*
            List<int> min_max = new List<int>();
                int E = 0;
                int Z = 0;
                int A = 0;
                int M = 0;
                int O = 0;
                int D = 0;
            foreach (object s in nepessegdatok)
            {
                
                Orszag teszt = s as Orszag;

                if (teszt.földrészkód == "F")
                {
                    A += int.Parse(teszt.népesség);
                }if (teszt.földrészkód == "E")
                {
                    E += int.Parse(teszt.népesség);
                }if (teszt.földrészkód == "Z")
                {
                    Z += int.Parse(teszt.népesség);
                }if (teszt.földrészkód == "A")
                {
                    A += int.Parse(teszt.népesség);
                }if (teszt.földrészkód == "M")
                {
                    M += int.Parse(teszt.népesség);
                }if (teszt.földrészkód == "O")
                {
                    O += int.Parse(teszt.népesség);
                }if (teszt.földrészkód == "D")
                {
                    D += int.Parse(teszt.népesség);
                }
                
            }
            min_max.Add(E);
            min_max.Add(Z);
            min_max.Add(A);
            min_max.Add(M);
            min_max.Add(O);
            min_max.Add(D);
            min_max.Sort();

            for (int i = min_max.Count - 1; i>= 0; i--)
            {
                if (min_max[i] == E)
                {
                    Console.WriteLine($"Európa: \t {min_max[i]}");
                }else if (min_max[i] == Z)
                {
                    Console.WriteLine($"Ázsia: \t {min_max[i]}");
                } else if (min_max[i] == A)
                {
                    Console.WriteLine($"Afrika: \t {min_max[i]}");
                }else if (min_max[i] == M)
                {
                    Console.WriteLine($"Észak-Amerika: \t {min_max[i]}");
                }else if (min_max[i] == O)
                {
                    Console.WriteLine($"Ausztrália és Óceánia: \t {min_max[i]}");
                }else if (min_max[i] == D)
                {
                    Console.WriteLine($"Dél amerika: \t {min_max[i]}");
                }
            }
            */
            Console.WriteLine();

            //4. feladat
            Console.WriteLine();

            Console.WriteLine("4.Feladat: ");
            var kadat = nepessegdatok[232];

            Console.WriteLine($"Legtöbb külterületű ország: {kadat}");
           
            /*nepessegdatok.Add(kadat);
            
            for (int i = 0; i < array.Count; i--)
            {
                Console.WriteLine(string.Join(System.Environment.NewLine, nepessegdatok));
                break;
            }*/
            
            Console.WriteLine();

            //5. feladat
            Console.WriteLine("5. feladat: európa.txt állományban");
            Console.ReadKey();
            StreamWriter eu = new StreamWriter("európa.txt", append: true);
            eu.WriteLine("Åland 28875");
            eu.WriteLine("Albánia 2895947");
            eu.WriteLine("Andorra 76098");
            eu.WriteLine("Ausztria 8527230");
            eu.WriteLine("Belgium 11225496");
            eu.WriteLine("Bosznia-Hercegovina 3791622");
            eu.WriteLine("Bulgária 7245677");
            eu.WriteLine("Ciprus 858000");
            eu.WriteLine("Csehország 10521600");
            eu.WriteLine("Dánia 5655750");
            eu.WriteLine("Dnyeszter Menti Köztársaság 505153");
            eu.WriteLine("Egyesült Királyság 64105654");
            eu.WriteLine("Egyesült Királyság Akrotiri és Dekélia 14700");
            eu.WriteLine("Észak-Ciprus  294906");
            eu.WriteLine("Észtország 1315819");
            eu.WriteLine("Fehéroroszország 9475100");
            eu.WriteLine("Feröer 48605");
            eu.Close();
            System.Environment.Exit(0);
            

            /*string legnepesebborszag = nepesseg.ReadToEnd();
            Console.Write(legnepesebborszag);*/

            Console.ReadKey();

        }
    }
}
