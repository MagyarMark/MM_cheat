using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace téglalap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // MM- 2023-09-20
            //Téglalap kerülete és területe

            Console.WriteLine("Téglalap kerülete és területe");
            Console.WriteLine("-----------------------------");

            Console.Write("Add meg a téglalap alap oldalának hosszát: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Add meg a téglalap b oldalának hosszát: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("A = " + a);
            Console.WriteLine("B = " + b);

            Console.Write("A téglalap kerülete: ");
            Console.WriteLine(2 * (a + b) + " cm");
            Console.Write("A téglalap területe: ");
            Console.WriteLine(a * b + " cm2");
            Console.ReadKey();
        }
    }
}
