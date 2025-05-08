using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ablakugras
{
    public partial class Form1 : Form
    {
        static public int x = 0, y = 0;
        public Form1()
        {
            InitializeComponent();
        }

        public void mozgat(int x, int y)
        {
            this.Location = new Point(x, y);
        }

        private void bal_also_Click(object sender, EventArgs e)
        {
            x = 0;
            y = Screen.PrimaryScreen.WorkingArea.Height - this.Height;
            mozgat(x, y);
        }

        private void jobb_felso_Click(object sender, EventArgs e)
        {
            y = 0;
            x= Screen.PrimaryScreen.WorkingArea.Width - this.Width;
            this.BackColor = Color.Red;
            jobb_felso.BackColor = Color.Green;
            mozgat(x, y);
        }

        private void jobb_also_Click(object sender, EventArgs e)
        {
            x = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
            y = Screen.PrimaryScreen.WorkingArea.Height - this.Height;
            mozgat(x, y);
        }

        private void bal_felso_Click(object sender, EventArgs e)
        {
            x = 0; 
            y = 0;
            mozgat(x, y);
        }
    }
}
