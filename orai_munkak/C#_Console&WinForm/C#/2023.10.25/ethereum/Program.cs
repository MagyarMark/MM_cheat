using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ethereum
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //MM-2023.10.25
            //Ethereum

            Console.WriteLine("Ethereum");
            Console.WriteLine("--------");

            double et = 646383.66;
            Random rand = new Random();
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    double rand_valos = rand.NextDouble() * 100000 -100000;
                    et += rand_valos;
                    Console.WriteLine($"Dátum: {i:D2}-{j:D2}" + "\t");
                    Console.Write ($"Etherium:{et:N2}%");

                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
