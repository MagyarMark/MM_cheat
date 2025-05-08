using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Barlangok
{
    class Barlang
    {
        public int Hossz = 0;
        public int Melyseg = 0;
        public int hossz { get { return Hossz; } private set { if (value >= Hossz) Hossz = value; } }
        public int melyseg { get { return Melyseg; } private set { if (value >= Melyseg) Melyseg = value; } }
        public int azon {get; private set;}
        public string nev {get; private set;}
        public string telepules { get; private set; }
        public string vedettseg { get; private set; }

        public Barlang(string sor )
        {   
            string[] s = sor.Split(';');
            azon = int.Parse(s[0]);
            nev = s[1];
            hossz = int.Parse(s[2]);
            melyseg = int.Parse(s[3]);
            telepules = s[4];
            vedettseg = s[5];
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("barlangok.txt", encoding: Encoding.UTF8);
            List<string> barlangs = new List<string>();

            /*while (!sr.EndOfStream)
            {
                Console.WriteLine(sr.ReadLine());
            }
            sr.Close();*/

            try
            {
                sr = new StreamReader("barlangok.txt", encoding: Encoding.UTF8);
                while (!sr.EndOfStream)
                {
                    barlangs.Add(sr.ReadLine());
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.ToString());
            }



            /*Barlang a = new Barlang("1;Abaligeti-barlang;1893;10;Abaliget;fokozottan védett");
            a.Hossz = 1000;*/


            Console.ReadKey();
        }
    }
}
