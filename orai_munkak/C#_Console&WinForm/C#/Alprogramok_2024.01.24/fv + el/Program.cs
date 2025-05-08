using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fv___el
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 6, b = 4, c;
            c = KétszeresétÖsszeadóFüggvény(a, b);
            Console.WriteLine("\'a\' értéke:{0}\n\'b\' értéke:{1}\n\'c\' értéke:{2}", a, b, c);
            //a: 6, b: 4, c: 20
            Console.ReadKey();
        }
        static int KétszeresétÖsszeadóFüggvény(int szam1, int szam2)
        {
            szam1 = szam1 * 2; szam2 = szam2 * 2;
            return szam1 + szam2;
        }

        /*
        static void Main(string[] args)
        {
            Udvozlet(); //nézzük meg mi lesz a kimenet ez és
            Udvozlet("Helló!"); //ez esetén (bele lett írva, nem jelenik meg a "Köszöntelek a programban!")
            Console.ReadKey();
        }
        static void Udvozlet(string s = "Köszöntelek a programban!") 
        { 
            Console.WriteLine(s); 
        }

        
        static void Main(string[] args)
        {
            Kiir();//Meghívás

            int i = Osszeg(); //Meghívás
            Console.WriteLine(i); //az i tartalma már 12

            int e = Példa(); //Meghívás
            Console.WriteLine(e); // az e tartalma már 5

            Console.ReadKey();
        }
        static void Kiir()
        { //Maga az alprogram
            Console.WriteLine("Üdvözöllek a programban! ");
        } //visszatérés

        static int Osszeg()
        {
            return 5 + 7;
        } // visszatérés int 12-vel

        static int Példa()
        {
            for (int e = 0; e < 10; e++)
            {
                if (e == 5) return e;
            }
            return 0;
        }
        */
    }
}
