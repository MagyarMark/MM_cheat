using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace Statisztika_Congui
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 2. feladat
            Console.WriteLine("2.feladat\n\tKörök száma: " + data.datas.Count);
            #endregion

            #region 3. feladat
            Console.WriteLine("3.feladat");
            Console.WriteLine("\t3.dobásra Bullseye(D25): " + eljarasok.feladat3());
            #endregion

            #region 4.feladat
            Console.WriteLine("4.feladat");
            Console.Write("\tAdja meg a szektor értékét! Szektor= ");
            string szektor = Console.ReadLine();

            int[] ints = eljarasok.feladat4(szektor);
            Console.WriteLine("\tAz 1. játékos a(z)" + szektor + "szektoros dobásainak száma: " + ints[0]);
            Console.WriteLine("\tAz 2. játékos a(z)" + szektor + "szektoros dobásainak száma: " + ints[1]);
            #endregion

            #region 5.feladat
            Console.WriteLine("5.feladat");
            Console.WriteLine("\tAz 1. játékos " + ints[2] + "db 180-ast dobott");
            Console.WriteLine("\tA 2. játékos " + ints[3] + "db 180-ast dobott");
            #endregion

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
