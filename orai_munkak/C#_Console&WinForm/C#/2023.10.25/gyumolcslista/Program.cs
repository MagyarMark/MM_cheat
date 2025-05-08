using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyumolcslista
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //MM-2023.10.25
            //Gyümölcs Lista

            Console.WriteLine("Gyümölcs Lista");
            Console.WriteLine("--------------");

            string[,] gyumolcs = {
                {"alma","körte","banán"},
                {"meggy","cseresznye","barack"},
                {"szőlő","szilva","áfonya"},
            };

            string gyumolcslista = "";

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    gyumolcslista = gyumolcs[i, j];
                    Console.Write(gyumolcslista += ",");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
