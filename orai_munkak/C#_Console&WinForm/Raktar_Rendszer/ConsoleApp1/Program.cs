using System;
using System.Collections.Generic;
using System.Linq;

namespace KészletkezelőRendszer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Termék> termékek = new List<Termék>();
            List<Raktár> raktárak = new List<Raktár>();

            while (true)
            {
                Console.WriteLine("Főmenü:");
                Console.WriteLine("1. Termék hozzáadása");
                Console.WriteLine("2. Raktár hozzáadása");
                Console.WriteLine("3. Készletmozgás hozzáadása");
                Console.WriteLine("4. Termékek megtekintése");
                Console.WriteLine("5. Raktárak megtekintése");
                Console.WriteLine("6. Készletmozgások megtekintése");
                Console.WriteLine("7. Kilépés");

                Console.Write("Válasszon egy lehetőséget: ");
                int opció = Convert.ToInt32(Console.ReadLine());

                switch (opció)
                {
                    case 1:
                        TermékHozzáadása(termékek);
                        break;
                    case 2:
                        RaktárHozzáadása(raktárak);
                        break;
                    case 3:
                        KészletmozgásHozzáadása(termékek, raktárak);
                        break;
                    case 4:
                        TermékekMegtekintése(termékek);
                        break;
                    case 5:
                        RaktárakMegtekintése(raktárak);
                        break;
                    case 6:
                        KészletmozgásokMegtekintése(raktárak);
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Érvénytelen lehetőség. Kérjük, válasszon érvényes lehetőséget.");
                        break;
                }
            }
        }

        static void TermékHozzáadása(List<Termék> termékek)
        {
            Console.Write("Adja meg a termék nevét: ");
            string név = Console.ReadLine();

            Console.Write("Adja meg a termék mennyiségét: ");
            int mennyiség = Convert.ToInt32(Console.ReadLine());

            Termék termék = new Termék { Név = név, Mennyiség = mennyiség };
            termékek.Add(termék);

            Console.WriteLine("Termék sikeresen hozzáadva.");
        }

        static void RaktárHozzáadása(List<Raktár> raktárak)
        {
            Console.Write("Adja meg a raktár nevét: ");
            string név = Console.ReadLine();

            Console.Write("Adja meg a raktár kapacitását: ");
            int kapacitás = Convert.ToInt32(Console.ReadLine());

            Raktár raktár = new Raktár { Név = név, Kapacitás = kapacitás };
            raktárak.Add(raktár);

            Console.WriteLine("Raktár sikeresen hozzáadva.");
        }

        static void KészletmozgásHozzáadása(List<Termék> termékek, List<Raktár> raktárak)
        {
            Console.Write("Adja meg a termék nevét: ");
            string név = Console.ReadLine();

            Termék termék = termékek.Find(t => t.Név == név);
            if (termék == null)
            {
                Console.WriteLine("Termék nem található.");
                return;
            }

            Console.Write("Adja meg a raktár nevét: ");
            string raktárNév = Console.ReadLine();

            Raktár raktár = raktárak.Find(r => r.Név == raktárNév);
            if (raktár == null)
            {
                Console.WriteLine("Raktár nem található.");
                return;
            }

            Console.Write("Adja meg az áthelyezni kívánt mennyiséget: ");
            int mennyiség = Convert.ToInt32(Console.ReadLine());

            if (mennyiség > termék.Mennyiség)
            {
                Console.WriteLine("Érvénytelen mennyiség. A termék mennyisége kevesebb, mint az áthelyezni kívánt mennyiség.");
                return;
            }

            termék.Mennyiség -= mennyiség;
            raktár.Termékek.Add(termék);

            Console.WriteLine("Készletmozgás sikeresen hozzáadva.");
        }

        static void TermékekMegtekintése(List<Termék> termékek)
        {
            Console.WriteLine("Termékek:");
            foreach (var termék in termékek)
            {
                Console.WriteLine($"Név: {termék.Név}, Mennyiség: {termék.Mennyiség}");
            }
        }

        static void RaktárakMegtekintése(List<Raktár> raktárak)
        {
            Console.WriteLine("Raktárak:");
            foreach (var raktár in raktárak)
            {
                Console.WriteLine($"Név: {raktár.Név}, Kapacitás: {raktár.Kapacitás}");
                Console.WriteLine("Termékek:");
                foreach (var termék in raktár.Termékek)
                {
                    Console.WriteLine($"Név: {termék.Név}, Mennyiség: {termék.Mennyiség}");
                }
            }
        }

        static void KészletmozgásokMegtekintése(List<Raktár> raktárak)
        {
            Console.WriteLine("Készletmozgások:");
            foreach (var raktár in raktárak)
            {
                Console.WriteLine($"Név: {raktár.Név}");
                Console.WriteLine("Termékek:");
                foreach (var termék in raktár.Termékek)
                {
                    Console.WriteLine($"Név: {termék.Név}, Mennyiség: {termék.Mennyiség}");
                }
            }
        }
    }

    class Termék
    {
        public string Név { get; set; }
        public int Mennyiség { get; set; }
    }

    class Raktár
    {
        public string Név { get; set; }
        public int Kapacitás { get; set; }
        public List<Termék> Termékek { get; set; }

        public Raktár()
        {
            Termékek = new List<Termék>();
        }
    }
}
