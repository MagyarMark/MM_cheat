using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.feladat
{
    internal class Program
    {
        static void tomb(int[] tomb, int mettol, int meddig)
        {
            Random rnd = new Random();
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rnd.Next(mettol, meddig);
            }
            Array.Sort(tomb);
            
        }
        static void Main(string[] args)
        {
            int tomb_elem = 10;
            int[] tombb = new int[tomb_elem];
            tomb(tombb, 1,50);
            Console.Write(string.Join(System.Environment.NewLine, tombb));

            Console.ReadKey();
        }
    }
}
