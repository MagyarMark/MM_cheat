using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MM_elemek
{
    internal class Program
    {
        class elem
        {
            public elem(string lista)
            {
                var kislista = lista.Split('\t');
                rendszám = kislista[0];
                vegyjel = kislista[1];
                név = kislista[2];
                atomtömeg = kislista[3];
                sűrűség = kislista[4];
                olvadáspont = kislista[5];
                forráspont = kislista[6];
                fajhő = kislista[7];
            }



            private int Rendszám;
            public string rendszám
            {
                get { return Rendszám.ToString(); }
                set
                {

                    Rendszám = int.Parse(value);
                }
            }
            private string Vegyjel;
            public string vegyjel
            {
                get { return Vegyjel; }
                set
                {
                    Vegyjel = value;
                }
            }
            private string Név;
            public string név
            {
                get { return Név; }
                set
                {
                    Név = value;
                }
            }

            private double Atomtömeg;
            public string atomtömeg
            {
                get { return Atomtömeg.ToString(); }
                set
                {

                    if (string.IsNullOrEmpty(value))
                    {
                        Atomtömeg = 0;
                    }
                    else
                    {
                        Atomtömeg = double.Parse(value.Replace('.', ','));
                    }

                }
            }
            private double Sűrűség;
            public string sűrűség
            {
                get { return Sűrűség.ToString(); }
                set
                {

                    if (string.IsNullOrEmpty(value))
                    {
                        Sűrűség = 0;
                    }
                    else
                    {
                        Sűrűség = double.Parse(value.Replace('.', ','));
                    }

                }
            }
            private double Olvadáspont;
            public string olvadáspont
            {
                get { return Olvadáspont.ToString(); }
                set
                {

                    if (string.IsNullOrEmpty(value))
                    {
                        Olvadáspont = 0;
                    }
                    else
                    {

                        Olvadáspont = double.Parse(value.Replace('.', ','));
                    }

                }
            }
            private double Forráspont;
            public string forráspont
            {
                get { return Forráspont.ToString(); }
                set
                {


                    if (string.IsNullOrEmpty(value))
                    {
                        Forráspont = 0;
                    }
                    else
                    {
                        Forráspont = double.Parse(value.Replace('.', ','));
                    }


                }
            }
            private double Fajhő;
            public string fajhő
            {
                get { return Fajhő.ToString(); }
                set
                {

                    if (string.IsNullOrEmpty(value))
                    {
                        Fajhő = 0;
                    }
                    else
                    {

                        Fajhő = double.Parse(value.Replace('.', ','));
                    }

                }

            }
            public double Suru()
            {
                return Sűrűség;
            }
            public double K()
            {
                return Forráspont;
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("------------");
            Console.WriteLine(" TT-elemek  ");
            Console.WriteLine("------------");

            ArrayList lista = new ArrayList();

            var file = File.ReadAllLines("elemek.csv");
            List<string> list = file.ToList();
            list.RemoveAt(0);
            foreach (string s in list)
            {

                lista.Add(new elem(s));

            }
            foreach (object s in lista)
            {

                elem teszt = s as elem;

                Console.WriteLine(teszt.rendszám + " " + teszt.vegyjel + " " + teszt.név + " " + teszt.atomtömeg + " " + teszt.sűrűség + " " + teszt.olvadáspont + " " + teszt.forráspont + " " + teszt.fajhő);
            }
            Console.WriteLine();
            Console.WriteLine("2.feladat:");
            Console.WriteLine($"beolvasott elemek száma:{lista.Count}");
            Console.WriteLine();
            Console.WriteLine("3.feladat:");
            int a = 0;
            foreach (object s in lista)
            {

                elem teszt = s as elem;
                if (teszt.vegyjel.Length == 1)
                {
                    Console.WriteLine(teszt.rendszám + "  " + teszt.vegyjel + " " + teszt.név + "\t\t" + teszt.atomtömeg + "\t\t" + teszt.sűrűség + "\t\t" + teszt.olvadáspont + "\t\t" + teszt.forráspont + "\t" + teszt.fajhő);
                    a++;
                }

            }
            Console.WriteLine($"összesen: {a}");
            Console.WriteLine();
            Console.WriteLine("4.feladat:");
            int sor = 0;
            double vegy = 0;
            foreach (object s in lista)
            {

                elem teszt = s as elem;
                if (teszt.Suru() > vegy)
                {
                    vegy = teszt.Suru();
                    sor = lista.IndexOf(s);
                }
            }
            elem test = lista[sor] as elem;
            Console.WriteLine($"legsűrűbb elem : {test.név} ({test.vegyjel}) : {test.Suru():n2}");
            Console.WriteLine();
            Console.WriteLine("5.feladat:");
            a = 0;
            foreach (object s in lista)
            {

                elem teszt = s as elem;
                if (teszt.Suru() < 0.01)
                {
                    Console.WriteLine(teszt.rendszám + "  " + teszt.vegyjel + " " + teszt.név + "\t\t" + teszt.atomtömeg + "\t\t" + teszt.sűrűség + "\t\t" + teszt.olvadáspont + "\t\t" + teszt.forráspont + "\t" + teszt.fajhő);
                    a++;
                }
            }
            Console.WriteLine($"összesen: {a}");
            Console.WriteLine();
            Console.WriteLine("6.feladat:");
            a = 0;
            foreach (object s in lista)
            {

                elem teszt = s as elem;
                if (teszt.K() < 400 && double.Parse(teszt.olvadáspont) > 200)
                {
                    Console.Write($"{teszt.vegyjel} {teszt.név} ");
                    Console.Write($"\t");
                    a++;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"összesen: {a}");
            Console.ReadKey();
        }
    }
}
