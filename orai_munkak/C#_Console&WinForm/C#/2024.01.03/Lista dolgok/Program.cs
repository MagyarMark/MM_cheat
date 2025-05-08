using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_dolgok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2024.01.03
            //MM-Lista Dolgok
            Console.WriteLine("|------------|");
            Console.WriteLine("|Lista Dolgok|");
            Console.WriteLine("|------------|");

            int[] tömb = new int[] { 20, 30, 12 };
            List<int> lista = new List<int>() { 18, 46, 91 } ;
            //lista.AddRange(tömb);

            /*for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }*/

            Console.WriteLine();
            lista.InsertRange(2, tömb);

            /*for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }*/

            foreach (int item in lista)
            {
                Console.WriteLine(item);
            }

            if (lista.Contains(18)) { Console.WriteLine("Van 18-as szám"); }

            Console.Write("Add meg a keresett számot: ");
            int szam = int.Parse(Console.ReadLine());

            int index = lista.IndexOf(szam);
            if (index != -1) 
            { 
                Console.WriteLine($"A {szam}. szám a(z) {index}. helyen van"); 
            }
            else 
            { 
                Console.WriteLine($" A {szam}. nincs a listában"); 
            }

            /*int[] mentes = lista.ToArray();

            foreach (int item in mentes)
            {
                Console.WriteLine(item);
            }*/

            Console.ReadKey();
        }
    }
}
