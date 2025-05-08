using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_ettermek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2024.01.03
            //MM-Állatkert
            Console.WriteLine("|---------|");
            Console.WriteLine("|Állatkert|");
            Console.WriteLine("|---------|");
            List<string> bevetelek = new List<string>();
            //string[] lines;
            var list = new List<string>();
            var fileStream = new FileStream("bevetel.csv", FileMode.Open);

            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    bevetelek.Add(line);
                }
            }
            //lines = list.ToArray();

            string file = "bevetel.csv";
            String[] lines = File.ReadAllLines("bevetel.csv");
            int[] napiatlag = lines.Select(int.Parse).ToArray();
            int evesatlag = napiatlag.Sum();
            double avaregenapiatlag = napiatlag.Average();

            Console.WriteLine($"A teljes éves bevétel: {evesatlag}");
            Console.WriteLine($"Napi átlag: {avaregenapiatlag}");
            Console.WriteLine($"Hétvége bevétel átlaga: {evesatlag / avaregenapiatlag}");

            int result = file.Max();
            Console.WriteLine("Maximum: " + result);

            int result2 = file.Min();
            Console.WriteLine("Minimum: " + result2);
            Console.ReadKey();
        }
    }
}
