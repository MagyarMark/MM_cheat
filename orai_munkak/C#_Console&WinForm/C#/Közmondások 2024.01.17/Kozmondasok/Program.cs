using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Kozmondasok
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var file1 = File.ReadAllLines("szoveg1.txt");
            List<string> list = new List<string>(file1);
            list.Sort();
            //Console.WriteLine(string.Join(System.Environment.NewLine, list));
            
            //Console.WriteLine("\n\n");

            var file2 = File.ReadAllLines("szoveg2.txt");
            List<string> list2 = new List<string>(file2);
            list2.Sort();
            //Console.WriteLine(string.Join(System.Environment.NewLine, list2));

            Console.WriteLine("1. feladat:");
            Console.WriteLine();
            Console.WriteLine("1. lista");
            foreach (string line in list)
            {
                Console.WriteLine("\t " + list.IndexOf(line) + "." + string.Join(System.Environment.NewLine, line));
            }
            Console.WriteLine($"összesen: {list.Count}");

            Console.WriteLine("\n");


            Console.WriteLine("2. lista");
            foreach (string line in list2)
            {
                Console.WriteLine($"\t " + list2.IndexOf(line) + "." + string.Join(System.Environment.NewLine, line));
            }
            Console.Write($"összesen: {list2.Count}");

            Console.WriteLine("\n");

            Console.WriteLine("2. feladat: ");
            string longest = list[0];

            //leghosszabb szöveg az első listában
            foreach (string s in list)
            {
                if (s.Length > longest.Length)
                {
                    longest = s;
                }
            }
            Console.WriteLine(longest);

            //leghosszabb szöveg a második listában
            string lonngest = list2[0];

            foreach (string s in list2)
            {
                if (s.Length > lonngest.Length)
                {
                    lonngest = s;
                }
            }
            Console.WriteLine(lonngest);

            Console.WriteLine("\n");

            //lista egyesítés
            Console.WriteLine("3. feladat: ");

            var egybe = file1.Concat(file2);
            Console.WriteLine(string.Join(System.Environment.NewLine, egybe));

            Console.WriteLine("\n");

            Console.WriteLine("4. feladat: ");
            Console.WriteLine(string.Join(System.Environment.NewLine, list));
            Console.WriteLine("\n");
            Console.WriteLine(string.Join(System.Environment.NewLine, list2));

            Console.WriteLine("\n");

            Console.WriteLine("5. feladat: ");
            using (Stream stream = new MemoryStream())
            {
                IFormatter formatter = new BinaryFormatter();

                formatter.Serialize(stream, list);
                Console.WriteLine(stream.Length);
            }

            Console.WriteLine("\n");

            Console.WriteLine("6. feladat: ");

            using (StreamWriter sw = new StreamWriter("kozmondasok.txt"))
            {
                sw.WriteLine(string.Join(System.Environment.NewLine, egybe));
            }


            Console.ReadKey();
        }
    }
}
