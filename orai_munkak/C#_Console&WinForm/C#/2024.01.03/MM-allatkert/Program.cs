using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_allatkert
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
            var file = File.ReadAllLines("budapesti_emlosok.csv");
            List<string> list = new List<string>(file);
            list.Sort();

            var file2 = File.ReadAllLines("veszpremi_emlosok.csv");
            List<string> list2 = new List<string>(file2);
            list2.Sort();

            Console.WriteLine("A Budapesti Állatkert emlős állatai: ");
            foreach (string line in list)
            {
                Console.WriteLine("\t " + list.IndexOf(line)+ "." + string.Join(System.Environment.NewLine, line));
            }
            Console.WriteLine($"összesen: {list.Count}");

            Console.WriteLine("\n\n\n");
            

            Console.WriteLine("A Veszprémi Állatkert emlős állatai: ");
            foreach (string line in list2)
            {
                Console.WriteLine($"\t " + list2.IndexOf(line) + "." + string.Join(System.Environment.NewLine, line));
            }
            Console.WriteLine($"összesen: {list2.Count}");
            
            Console.WriteLine("\n\n\n");

            Console.WriteLine("Egyesített lista: ");
            var combined = list.Concat(list2);
            Console.WriteLine("\t " + string.Join(System.Environment.NewLine, combined));

            Console.WriteLine("\n két állatkert Összesen: ");
            List<string> list3 = new List<string>(list.Union(list2));
            Console.WriteLine("\t "+string.Join(System.Environment.NewLine, list3.Count));
            

            Console.WriteLine("\n Mindkét állatkertben Összesen: ");
            Console.WriteLine("\t "+string.Join(System.Environment.NewLine, list3.Count-136));


            Console.ReadKey();
        }
    }
}
