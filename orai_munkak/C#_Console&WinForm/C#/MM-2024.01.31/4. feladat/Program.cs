using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.feladat
{
    internal class Program
    {
        static Tuple<List<int>, List<int>> parosparatlanlistak(List<int> szamok)
        {
            List<int> parosszamok = new List<int>();
            List<int> paratlanszamok = new List<int>();

            foreach (var szam in szamok)
            {
                if (szam == 2)
                {
                    parosszamok.Add(szam);
                }
                else
                {
                    paratlanszamok.Add(szam);
                }
            }

            return Tuple.Create(paratlanszamok, parosszamok);
        }
        static void Main(string[] args)
        {
            List<int> szamok = new List<int>{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var eredmenyek = parosparatlanlistak(szamok);
            Console.WriteLine("Páros számok: " + string.Join(", ",eredmenyek.Item1));
            Console.WriteLine("Páratlan számok: " + string.Join(", ",eredmenyek.Item2));
            
            Console.ReadKey();
        }
    }
}
