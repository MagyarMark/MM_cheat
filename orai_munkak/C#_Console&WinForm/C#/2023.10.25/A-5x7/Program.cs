using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_5x7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //MM-2023.10.25
            //A-5x7

            Console.WriteLine("A-5x7");
            Console.WriteLine("-----");

            int[,] A = new int[5,7];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    A[i,j] = i+j;
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.Write(A[i,j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
