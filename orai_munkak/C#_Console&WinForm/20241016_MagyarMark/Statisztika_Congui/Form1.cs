using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Statisztika_Congui
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl2feladat.Text   = string.Empty;
            lbl3feladat.Text   = string.Empty;
            lbl4_1feladat.Text = string.Empty;
            lbl4_2feladat.Text = string.Empty;
            lbl5_1feladat.Text = string.Empty;
            lbl5_2feladat.Text = string.Empty;
        }

        private void btn_stat_Click(object sender, EventArgs e)
        {
            List<data> datas = eljarasok.fileRead(txbFileName.Text);

            lbl2feladat.Text = "Körök száma: " + data.datas.Count;

            lbl3feladat.Text = "3.dobásra Bullseye(D25): " + eljarasok.feladat3();

            int[] ints = eljarasok.feladat4(txbSector.Text);
            lbl4_1feladat.Text = "Az 1. játékos a(z)" + txbSector.Text + "szektoros dobásainak száma: " + ints[0];
            lbl4_2feladat.Text = "Az 2. játékos a(z)" + txbSector.Text + "szektoros dobásainak száma: " + ints[1];

            lbl5_1feladat.Text = "Az 1. játékos " + ints[2] + "db 180-ast dobott";
            lbl5_2feladat.Text = "A 2. játékos " + ints[3] + "db 180-ast dobott";


        }
    }
}
