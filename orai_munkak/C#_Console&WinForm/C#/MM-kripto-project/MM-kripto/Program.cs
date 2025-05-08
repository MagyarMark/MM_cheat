using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Eventing.Reader;

namespace MM_kripto
{
    internal class Program
    {
        class elem
        {
            public elem(string lista)
            {
                var kislista = lista.Split(';');
                Unix = kislista[0];
                Date = kislista[1];
                Symbol = kislista[2];
                Open = kislista[3];
                High = kislista[4];
                Low = kislista[5];
                Close = kislista[6];
                VolumeEUR = kislista[7];
                Tradecount = kislista[8];
            }

            private string Unix;
            public string unix
            {
                get { return Unix; }
                set
                {
                    Unix = value;
                }
            }
            
            private string Date;
            public string date
            {
                get { return Date; }
                set
                {
                    Date = value;
                }
            }


            private string Symbol;
            public string symbol
            {
                get { return Symbol; }
                set
                {
                    Symbol = value;
                }
            }

            private string Open;
            public string open
            {
                get { return Open;  }
                set
                {
                    Open = value;
                }
            }

            private string High;
            public string high
            {
                get{ return High; }
                set
                {
                    High = value;
                }
            }

            private string Low;
            public string low
            {
                get { return Low; }
                set
                {
                    Low = value;
                }
            }

            private string Close;
            public string close
            {
                get { return Close; }
                set
                {
                    Close = value;
                }
            }

            private string VolumeEUR;
            public string volumeEUR
            {
                get { return VolumeEUR; }
                set
                {
                    VolumeEUR = value;
                }
            }

            private string Tradecount;
            public string tradecount
            {
                get { return Tradecount; }
                set
                {
                    Tradecount = value;
                }
            }

            
        }

        class elem2
        {
            public elem2(string listaETH)
            {
                var kislista = listaETH.Split(',');
                Unix = kislista[0];
                Date = kislista[1];
                Symbol = kislista[2];
                Open = kislista[3];
                High = kislista[4];
                Low = kislista[5];
                Close = kislista[6];
                VolumeETH = kislista[7];
                VolumeEUR = kislista[8];
                Tradecount = kislista[9];
            }

            private string Unix;
            public string unix
            {
                get { return Unix; }
                set
                {
                    Unix = value;
                }
            }

            private string Date;
            public string date
            {
                get { return Date; }
                set
                {
                    Date = value;
                }
            }


            private string Symbol;
            public string symbol
            {
                get { return Symbol; }
                set
                {
                    Symbol = value;
                }
            }

            private string Open;
            public string open
            {
                get { return Open; }
                set
                {
                    Open = value;
                }
            }

            private string High;
            public string high
            {
                get { return High; }
                set
                {
                    High = value;
                }
            }

            private string Low;
            public string low
            {
                get { return Low; }
                set
                {
                    Low = value;
                }
            }

            private string Close;
            public string close
            {
                get { return Close; }
                set
                {
                    Close = value;
                }
            }
            private string VolumeETH;
            public string volumeETH
            {
                get { return VolumeETH; }
                set
                {
                    VolumeETH = value;
                }
            }
            private string VolumeEUR;
            public string volumeEUR
            {
                get { return VolumeEUR; }
                set
                {
                    VolumeEUR = value;
                }
            }

            private string Tradecount;
            public string tradecount
            {
                get { return Tradecount; }
                set
                {
                    Tradecount = value;
                }
            }
        }

        class elem3
        {
            public elem3(string listaSOL)
            {
                var kislista = listaSOL.Split(',');
                Unix = kislista[0];
                Date = kislista[1];
                Symbol = kislista[2];
                Open = kislista[3];
                High = kislista[4];
                Low = kislista[5];
                Close = kislista[6];
                VolumeSOL = kislista[7];
                VolumeEUR = kislista[8];
                Tradecount = kislista[9];
            }

            private string Unix;
            public string unix
            {
                get { return Unix; }
                set
                {
                    Unix = value;
                }
            }

            private string Date;
            public string date
            {
                get { return Date; }
                set
                {
                    Date = value;
                }
            }


            private string Symbol;
            public string symbol
            {
                get { return Symbol; }
                set
                {
                    Symbol = value;
                }
            }

            private string Open;
            public string open
            {
                get { return Open; }
                set
                {
                    Open = value;
                }
            }

            private string High;
            public string high
            {
                get { return High; }
                set
                {
                    High = value;
                }
            }

            private string Low;
            public string low
            {
                get { return Low; }
                set
                {
                    Low = value;
                }
            }

            private string Close;
            public string close
            {
                get { return Close; }
                set
                {
                    Close = value;
                }
            }
            private string VolumeSOL;
            public string volumeSOL
            {
                get { return VolumeSOL; }
                set
                {
                    VolumeSOL = value;
                }
            }
            private string VolumeEUR;
            public string volumeEUR
            {
                get { return VolumeEUR; }
                set
                {
                    VolumeEUR = value;
                }
            }

            private string Tradecount;
            public string tradecount
            {
                get { return Tradecount; }
                set
                {
                    Tradecount = value;
                }
            }
        }

        class Kriptovaluta
        {
            public string Neve { get; set; }
            public DateTime Datum { get; set; }
            public double Ar { get; set; }

        }
        static void Main(string[] args)
        {
            ArrayList lista = new ArrayList();
            Console.WriteLine("\t\t\t\t\t|-------|");
            Console.WriteLine("\t\t\t\t\t Bitcoin");
            Console.WriteLine("\t\t\t\t\t|-------|");
            var file = File.ReadAllLines("BTCEUR.csv");
            List<string> list = file.ToList();
            list.RemoveAt(0);
            list.RemoveAt(1);
            foreach (string s in list)
            {

                lista.Add(new elem(s));

            }
            foreach (object s in lista)
            {

                elem teszt = s as elem;

                Console.WriteLine(teszt.unix + " " + teszt.date + " " + teszt.symbol + " " + teszt.open + " " + teszt.high + " " + teszt.low + " " + teszt.close + " " + teszt.volumeEUR + " " + teszt.tradecount);
            }



            ArrayList lista2 = new ArrayList();
            Console.WriteLine("\t\t\t\t\t|--------|");
            Console.WriteLine("\t\t\t\t\t Etherium");
            Console.WriteLine("\t\t\t\t\t|--------|");
            var file2 = File.ReadAllLines("ETHEUR.csv");
            List<string> list2 = file2.ToList();
            list2.RemoveAt(0);
            foreach (string s in list2)
            {

                lista2.Add(new elem2(s));

            }
            foreach (object s in lista2)
            {

                elem2 teszt2 = s as elem2;

                Console.WriteLine(teszt2.unix + " " + teszt2.date + " " + teszt2.symbol + " " + teszt2.open + " " + teszt2.high + " " + teszt2.low + " " + teszt2.close + " " + teszt2.volumeETH + " " + teszt2.volumeEUR + " " + teszt2.tradecount);
            }



            ArrayList lista3 = new ArrayList();
            Console.WriteLine("\t\t\t\t\t|--------|");
            Console.WriteLine("\t\t\t\t\t Solarium");
            Console.WriteLine("\t\t\t\t\t|--------|");
            var file3 = File.ReadAllLines("SOLEUR.csv");
            List<string> list3 = file3.ToList();
            list3.RemoveAt(0);
            foreach (string s in list3)
            {

                lista3.Add(new elem3(s));

            }
            foreach (object s in lista3)
            {

                elem3 teszt3 = s as elem3;

                Console.WriteLine(teszt3.unix + " " + teszt3.date + " " + teszt3.symbol + " " + teszt3.open + " " + teszt3.high + " " + teszt3.low + " " + teszt3.close + " " + teszt3.volumeSOL + " " + teszt3.volumeEUR + " " + teszt3.tradecount);
            }
            Console.WriteLine();

            List<string> kript = new List<string>();
            List<Kriptovaluta> kriptovalutak = new List<Kriptovaluta>();
            int choice;

            int oldalMeret = 100;
            int aktualisOldal = 0;
            int osszesOldal = (int)Math.Ceiling((double)kriptovalutak.Count / oldalMeret);
            Console.Clear();

            do
            {
                Console.WriteLine("Válasszon egy lehetőséget:");
                Console.WriteLine("1 - Kriptovaluta kiválasztása");
                Console.WriteLine("2 - Kriptovaluta Grafikon");
                Console.WriteLine("3 - Statisztika");
                Console.WriteLine("4 - Befektetési számítás");
                Console.WriteLine("0 - Kilépés a programból");
                Console.Write("Választott opció: ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Érvénytelen választás. Kérem, válasszon újra.");
                    continue;
                }

                switch (choice) 
                {
                    case 1:
                        Console.Clear();

                        Console.WriteLine("Válasszon egy kriptovalutát:");
                        Console.WriteLine();
                        Console.WriteLine("1. Bitcoin");
                        Console.WriteLine("2. Ethereum");
                        Console.WriteLine("3. Solarium");
                        Console.WriteLine();
                        Console.Write("Választott kriptovaluta sorszáma: ");

                        if (!int.TryParse(Console.ReadLine(), out int cryptoChoice) || cryptoChoice < 1 || cryptoChoice > 3)
                        {
                            Console.WriteLine("Érvénytelen választás.");
                            continue;
                        }
                        Console.WriteLine("A kiválasztott kripto: {0}", cryptoChoice);

                        Console.WriteLine($"Kriptovaluta adatok - Oldal {aktualisOldal + 1}/{osszesOldal}");
                        Console.WriteLine("Dátum\t\t\t\tÁr");

                        int startIndex = aktualisOldal * oldalMeret;
                        int endIndex = Math.Min(startIndex + oldalMeret, kriptovalutak.Count);
                        for (int i = startIndex; i < endIndex; i++)
                        {
                            Kriptovaluta kripto = kriptovalutak[i];
                            Console.WriteLine($"{kripto.Datum.ToShortDateString()}\t{kripto.Ar}");
                        }
                        while (Console.ReadKey().Key != ConsoleKey.PageDown && aktualisOldal < osszesOldal - 1) { }
                        aktualisOldal++;
                        while (aktualisOldal < osszesOldal) ;

                        if (cryptoChoice == 1)
                        {
                            foreach (object s in lista)
                            {

                                elem teszt = s as elem;
                                Console.WriteLine(teszt.date + "\t" + teszt.open + " " + teszt.high + "\t" + teszt.low + " " + teszt.close + "\t");
                                /*var atlag = int.Parse(teszt.high + teszt.low);
                                int myInt = int.Parse(teszt.open);
                                Console.WriteLine(myInt);
                                //int myInt1 = Convert.ToInt32(teszt.low);
                                //int myInt2 = myInt + myInt1;
                                //int atlag = myInt2 / 2;
                                //Console.WriteLine("Átlag: {0} " + atlag);*/
                            }
                        }
                        if (cryptoChoice == 2)
                        {
                            foreach (object s in lista2)
                            {

                                elem2 teszt2 = s as elem2;
                                Console.WriteLine(teszt2.date + "\t" + teszt2.open + " " + teszt2.high + "\t" + teszt2.low + " " + teszt2.close + "\t");
                                /*var high = int.Parse(teszt2.high);
                                var low = int.Parse(teszt2.low);
                                var atlag2 = high + low;
                                var atlagatlag2 = atlag2 / 2;
                                Console.WriteLine("Átlag: " + atlagatlag2);*/
                            }
                        }
                        if (cryptoChoice == 3)
                        {
                            foreach (object s in lista3)
                            {

                                elem3 teszt3 = s as elem3;
                                Console.WriteLine(teszt3.date + "\t" + teszt3.open + " " + teszt3.high + "\t" + teszt3.low + " " + teszt3.close + "\t");

                                /*var high = int.Parse(teszt3.high);
                                var low = int.Parse(teszt3.low);
                                var atlag3 = high + low;
                                var atlagatlag3 = atlag3 / 2;
                                Console.WriteLine("Átlag: " + atlagatlag3);*/
                            }
                        }
                        break;

                    case 2:
                        Console.Clear();

                        Console.WriteLine("Válasszon egy kriptovalutát:");
                        Console.WriteLine();
                        Console.WriteLine("1. Bitcoin");
                        Console.WriteLine("2. Ethereum");
                        Console.WriteLine("3. Solarium");
                        Console.WriteLine();
                        Console.Write("Választott kriptovaluta sorszáma: ");

                        if (!int.TryParse(Console.ReadLine(), out int cryptoChoicee) || cryptoChoicee < 1 || cryptoChoicee > 3)
                        {
                            Console.WriteLine("Érvénytelen választás.");
                            continue;
                        }
                        Console.WriteLine("A kiválasztott kripto: {0}", cryptoChoicee);

                        Console.WriteLine();

                        Console.WriteLine("Milyen dátum intervallumot szeretnél megadni?");
                        Console.WriteLine();
                        Console.WriteLine("1. Teljes időszak");
                        Console.WriteLine("2. Intervallum megadása");
                        Console.WriteLine();
                        Console.Write("Választásod: ");

                        if (!int.TryParse(Console.ReadLine(), out int cryptoChoiceee) || cryptoChoiceee < 1 || cryptoChoiceee > 3)
                        {
                            Console.WriteLine("Érvénytelen választás.");
                            continue;
                        }
                        Console.Write("A kiválasztott kripto: {0}", cryptoChoiceee);

                        if (cryptoChoiceee == 1)
                        {
                            foreach (object s in lista)
                            {
                                elem teszt = s as elem;
                                /*Console.Write(teszt.date + "\t") ;
                                Console.ForegroundColor = ConsoleColor.Yellow;Console.WriteLine("[");
                                
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write(teszt.close);
                                Console.ForegroundColor = ConsoleColor.Yellow;Console.WriteLine("]");
                                
                                Console.ForegroundColor = ConsoleColor.White;*/

                                Console.OutputEncoding = System.Text.Encoding.UTF8;
                                string ismetlodoBetu = "€";
                                char karakter = '€';
                                var ismetlesSzam = teszt.close;
                                var szam = ismetlesSzam.Substring(0);

                                for (var i = 0; i < szam.Length; i++)
                                {
                                    ismetlodoBetu += karakter;
                                }

                                Console.Write(teszt.date + "\t"); 
                                Console.ForegroundColor = ConsoleColor.Yellow; 
                                Console.Write("["); 
                                Console.ForegroundColor = ConsoleColor.White; 
                                Console.Write(teszt.close);
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("]"+" |\t "+ ismetlodoBetu);
                                Console.ForegroundColor = ConsoleColor.White;



                            }
                        }
                        if (cryptoChoiceee == 2)
                        {
                            Console.Write("Add meg a kezdő dátumot (min. 2021-05-28):");
                            var feher = Console.ReadLine();
                            Console.WriteLine(feher);

                            for (int i = 0; i < feher.Length; i++)
                            {
                                foreach (object s in lista)
                                {

                                    elem teszt = s as elem;

                                    Console.OutputEncoding = System.Text.Encoding.UTF8;
                                    string ismetlodoBetu = "€";
                                    char karakter = '€';
                                    var ismetlesSzam = teszt.close;
                                    var szam = ismetlesSzam.Substring(0);

                                    for (var a = 0; a < szam.Length; a++)
                                    {
                                        ismetlodoBetu += karakter;
                                    }
                                    Console.WriteLine(teszt.date + " |\t " + ismetlodoBetu);

                                }
                            }

                            Console.Write("Add meg a záró dátumot (max. 2024-03-18):");
                            var fekete = Console.ReadLine();
                            Console.WriteLine(fekete);
                            for (int i = 0; i < fekete.Length; i++)
                            {
                                foreach (object s in lista)
                                {

                                    elem teszt = s as elem;

                                    Console.OutputEncoding = System.Text.Encoding.UTF8;
                                    string ismetlodoBetu = "€";
                                    char karakter = '€';
                                    var ismetlesSzam = teszt.close;
                                    var szam = ismetlesSzam.Substring(0);

                                    for (var a = 0; a < szam.Length; a++)
                                    {
                                        ismetlodoBetu += karakter;
                                    }
                                    Console.WriteLine(teszt.date+"|\t"+ ismetlodoBetu);

                                }
                            }


                        }

                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Statisztika kiválasztva.");
                        Console.WriteLine();

                        Console.WriteLine("Válasszon egy kriptovalutát:");
                        Console.WriteLine();
                        Console.WriteLine("1. Bitcoin");
                        Console.WriteLine("2. Ethereum");
                        Console.WriteLine("3. Solarium");
                        Console.WriteLine();
                        Console.Write("Választott kriptovaluta sorszáma: ");

                        if (!int.TryParse(Console.ReadLine(), out int cryptoChoiceeee) || cryptoChoiceeee < 1 || cryptoChoiceeee > 3)
                        {
                            Console.WriteLine("Érvénytelen választás.");
                            continue;
                        }
                        Console.WriteLine("A kiválasztott kripto: {0}", cryptoChoiceeee);

                        if (cryptoChoiceeee == 1)
                        {
                            List<int> min_max = new List<int>();
                            foreach (object s in lista)
                            {
                                int szam = 0;
                                elem teszt = s as elem;
                                if(teszt.close.Length == 8)
                                {
                                    szam = int.Parse(teszt.close.Substring(0, 5)); min_max.Add(szam);
                                }else if ((teszt.close.Length == 6))
                                {
                                    szam = int.Parse(teszt.close.Substring(0, 4)); min_max.Add(szam);
                                }
                                min_max.Add(szam);
                            }
                            Console.WriteLine("BITCOIN");
                            Console.OutputEncoding = System.Text.Encoding.UTF8;
                            Console.WriteLine($"Legkisebb: {min_max.Min()}€");
                            Console.WriteLine($"Legnagyobb: {min_max.Max()}€");
                            Console.WriteLine($"Átlaga: {min_max.Average()}€");
                        }
                        if (cryptoChoiceeee == 2)
                        {
                            List<int> min_max = new List<int>();
                            foreach (object s in lista2)
                            {
                                int szam = 0;
                                elem2 teszt2 = s as elem2;
                                if (teszt2.close.Length == 8)
                                {
                                    szam = int.Parse(teszt2.close.Substring(0, 5)); min_max.Add(szam);
                                }
                                else if ((teszt2.close.Length == 6))
                                {
                                    szam = int.Parse(teszt2.close.Substring(0, 4)); min_max.Add(szam);
                                }
                                min_max.Add(szam);
                            }
                            Console.WriteLine("ETHERIUM");
                            Console.OutputEncoding = System.Text.Encoding.UTF8;
                            Console.WriteLine($"Legkisebb: {min_max.Min()}€");
                            Console.WriteLine($"Legnagyobb: {min_max.Max()}€");
                            Console.WriteLine($"Átlaga: {min_max.Average()}€");
                        }
                        if (cryptoChoiceeee == 3)
                        {
                            List<int> min_max = new List<int>();
                            foreach (object s in lista3)
                            {
                                int szam = 0;
                                elem3 teszt3 = s as elem3;
                                if (teszt3.close.Length == 8)
                                {
                                    szam = int.Parse(teszt3.close.Substring(0, 5)); min_max.Add(szam);
                                }
                                else if ((teszt3.close.Length == 6))
                                {
                                    szam = int.Parse(teszt3.close.Substring(0, 4)); min_max.Add(szam);
                                }
                                min_max.Add(szam);
                            }
                            Console.WriteLine("SOLANA");
                            Console.OutputEncoding = System.Text.Encoding.UTF8;
                            Console.WriteLine($"Legkisebb: {min_max.Min()}€");
                            Console.WriteLine($"Legnagyobb: {min_max.Max()}€");
                            Console.WriteLine($"Átlaga: {min_max.Average()}€");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Befektetés kiválasztva.");
                        break;

                    case 0:
                        Console.WriteLine("Kilépés a programból...");
                        break;

                    default:
                        Console.WriteLine("Érvénytelen választás. Kérem, válasszon újra.");
                        break;
                }
                Console.WriteLine();
            } while (choice != 0);

            Console.ReadKey();
        }
    }
}
