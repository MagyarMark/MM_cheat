using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace realestate_sql
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder { Server = "127.0.0.1", UserID="root", Password="", Database="ingatlan" };
            MySqlConnection kapcsolat = new MySqlConnection(build.ConnectionString);
            kapcsolat.Open();

            var parancs = kapcsolat.CreateCommand();
            parancs.CommandText = "SELECT sum(area), count(id) from realestates where floors = 0;";
            var read = parancs.ExecuteReader();
            while (read.Read())
            {
                Console.WriteLine($"A földszinti ingatlanok átlagos alapterülete:{(double)read.GetInt64(0)/ read.GetInt64(1):0.00} m2");
            }
            read.Close();

            parancs.CommandText = "SELECT sum(area), count(id) from realestates where floors = 0;";
            read = parancs.ExecuteReader();
            while (read.Read())
            {
                Console.WriteLine($"Az első emeleti ingatlanok száma:{(double)read.GetInt64(1)} db");
            }
            read.Close();

            kapcsolat.Close();

            Console.ReadKey();
        }
    }
}
