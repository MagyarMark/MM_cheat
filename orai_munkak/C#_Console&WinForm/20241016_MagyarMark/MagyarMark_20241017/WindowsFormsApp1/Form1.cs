using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSzamol_Click(object sender, EventArgs e)
        {
            int szam = int.Parse(txtA.Text.ToString());
            int szam1 = int.Parse(txtB.Text.ToString());

            if (RB1.Checked)
            {
                lblMegoldas.Text = "A legnagyobb közös osztó: " + LNKO(szam, szam1);
            }
            else if (RB2.Checked)
            {
                lblMegoldas.Text = "A legkisebb közös többszörös: " + LKKT(szam, szam1);
            }
            else
            {
                MessageBox.Show("Nem számot adtál meg");
            }
        }

        private int LNKO(int a, int b)
        {
            while (b != 0)
            {
                int tmp = b;
                b = a % b;
                a = tmp;
            }
            return a;
        }

        private int LKKT(int a, int b)
        {
            return (a * b) / LNKO(a,b);
        }
    }
}
