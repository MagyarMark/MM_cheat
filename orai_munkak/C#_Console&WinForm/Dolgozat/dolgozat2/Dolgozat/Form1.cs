using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Dolgozat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Button[,] matrix = new Button[8,6];
        Label kiiras = new Label();
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            button1.Visible = false;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    
                    matrix[i, j] = new Button();
                    matrix[i,j].Name = $"{i+1}/{j+1}";
                    matrix[i, j].Width = 50;
                    matrix[i, j].Height = 50;
                    matrix[i, j].Top = i * 50;
                    matrix[i, j].Left = j * 50;
                    matrix[i, j].Visible = true;
                    matrix[i, j].Click += new EventHandler(GombKattintva);

                    this.Controls.Add(matrix[i, j]);
                }
            }

            kiiras = new Label()
            {
                Text = "",
                Size = new Size(100, 50),
                Location = new Point(350,150),
                Visible = true
            };
            this.Controls.Add(kiiras);
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        private void GombKattintva(object sender, EventArgs e)
        {
            Random r = new Random();
            Button gomb = (Button)sender;
            kiiras.Text = gomb.Name;
            matrix.Cast<Button>().ToList().ForEach(x => x.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), 0));
        }
    }
}
