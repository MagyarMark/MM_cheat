using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_focicsapat_vizsgalat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2023.10.11
            // for focicsapat vizsgalat

            Console.WriteLine("------------------------");
            Console.WriteLine("for focicsapat vizsgalat");
            Console.WriteLine("------------------------");

            Random random = new Random();
            int ossz_pulzus = 0;
            int vernyomas_szisz = 0;
            int vernyomas_dia = 0;

            int aktual_pulzus = 0;
            int aktual_vernyomas_szisz = 0;
            int aktual_vernyomas_dia = 0;

            int min_pulzus = 120;
            int min_vernyomas_szisz = 141;
            int min_vernyomas_dia = 111;

            int max_pulzus = 50;
            int max_vernyomas_szisz = 90;
            int max_vernyomas_dia = 60;

            for (int i = 1; i <= 11; i++)
            {
                Console.WriteLine($"A(z) " + i + "." + " jatekos: ");
                aktual_pulzus = random.Next(50, 121);
                aktual_pulzus += ossz_pulzus;
                if (aktual_pulzus < min_pulzus)
                {
                    min_pulzus = aktual_pulzus;
                }

                if (aktual_pulzus > max_pulzus)
                {
                    max_pulzus = aktual_pulzus;
                }

                aktual_vernyomas_dia = random.Next(60, 111);
                aktual_vernyomas_dia += vernyomas_dia;
                if (aktual_vernyomas_dia < min_vernyomas_dia)
                {
                    min_vernyomas_dia = aktual_vernyomas_dia;
                }

                if (aktual_vernyomas_dia > max_vernyomas_dia)
                {
                    max_vernyomas_dia = aktual_vernyomas_dia;
                }

                aktual_vernyomas_szisz = random.Next(90, 141);
                aktual_vernyomas_szisz += vernyomas_szisz;
                if (aktual_vernyomas_szisz < min_vernyomas_szisz)
                {
                    min_vernyomas_szisz = aktual_vernyomas_szisz;
                }

                if (aktual_vernyomas_szisz > max_vernyomas_szisz)
                {
                    max_vernyomas_szisz = aktual_vernyomas_szisz;
                }
                
                aktual_vernyomas_szisz += vernyomas_szisz;
                Console.WriteLine($"pulzusa: " + aktual_pulzus + "/perc, " + "vérnyomása: " + aktual_vernyomas_szisz + "/perc, " + " összehúzódás: " + aktual_vernyomas_dia + "/perc, ");
                Console.WriteLine();
                Console.WriteLine($"A játékosok átlag pulzusa: " + aktual_pulzus/11 + ". /perc");
                //Console.WriteLine($"A játékosok átlag vérnyomása(szisz): " + aktual_vernyomas_szisz/11 + ". hgmn, " + " átlag vérnyomása(dia): " + aktual_vernyomas_dia/11 + ". hgmn");
                Console.WriteLine($"A játékosok átlag vérnyomása(szisz/dia): {aktual_vernyomas_szisz/11}/{aktual_vernyomas_dia/11}. hgmn");
                Console.WriteLine();
                Console.WriteLine($"A játékosok minimum pulzusa: " + min_pulzus + ". /perc " );
                //Console.WriteLine($"A játékosok minimum vérnyomása(szisz): " + min_vernyomas_szisz + ". hgmn," + "minimum vérnyomása(dia): " + min_vernyomas_dia + ". hgmn");
                Console.WriteLine($"A játékosok minimum vérnyomás(szisz/dia): "+ min_vernyomas_szisz + "/" + min_vernyomas_dia + ". hgmn");
                Console.WriteLine();
                Console.WriteLine($"A játékosok maximum pulzusa: " + max_pulzus + ". /perc ");
                Console.WriteLine($"A játékosok maximum vérnyomása(szisz/dia): " + max_vernyomas_szisz + "/" + max_vernyomas_dia + ". hgmn");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
