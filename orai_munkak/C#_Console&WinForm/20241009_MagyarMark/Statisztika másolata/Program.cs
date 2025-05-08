using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Statisztika
{
    internal class Program
    {
        static List<data> fileRead(string path)
        {
            List<data> list = new List<data>();

            StreamReader sr = new StreamReader(path, Encoding.UTF8);
            while (!sr.EndOfStream)
            { /* átmeneti állomány = tmp */
                data tmp = new data(sr.ReadLine());
                if (tmp.playerID != -99)
                {
                    list.Add(tmp);
                }
            }
            sr.Close();
            return list;
        }
        static int feladat3(List <data> list)
        {
            int db = 0;
            foreach (var item in list)
            {
                if (item == null)
                {
                    continue;
                }
                if (item.types[2] == "D" && item.scores[2] == 25)
                {
                    db++;
                }
            }
            return db;
        }
        static int[] feladat4(List<data> list, string szektor)
        {
            int db = 0, db2 = 0;
            int db180 = 0, db2180 = 0;
            foreach (var item in list)
            {
                if (item == null)
                {
                    continue;
                }
                for (int i = 0; i < 3; i++)
                {
                    if (szektor == item.types[i] + item.scores[i].ToString() && item.playerID == 1)
                    {
                        db++;
                    }
                    else if (szektor == item.types[i] + item.scores[i].ToString() && item.playerID == 2)
                    {
                        db2++;
                    }
                }

                if (item.playerID == 1 && item.circlescores == 180)
                {
                    db180++;
                }
                if (item.playerID == 2 && item.circlescores == 180)
                {
                    db2180++;
                }

                
                /*
                if (item.playerID== 1 && 
                    item.types[0] == "T" && 
                    item.scores[0] == 20 && 
                    item.types[1] == "T" && 
                    item.scores[1] == 20 && 
                    item.types[2] == "T" && 
                    item.scores[2] == 20)
                {
                    db180++;
                }
                else if(item.playerID == 2 
                    && item.types[0] == "T" 
                    && item.scores[0] == 20 
                    && item.types[1] == "T" 
                    && item.scores[1] == 20 
                    && item.types[2] == "T" 
                    && item.scores[2] == 20)
                {
                    db2180++;
                }*/
                

            
            }
            int[] vissza = new int[] {db,db2,db180,db2180};
                return vissza;
        }
        class data
        {
            public int playerID;
            public string[] types = new string[3];
            public int[] scores = new int[3];
            public int[] Realscores = new int[3];
            public int circlescores;
            public data(string sor)
            {
                string[] strings = sor.Split(';');
                try
                {
                    this.playerID = int.Parse(strings[0]);
                    for (int i = 1; i < 4; i++)
                    {
                        if (strings[i][0] == 'D' || strings[i][0] == 'T')
                        {
                            this.types[i - 1] = strings[i][0].ToString();
                            if (strings[i][0] == 'D')
                            {
                                this.scores[i - 1] = int.Parse(strings[i].Substring(1));
                                this.Realscores[i - 1] = int.Parse(strings[i].Substring(1))*2;
                            }
                            else if (strings[i][0] == 'T')
                            {
                                this.scores[i - 1] = int.Parse(strings[i].Substring(1));
                                this.Realscores[i - 1] = int.Parse(strings[i].Substring(1))*3;
                            }
                        }
                        else
                        {
                            this.types[i - 1] = "";
                            this.scores[i - 1] = int.Parse(strings[i]);
                            this.Realscores[i - 1] = int.Parse(strings[i]);
                        }
                    }
                    this.circlescores = Realscores.Sum();
                }
                catch (Exception)
                {
                    this.playerID = -99;
                }
            }
        }
        static void Main(string[] args)
        {
            #region 1. feladat
            List<data> adatLista = fileRead("dobasok.txt");
            #endregion

            #region 2. feladat
            Console.WriteLine("2.feladat");
            Console.WriteLine("Körök száma: " +adatLista.Count);

            #endregion

            #region 3. feladat
            Console.WriteLine("3.feladat");
            Console.WriteLine("3. dobásra Bullseye(D25): " + feladat3(adatLista));
            #endregion

            #region 4. feladat
            Console.WriteLine("4.feladat");
            Console.Write("Adja meg a szektor értékét! Szektor= ");
            string szektor = Console.ReadLine();
            int[] ertekek = feladat4(adatLista,szektor);
            Console.WriteLine("Az 1. játékos a(z)" + szektor + "szektoros dobásainak száma: " + ertekek[0]);
            Console.WriteLine("Az 2. játékos a(z)" + szektor + "szektoros dobásainak száma: " + ertekek[1]);
            #endregion

            #region 5. feladat
            Console.WriteLine("5.feladat");
            Console.WriteLine("Az 1. játékos " + ertekek[2] + "db 180-ast dobott");
            Console.WriteLine("A 2. játékos " + ertekek[3] + "db 180-ast dobott");
            #endregion

            Console.ReadKey();
        }
    }
}
