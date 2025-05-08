using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Statisztika_GUI
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
    }
}
