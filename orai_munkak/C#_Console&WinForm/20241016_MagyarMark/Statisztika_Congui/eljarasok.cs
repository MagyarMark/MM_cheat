using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Statisztika_Congui
{
    class eljarasok
    {
        static public List<data> fileRead(string path)
        {
            List<data> lista = new List<data>();

            StreamReader sr = new StreamReader(path, Encoding.UTF8);

            while (!sr.EndOfStream)
            { /* átmeneti állomány = tmp */
                data tmp = new data(sr.ReadLine());
                if (tmp.playerID != -99)
                {
                    lista.Add(tmp);
                }
            }
            sr.Close();

            return lista;
        }

        static public int feladat3()
        {
            int db = 0;
            foreach (var item in data.datas)
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

        static public int[] feladat4(string béla)
        {
            int db = 0;
            int db2 = 0;
            int db180 = 0;
            int db2180 = 0;

            foreach (var item in data.datas)
            {
                if (item == null)
                {
                    continue;
                }
                for (int i = 0; i < 3; i++)
                {
                    if (béla == item.types[i] + item.scores[i].ToString() && item.playerID == 1)
                    {
                        db++;
                    }
                    else if (béla == item.types[i] + item.scores[i].ToString() && item.playerID == 2)
                    {
                        db2++;
                    }
                }
                if (item.playerID == 1 && item.circlescores == 180)
                {
                    db180++;
                }
                else if(item.playerID == 2 && item.circlescores == 180)
                {
                    db2180++;
                }
            }
            int[] vissza = new int[] { db, db2, db180, db2180 };
            return vissza;
        }
    }
}
