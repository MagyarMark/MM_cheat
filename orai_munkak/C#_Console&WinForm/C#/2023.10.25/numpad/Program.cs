using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numpad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MM-2023.10.25
            //NumPad

            Console.WriteLine("NumPad");
            Console.WriteLine("------");

            char[,] numpad = new char[2, 4];

            for (int i = 0; i < numpad.GetLength(0); i++)
            {
                for (int j = 0; j < numpad.GetLength(1); j++)
                {
                    Console.Write($"Add meg a(z) {i+1} sor {j+1} oszlopának karakterét: ");
                    numpad[i,j] = char.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();

            for (int i = 0; i < numpad.GetLength(0); i++)
            {
                for (int j = 0; j < numpad.GetLength(1); j++)
                {
                    Console.Write(numpad[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
