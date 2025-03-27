using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace hudejo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder 
            {
                Server = "127.0.0.1",
                UserID = "root",
                Password = "",
                Database = "igatlan"
            };
            MySqlConnection kapcsolat = new MySqlConnection(build.ConnectionString);

            kapcsolat.Open();

            var parancs = kapcsolat.CreateCommand();
            //parancs.CommandText = "select name from sellers order by phone;";

            //1. feladat: földszínti ingatlanok átlagos alapterülete
            parancs.CommandText = "select round(avg(`area`), 2) from realestates where `floors` = 0;";//1érték

            //parancs.CommandText = "SELECT * FROM sellers WHERE id in (SELECT DISTINCT `sellerId` FROM `realestates`) ORDER BY phone;";//két érték
            var read = parancs.ExecuteReader();
            while (read.Read())
            {
                //Console.WriteLine(read.GetString("name") + " " + read.GetInt64("id"));//két érték
                //Console.WriteLine("A földszinti ingatlanok átlagos alapterülete: " + read.GetDouble(0) +"m2" );//1érték
            }
            read.Close();

            /*parancs.CommandText = "select count(id) from realestates where `floors` = 1;";
            read = parancs.ExecuteReader();
            while (read.Read())
            {
               Console.WriteLine("első emeleti ingatlanok száma: " + read.GetInt64(0) + "db");
            }*/

            /*2. feladat:A Mesevár óvoda Budán a 47.4164220114023, 
                        19.066342425796986 GPS koordinátán helyezkedik el. Keresse ki és írja ki a minta 
                        alapján annak a tehermentes ingatlannak az adatait, melyik a legközelebb van 
                        légvonalban a Mesevár óvodához! kiíratásnál legyen kiírva a neve, telefonszáma, alapterülete az ingatlannak, és a szobák száma*/
            parancs.CommandText = "SELECT s.name, s.phone, r.area, r.rooms FROM sellers s JOIN realestates r ON s.id = r.sellerId WHERE name = \"Ápry Lísa\" ORDER BY sqrt(pow(47.4164220114023 - r.latlong, 2) + pow(19.066342425796986 - r.latlong, 2)) LIMIT 1;";
            read = parancs.ExecuteReader();
            while (read.Read())
            {
                Console.WriteLine("Ingatlan adatai:");
                Console.WriteLine("Neve: " + read["name"]);
                Console.WriteLine("Telefonszáma: " + read["phone"]);
                Console.WriteLine("Alapterülete: " + read["area"]);
                Console.WriteLine("Szobák száma: " + read["rooms"]);
            }
            kapcsolat.Close();
            Console.ReadKey();
        }
    }
}
