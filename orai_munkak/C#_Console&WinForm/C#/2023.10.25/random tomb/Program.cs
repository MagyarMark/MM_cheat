using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random_tomb
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //MM-2023.10.25
            //Random Tömb

            Console.WriteLine("Random Tömb");
            Console.WriteLine("-----------");

            double[,] mátrix = new double[5, 5];

            //Mátrix feltöltése randomolt számokkal !!-a mátrix nevű tömböt már létrehoztuk-!!
            Random r = new Random();
            for (int i = 0; i < mátrix.GetLength(0); i++)
            {
                for (int j = 0; j < mátrix.GetLength(1); j++)
                {
                    mátrix[i, j] = r.Next(100, 1000);
                }
            }

            Console.WriteLine();

            for (int i = 0; i < mátrix.GetLength(0); i++)
            {
                for (int j = 0; j < mátrix.GetLength(1); j++)
                {
                    Console.Write(mátrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
