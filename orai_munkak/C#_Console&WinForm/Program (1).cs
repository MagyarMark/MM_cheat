using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using System.Web;
namespace Feladat_1
{
    class kiosztas
    {
        public string azon;
        public string frekvencia;
        public string teljesitmeny;
        public string csatorna;
        public string adohely;
        public string cim = "";

        public kiosztas(string line)
        {
            try
            {
                string[] sz = line.Split('\t');
                frekvencia = sz[0];
                teljesitmeny = sz[1];
                csatorna = sz[2];
                adohely = sz[3];
                if (sz[4] != "") cim = sz[4];
            }
            catch 
            {
            }
        }
    }
    class telepules
    {
        public string nev;
        public string megye;
        public telepules(string line)
        {
            try
            {
                string[] sz = line.Split('\t');
                nev = sz[0];
                megye = sz[1];
            }
            catch
            {
            }
        }
    }    
    class regio
    {
        public string nev;
        public string megye;

        public regio(string line)
        {
            try
            {
                string[] sz = line.Split('\t');
                nev = sz[0];
                megye = sz[1];
            }
            catch
            {
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = new MySqlConnectionStringBuilder {Server = "127.0.0.1", UserID = "root", Password = ""};
            MySqlConnection kapcsolat = new MySqlConnection(builder.ConnectionString);
            var parancs = kapcsolat.CreateCommand();

            string tabla1 = "kiosztas";
            string tabla2 = "telepules";
            string tabla3 = "regio";

            string[] tabla1Adat = File.ReadAllLines(tabla1 + ".txt", Encoding.UTF8);
            string[] tabla2Adat = File.ReadAllLines(tabla2 + ".txt", Encoding.UTF8);
            string[] tabla3Adat = File.ReadAllLines(tabla3 + ".txt", Encoding.UTF8);

            parancs.CommandText = $"" +
                $"CREATE DATABASE IF NOT EXISTS radioadok CHARACTER SET utf8 COLLATE utf8_hungarian_ci;" +
                $"USE radioadok;"; 
                /*$"DROP TABLE IF EXISTS {tabla1}" +
                $"DROP TABLE IF EXISTS {tabla2}" +
                $"DROP TABLE IF EXISTS {tabla3};";*/
            string[] strings = tabla1Adat[0].Split('\t');
            parancs.CommandText += $"DROP TABLE IF EXISTS {tabla1};";
            parancs.CommandText += $"CREATE TABLE IF NOT EXISTS {tabla1} (azon INT NOT null, {strings[0]} FLOAT, {strings[1]} FLOAT, {strings[2]} VARCHAR(40), {strings[3]} VARCHAR(40), {strings[4]} VARCHAR(40), PRIMARY KEY (azon));";
            kapcsolat.Open();
            var reader = parancs.ExecuteReader();
            reader.Read();
            reader.Close();



            string[] strings2 = tabla2Adat[0].Split('\t');
            parancs.CommandText = $"DROP TABLE IF EXISTS {tabla2};";
            parancs.CommandText += $"CREATE TABLE IF NOT EXISTS {tabla2} ({strings2[0]} VARCHAR(40) PRIMARY KEY, {strings2[1]} VARCHAR(40));";
            reader = parancs.ExecuteReader();
            reader.Read();
            reader.Close();


            string[] strings3 = tabla3Adat[0].Split('\t');
            parancs.CommandText = $"DROP TABLE IF EXISTS {tabla3};";
            parancs.CommandText += $"CREATE TABLE IF NOT EXISTS {tabla3} ({strings3[0]} VARCHAR(40), {strings3[1]} VARCHAR(40) PRIMARY KEY);";
            reader = parancs.ExecuteReader();
            reader.Read();
            reader.Close();

            parancs.CommandText = "";
            for (int i = 1; i < tabla1Adat.Length; i++)
            {
                kiosztas tmp = new kiosztas(tabla1Adat[i]);
                if (tmp.csatorna != "hiba")
                {
                parancs.CommandText += $"INSERT INTO {tabla1} VALUES (";
                parancs.CommandText += i.ToString() + ",";
                parancs.CommandText += tmp.frekvencia + ",";
                parancs.CommandText += tmp.teljesitmeny + ",";
                parancs.CommandText += "'" + tmp.csatorna.Trim() + "',";
                parancs.CommandText += "'" + tmp.adohely.Trim() + "',";
                if (tmp.cim != "") parancs.CommandText += "'" + tmp.cim.Trim() + "');\n";
                else
                {
                    parancs.CommandText += "NULL);\n";
                }
                }
                
            }
            reader = parancs.ExecuteReader();
            reader.Read();
            reader.Close();



            parancs.CommandText = "";
            for (int i = 1; i < tabla2Adat.Length; i++)
            {
                telepules tmp = new telepules(tabla2Adat[i]);
                if (tmp.nev != "hiba")
                {       
                    parancs.CommandText += $"INSERT INTO {tabla2} VALUES (";
                    parancs.CommandText += "'" + tmp.nev.Trim() + "',";
                    parancs.CommandText += "'" + tmp.megye.Trim() + "');";
                }

            }
            reader = parancs.ExecuteReader();
            reader.Read();
            reader.Close();



            parancs.CommandText = "";
            for (int i = 1; i < tabla3Adat.Length; i++)
            {
                regio tmp = new regio(tabla3Adat[i]);
                if (tmp.nev != "hiba")
                {
                    parancs.CommandText += $"INSERT INTO {tabla3} VALUES (";
                    parancs.CommandText += "'" + tmp.nev.Trim() + "',";
                    parancs.CommandText += "'" + tmp.megye.Trim() + "');";
                }

            }
            reader = parancs.ExecuteReader();
            reader.Read();
            reader.Close();



            parancs.CommandText = $"ALTER TABLE {tabla1} ADD CONSTRAIN FOREIGN KEY(adohely) REFERENCES telepules(nev)";
            parancs.CommandText += $"ALTER TABLE {tabla2} ADD CONSTRAIN FOREIGN KEY(megye) REFERENCES regio(megye)";
            //reader = parancs.ExecuteReader();
            //reader.Read();
            //reader.Close();

            kapcsolat.Close();
            Console.ReadKey();
        }
    }
}
