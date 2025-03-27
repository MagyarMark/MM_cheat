using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace realestates
{
    internal class Program
    {
        class Category
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        class Seller
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Phone { get; set; }

        }
        class Ad
        {
            public int Area { get; set; }
            public Category Category { get; set; }
            public DateTime CreateAt { get; set; }
            public string Description { get; set; }
            public int Floors { get; set; }
            public bool FreeofCharge { get; set; }
            public int Id { get; set; }
            public string ImageUrl { get; set; }
            public string LatLong { get; set; }
            public int Rooms { get; set; }
            public Seller Seller { get; set; }

            public Ad(string line)
            {
                string[] szet = line.Split(';');
                this.Id = int.Parse(szet[0]);
                this.Description = szet[5];
                this.Rooms = int.Parse(szet[1]);
                this.Area = int.Parse(szet[4]);
                this.Floors = int.Parse(szet[3]);
                this.Category = new Category();
                this.Category.Id = int.Parse(szet[12]);
                this.Category.Name = szet[13];
                this.Seller = new Seller();
                this.Seller.Id = int.Parse(szet[9]);
                this.Seller.Name = szet[10];
                this.Seller.Phone = szet[11];
                this.FreeofCharge = szet[6] == "1";
                this.ImageUrl = szet[7];
                this.LatLong = szet[2];
                this.CreateAt = DateTime.Parse(szet[8]);
            }
            public static List<Ad> LoadFromCsv(string fileName)
            {
                string[] strings = File.ReadAllLines(fileName, Encoding.UTF8).Skip(1).ToArray();
                List<Ad> ad = new List<Ad>();
                foreach (var item in strings)
                {
                    ad.Add(new Ad(item));
                }
                return ad;
            }

            public double DistanceTo(double x, double y)
            {

                double a = x - double.Parse(LatLong.Split(',')[0].Replace(".",","));
                double b = y - double.Parse(LatLong.Split(',')[1].Replace(".", ","));
                return Math.Sqrt(a * a + b * b);
            }
        }

        static void Main(string[] args)
        {
            List<Ad> adatok = Ad.LoadFromCsv("realestates.csv");

            double osszeg = 0;
            int db = 0;
            foreach (var item in adatok)
            {
                if (item.Floors == 0)
                {
                    osszeg += item.Area;
                    db++;
                }
            }
            Console.WriteLine($"6.feladat Földszinti ingatlanok átlagos alapterülete: {osszeg/db:0.00} m2");
            
            
            int lkind = 0;

            foreach (var item in adatok) 
            {
                if (item.FreeofCharge) break;
                else lkind++;
            }

            for (int i = lkind+1; i < adatok.Count; i++)
            {
                if (adatok[i].DistanceTo(47.4164220114023, 19.066342425796986) < adatok[lkind].DistanceTo(47.4164220114023, 19.066342425796986)
                    &&
                    adatok[i].FreeofCharge) lkind = i;
            }
            Console.WriteLine($"8. feladat Mesevásár óvodához légvonalban tehermentes ingatlanok adatai:");
            Console.WriteLine($"\tEladó neve: {adatok[lkind].Seller.Name}");
            Console.WriteLine($"\tEladó telefonszáma: {adatok[lkind].Seller.Phone}");
            Console.WriteLine($"\tAlapterület: {adatok[lkind].Area}");
            Console.WriteLine($"\tSzobák száma: {adatok[lkind].Rooms}");
            Console.ReadKey();
            //innentől az én részem ez a szöveg előtt Butty Mátéé

            Console.WriteLine();

            adatok.Sort((x, y) => x.Seller.Name.CompareTo(y.Seller.Name));
            /*Console.WriteLine("feladat: név abc sorrendben");
            foreach (var item in adatok)
            {
                if (item.Id > 0)
                {
                    Console.WriteLine(item.Seller.Name);
                }
            }
            */
            Console.WriteLine();
            
            adatok.Sort((x, y) => x.Seller.Phone.CompareTo(y.Seller.Phone));
            Console.WriteLine("feladat: telefonszám abc sorrendben");
            foreach (var item in adatok)
            {
                if (item.Id > -1)
                {
                    Console.WriteLine($"Eladó neve: {item.Seller.Name}");
                    Console.WriteLine($"Eladó telefonszáma: {item.Seller.Phone}");
                }
            }
            Console.ReadKey();

        }
    } 
}




