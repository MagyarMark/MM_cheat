using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barlangok
{
    public partial class Form1 : Form
    {
        static public int sorszam;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Barlangok";
            btnMentes.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnKeres_Click(object sender, EventArgs e)
        {
            int ii = 0;
            while ( ii < Program.barlangs.Count && Program.barlangs[ii].azon != int.Parse(textBox1.Text))
            {
                ii++;
            }
            if (ii == Program.barlangs.Count)
            { 
                MessageBox.Show("Ezzel az azonosítóval nem létezik barlang"); 
            }
            else
            {
                textBox2.Text = Program.barlangs[ii].hossz.ToString();
                textBox3.Text = Program.barlangs[ii].melyseg.ToString();
                lblNev.Text = "Barlang neve: " + Program.barlangs[ii].nev;
                richTextBox1.Text = Program.barlangs[ii].ToString();
                try
                {
                    string a = "Képek\\" + Program.barlangs[ii].azon.ToString();
                    pictureBox1.Image = new Bitmap(a);
                }
                catch (Exception)
                {
                    pictureBox1.Image = new Bitmap("Képek\\ures.jpg");
                }
                
                btnMentes.Enabled = true;
                sorszam = ii;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnMentes_Click(object sender, EventArgs e)
        {
            bool hiba = false;
            if(int.Parse(textBox2.Text) < Program.barlangs[sorszam].hossz)
            {
                hiba = true;
                MessageBox.Show("A hossz nem lehet kisebb a korábbi értéknél");
            }
            if (int.Parse(textBox3.Text) < Program.barlangs[sorszam].hossz)
            {
                hiba = true;
                MessageBox.Show("A mélység nem lehet kisebb a korábbi értéknél");
            }
            if (!hiba)
            {
                Program.barlangs[sorszam].hossz = int.Parse(textBox2.Text);
                Program.barlangs[sorszam].melyseg = int.Parse(textBox3.Text);
            }
            else
            {
                textBox1.Text = null;
                textBox2.Text = null;
                textBox3.Text = null;
                lblNev.Text = "Barlang neve: ";
                richTextBox1.Text = null;
                pictureBox1.Image = null;
            }
        }

        
    }
}
