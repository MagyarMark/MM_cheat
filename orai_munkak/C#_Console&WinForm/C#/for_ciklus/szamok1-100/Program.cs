using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamok1_100
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 2023.10.11
            // számok 1-100

            Console.WriteLine("Számok 1-100");
            Console.WriteLine("------------");

            for (int i = 1; i <= 100; i++) 
            {
                Console.Write($" " + i + ""); //
            }
                

            Console.ReadKey();

        }
    }
}
