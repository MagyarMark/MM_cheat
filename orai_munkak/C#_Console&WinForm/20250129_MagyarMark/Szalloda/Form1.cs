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

namespace Szalloda
{
    public partial class Form1 : Form
    {
        CheckBox[,] napok= new CheckBox[31, 31];
        Label[] szoba = new Label[31];
        Label[] nap= new Label[31];
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;

            /*for (int i = 0; i < 31; i++)
            {
                for (int j = 0; j < 27; j++)
                {
                    napok[i, j] = new CheckBox();
                    napok[i, j].Location = new Point(75 + i *20, 80 + j * 20);
                    napok[i, j].Size = new Size(20, 20);
                    napok[i, j].Checked = false;
                    Controls.Add(napok[i, j]);
                }
            }*/

            for (int i = 0; i < 27; i++)
            {
                szoba[i] = new Label();
                szoba[i].Location = new Point(10, 82 + i * 20);
                szoba[i].Size = new Size(55,16);
                szoba[i].Font = new Font("Arial", 8, FontStyle.Bold);
                szoba[i].Text = $"{i+1}.szoba";
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
                for (int i = 0; i < comboBox2.Items.Count; i++)
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

        /*private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 1) // febr
            {
                for (int i = 0; i < 27; i++)
                {
                    for (int j = 0; j < 27; j++)
                    {
                        napok[i, j].Visible = true;
                    }
                }
            }
            else
            {
                for (int i = 0; i < 31; i++)
                {
                    for (int j = 0; j < 27; j++)
                    {
                        napok[i, j].Visible = true;
                    }
                }
            }
        }*/

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

            /*if (comboBox2.Text == "Február")
            {
                matrix(28);
            }
            else if (comboBox2.Text == "Március")
            {
                matrix(31);
            }
            else if (comboBox2.Text == "Április")
            {
                matrix(30);
            }
            else if (comboBox2.Text == "Május")
            {
                matrix(31);
            }
            else if (comboBox2.Text == "Június")
            {
                matrix(30);
            }
            else if (comboBox2.Text == "Július")
            {
                matrix(31);
            }
            else if (comboBox2.Text == "Augusztus")
            {
                matrix(31);
            }
            else if (comboBox2.Text == "Szeptember")
            {
                matrix(30);
            }
            else if (comboBox2.Text == "Október")
            {
                matrix(31);
            }
            else if (comboBox2.Text == "November")
            {
                matrix(30);
            }else if (comboBox2.Text == "December")
            {
                matrix(31);
            }*/

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

            /*if (comboBox2.Text == "Február")
            {
                for (int i = 0; i < 31; i++)
                {
                    for (int j = 0; j < 27; j++)
                    {
                        napok[i, j] = new CheckBox();
                        napok[i, j].Location = new Point(75 + i * 20, 80 + j * 20);
                        napok[i, j].Size = new Size(20, 20);
                        napok[i, j].Checked = false;
                        napok[i, j].Enabled = true;
                        napok[i, j].BackColor = Color.Green;
                        Controls.Add(napok[i, j]);
                    }
                }
                for (int i = 0; i < napok.GetLongLength(1); i++)
                {
                    nap[i] = new Label();
                    nap[i].Location = new Point(75 + i * 20, 55);
                    nap[i].Size = new Size(20, 16);
                    nap[i].Font = new Font("Arial", 8, FontStyle.Bold);
                    nap[i].Text = $"{i + 1}.";
                    Controls.Add(nap[i]);
                }
            }

            if (comboBox2.Text == "Március")
            {
                for (int i = 0; i < 31; i++)
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
                for (int i = 0; i < napok.GetLongLength(1); i++)
                {
                    nap[i] = new Label();
                    nap[i].Location = new Point(75 + i * 20, 55);
                    nap[i].Size = new Size(20, 16);
                    nap[i].Font = new Font("Arial", 8, FontStyle.Bold);
                    nap[i].Text = $"{i + 1}.";
                    Controls.Add(nap[i]);
                }
            }

            if (comboBox2.Text == "Április")
            {
                for (int i = 0; i < 30; i++)
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
                for (int i = 0; i < napok.GetLongLength(1); i++)
                {
                    nap[i] = new Label();
                    nap[i].Location = new Point(75 + i * 20, 55);
                    nap[i].Size = new Size(20, 16);
                    nap[i].Font = new Font("Arial", 8, FontStyle.Bold);
                    nap[i].Text = $"{i + 1}.";
                    Controls.Add(nap[i]);
                }
            }

            if (comboBox2.Text == "Május")
            {
                for (int i = 0; i < 31; i++)
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
                for (int i = 0; i < napok.GetLongLength(1); i++)
                {
                    nap[i] = new Label();
                    nap[i].Location = new Point(75 + i * 20, 55);
                    nap[i].Size = new Size(20, 16);
                    nap[i].Font = new Font("Arial", 8, FontStyle.Bold);
                    nap[i].Text = $"{i + 1}.";
                    Controls.Add(nap[i]);
                }
            }
            if (comboBox2.Text == "Június")
            {
                for (int i = 0; i < 30; i++)
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
                for (int i = 0; i < napok.GetLongLength(1); i++)
                {
                    nap[i] = new Label();
                    nap[i].Location = new Point(75 + i * 20, 55);
                    nap[i].Size = new Size(20, 16);
                    nap[i].Font = new Font("Arial", 8, FontStyle.Bold);
                    nap[i].Text = $"{i + 1}.";
                    Controls.Add(nap[i]);
                }
            }

            if (comboBox2.Text == "Július")
            {
                for (int i = 0; i < 31; i++)
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
                for (int i = 0; i < napok.GetLongLength(1); i++)
                {
                    nap[i] = new Label();
                    nap[i].Location = new Point(75 + i * 20, 55);
                    nap[i].Size = new Size(20, 16);
                    nap[i].Font = new Font("Arial", 8, FontStyle.Bold);
                    nap[i].Text = $"{i + 1}.";
                    Controls.Add(nap[i]);
                }
            }

            if (comboBox2.Text == "Augusztus")
            {
                for (int i = 0; i < 31; i++)
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
                for (int i = 0; i < napok.GetLongLength(1); i++)
                {
                    nap[i] = new Label();
                    nap[i].Location = new Point(75 + i * 20, 55);
                    nap[i].Size = new Size(20, 16);
                    nap[i].Font = new Font("Arial", 8, FontStyle.Bold);
                    nap[i].Text = $"{i + 1}.";
                    Controls.Add(nap[i]);
                }
            }

            if (comboBox2.Text == "Szeptember")
            {
                for (int i = 0; i < 30; i++)
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
                for (int i = 0; i < napok.GetLongLength(1); i++)
                {
                    nap[i] = new Label();
                    nap[i].Location = new Point(75 + i * 20, 55);
                    nap[i].Size = new Size(20, 16);
                    nap[i].Font = new Font("Arial", 8, FontStyle.Bold);
                    nap[i].Text = $"{i + 1}.";
                    Controls.Add(nap[i]);
                }
            }

            if (comboBox2.Text == "Október")
            {
                for (int i = 0; i < 31; i++)
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
                for (int i = 0; i < napok.GetLongLength(1); i++)
                {
                    nap[i] = new Label();
                    nap[i].Location = new Point(75 + i * 20, 55);
                    nap[i].Size = new Size(20, 16);
                    nap[i].Font = new Font("Arial", 8, FontStyle.Bold);
                    nap[i].Text = $"{i + 1}.";
                    Controls.Add(nap[i]);
                }
            }

            if (comboBox2.Text == "November")
            {
                for (int i = 0; i < 30; i++)
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
                for (int i = 0; i < napok.GetLongLength(1); i++)
                {
                    nap[i] = new Label();
                    nap[i].Location = new Point(75 + i * 20, 55);
                    nap[i].Size = new Size(20, 16);
                    nap[i].Font = new Font("Arial", 8, FontStyle.Bold);
                    nap[i].Text = $"{i + 1}.";
                    Controls.Add(nap[i]);
                }
            }

            if (comboBox2.Text == "December")
            {
                for (int i = 0; i < 31; i++)
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
                for (int i = 0; i < napok.GetLongLength(1); i++)
                {
                    nap[i] = new Label();
                    nap[i].Location = new Point(75 + i * 20, 55);
                    nap[i].Size = new Size(20, 16);
                    nap[i].Font = new Font("Arial", 8, FontStyle.Bold);
                    nap[i].Text = $"{i + 1}.";
                    Controls.Add(nap[i]);
                }
            }*/

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
            //comboBox1.SelectedIndex = default;
            comboBox2.Enabled = false;
            //comboBox2.SelectedIndex = default;

            /*for (int i = 0; i < 31; i++)
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
            }*/

            /*for (int i = 0; i < 31; i++)
            {
                for (int j = 0; j < 27; j++)
                {
                    if (napok[i, j] != null)
                    {
                        napok[i, j].Enabled = false;
                        napok[i, j].Checked = default;
                        napok[i,j].ResetText();
                    }
                }
            }*/

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //txt beolvasas
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Február")
            {
                matrix(28);
            }
            else if (comboBox2.Text == "Március")
            {
                matrix(31);
            }
            else if (comboBox2.Text == "Április")
            {
                matrix(30);
            }
            else if (comboBox2.Text == "Május")
            {
                matrix(31);
            }
            else if (comboBox2.Text == "Június")
            {
                matrix(30);
            }
            else if (comboBox2.Text == "Július")
            {
                matrix(31);
            }
            else if (comboBox2.Text == "Augusztus")
            {
                matrix(31);
            }
            else if (comboBox2.Text == "Szeptember")
            {
                matrix(30);
            }
            else if (comboBox2.Text == "Október")
            {
                matrix(31);
            }
            else if (comboBox2.Text == "November")
            {
                matrix(30);
            }
            else if (comboBox2.Text == "December")
            {
                matrix(31);
            }

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "2026")
            {
                for (int i = 0; i < 31; i++)
                {
                    for (int j = 0; j < 27; j++)
                    {
                        if (napok[i,j] != null)
                        {
                            napok[i,j].Checked = false;
                        }
                    }
                }
            }
            if (comboBox1.Text == "2027")
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
            if (comboBox1.Text == "2028")
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
            if (comboBox1.Text == "2029")
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
            if (comboBox1.Text == "2030")
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
            if (comboBox1.Text == "2031")
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
            if (comboBox1.Text == "2032")
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
            if (comboBox1.Text == "2033")
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
            if (comboBox1.Text == "2034")
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
            if (comboBox1.Text == "2035")
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
            if (comboBox1.Text == "2036")
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
            if (comboBox1.Text == "2037")
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
            if (comboBox1.Text == "2038")
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
            if (comboBox1.Text == "2039")
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
            if (comboBox1.Text == "2040")
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
