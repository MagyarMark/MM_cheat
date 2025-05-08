using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;
using System.Windows.Forms;

namespace barlangok
{
    class Barlang
    {
        private int Melyseg = 0;
        private int Hossz = 0;
        public int hossz { get { return Hossz; } set { if (value >= Hossz || value >= 0) Hossz = value; } }
        public int melyseg { get { return Melyseg; } set { if (value >= 0) Melyseg = value; } }
        public int azon { get; set; }
        public string nev { get; set; }
        public string telepules { get; set; }
        public string vedettseg { get; set; }

        public Barlang(string line)
        {
            try
            {
                string[] strings = line.Split(';');
                hossz = int.Parse(strings[2]);
                melyseg = int.Parse(strings[3]);
                azon = int.Parse(strings[0]);
                nev = strings[1];
                telepules = strings[4];
                vedettseg = strings[5];
            }
            catch (Exception)
            {
                Hossz = 0;
            }

        }
        public override string ToString()
        {
            return $"\tAzon: {azon}\n\tNév: {nev}\n\tHossz: {hossz} m\n\tMélység: {melyseg} m\n\tTelepülés: {telepules}";
        }
    }


    internal class Program
    {
        static public List<Barlang> barlangs = new List<Barlang>();
        static void Main(string[] args)
        {
            System.IO.StreamReader sr = new System.IO.StreamReader("barlangok.txt", encoding: Encoding.UTF8);

            while (!sr.EndOfStream)
            {
                Barlang tmp = new Barlang(sr.ReadLine());
                if (tmp.hossz != 0) barlangs.Add(tmp);
            }
            sr.Close();

            Console.WriteLine($"4. feladat: Barlangok száma: {barlangs.Count}");

            int db = 0;
            int melysegek = 0;
            foreach (var item in barlangs)
            {
                if (item.telepules.StartsWith("Miskolc"))
                {
                    db++;
                    melysegek += item.melyseg;
                }
            }
            Console.WriteLine($"3. feladat: Az átlagos mélység: {((double)melysegek / (double)db):#.###}");

            Console.Write("6. feladat: Kérem a védettségi szintet: ");
            goto ide;
            string vedettsegBe = Console.ReadLine();
            int legh = 0;
            int leghIndex = 0;

            for (int i = 0; i < barlangs.Count; i++)
            {
                if (barlangs[i].hossz > legh && barlangs[i].vedettseg == vedettsegBe)
                {
                    legh = barlangs[i].hossz;
                    leghIndex = i;
                }
            }
            if (legh != 0) Console.WriteLine(barlangs[leghIndex].ToString());
            else Console.WriteLine("Nincs ilyen védettségi szinttel barlang az adatok között!");
            ide:
            Console.WriteLine("5. feladat: Statisztika");
            SortedSet<string> vedettsegek = new SortedSet<string>();
            foreach (var item in barlangs)
            {
                vedettsegek.Add(item.vedettseg);
            }

            int vHossz = 0;
            foreach (var item in vedettsegek)
            {
                if (item.Length > vHossz) 
                {
                    vHossz = item.Length;
                }
                vHossz += 4;
            }

            foreach (var aktualisVedettseg in vedettsegek)
            {
                int db2 = 0;
                foreach(var item in barlangs)
                {
                    if (item.vedettseg == aktualisVedettseg)
                    {
                        db2++;
                    }
                    
                }
                string kiirando = "\t" +aktualisVedettseg + ":";
                for(int i = kiirando.Length; i <= vHossz; i++) 
                {
                    kiirando += "-";
                    
                }
                kiirando += "> " + db2.ToString() + " db";
                Console.WriteLine(kiirando);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
