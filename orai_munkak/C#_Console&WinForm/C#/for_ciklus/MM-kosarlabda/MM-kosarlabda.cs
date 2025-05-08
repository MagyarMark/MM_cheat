using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_kosarlabda
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 2023.10.11
            // MM-Kosarlabda

            Console.WriteLine("------------------------");
            Console.WriteLine("MM-Kosárlabda");
            Console.WriteLine("------------------------");

            int elso_dobas = 0;
            int masodik_dobas = 0;
            int harmadik_dobas = 0;
            int ossz_pont = 0;

            Console.WriteLine("Félegyházi Ördögök - Kecskeméti Angyalok");

            while (true)
            {
                Console.Write("dobás:");
                int dobas = Convert.ToInt32(Console.ReadLine());

                if (dobas == 0)
                    break;
                Console.WriteLine("dobás: ");
                int dobass = Convert.ToInt32(Console.ReadLine());

                switch (dobas)
                {
                    case 1:
                        elso_dobas += dobass;
                        break;
                    case 2:
                        masodik_dobas += dobass;
                        break;
                    case 3:
                        harmadik_dobas += dobass;
                        break;
                }

                int osszes_pont = elso_dobas + 2 * masodik_dobas * harmadik_dobas;
                Console.WriteLine($"Első dobás: " + elso_dobas);
                Console.WriteLine($"Második dobás: " + masodik_dobas);
                Console.WriteLine($"Harmadik dobás: " + harmadik_dobas);
                Console.WriteLine();
                ossz_pont += osszes_pont;

                Console.WriteLine("Félegyházi Ördögök - Kecskeméti Angyalok");
                Console.WriteLine($"Összes pontszám: " + ossz_pont);

                if (elso_dobas > ossz_pont)
                {
                    Console.WriteLine("A meccs győztese a hazai Félegyházi Ördögök!\r\n");
                }
                else if (ossz_pont < masodik_dobas)
                {
                    Console.WriteLine("A meccs győztese a vendég Kecskeméti Angyalok!\r\n");
                }
                else
                {
                    Console.WriteLine("A meccs döntetlenre végződött!");
                }
            }

            Console.ReadKey();
        }
    }
}
