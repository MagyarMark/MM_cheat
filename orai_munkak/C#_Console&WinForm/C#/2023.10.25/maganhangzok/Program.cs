using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maganhangzok
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //MM-2023.10.25
            //Magánhangzók

            Console.WriteLine("Magánhangzók");
            Console.WriteLine("------------");

            char[] maganhangzok = { 'a', 'e', 'i', 'o', 'u' };
            char[,] igen = new char[10,10];
            Random random = new Random();

            for (int i = 0; i < igen.GetLength(0); i++)
            {
                for (int j = 0; j < igen.GetLength(1); j++)
                {
                    int k = random.Next(maganhangzok.Length);
                    igen[i,j] = maganhangzok[k];
                    Console.Write(igen[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
