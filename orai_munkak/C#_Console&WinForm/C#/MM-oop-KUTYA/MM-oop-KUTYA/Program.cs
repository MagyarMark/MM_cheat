using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_oop_KUTYA
{
    class Kutya
    {
        public string Név;
        private int ÉhségJelző = 50;

        public Kutya(string n, int éh)
        {
            this.Név = n; this.ÉhségJelző = éh;
        }
        public void Etet(int étel)
        {
            ÉhségJelző -= étel;
            Console.WriteLine($"{Név} kapott {étel} ételt");
        }
        public void Játék()
        {
            Console.WriteLine($"{Név} éhsége: {ÉhségJelző}");
            if (ÉhségJelző <= 80)
            {
                ÉhségJelző += 50;
                Console.WriteLine($"{Név} Játszik...");
            }
            else Console.WriteLine($"{Név} éhes, nem tudsz játszani vele!");
            Console.WriteLine($"{Név} éhsége: {ÉhségJelző}");
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Random random = new Random();
            Console.Write("Add meg a kutya nevét: ");
            var kutyanev = Console.ReadLine();
            var kutyaehseg = random.Next(90);
            Kutya k = new Kutya(kutyanev, kutyaehseg);
            k.Játék();
            k.Etet(random.Next(1,90));
            k.Játék();
            Console.ReadKey();
        }
    }
}
