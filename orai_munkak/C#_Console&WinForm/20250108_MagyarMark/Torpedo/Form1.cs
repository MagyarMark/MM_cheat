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

namespace Torpedo
{
    public partial class Form1 : Form
    {
        public CheckBox[,] matrix = new CheckBox[10, 10];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false;

            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    matrix[y, x] = new CheckBox();
                    matrix[y, x].Text = null;
                    matrix[y, x].AutoSize = false;
                    matrix[y, x].Size = new Size(20,20);
                    matrix[y, x].Location = new Point(20 + x * 26, 90 + y * 20);
                    matrix[y, x].Visible = true;
                    matrix[y, x].Checked = false;
                    matrix[y, x].Enabled = true;
                    Controls.Add(matrix[y ,x]);
                }
            }

        }

        public void btnReset_Click(object sender, EventArgs e)
        {
            foreach(var item in matrix)
            {
                item.Checked = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textBox1.Text.Replace(' ', '_');
            textBox1.Text = textBox1.Text.Trim();
            if (textBox1.Text.Length == 0)
            {
                btnSave.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            int db = 0;
            foreach (var item in matrix)
            {
                if (item.Checked)
                {
                    db++;
                }
            }
            if (db != 15)
            {
                MessageBox.Show("Maximum 15!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (matrix[i, j].Checked)
                    {
                        matrix[i, j].BackColor = Color.Red;
                        matrix[i, j].Enabled = false;

                        if (i > 0 && matrix[i - 1, j].Checked)
                        {
                            MessageBox.Show("Torpedók nem lehetnek egymás mellett!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (i > 9 && matrix[i + 1, j].Checked)
                        {
                            MessageBox.Show("Torpedók nem lehetnek egymás mellett!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (j > 0 && matrix[i, j - 1].Checked)
                        {
                            MessageBox.Show("Torpedók nem lehetnek egymás mellett!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (j > 9 && matrix[i, j + 1].Checked)
                        {
                            MessageBox.Show("Torpedók nem lehetnek egymás mellett!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }

            CheckBox[,] alap = matrix;
            bool otos = false;
            bool negy = false;
            bool harom = false;
            bool ketto = false;
            bool egy = false;
            int sor = 0;
            int[] kooSor = new int[5];
            int[] kooOszlop = new int[5];
            while (sor < 10 && !otos)
            {
                db = 0;
                kooSor = null;
                kooOszlop = null;
                for (int oszlop = 0; oszlop < 10; oszlop++)
                {
                    if (alap[sor, oszlop].Checked)
                    {
                        kooSor[db] = sor;
                        kooOszlop[db] = oszlop;
                        db++;
                    }
                    if (db == 5)
                    {
                        otos = true;
                        alap[kooSor[0], kooOszlop[0]].Checked = false;
                        for (int i = 0; i < 5; i++)
                        {
                            alap[kooSor[i], kooOszlop[i]].Checked = false;
                        }
                        break;
                    }
                    if (db == 4)
                    {
                        negy = true;
                        alap[kooSor[0], kooOszlop[0]].Checked = false;
                        for (int i = 0; i < 4; i++)
                        {
                            alap[kooSor[i], kooOszlop[i]].Checked = false;
                        }
                        break;
                    }
                    if (db == 3)
                    {
                        harom = true;
                        alap[kooSor[0], kooOszlop[0]].Checked = false;
                        for (int i = 0; i < 3; i++)
                        {
                            alap[kooSor[i], kooOszlop[i]].Checked = false;
                        }
                        break;
                    }
                    if (db == 2)
                    {
                        ketto = true;
                        alap[kooSor[0], kooOszlop[0]].Checked = false;
                        for (int i = 0; i < 2; i++)
                        {
                            alap[kooSor[i], kooOszlop[i]].Checked = false;
                        }
                        break;
                    }
                    if (db == 1)
                    {
                        egy = true;
                        alap[kooSor[0], kooOszlop[0]].Checked = false;
                        for (int i = 0; i < 1; i++)
                        {
                            alap[kooSor[i], kooOszlop[i]].Checked = false;
                        }
                        break;
                    }
                }sor++;
            }
            
            /*int db = 0;
            foreach (var item in matrix)
            {
                if (item.Checked)
                {
                    db++;
                }
            }
            if (db != 15)
            {
                MessageBox.Show("Maximum 15!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (matrix[i, j].Checked)
                    {
                        matrix[i, j].BackColor = Color.Red;
                        matrix[i, j].Enabled = false;
                    }
                }
            }

            CheckBox[,] alap = matrix;
            //ötös
            bool otos = false;
            int sor = 0;
            int[] kooSor = new int[5];
            int[] kooOszlop = new int[5];
            while (sor < 10 && !otos)
            {
                db= 0;
                kooSor = null;
                kooOszlop = null;
                for (int oszlop = 0; oszlop < 10; oszlop++)
                {
                    if (alap[sor, oszlop].Checked)
                    {
                        kooSor[db] = sor;
                        kooOszlop[db] = oszlop;
                        db++;
                    }
                    if (db == 5)
                    {
                        otos = true;
                        alap[kooSor[0], kooOszlop[0]].Checked = false;
                        for (int i = 0; i < 5; i++)
                        {
                            alap[kooSor[i], kooOszlop[i]].Checked = false;
                        }
                        break;
                    }
                }
            }*/

                        StreamWriter sw = new StreamWriter(textBox1.Text + ".txt", true, Encoding.UTF8);
            foreach (var item in matrix)
            {
                if (item.Checked)
                {
                    sw.Write(1.ToString());
                }
                else
                {
                    sw.Write(0.ToString());
                }
            }
            sw.WriteLine();
            sw.Close();
            btnReset_Click(sender,e);
        }
    }
}
