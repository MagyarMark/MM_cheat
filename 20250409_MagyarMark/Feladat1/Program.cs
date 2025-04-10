﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MySqlConnector;
using System.Diagnostics;

namespace Feladat1
{
    class kiosztas
    {
        public string /* int */ azon;//kulcs
        public string /*float*/ frekvencia;
        public string /*float*/ teljesitmeny;
        public string csatorna;
        public string adohely;
        public string cim = "";

        public kiosztas(string sor)
        {
            try
            {
                string[] sz = sor.Split('\t');
                frekvencia = sz[0];
                teljesitmeny = sz[1];
                csatorna = sz[2];
                adohely = sz[3];
                if (sz[4] != "")
                {
                    cim = sz[4];
                }
            }
            catch (Exception) { }
        }
    }

    class telepules
    {
        public string nev;//kulcs
        public string megye;

        public telepules(string[] sor)
        {
            nev = sor[0];
            megye = sor[1];
        }
    }

    class regio
    {
        public string nev;
        public string megye;//kulcs

        public regio(string[] sor)
        {
            nev = sor[0];
            megye = sor[1];
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var build = new MySqlConnectionStringBuilder
            {
                Server = "127.0.0.1",
                UserID = "root",
                Password = ""
                //Database = "radioado"
            };
            MySqlConnection kapcsolat = new MySqlConnection(build.ConnectionString);
            var parancs = kapcsolat.CreateCommand();
            string tabla1 = "kiosztas";
            string tabla2 = "telepules";
            string tabla3 = "regio";

            string[] adat1tabla = File.ReadAllLines(tabla1 + ".txt", encoding: Encoding.UTF8);
            string[] adat2tabla = File.ReadAllLines(tabla2 + ".txt", encoding: Encoding.UTF8);
            string[] adat3tabla = File.ReadAllLines(tabla3 + ".txt", encoding: Encoding.UTF8);

            string[] oszlopok = adat1tabla[0].Split('\t');
            parancs.CommandText = $"CREATE DATABASE IF NOT EXISTS radioado CHARACTER SET utf8 COLLATE utf8_hungarian_ci; " +
                      $"USE radioado; " +
                      $"DROP TABLE IF EXISTS {tabla1}; " +
                      $"CREATE TABLE IF NOT EXISTS {tabla1} (azon INT NOT NULL, {oszlopok[0]} FLOAT, " +
                      $"{oszlopok[1]} FLOAT, {oszlopok[2]} VARCHAR(255), {oszlopok[3]} VARCHAR(255), " +
                      $"{oszlopok[4]} VARCHAR(255), PRIMARY KEY (azon));";
            Debug.WriteLine(parancs.CommandText);
            kapcsolat.Open();
            var reader = parancs.ExecuteReader();
            reader.Read();
            reader.Close();

            string[] oszlopok2 = adat2tabla[0].Split('\t');
            parancs.CommandText = $"DROP TABLE IF EXISTS {tabla2}";
            parancs.CommandText = $"CREATE TABLE IF NOT EXISTS {tabla2} ({oszlopok2[0]} VARCHAR(255), {oszlopok2[1]} TEXT, PRIMARY KEY (nev))";
            //Debug.WriteLine(parancs.CommandText);
            reader = parancs.ExecuteReader();
            reader.Read();
            reader.Close();

            string[] oszlopok3 = adat3tabla[0].Split('\t');
            parancs.CommandText = $"DROP TABLE IF EXISTS {tabla3}";
            parancs.CommandText = $"CREATE TABLE IF NOT EXISTS {tabla3} ({oszlopok3[0]} VARCHAR(255), {oszlopok3[1]} VARCHAR(255), PRIMARY KEY (megye))";
            //Debug.WriteLine(parancs.CommandText);
            reader = parancs.ExecuteReader();
            reader.Read();
            reader.Close();

            for (int i = 1; i < adat1tabla.Length; i++)
            {
                kiosztas tmp = new kiosztas(adat1tabla[i]);
                if (tmp.csatorna != "hiba")
                {
                    parancs.CommandText = $"INSERT INTO {tabla1} VALUES (@id, @frekvencia, @teljesitmeny, @csatorna, @adohely, @cim)";
                    parancs.Parameters.Clear();
                    parancs.Parameters.AddWithValue("@id", i);
                    parancs.Parameters.AddWithValue("@frekvencia", tmp.frekvencia);
                    parancs.Parameters.AddWithValue("@teljesitmeny", tmp.teljesitmeny);
                    parancs.Parameters.AddWithValue("@csatorna", tmp.csatorna.Trim());
                    parancs.Parameters.AddWithValue("@adohely", tmp.adohely.Trim());
                    if (tmp.cim == "NULL")
                    {
                        parancs.Parameters.AddWithValue("@cim", DBNull.Value);
                    }
                    else
                    {
                        parancs.Parameters.AddWithValue("@cim", tmp.cim.Trim());
                    }

                    reader = parancs.ExecuteReader();
                    reader.Read();
                    reader.Close();
                }
            }

            for (int i = 1; i < adat2tabla.Length; i++)
            {
                string[] tmp = adat2tabla[i].Split('\t');
                parancs.CommandText = $"INSERT INTO {tabla2} VALUES (@nev, @megye) ON DUPLICATE KEY UPDATE megye = VALUES(megye)";
                parancs.Parameters.Clear();
                parancs.Parameters.AddWithValue("@nev", tmp[0]);
                parancs.Parameters.AddWithValue("@megye", tmp[1]);
                reader = parancs.ExecuteReader();
                reader.Read();
                reader.Close();
            }


            for (int i = 1; i < adat3tabla.Length; i++)
            {
                string[] tmp = adat3tabla[i].Split('\t');
                parancs.CommandText = $"INSERT INTO {tabla3} VALUES (@nev, @megye) ON DUPLICATE KEY UPDATE megye = VALUES(megye)";
                parancs.Parameters.Clear();
                parancs.Parameters.AddWithValue("@nev", tmp[0]);
                parancs.Parameters.AddWithValue("@megye", tmp[1]);
                reader = parancs.ExecuteReader();
                reader.Read();
                reader.Close();
            }

            /*//kiosztas = k, telepules = t, regio = r, táblák összekapcsolása
            parancs.CommandText = $"UPDATE {tabla1} k " +
                                  $"JOIN {tabla2} t ON k.adohely = t.nev " +
                                  $"JOIN {tabla3} r ON t.megye = r.megye "/* +
                                  $"SET r.megye = k.adohely"*/;

            parancs.CommandText = "ALTER TABLE kiosztas ADD CONSTRAINT FOREIGN KEY (adohely) REFERENCES telepules(nev);";
            parancs.CommandText += "ALTER TABLE telepules ADD CONSTRAINT FOREIGN KEY (megye) REFERENCES regio(megye);";

            Console.WriteLine("Sikeres feltöltés 😁😁");
            //2. feladat: 
            parancs.CommandText = $"SELECT cim, adohely FROM {tabla1} WHERE adohely LIKE '%Budapest%' ORDER BY cim;";
            reader = parancs.ExecuteReader();
            while (reader.Read())
            {
                Debug.WriteLine($"cim: {reader.GetString(0)}, adohely: {reader.GetString(1)}");
            }
            reader.Close();
            kapcsolat.Close();

            kapcsolat.Open();
            //3. feladat:
            parancs.CommandText = $"USE radioado; SELECT adohely, csatorna, teljesitmeny FROM kiosztas WHERE adohely = 'Miskolc' ORDER BY teljesitmeny DESC;";
            reader = parancs.ExecuteReader();
            while (reader.Read())
            {
                Debug.WriteLine($"adohely: {reader.GetString(0)}, csatorna: {reader.GetString(1)}, teljesitmeny: {reader.GetFloat(2)}");
            }
            reader.Close();
            kapcsolat.Close();

            kapcsolat.Open();
            //4. feladat:
            parancs.CommandText = $"USE radioado; SELECT megye, COUNT(*) AS db FROM kiosztas, regio WHERE csatorna = 'MR1-Kossuth Rádió' GROUP BY megye;";
            reader = parancs.ExecuteReader();
            while (reader.Read())
            {
                Debug.WriteLine($"megye: {reader.GetString(0)}, db: {reader.GetInt32(1)}");
            }
            reader.Close();
            kapcsolat.Close();
            
            Console.ReadKey();
        }
    }
}
