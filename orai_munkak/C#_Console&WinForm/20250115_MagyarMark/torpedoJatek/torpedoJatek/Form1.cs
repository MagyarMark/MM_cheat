using System.IO;

namespace torpedoJatek
{
    public partial class Form1 : Form
    {
        CheckBox[,] sajat = new CheckBox[10, 10];
        CheckBox[,] lovesek = new CheckBox[10, 10];
        CheckBox[,] puska = new CheckBox[10, 10];
        Button Jatek = new Button();
        Button ki = new Button();
        string[] palya = File.ReadAllLines("palya_1.txt");
        int valasztott = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int s = 0; s < 10; s++)
            {
                for (int o = 0; o < 10; o++)
                {
                    sajat[s, o] = new CheckBox();
                    sajat[s, o].Location = new Point(15 + s * 20, 15 + o * 20);
                    sajat[s, o].AutoSize = false;
                    sajat[s, o].Size = new Size(20, 20);
                    sajat[s, o].Enabled = true;
                    sajat[s, o].Checked = false;
                    sajat[s, o].Text = null;
                    Controls.Add(sajat[s, o]);
                    sajat[s, o].Click += sajatEllenorzes;

                    
                }
            }
            sajat[0,0].Checked = true;
            sajat[0,1].Checked = true;
            sajat[0,2].Checked = true;
            sajat[0,3].Checked = true;
            sajat[0,4].Checked = true;

            sajat[2,0].Checked = true;
            sajat[2,1].Checked = true;
            sajat[2,2].Checked = true;
            sajat[2,3].Checked = true;

            sajat[4,0].Checked = true;
            sajat[4,1].Checked = true;
            sajat[4,2].Checked = true;

            sajat[6,0].Checked = true;
            sajat[6,1].Checked = true;

            sajat[8,0].Checked = true;
            sajatEllenorzes(sender,e);

            for (int s = 0; s < 10; s++)
            {
                

                for (int o = 0; o < 10; o++)
                {
                    lovesek[s, o] = new CheckBox();
                    lovesek[s, o].Location = new Point(250 + s * 20, 15 + o * 20);
                    lovesek[s, o].AutoSize = false;
                    lovesek[s, o].Size = new Size(20, 20);
                    lovesek[s, o].Enabled = false;
                    lovesek[s, o].Checked = false;
                    lovesek[s, o].Text = null;
                    Controls.Add(lovesek[s, o]);
                    lovesek[s, o].Click += lovesekChange;
                }
                
            }

            for (int s = 0; s < 10; s++)
            {
                for (int o = 0; o < 10; o++)
                {
                    puska[s, o] = new CheckBox();
                    puska[s, o].Location = new Point(15 + s * 20, 230 + o * 20);
                    puska[s, o].AutoSize = false;
                    puska[s, o].Size = new Size(20, 20);
                    puska[s, o].Enabled = false;
                    puska[s, o].Checked = false;
                    puska[s, o].Text = null;
                    Controls.Add(puska[s, o]);
                }
            }

            Jatek = new Button
            {
                Location = new Point(450, 15),
                AutoSize = false,
                Size = new Size(100, 30),
                Text = "J�t�k",
                Enabled = true,
                Name = "Jatek",
                Visible = true
            };
            this.Controls.Add(Jatek);
            Jatek.Click += btnjatek_Click;

            ki = new Button
            {
                Location= new Point(450, 50),
                AutoSize = false,
                Size = new Size(100, 30),
                Text = "Kilep",
                Visible= true
            };
            this.Controls.Add(ki);
            ki.Click += btnkilep_Click;

        }
            

        static bool joE(CheckBox[,] matrix)
        {
            
            bool[] hajok = new bool[6];

            int[] kooSor = new int[5];
            int[] kooOszlop = new int[5];

            int[,] alap = new int[12, 12];

            int jelolt = 0;

            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                    if (matrix[i, j].Checked)
                    {
                        alap[i + 1, j + 1] = 1;
                        jelolt++;
                        matrix[i, j].BackColor = Color.Green;
                    }
                    else 
                    {
                        alap[i + 1, j + 1] = 0;
                        matrix[i, j].BackColor = Color.Red;
                    }
            

            if (jelolt != 15) // 15 jel�l�s vizsg�lata
            {
                return false;
            }

            for (int s = 1; s < 12; s++)
            {
                jelolt = 0;
                for (int o = 1; o < 12; o++)
                {
                    if (alap[s, o] == 1) jelolt++;
                    else
                    {
                        if (jelolt <= 5) hajok[jelolt] = true;
                        else
                        {
                            return false;
                        }
                        jelolt = 0;
                    }
                }
            }
            for (int o = 1; o < 12; o++)
            {
                jelolt = 0;
                for (int s = 1; s < 12; s++)
                {
                    if (alap[s, o] == 1) jelolt++;
                    else
                    {
                        if (jelolt <= 5) hajok[jelolt] = true;
                        else
                        {
                            return false;
                        }
                        jelolt = 0;
                    }
                }
            }

            for (int i = 1; i < 6; i++)
            {
                if (!hajok[i])
                {
                    return false;
                }
            }

            for (int hajo = 5; hajo > 0; hajo--)
            {
                if (!hajok[hajo]) continue;

                for (int s = 1; s < 12; s++)
                {
                    jelolt = 0;
                    kooSor = new int[5];
                    kooOszlop = new int[5];

                    for (int o = 1; o < 12; o++)
                    {
                        if (alap[s, o] == 1)
                        {
                            kooOszlop[jelolt] = o;
                            kooSor[jelolt] = s;
                            jelolt++;
                        }
                        else
                        {
                            if (jelolt == hajo)
                            {
                                for (int torol = 0; torol < jelolt; torol++)
                                {
                                    alap[kooSor[torol], kooOszlop[torol]] = 0;
                                    alap[kooSor[torol] - 1, kooOszlop[torol]] = 0;
                                    alap[kooSor[torol] + 1, kooOszlop[torol]] = 0;
                                    alap[kooSor[torol], kooOszlop[torol] - 1] = 0;
                                    alap[kooSor[torol], kooOszlop[torol] + 1] = 0;
                                }
                                hajok[hajo] = false;
                                jelolt = 0;
                                continue;
                            }
                            else
                            {
                                jelolt = 0;
                                continue;
                            }

                        }
                    }
                }
                if (!hajok[hajo]) continue;

                for (int o = 1; o < 12; o++)
                {
                    jelolt = 0;
                    kooSor = new int[5];
                    kooOszlop = new int[5];

                    for (int s = 1; s < 12; s++)
                    {
                        if (alap[s, o] == 1)
                        {
                            kooOszlop[jelolt] = o;
                            kooSor[jelolt] = s;
                            jelolt++;
                        }
                        else
                        {
                            if (jelolt == hajo)
                            {
                                for (int torol = 0; torol < jelolt; torol++)
                                {
                                    alap[kooSor[torol], kooOszlop[torol]] = 0;
                                    alap[kooSor[torol] - 1, kooOszlop[torol]] = 0;
                                    alap[kooSor[torol] + 1, kooOszlop[torol]] = 0;
                                    alap[kooSor[torol], kooOszlop[torol] - 1] = 0;
                                    alap[kooSor[torol], kooOszlop[torol] + 1] = 0;
                                }
                                hajok[hajo] = false;
                                jelolt = 0;
                                continue;
                            }
                            else
                            {
                                jelolt = 0;
                                continue;
                            }
                        }
                    }
                }
            }

            for (int i = 1; i < 6; i++)
            {
                if (hajok[i])
                {
                    return false;
                }
            }

            return true;
        }


        /*private void btnjatek_Click(object sender, EventArgs e)
        {
            if (joE(sajat))
            {
                this.BackColor = Color.Green;
                foreach (var item in sajat)
                {
                    item.Enabled = false;
                }
                foreach (var item in lovesek)
                {
                    item.Enabled = false;
                }
            }
            else
            {
                this.BackColor = Color.Red;
            }
        }*/

        private void lovesekChange(object sender, EventArgs e)
        {
            int pos = 0;
            foreach (var item in lovesek)
            {
                if (item.Enabled && item.Checked)
                {
                    item.Enabled = false;
                    break;
                }
                else pos++;

            }
            if (palya[valasztott][pos] == '1')
            {
                lovesek[pos / 10, pos % 10].BackColor = Color.Yellow;

                bool xvan = false;
                bool yvan = false;
                int tol = 0;
                int ig = 9;


                for (int i = (pos / 10) + 1; i < 10; i++)
                {
                    if (puska[i, pos % 10].Checked)
                    {
                        ig = i;
                        xvan = true;
                    }
                    else break;
                }
                for (int i = (pos / 10) - 1; i >= 0; i--)
                {
                    if (puska[i, pos % 10].Checked)
                    {
                        tol = i;
                        xvan = true;
                    }
                    else break;
                }
                if (!xvan)
                {
                    for (int i = (pos % 10) + 1; i < 10; i++)
                    {
                        if (puska[pos / 10, i].Checked)
                        {
                            ig = i;
                            yvan = true;
                        }
                        else break;
                    }
                    for (int i = (pos % 10) - 1; i >= 0; i--)
                    {
                        if (puska[pos / 10, i].Checked)
                        {
                            tol = i;
                            yvan = true;
                        }
                        else break;
                    }
                }

                if (xvan)
                {
                    for (int i = tol + 1; i < ig; i++)
                    {
                        if (puska[i, pos % 10].Checked)
                        {
                            lovesek[i, pos % 10].BackColor = Color.Red;
                        }
                        
                    }
                }
                if (yvan)
                {
                    for (int i = tol + 1; i < ig; i++)
                    {
                        if (puska[pos / 10, i].Checked)
                        {
                            lovesek[pos / 10, i].BackColor = Color.Red;
                        }
                        
                    }               
                }

                if (!xvan && !yvan)
                {
                    lovesek[pos / 10, pos % 10].BackColor = Color.Red;
                }


            }
            else
            {
                lovesek[pos / 10, pos % 10].BackColor = Color.Blue;
                return;
            }
        }
        private void btnkilep_Click(object sender, EventArgs e) 
        {
            Application.Exit();
        }
        private void btnjatek_Click(object sender, EventArgs e)
        {
            if (joE(sajat))
            {
                foreach (var item in sajat)
                {
                    item.Enabled = false;
                    item.BackColor = default;
                }
                foreach (var item in lovesek)
                {
                    item.Enabled = true;
                }

                valasztott = new Random().Next(0, palya.Length);
                int ii = 0;
                foreach (var item in puska)
                {
                    item.Checked = palya[valasztott][ii] == '1';
                    ii++;
                }
            }
            else return;
        }
        private void sajatEllenorzes(object sender, EventArgs e)
        {
            if (joE(sajat))
            {
                foreach (var item in sajat)
                {
                    item.BackColor = Color.Green;
                    
                }
                Jatek.Enabled = true;
            }
            else 
            {
                foreach (var item in sajat)
                { 
                    item.BackColor = Color.Red;
                    Jatek.Enabled = false;
                }
            }
        }


    }
}
