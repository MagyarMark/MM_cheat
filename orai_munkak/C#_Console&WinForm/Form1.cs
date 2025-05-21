using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace readlestates_sql_gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder { Server = "127.0.0.1", UserID = "root", Password = "", Database = "ingatlan" };
            MySqlConnection kapcsolat = new MySqlConnection(build.ConnectionString);
            kapcsolat.Open();
            List<string> sellers = new List<string>();
            var parancs = kapcsolat.CreateCommand();
            parancs.CommandText = "SELECT name from sellers;";
            var read = parancs.ExecuteReader();

            listBox1.Items.Add((string)read.GetString(0));    
            read.Close();

            foreach (string s in sellers)
            {
                Console.WriteLine(s);
            }





            kapcsolat.Close();

        }
    }
}
