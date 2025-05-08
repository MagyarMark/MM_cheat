using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int szam; 
            Console.Write("Adj meg egy egész számot (10-1000): ");
            szam = int.Parse(Console.ReadLine());

            Random random = new Random();
            int Rszam = random.Next(1, 1001);
            List<object> betu = new List<object>();
            betu.Add('a');
            betu.Add('b');
            betu.Add('c');

            Console.Write("Random szám és betű: "+ Rszam + "-");
            Console.WriteLine(string.Join(System.Environment.NewLine, betu[2]) + string.Join(System.Environment.NewLine, betu[1]));

            StreamWriter ki = new StreamWriter("adatok.dot", append: true);
            ki.Write("Random szám és betű: " + Rszam + "-");
            ki.WriteLine(string.Join(System.Environment.NewLine, betu[2]) + string.Join(System.Environment.NewLine, betu[1]));
            ki.Close();

            Console.ReadKey();
        }
    }
}
