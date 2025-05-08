using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szamonkeres
{
    public partial class Form1 : Form
    {
        private int db = 0;
        public Form1()
        {
            InitializeComponent();
            szoveg();
        }

        public void szoveg()
        {
            if (db < 9)
            {
                db++;
            }
            else if (db <= 10)
            {
                MessageBox.Show("Ok");
                db = 0;
            }
        }
        private void btn_vege_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            szoveg();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            szoveg();
        }
    }
}
