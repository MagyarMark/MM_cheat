using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_ut_eredmenyek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                //MM - ut
                //2023.12.13

                Console.WriteLine("|-----|");
                Console.WriteLine("|MM-ut|");
                Console.WriteLine("|-----|");

                //string[] nevek = new string[10] { "Sherlyn Wells", "Niko Bates", "Gemma Pena", "Jean Mccall", "Kelly Coffey", "Quincy Grimes", "Marcus Hudson", "Kadin Curry", "Roy Lewis", "Caroline Reese" };

                //Console.WriteLine(string.Join(System.Environment.NewLine, nevek));

                //string nev = " " + rand.Next(1,10);

                //Console.WriteLine(string.Join(System.Environment.NewLine, nevek) + nev);

                List<string> nevek = new List<string>() { "Sherlyn Wells", "Niko Bates", "Gemma Pena", "Jean Mccall", "Kelly Coffey", "Quincy Grimes", "Marcus Hudson", "Kadin Curry", "Roy Lewis", "Caroline Reese" };
                nevek.Sort();

                using (StreamWriter file = new StreamWriter("UrbanTerror.txt"))
                {
                    file.WriteLine("|--------------|");
                    file.WriteLine("|MM-UrbanTerror|");
                    file.WriteLine("|--------------|");

                    foreach (var nevv in nevek)
                    {
                        file.WriteLine(nevv);
                    }
                }

                Random rand = new Random();
                //int score = rand.Next(0, 150);
                //Console.WriteLine(score);

                int score1 = rand.Next(0, 150);
                int score2 = rand.Next(0, 150);
                int score3 = rand.Next(0, 150);
                int score4 = rand.Next(0, 150);
                int score5 = rand.Next(0, 150);
                int score6 = rand.Next(0, 150);
                int score7 = rand.Next(0, 150);
                int score8 = rand.Next(0, 150);
                int score9 = rand.Next(0, 150);
                int score10 = rand.Next(0, 150);

                int Ascore = rand.Next(0, 150);
                int Bscore = rand.Next(0, 150);

                int ctf = rand.Next(0,150);
                int ctfscore = rand.Next(0, 150);

                string[] nev = { "Sherlyn Wells", "Niko Bates", "Gemma Pena", "Jean Mccall", "Kelly Coffey", "Quincy Grimes", "Marcus Hudson", "Kadin Curry", "Roy Lewis", "Caroline Reese" };
                int csapat = nev.Length / 2;
                string[] teamA = new string[csapat];
                string[] teamB = new string[csapat];

                bool fut = true;

                while (fut)
                {

                    Console.WriteLine("nevek:");
                    for (int i = 0; i < nevek.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {nevek[i]}");
                    }

                    Console.WriteLine();

                    Console.WriteLine("Válasszon menüpontot!");
                    Console.WriteLine("1 - Free for All (FFA)\r\n ");
                    Console.WriteLine("2 - Team Deathmatch (TDM)\r\n ");
                    Console.WriteLine("3 - Capture the Flag (CTF)\r\n ");
                    Console.WriteLine("4 - Bomb & Defuse (BM)\r\n ");
                    Console.WriteLine("0 - Kilépés");

                    Console.Write("Menüpont száma: ");
                    char menupont = Convert.ToChar(Console.ReadLine());

                    switch (menupont)
                    {

                        case '1':
                            Console.Write("\nFFA: ");
                            Console.WriteLine();
                            Console.WriteLine("1. Játékos: " + nevek[rand.Next(1, 10)] + " Pontszáma: " + score1);
                            Console.WriteLine("2. Játékos: " + nevek[rand.Next(1, 10)] + " Pontszáma: " + score2);
                            Console.WriteLine("3. Játékos: " + nevek[rand.Next(1, 10)] + " Pontszáma: " + score3);
                            Console.WriteLine("4. Játékos: " + nevek[rand.Next(1, 10)] + " Pontszáma: " + score4);
                            Console.WriteLine("5. Játékos: " + nevek[rand.Next(1, 10)] + " Pontszáma: " + score5);
                            Console.WriteLine("6. Játékos: " + nevek[rand.Next(1, 10)] + " Pontszáma: " + score6);
                            Console.WriteLine("7. Játékos: " + nevek[rand.Next(1, 10)] + " Pontszáma: " + score7);
                            Console.WriteLine("8. Játékos: " + nevek[rand.Next(1, 10)] + " Pontszáma: " + score8);
                            Console.WriteLine("9. Játékos: " + nevek[rand.Next(1, 10)] + " Pontszáma: " + score9);
                            Console.WriteLine("10.Játékos: " + nevek[rand.Next(1, 10)] + " Pontszáma: " + score10);

                            if (score1 >= score2)
                            {
                                Console.WriteLine("1. Játékos nyert");
                            }
                            if (score2 >= score3)
                            {
                                Console.WriteLine("2. játékos nyert");
                            }
                            if (score3 >= score4)
                            {
                                Console.WriteLine("3. Játékos nyert");
                            }
                            if (score4 >= score5)
                            {
                                Console.WriteLine("4. játékos nyert");
                            }
                            if(score5 >= score6)
                            {
                                Console.WriteLine("5. játékos nyert");
                            }
                            if (score6 >= score7)
                            {
                                Console.WriteLine("6. játékos nyert");
                            }
                            if (score7 >= score8)
                            {
                                Console.WriteLine("7.játékos nyert");
                            }
                            if (score8 >= score9)
                            {
                                Console.WriteLine("8.játékos nyert");
                            }
                            if (score9 >= score10)
                            {
                                Console.WriteLine("9. játékos nyert");
                            }
                            else
                            {
                                Console.WriteLine("Döntetlen");
                            }
                            break;

                        case '2':
                            Console.WriteLine("\nTDM: ");
                            Console.Write("Válassz csapatot(A / B): ");
                            Console.ReadLine();
                            

                            for (int i = 0; i < csapat; i++)
                            {
                                teamA[i] = nev[i];
                                teamB[i] = nev[i + csapat];
                            }
                            Console.WriteLine("Csapatok: ");
                            Console.WriteLine();
                            Console.WriteLine("Team A: ");
                            foreach (string jatekos in teamA)
                            {
                                Console.WriteLine(jatekos);
                            }
                            Console.WriteLine("A csapat pontszáma: " + Ascore);

                            Console.WriteLine();

                            Console.WriteLine("Team B:");
                            foreach (string jatekos in teamB)
                            {
                                Console.WriteLine(jatekos);
                            }
                            Console.WriteLine("B csapat pontszáma: " + Bscore);

                            Console.WriteLine();

                            if (Ascore >= Bscore)
                            {
                                Console.WriteLine("Az A csapat nyerte a Team Deathmatch játékot!");
                            }
                            else
                            {
                                Console.WriteLine("B csapat nyerte a Team Deathmatch játékot!");
                            }
                            break;

                        case '3':
                            Console.WriteLine("CTF: ");
                            Console.Write("Válassz csapatot(A / B): ");

                            for (int i = 0; i < csapat; i++)
                            {
                                teamA[i] = nev[i];
                                teamB[i] = nev[i + csapat];
                            }
                            Console.WriteLine("Csapatok: ");
                            Console.WriteLine();
                            Console.WriteLine("Team B: ");
                            foreach (string jatekos in teamB)
                            {
                                Console.WriteLine(jatekos);
                            }
                            Console.WriteLine("B csapat pontszáma: " + ctfscore);

                            Console.WriteLine();

                            Console.WriteLine("Team A:");
                            foreach (string jatekos in teamA)
                            {
                                Console.WriteLine(jatekos);
                            }
                            Console.WriteLine("A csapat pontszáma: " + ctf);

                            if (ctf >= ctfscore)
                            {
                                Console.WriteLine("Az A csapat nyerte a Capture the Flag játékot tovább bírtokolták a zászlót mint az ellenfél!");
                            }
                            else
                            {
                                Console.WriteLine("B csapat nyerte a Capture the Flag játékot tovább bírtokolták a zászlót mint az ellenfél!");
                            }

                            break;

                        case '4':
                            Console.WriteLine("BM: ");
                            Console.WriteLine("?");
                            break;

                        case '0':
                            fut = false;
                            break;

                        default:
                            break;
                    }
                    //Console.Clear();

                    Console.ReadKey();
                }
            }
        }
    }
}

