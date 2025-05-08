using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_forms
{
    public partial class alap_ablak : Form
    {
        public void muvelet()
        {
            try
            {
                double a = 0;
                if (chb_plus.Checked == true) 
                {
                     a = double.Parse(txb_elso.Text) + double.Parse(txb_masodik.Text);
                }
                else if (chb_division.Checked == true) {  a = double.Parse(txb_elso.Text) / double.Parse(txb_masodik.Text); }
                else if (chb_dives.Checked == true) { a = double.Parse(txb_elso.Text) * double.Parse(txb_masodik.Text); }
                else if (chb_minus.Checked == true) { a = double.Parse(txb_elso.Text) - double.Parse(txb_masodik.Text); }
                lbl_eredmeny.Text = "= " + a.ToString();
            }
            catch (Exception)
            {
                lbl_eredmeny.Text = "= " + "Hiba";
            }
        }
        public alap_ablak()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            btn_exit.Text = "Kilépés";
            Text = "új oldal" ;
            btn_exit.Enabled = false;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chb_plus_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_plus.Checked == true)
            {
                chb_division.Checked = false;
                chb_dives.Checked = false;
                chb_minus.Checked = false;
            }
            muvelet();
        }

        private void chb_minus_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_minus.Checked == true)
            {
                chb_division.Checked = false;
                chb_dives.Checked = false;
                chb_plus.Checked = false;
            }
            muvelet();
        }

        private void chb_dives_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_dives.Checked == true)
            {
                chb_division.Checked = false;
                chb_minus.Checked = false;
                chb_plus.Checked = false;
            }
            muvelet();
        }

        private void chb_division_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txb_masodik.Text) == 0) chb_division.Checked = true;
            }
            catch (Exception)
            {
                chb_division.Checked = false;
            }
            

            if (chb_division.Checked == true)
            {
                chb_minus.Checked = false;
                chb_dives.Checked = false;
                chb_plus.Checked = false;
            }
            muvelet();
        }
    }
}
