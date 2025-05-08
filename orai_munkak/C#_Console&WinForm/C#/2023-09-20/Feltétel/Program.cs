using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feltétel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // MM- 2023-09-20
            //Feltétel vizsgálat

            Console.WriteLine("Feltétel vizsgálat");
            Console.WriteLine("------------------");

            Console.Write("Add meg az életkorodat: ");

            int eletkor = int.Parse(Console.ReadLine());

            if (eletkor >= 18)
            {
                Console.WriteLine("vehetsz sört");
            else
                {
                    Console.WriteLine("Nem vehetsz sört");
                }
            }

            Console.ReadKey();
        }
    }
}
