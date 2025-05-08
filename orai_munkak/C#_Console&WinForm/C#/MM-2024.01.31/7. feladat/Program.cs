using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.feladat
{
    internal class Program
    {
        static string FB(int szam) 
        {
            if (szam % 3 == 0 && szam % 5 == 0) 
            {
                return "FizzBuzz";
            }
            else if (szam % 3 == 0) 
            {
                return "Fizz";
            }
            else if(szam % 5 == 0) 
            {
                return "Buzz";
            }
            else
            {
                szam.ToString();
            }
            return szam.ToString();
        }
        static void Main(string[] args)
        {
            for (int i = 1; i <= 15; i++)
            {
                string eredmeny = FB(i);
                Console.WriteLine(eredmeny);
            }

            Console.ReadKey();
        }
    }
}
