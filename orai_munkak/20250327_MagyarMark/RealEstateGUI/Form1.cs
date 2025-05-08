using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RealEstateGUI
{
    public partial class Form1 : Form
    {
        private Dictionary<string, (string phone, int number)> adatok = new Dictionary<string, (string, int)>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hbe.Dock = DockStyle.Fill;
            listBox1.Dock = DockStyle.Fill;
            tableLayoutPanel1.SetRowSpan(listBox1, 8);
            nev.Text = "";
            tel.Text = "";
            hSzam.Text = "0";
            hName.Text = "";
            hTel.Text = "";
            hTer.Text = "";
            hSzoba.Text = "";
            hEmelet.Text = "";
            hLeir.Text = "";
            hCreate.Text = "";
            hFree.Text = "";
            hLat.Text = "";
            hImg.Text = "";

           /* string filePath = "nevek.txt";

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');

                    if (parts.Length == 3)
                    {
                        string name = parts[0].Trim();
                        string phone = parts[1].Trim();
                        int number = int.Parse(parts[2].Trim());

                        adatok[name] = (phone, number);

                        Debug.WriteLine($"Név: {name}, Telefonszám: {phone}, Véletlen szám: {number}");
                        listBox1.Items.Add(name);
                    }
                }
            }
            else
            {
                MessageBox.Show("HALO NINCS FILE");
            }*/

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

            parancs.CommandText = "select name, phone from sellers";
            var read = parancs.ExecuteReader();
            while (read.Read())
            {
                listBox1.Items.Add(read.GetString("name"));
                adatok[read.GetString("name")] = (read.GetString("phone"), 0);
            }
            read.Close();
            kapcsolat.Close();
        }

        private void hbe_Click(object sender, EventArgs e)
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

            parancs.CommandText = "SELECT s.id, s.name, s.phone, r.area, r.rooms, r.floors, r.description, r.createAt, r.freeofcharge, r.latlong, r.imageUrl FROM sellers s JOIN realestates r ON s.id = r.sellerId WHERE s.name = @name";
            parancs.Parameters.AddWithValue("@name", listBox1.Text);
            var read = parancs.ExecuteReader();
            while (read.Read())
            {

                hSzam.Text = read["id"].ToString();
                hName.Text = "Neve: "+read["name"].ToString();
                hTel.Text = "Telefonszáma: "+read["phone"].ToString();
                hTer.Text = "Terület: "+read["area"].ToString();
                hSzoba.Text = "Szoba: "+read["rooms"].ToString();
                hEmelet.Text = "Emeletek: "+read["floors"].ToString();
                hLeir.Text = "Leiras: NULL";
                hCreate.Text = "CreateAt: "+read["createAt"].ToString();
                hFree.Text = "Ingyenes: "+read["freeofcharge"].ToString();
                hLat.Text = "LatLong: "+read["latlong"].ToString();
                hImg.Text = "Kép: "+read["imageUrl"].ToString();
                Debug.WriteLine($"Név: {read["name"]}, Telefonszám: {read["phone"]}, Terület: {read["area"]}, Szobák: {read["rooms"]}, Emeletek: {read["floors"]}, Leiras: {read["description"]}, Create: {read["createAt"]}, FreeOfCharge: {read["freeofcharge"]}, LatLong: {read["latlong"]}, Image: {read["imageUrl"]}");
            }
            read.Close();
            kapcsolat.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (listBox1.SelectedItem != null)
            {
                string valasztott = listBox1.SelectedItem.ToString();

                if (adatok.ContainsKey(valasztott))
                {
                    nev.Text = valasztott;
                    tel.Text = adatok[valasztott].phone;
                }
            }*/

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

            parancs.CommandText = "select name, phone from sellers";
            var read = parancs.ExecuteReader();
            while (read.Read())
            {
                if (read.GetString(0) != listBox1.SelectedItem.ToString())
                {
                    continue;
                }
                nev.Text = read.GetString(0);
                tel.Text = read.GetString(1);
            }
            read.Close();
            kapcsolat.Close();
        }
    }
}
