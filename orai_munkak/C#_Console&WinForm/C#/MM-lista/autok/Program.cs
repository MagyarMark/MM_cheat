using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autok
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //MM - Autók
            //2023.12.13

            Console.WriteLine("|--------|");
            Console.WriteLine("|MM-Autók|");
            Console.WriteLine("|--------|");

            List<string> autok = new List<string>() { "Suzuki S-Cross", "Kia Ceed", "Toyota Yaris Cross", "Dacia Duster", "Suzuki Vitara", "Toyota Yaris", "Fiat 500", "Toyota C-HR", "Toyota Coroll", "Ford Tourneo Custom", "Fiat Ducato", "Skoda Octavia", "Dacia Jogger", "Renault Master", "Toyota RAV", "Toyota Hilux", "Ssangyong Korando", "Toyota Corolla Cross", "Kia Sportage", "Renault Clio" } ;
            autok.Sort();
            //Console.WriteLine(string.Join(System.Environment.NewLine, autok));

            using (StreamWriter file = new StreamWriter("autok.txt"))
            {
                file.WriteLine("|--------|");
                file.WriteLine("|MM-Autók|");
                file.WriteLine("|--------|");

                foreach (var auto in autok)
                {
                    file.WriteLine(auto);
                }
            }

            bool fut = true;

            while (fut)
            {

                List<string> autok2 = new List<string>() {"Opel Astra", "VW Golf", "Nissan Qashqai", "Tesla Model Y", "Volvo XC90"};

                Console.WriteLine("Jelenlegi Autók:");
                for (int i = 0; i < autok.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {autok[i]}");
                }

                Console.WriteLine();

                Console.WriteLine("Válasszon menüpontot!");
                Console.WriteLine("1 - Autó Hozzáadása ");
                Console.WriteLine("2 - Autó Törlése ");
                Console.WriteLine("3 - Összes Dacia márkájú autó törlése");
                Console.WriteLine($"4 - 2db autó hozzáadása ezek közül: {string.Join(System.Environment.NewLine, autok2)}");
                Console.WriteLine("5 - Tesla Model Y első helyre tétele");
                Console.WriteLine("0 - Kilépés");

                Console.Write("Menüpont száma: ");
                char menupont = Convert.ToChar(Console.ReadLine());

                switch (menupont)
                {
                    
                    case '1':
                        
                        Console.Write("Add meg az autó nevét: ");
                        autok.Add(Console.ReadLine());
                        break;

                    case '2':
                        Console.WriteLine("Melyik autót töröljük?");
                        Console.Write("Add meg az autó sorszámát: ");
                        autok.RemoveAt(int.Parse(Console.ReadLine()) - 1);
                        break;

                    case '3':
                        Console.WriteLine("Az összes Dacia autó törölve lett");
                        autok.Remove("Dacia Duster");
                        autok.Remove("Dacia Jogger");
                        break;

                    case '4':
                        Console.Write("Add meg az autó nevét: ");
                        autok.Add(Console.ReadLine());
                        Console.Write("Add meg az autó nevét: ");
                        autok.Add(Console.ReadLine());
                        break;

                    case '5':
                        Console.WriteLine("Az első helyre került");
                        autok.Insert(0,"Tesla Model Y");
                        break;

                    case '0':
                        fut = false;
                        break;

                    default:
                        break;
                }
                Console.Clear();

                using (StreamWriter file = new StreamWriter("autok2.txt"))
                {
                    file.WriteLine("|--------|");
                    file.WriteLine("|MM-Autók|");
                    file.WriteLine("|--------|");

                    foreach (var auto in autok2)
                    {
                        file.WriteLine(auto);
                    }
                }
            }

        }
    }
}
