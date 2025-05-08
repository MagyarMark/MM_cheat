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

namespace Dolgozat
{
    public partial class Form1 : Form
    {
        CheckBox[,] napok = new CheckBox[31, 31];
        Label[] szoba = new Label[31];
        Label[] nap = new Label[31];
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
            comboBox1.Items.Add("2023");
            comboBox1.Items.Add("2024");
            comboBox1.Items.Add("2025");
            comboBox1.Items.Add("2026");
            comboBox1.Items.Add("2027");
            comboBox1.Items.Add("2028");
            comboBox1.Items.Add("2029");
            comboBox1.Items.Add("2030");
            comboBox1.Items.Add("2031");
            comboBox1.Items.Add("2032");
            comboBox1.Items.Add("2033");
            comboBox1.Items.Add("2034");
            comboBox1.Items.Add("2035");
            comboBox1.Items.Add("2036");
            comboBox1.Items.Add("2037");
            comboBox1.Items.Add("2038");
            comboBox1.Items.Add("2039");
            comboBox1.Items.Add("2040");
            comboBox1.Items.Add("2041");
            comboBox1.Items.Add("2042");
            comboBox1.Items.Add("2043");
            comboBox1.Items.Add("2044");
            comboBox1.Items.Add("2045");
            comboBox1.Items.Add("2046");
            comboBox1.Items.Add("2047");
            comboBox1.Items.Add("2048");
            comboBox1.Items.Add("2049");
            comboBox1.Items.Add("2050");

            comboBox2.Items.Add("Január");
            comboBox2.Items.Add("Február");
            comboBox2.Items.Add("Március");
            comboBox2.Items.Add("Április");
            comboBox2.Items.Add("Május");
            comboBox2.Items.Add("Június");
            comboBox2.Items.Add("Július");
            comboBox2.Items.Add("Augusztus");
            comboBox2.Items.Add("Szeptember");
            comboBox2.Items.Add("Október");
            comboBox2.Items.Add("November");
            comboBox2.Items.Add("December");

            comboBox1.Enabled = false;
            comboBox2.Enabled = false;

            for (int i = 0; i < 27; i++)
            {
                szoba[i] = new Label();
                szoba[i].Location = new Point(10, 82 + i * 20);
                szoba[i].Size = new Size(55, 16);
                szoba[i].Font = new Font("Arial", 8, FontStyle.Bold);
                szoba[i].Text = $"{i + 1}.szoba";
                Controls.Add(szoba[i]);
            }

            for (int i = 0; i < 28; i++)
            {
                nap[i] = new Label();
                nap[i].Location = new Point(75 + i * 20, 55);
                nap[i].Size = new Size(20, 16);
                nap[i].Font = new Font("Arial", 8, FontStyle.Bold);
                nap[i].Text = $"{i + 1}.";
                Controls.Add(nap[i]);
            }

            comboBox1.Text = DateTime.Now.ToString("yyyy");
            comboBox2.Text = DateTime.Now.ToString("MMMM");
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;


            if (comboBox2.SelectedIndex == 1)
            {
                for (int i = 0; i < 28; i++)
                {
                    for (int j = 0; j < 27; j++)
                    {
                        napok[i, j] = new CheckBox();
                        napok[i, j].Location = new Point(75 + i * 20, 80 + j * 20);
                        napok[i, j].Size = new Size(20, 20);
                        napok[i, j].BackColor = Color.Green;
                        napok[i, j].Enabled = false;
                        napok[i, j].Checked = false;
                        Controls.Add(napok[i, j]);
                    }
                }
                for (int i = 0; i < 28; i++)
                {
                    nap[i] = new Label();
                    nap[i].Location = new Point(75 + i * 20, 55);
                    nap[i].Size = new Size(20, 16);
                    nap[i].Font = new Font("Arial", 8, FontStyle.Bold);
                    nap[i].Text = $"{i + 1}.";
                    Controls.Add(nap[i]);
                }
            }



        }
        private void BtnKi_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BtnTel_Click(object sender, EventArgs e)
        {
            BtnFoglalas.Visible = false;
            BtnKi.Visible = false;
            BtnStat.Visible = false;
        }

        private void BtnStat_Click(object sender, EventArgs e)
        {
            BtnTel.Visible = false;
            BtnFoglalas.Visible = false;
            BtnKi.Visible = false;

            StreamWriter stat = new StreamWriter("stat.txt");
            stat.Write("");
            stat.Close();
        }

        private void BtnFoglalas_Click(object sender, EventArgs e)
        {
            BtnStat.Visible = false;
            BtnTel.Visible = false;
            BtnKi.Visible = false;

            comboBox1.Enabled = true;
            comboBox2.Enabled = true;

            for (int i = 0; i < 31; i++)
            {
                for (int j = 0; j < 27; j++)
                {
                    if (napok[i, j] != null)
                    {
                        napok[i, j].Enabled = true;
                    }
                }
            }
        }

        private void matrix(int napokSzama)
        {
            for (int i = 0; i < napokSzama; i++)
            {
                for (int j = 0; j < 27; j++)
                {
                    napok[i, j] = new CheckBox();
                    napok[i, j].Location = new Point(75 + i * 20, 80 + j * 20);
                    napok[i, j].Size = new Size(20, 20);
                    napok[i, j].BackColor = Color.Green;
                    napok[i, j].Enabled = true;
                    napok[i, j].Checked = false;
                    Controls.Add(napok[i, j]);
                }
            }

            for (int i = 0; i < napokSzama; i++)
            {
                nap[i] = new Label();
                nap[i].Location = new Point(75 + i * 20, 55);
                nap[i].Size = new Size(20, 16);
                nap[i].Font = new Font("Arial", 8, FontStyle.Bold);
                nap[i].Text = $"{i + 1}.";
                Controls.Add(nap[i]);
            }
        }

        private void BtnVissza_Click(object sender, EventArgs e)
        {
            BtnStat.Visible = true;
            BtnTel.Visible = true;
            BtnKi.Visible = true;
            BtnFoglalas.Visible = true;

            comboBox1.Enabled = false;
            comboBox2.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 31; i++)
            {
                for (int j = 0; j < 27; j++)
                {
                    if (napok[i, j] != null)
                    {
                        Controls.Remove(napok[i, j]);
                        napok[i, j] = null;
                    }
                }
                if (nap[i] != null)
                {
                    Controls.Remove(nap[i]);
                    nap[i] = null;
                }
            }

            int napokSzama = DateTime.DaysInMonth(int.Parse(comboBox1.Text), comboBox2.SelectedIndex + 1);
            matrix(napokSzama);
            for (int i = 0; i < napokSzama; i++)
            {
                for (int j = 0; j < 27; j++)
                {
                    if (napok[i, j] != null)
                    {
                        napok[i, j].Enabled = true;
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == comboBox1.Text)
            {
                for (int i = 0; i < 31; i++)
                {
                    for (int j = 0; j < 27; j++)
                    {
                        if (napok[i, j] != null)
                        {
                            napok[i, j].Checked = false;
                        }
                    }
                }

            }
        }
    }
}
