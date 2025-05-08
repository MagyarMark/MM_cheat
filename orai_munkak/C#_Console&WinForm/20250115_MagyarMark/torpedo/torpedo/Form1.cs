using System.Text;

namespace torpedo
{
    public partial class Form1 : Form
    {
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
                    }
                    else alap[i + 1, j + 1] = 0;

            if (jelolt != 15) // 15 jelölés vizsgálata
            {
                MessageBox.Show("Nincs 15 jelölés");
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
                            MessageBox.Show("Túl nagy hajó (H)");
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
                            MessageBox.Show("Túl nagy hajó (V)");
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
                    MessageBox.Show($"Nincs {i} méretû hajó");
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
                    MessageBox.Show($"Nincs {i} méretû hajó");
                    return false;
                }
            }

            return true;
        }

        public Form1()
        {
            InitializeComponent();
        }
        public CheckBox[,] matrix = new CheckBox[10, 10];
        private void Torpedo_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    matrix[y, x] = new CheckBox();
                    matrix[y, x].Location = new Point(15 + x * 25, 115 + y * 20);
                    matrix[y, x].AutoSize = false;
                    matrix[y, x].Size = new Size(20, 20);
                    matrix[y, x].Enabled = true;
                    matrix[y, x].Checked = false;
                    matrix[y, x].Text = null;
                    Controls.Add(matrix[y, x]);

                }
            }

        }

        public void btnReset_Click(object sender, EventArgs e)
        {
            foreach (var item in matrix)
            {
                item.Checked = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textBox1.Text.Replace(' ','_');
            textBox1.Text = textBox1.Text.Trim();
            if (textBox1.Text.Length == 0) btnSave.Enabled = false;
            else btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (joE(matrix) == false) return;

            StreamWriter sw = new StreamWriter(textBox1.Text+".txt");
            foreach (var item in matrix)
            {
                if (item.Checked) sw.Write(1.ToString());
                else sw.Write(0.ToString());
            }
            sw.WriteLine();
            sw.Close();
            btnReset_Click(sender, e);
        }
    }
}
