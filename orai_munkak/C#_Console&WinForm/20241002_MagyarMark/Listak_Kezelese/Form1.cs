using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listak_Kezelese
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SortedSet<int> A_Halmaz = new SortedSet<int>();
        SortedSet<int> B_Halmaz = new SortedSet<int>();
        private void btn_keszit_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int osszDB = 0;
            for (int i = 0; i < 5; i++)
            {
                lBMetszet.Items.Clear();
                A_Halmaz.Clear();
                do
                {
                    A_Halmaz.Add(random.Next(1, 101));
                } while (A_Halmaz.Count < 5);

                B_Halmaz.Clear();
                do
                {
                    B_Halmaz.Add(random.Next(1, 101));
                } while (B_Halmaz.Count < 5);
                
                lBA.Items.Clear();
                foreach (var item in A_Halmaz)
                {
                    lBA.Items.Add(item);
                }
                lBB.Items.Clear();
                foreach (var item in B_Halmaz)
                {
                    lBB.Items.Add(item);
                }
                
                SortedSet<int> segment = new SortedSet<int>();
                foreach (var item in A_Halmaz)
                {
                    foreach (var item1 in B_Halmaz)
                    {
                        if (item == item1)
                        {
                            segment.Add(item);
                            break;
                        }
                    }
                }
                lBMetszet.Items.Clear();
                foreach (var item in segment)
                {
                    lBMetszet.Items.Add(item);
                }
                osszDB += lBMetszet.Items.Count;
                label1.Text = ((double)osszDB / 5).ToString(); 
            }
        }

        private void btn_szamol_Click(object sender, EventArgs e)
        {
            SortedSet<int> segment = new SortedSet<int>();
            foreach (var item in A_Halmaz)
            {
                foreach (var item1 in B_Halmaz)
                {
                    if (item == item1)
                    {
                        segment.Add(item);
                        break;
                    }
                }
            }
            lBMetszet.Items.Clear();
            foreach (var item in segment)
            {
                lBMetszet.Items.Add(item);
            }

            //unio
            SortedSet<int> unio = new SortedSet<int>(A_Halmaz);
            unio.UnionWith(B_Halmaz);

            lBUnio.Items.Clear();
            foreach (var item in unio)
            {
                lBUnio.Items.Add(item);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lBA.Enabled = false;
            lBB.Enabled = false;
            lBMetszet.Enabled = false;
            lBUnio.Enabled = false;
            
            lBA.Items.Clear();
            lBB.Items.Clear();
            lBMetszet.Items.Clear();
            lBUnio.Items.Clear();
        }

        private void lBUnio_SelectedIndexChanged(object sender, EventArgs e)
        {
            lBUnio.Items.Clear();
        }
    }
}
