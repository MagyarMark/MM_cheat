using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LabirintusGUI
{
    public partial class Form1 : Form
    {
        CheckBox[,] chkSzamok = new CheckBox[13, 13];

        public Form1()
        {
            InitializeComponent();
            this.Text = "Labirintus készítő";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Labirintus mérete [sor x oszlop]: ";
            button1.Text = "Induló labirintus létrehozása";
            button2.Text = "Labirintus mentése";
            comboBox1.Text = "12";
            comboBox2.Text = "12";
            comboBox3.Text = "3";
            for (int i = 0; i < int.Parse(comboBox1.Text); i++)
            {
                for (int j = 0; j < int.Parse(comboBox2.Text); j++)
                {
                    chkSzamok[i, j] = new System.Windows.Forms.CheckBox();
                    chkSzamok[i, j].Size = new Size(25, 20);
                    chkSzamok[i, j].Location = new Point(20 + j * 25, 70 + i * 25);
                    chkSzamok[i, j].TextAlign = ContentAlignment.MiddleCenter;
                    chkSzamok[i, j].Font = new Font("Microsoft Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
                    chkSzamok[i, j].Visible = false;
                    Controls.Add(chkSzamok[i, j]);
                }
            }

            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                chkSzamok[0, 0].Checked = true;
                chkSzamok[0, 1].Checked = true;
                chkSzamok[0, 2].Checked = true;
                chkSzamok[0, 3].Checked = true;
                chkSzamok[0, 4].Checked = true;
                chkSzamok[0, 5].Checked = true;
                chkSzamok[0, 6].Checked = true;
                chkSzamok[0, 7].Checked = true;
                chkSzamok[0, 8].Checked = true;
                chkSzamok[0, 9].Checked = true;
                chkSzamok[0, 10].Checked = true;
                chkSzamok[0, 11].Checked = true;
                
                chkSzamok[1, 11].Checked = true;
                chkSzamok[2, 11].Checked = true;
                chkSzamok[3, 11].Checked = true;
                chkSzamok[4, 11].Checked = true;
                chkSzamok[5, 11].Checked = true;
                chkSzamok[6, 11].Checked = true;
                chkSzamok[7, 11].Checked = true;
                chkSzamok[8, 11].Checked = true;
                chkSzamok[9, 11].Checked = true;
                chkSzamok[11, 11].Checked = true;
                
                chkSzamok[2, 0].Checked = true;
                chkSzamok[3, 0].Checked = true;
                chkSzamok[4, 0].Checked = true;
                chkSzamok[5, 0].Checked = true;
                chkSzamok[6, 0].Checked = true;
                chkSzamok[7, 0].Checked = true;
                chkSzamok[8, 0].Checked = true;
                chkSzamok[9, 0].Checked = true;
                chkSzamok[10, 0].Checked = true;
                chkSzamok[11, 0].Checked = true;

                chkSzamok[11, 10].Checked= true;
                chkSzamok[11, 9].Checked= true;
                chkSzamok[11, 8].Checked= true;
                chkSzamok[11, 7].Checked= true;
                chkSzamok[11, 6].Checked= true;
                chkSzamok[11, 5].Checked= true;
                chkSzamok[11, 4].Checked= true;
                chkSzamok[11, 3].Checked= true;
                chkSzamok[11, 2].Checked= true;
                chkSzamok[11, 1].Checked= true;

                chkSzamok[0, 0].Enabled = false;
                chkSzamok[0, 1].Enabled = false;
                chkSzamok[0, 2].Enabled = false;
                chkSzamok[0, 3].Enabled = false;
                chkSzamok[0, 4].Enabled = false;
                chkSzamok[0, 5].Enabled = false;
                chkSzamok[0, 6].Enabled = false;
                chkSzamok[0, 7].Enabled = false;
                chkSzamok[0, 8].Enabled = false;
                chkSzamok[0, 9].Enabled = false;
                chkSzamok[0, 10].Enabled = false;
                chkSzamok[0, 11].Enabled = false;

                chkSzamok[1, 0].Enabled = false;
                chkSzamok[2, 0].Enabled = false;
                chkSzamok[3, 0].Enabled = false;
                chkSzamok[4, 0].Enabled = false;
                chkSzamok[5, 0].Enabled = false;
                chkSzamok[6, 0].Enabled = false;
                chkSzamok[7, 0].Enabled = false;
                chkSzamok[8, 0].Enabled = false;
                chkSzamok[9, 0].Enabled = false;
                chkSzamok[10, 0].Enabled = false;
                chkSzamok[11, 0].Enabled = false;

                chkSzamok[1, 11].Enabled = false;
                chkSzamok[2, 11].Enabled = false;
                chkSzamok[3, 11].Enabled = false;
                chkSzamok[4, 11].Enabled = false;
                chkSzamok[5, 11].Enabled = false;
                chkSzamok[6, 11].Enabled = false;
                chkSzamok[7, 11].Enabled = false;
                chkSzamok[8, 11].Enabled = false;
                chkSzamok[9, 11].Enabled = false;
                chkSzamok[11, 11].Enabled = false;

                chkSzamok[11, 10].Enabled = false;
                chkSzamok[11, 9].Enabled = false;
                chkSzamok[11, 8].Enabled = false;
                chkSzamok[11, 7].Enabled = false;
                chkSzamok[11, 6].Enabled = false;
                chkSzamok[11, 5].Enabled = false;
                chkSzamok[11, 4].Enabled = false;
                chkSzamok[11, 3].Enabled = false;
                chkSzamok[11, 2].Enabled = false;
                chkSzamok[11, 1].Enabled = false;

                for (int i = 0; i < int.Parse(comboBox1.Text); i++)
                {
                    for (int j = 0; j < int.Parse(comboBox2.Text); j++)
                    {
                        chkSzamok[i, j].Visible = true;

                    }
                }
            }
            catch 
            {
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var index = comboBox3.Text;
            StreamWriter sw = new StreamWriter($"Lab{index}.txt");
            sw.WriteLine();
            sw.Close();

            MessageBox.Show("Az állomány mentése sikeres!");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
