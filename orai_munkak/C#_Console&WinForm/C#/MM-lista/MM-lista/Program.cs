using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_lista
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //MM - lista
            //2023.12.13

            Console.WriteLine("|--------|");
            Console.WriteLine("|MM-Lista|");
            Console.WriteLine("|--------|");

            /*
            List<int> lista = new List<int>();
            lista.Add(12);
            lista.Add(2);
            lista.Add(43);

            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                lista.Add(rnd.Next(100));
            }

            Console.WriteLine("Kapacítása: " + lista.Capacity);
            Console.WriteLine("Mérete: " + lista.Count);

            foreach (int item in lista)
            {
                Console.Write(item + ", ");
            }
            */

            List<string> jatekok = new List<string>() { "GTA VI", "God of War", "Shadow of Mordor", "Quake III" };
            jatekok.Sort();

            bool fut = true;

            while (fut)
            {

                Console.WriteLine("Jelenlegi játékok:");
                for (int i = 0; i < jatekok.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {jatekok[i]}");
                }

                Console.WriteLine();

                Console.WriteLine("Válasszon menüpontot!");
                Console.WriteLine("1 - játék Hozzáadása ");
                Console.WriteLine("2 - játék Törlése ");
                Console.WriteLine("0 - Kilépés");

                Console.Write("Menüpont száma: ");
                char menupont = Convert.ToChar(Console.ReadLine());

                switch (menupont)
                {
                    case '1':
                        Console.Write("Add meg a játék nevét: ");
                        jatekok.Add(Console.ReadLine());
                        break;

                    case '2':
                        Console.WriteLine("Melyik játékot töröljük?");
                        Console.Write("Add meg a játék sorszámát: ");
                        jatekok.RemoveAt(int.Parse(Console.ReadLine()) - 1);
                        break;

                    case '0':
                        fut = false;
                        break;

                    default:
                        break;
                }
                Console.Clear();
            }
            Console.WriteLine();

            /*
            foreach (string jateknev in jatekok)
            {
                Console.WriteLine(jateknev + " ");
            }
            */

            /*
            jatekok.Insert(2,"WoW");//WoW beszúrása a 2. helyre a listába
            jatekok.Remove("God of War");//Gof of War törlése a listából
            jatekok.RemoveAt(0);//Lista index alapon törli GTA VI = 0 index
            jatekok.Clear();//teljes lista törlése
            */

            /*
            for (int i = 0; i < jatekok.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {jatekok[i]}");
            }
            */

            Console.ReadKey();

        }
    }
}
