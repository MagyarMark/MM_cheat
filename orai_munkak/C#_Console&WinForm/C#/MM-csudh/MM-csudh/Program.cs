using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace MM_csudh
{
    internal class Program
    {
        class DomainInfo
        {
            public string DomainNév { get; set; }
            public string SzintRész(int szint)
            {
                string[] részek = DomainNév.Split('.');
                int mélység = részek.Length;

                if (szint <= 0 || szint > mélység)
                    return "nincs";

                return részek[mélység - szint];
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("2. feladat: ");
            var file = File.ReadAllLines("csudh.txt");
            List<string> list = file.ToList();
            list.RemoveAt(0);
            Console.WriteLine(string.Join(System.Environment.NewLine, list));// VARÁZS MONDAT

            Console.WriteLine();
            Console.WriteLine("3. feladat: Domainek száma: {0}", list.Count);
            Console.WriteLine("5. feladat: Az első domain felépítése: ");

            DomainInfo domainInfo = new DomainInfo();
            domainInfo.DomainNév = "edu.csudh.dhvx20";

            Console.WriteLine("\t1. szint: {0}", domainInfo.SzintRész(3));
            Console.WriteLine("\t2. szint: {0}", domainInfo.SzintRész(2));
            Console.WriteLine("\t3. szint: {0}", domainInfo.SzintRész(1));
            Console.WriteLine("\t4. szint: {0}", domainInfo.SzintRész(4));
            Console.WriteLine("\t5. szint: {0}", domainInfo.SzintRész(5));

            Console.ReadKey();

        }
    }
}
