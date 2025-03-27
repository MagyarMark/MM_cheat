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
            tableLayoutPanel1.SetRowSpan(listBox1, 4);
            nev.Text = "";
            tel.Text = "";
            hSzam.Text = "";

            string filePath = "nevek.txt";

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
            }
        }

        private void hbe_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string valasztott = listBox1.SelectedItem.ToString();

                if (adatok.ContainsKey(valasztott))
                { 
                    hSzam.Text = adatok[valasztott].number.ToString();
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string valasztott = listBox1.SelectedItem.ToString();

                if (adatok.ContainsKey(valasztott))
                {
                    nev.Text = valasztott;
                    tel.Text = adatok[valasztott].phone;
                }
            }
        }
    }
}
