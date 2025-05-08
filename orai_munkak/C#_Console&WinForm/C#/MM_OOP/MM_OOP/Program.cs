using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_OOP
{
    internal class Program
    {

        class Ember
        {
            public string Név;
            public int Életkor;
            public string Lakhely;
            public string Munkahely;
            public Ember(string név, int életkor, string lakhely, string munkahely)
            {
                this.Név = név; this.Életkor = életkor;
                this.Lakhely = lakhely; this.Munkahely = munkahely;
            }
            public void Kiír()
            {
                Console.WriteLine("Név:       " + Név);
                Console.WriteLine("Életkor:   " + Életkor);
                Console.WriteLine("Lakhely:   " + Lakhely);
                Console.WriteLine("Munkahely: " + Munkahely);
            }
        }

        static string emberadatgen()
        {
            Random random = new Random();

            Console.Write("add meg a doglozó nevét: ");
            string tempNev = Console.ReadLine();
            int tempeletkor = random.Next(17,65);

            string[] telepulesek = new string[] { "Aranyhegy", "Kecskemét", "Kiskunfélegyháza", "Kunszállás", "Gátér" };
            string templakhely = telepulesek[random.Next(0,telepulesek.Length)-1];

            Console.Write("add meg a munkahely cégnevét: ");
            string tempmunkahely = Console.ReadLine();

            return (tempNev, tempeletkor, templakhely, tempmunkahely,);
        }

        static void Main(string[] args)
        {
            string tempNev = "Tóth József";
            int tempeletkor = 12;
            string templakhely = "Eger";
            string tempmunkahely = "XY kft";
            Console.WriteLine();
            Ember cegvezeto = new Ember(tempNev, tempeletkor, templakhely, tempmunkahely);
            cegvezeto.Kiír();

            Ember dolgozo = new Ember(emberadatgen());
            emberadatgen();

            Console.ReadKey();
        }
    }
}
