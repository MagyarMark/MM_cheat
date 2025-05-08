using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //MM-2023.10.25
            //Mátrix

            Console.WriteLine("Mátrix");
            Console.WriteLine("------");

            Random random = new Random();

            int[,] matrix = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = random.Next(1, 91);
                }
            }

            Console.WriteLine("5x5-ös mátrix:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.Write("Melyik sort szeretné kiíratni: ");
            int sor = int.Parse(Console.ReadLine()) - 1;

            Console.Write("Kiválasztott sor: ");
            for (int j = 0; j < 5; j++)
            {
                Console.Write(matrix[sor, j]);
                if (j < 4)
                    Console.Write(",");
            }
            Console.WriteLine();

            Console.Write("Melyik oszlopot szeretné kiíratni (1-5): ");
            int oszlop = int.Parse(Console.ReadLine()) - 1;

            Console.Write("Kiválasztott oszlop: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(matrix[i, oszlop]);
                if (i < 4)
                    Console.Write(",");
            }
            Console.WriteLine();

            Console.Write("Főátló: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(matrix[i, i]);
                if (i < 4)
                    Console.Write(",");
            }
            Console.WriteLine();
            
            Console.ReadKey();
        }
    }
}
