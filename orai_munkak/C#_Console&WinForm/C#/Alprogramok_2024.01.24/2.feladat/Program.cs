using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.feladat
{
    internal class Program
    {
        static void fahrenheit()
        {
            Console.Write("Add meg a hömérsékeletet: ");

            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahren = (celsius * 9 / 5 + 32);
            Console.Write($"A hőméréséklet fahrenheit fokban: {celsius}°C -> {fahren}°F");
        }
        static void Main(string[] args)
        {

            fahrenheit();

            Console.ReadKey();
        }
    }
}
