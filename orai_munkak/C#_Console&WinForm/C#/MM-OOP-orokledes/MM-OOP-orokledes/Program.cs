using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_OOP_oroklodes
{
    internal class Program
    {
        class Nagyszülő
        {
            public int eletkor = 72;
            public string vezeteknev = "Perecz";
            public string keresztnev = "Zoltán";
            public override string ToString()
            {
                return
                  $"{vezeteknev} {keresztnev} {eletkor} éves";
            }
        }
        class Szülő : Nagyszülő
        {
            public int eletkor;
            public Szülő()
            {
                Random rnd = new Random();
                this.eletkor = rnd.Next(15, 45);
            }
            public override string ToString()
            {
                return
                  $"{vezeteknev} {eletkor} éves";
            }


        }
        class Gyerek : Szülő
        {
            public int eletkor;
            public Gyerek(int ek) // 16 --> éves legyen
            {
                this.eletkor = ek;
            }
            public override string ToString()
            {
                return
                  $"{vezeteknev} {eletkor} éves";
            }
        }
        static void Main(string[] args)
        {
            ArrayList szemelyek = new ArrayList();

            Nagyszülő nsz = new Nagyszülő();
            szemelyek.Add(nsz);

            Szülő sz = new Szülő();
            szemelyek.Add(sz);

            //Console.WriteLine(sz);

            Gyerek gy1 = new Gyerek(16);
            szemelyek.Add(gy1);

            //Console.WriteLine(gy1.vezeteknev + ", " + gy1.eletkor);

            foreach (var szemely in szemelyek)
            {
                Console.WriteLine(szemely);
            }

            Console.ReadLine();
        }
    }
}
