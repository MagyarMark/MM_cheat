using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szalloda
{
    
    public partial class Form1 : Form
    {
        class Price
        {
            public string seasonName { get; set; }
            public DateTime fromDate { get; set; }
            public DateTime toDate { get; set; }
            public int price { get; set; }
            public Price(string Line)
            {
                string[] cut = Line.Split(';');
                this.seasonName = cut[0];
                this.fromDate = DateTime.Parse(cut[1]);
                this.toDate = DateTime.Parse(cut[2]);
                this.price = int.Parse(cut[3]);
            }
        }

        internal class Reservation
        {
            public int id { get; set; }
            public int room { get; set; }
            public int startingMonth { get; set; }
            public int endingMonth { get; set; }
            public int year { get; set; }
            public int firstDay { get; set; }
            public int lastDay { get; set; }
            public int peopleCount { get; set; }
            public bool breakfast { get; set; }
            public string name { get; set; }
            public bool multimonth { get; set; }
            public bool isPaid { get; set; }

            public Reservation(string Line, bool isPaid = true)
            {
                string[] cut = Line.Split(';');
                this.id = int.Parse(cut[0]);
                this.room = int.Parse(cut[1]);
                this.startingMonth = int.Parse(cut[2]);
                this.endingMonth = int.Parse(cut[3]);
                this.year = int.Parse(cut[4]);
                this.firstDay = int.Parse(cut[5]);
                this.lastDay = int.Parse(cut[6]);
                this.peopleCount = int.Parse(cut[7]);
                this.breakfast = false;
                if (cut[8] == "1")
                {
                    this.breakfast = true;
                }
                this.name = cut[9];
                this.multimonth = false;
                if (cut[10] == "1") { this.multimonth = true; }

                if (!isPaid)
                {
                    this.isPaid = false;
                }
                else
                {
                    this.isPaid = true;
                }
            }
        }
        CheckBox[,] matrix2 = new CheckBox[,] { };
        class Foglalas
        {
            public int Ev;
            public int id;
            public int szoba;
            public int bejel;
            public int kijel;
            public int letszam;
            public int ellatas;
            public string nev;

            public Foglalas(int ev, int id, int szoba, int bejel, int kijel, int letszam, int ellatas, string nev)
            {
                this.Ev = ev;
                this.id = id;
                this.szoba = szoba;
                this.bejel = bejel;
                this.kijel = kijel;
                this.letszam = letszam;
                this.ellatas = ellatas;
                this.nev = nev;
            }
        }
        List<Foglalas> foglalasLista = new List<Foglalas>();
        CheckBox[,] napok= new CheckBox[31, 31];
        Label[] szoba = new Label[31];
        Label[] nap= new Label[31];
        private Label allprice;
        public Form1()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button1_Click(sender, e);
            comboBox1.Items.Add("2023");
            comboBox1.Items.Add("2024");
            comboBox1.Items.Add("2025");
            comboBox1.Items.Add("2026");
            comboBox1.Items.Add("2027");
            comboBox1.Items.Add("2028");
            comboBox1.Items.Add("2029");
            comboBox1.Items.Add("2030");
            comboBox1.Items.Add("2031");
            comboBox1.Items.Add("2032");
            comboBox1.Items.Add("2033");
            comboBox1.Items.Add("2034");
            comboBox1.Items.Add("2035");
            comboBox1.Items.Add("2036");
            comboBox1.Items.Add("2037");
            comboBox1.Items.Add("2038");
            comboBox1.Items.Add("2039");
            comboBox1.Items.Add("2040");
            comboBox1.Items.Add("2041");
            comboBox1.Items.Add("2042");
            comboBox1.Items.Add("2043");
            comboBox1.Items.Add("2044");
            comboBox1.Items.Add("2045");
            comboBox1.Items.Add("2046");
            comboBox1.Items.Add("2047");
            comboBox1.Items.Add("2048");
            comboBox1.Items.Add("2049");
            comboBox1.Items.Add("2050");

            comboBox2.Items.Add("Január");
            comboBox2.Items.Add("Február");
            comboBox2.Items.Add("Március");
            comboBox2.Items.Add("Április");
            comboBox2.Items.Add("Május");
            comboBox2.Items.Add("Június");
            comboBox2.Items.Add("Július");
            comboBox2.Items.Add("Augusztus");
            comboBox2.Items.Add("Szeptember");
            comboBox2.Items.Add("Október");
            comboBox2.Items.Add("November");
            comboBox2.Items.Add("December");

            comboBox1.Enabled = false;
            comboBox2.Enabled = false;

            string[] sorok = File.ReadAllLines("pitypang.txt");

            int ev = int.Parse(sorok[1]);

            for (int i = 1; i < sorok.Length; i++)
            {

                string[] parts = sorok[i].Split(' ');

                if (parts.Length == 7)
                {
                    int id = int.Parse(parts[0]);
                    int szoba = int.Parse(parts[1]);
                    int bejel = int.Parse(parts[2]);
                    int kijel = int.Parse(parts[3]);
                    int letszam = int.Parse(parts[4]);
                    int ellatas = int.Parse(parts[5]);
                    string nev = parts[6];

                    Foglalas foglalas = new Foglalas(ev, id, szoba, bejel, kijel, letszam, ellatas, nev);
                    foglalasLista.Add(foglalas);
                }
                else if (parts.Length == 1)
                {
                    ev = int.Parse(parts[0]);
                }
            }

            comboBox1.Text = DateTime.Now.ToString("yyyy");
            comboBox2.Text = DateTime.Now.ToString("MMMM");
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void BtnKi_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void BtnTel_Click(object sender, EventArgs e)
        {
            BtnFoglalas.Visible = false;
            BtnKi.Visible = false;
            BtnStat.Visible = false;
        }
        private void BtnStat_Click(object sender, EventArgs e)
        {//feladat:
         //meg kell csinálni a statisztika gombot, le törlődik a képernyő meg jelenik egy combobox amiben megjelennek az évek hónapok, éves bevétel kiíratása, éves reggelik száma kiíratás, abban a szobában hányszor volt pót ágy
         //működnie kell a foglalalásnak meg a statisztikának

            Controls.Clear();

            ComboBox comboBox = new ComboBox();
            comboBox.Location = new Point(10, 10);
            comboBox.Size = new Size(200, 20);
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            for (int i = 2023; i <= 2049; i++)
            {
                comboBox.Items.Add(i);
            }

            ComboBox comboBox2 = new ComboBox();
            comboBox2.Location = new Point(10, 40);
            comboBox2.Size = new Size(200, 20);
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;

            string[] hónapok = { "Január", "Február", "Március", "Április", "Május", "Június", "Július", "Augusztus", "Szeptember", "Október", "November", "December" };
            foreach (string hónap in hónapok)
            {
                comboBox2.Items.Add(hónap);
            }

            Button statbutton = new Button();
            statbutton.Location = new Point(10, 70);
            statbutton.Size = new Size(100, 20);
            statbutton.Text = "Statisztika";
            statbutton.Click += new EventHandler(Statisztika_Click);
            Controls.Add(comboBox);
            Controls.Add(comboBox2);
            Controls.Add(statbutton);

            comboBox.Text = DateTime.Now.ToString("yyyy");
            comboBox2.Text = DateTime.Now.ToString("MMMM");
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Statisztika_Click(object sender, EventArgs e)
        {
            int ev = int.Parse(((ComboBox)Controls[0]).SelectedItem.ToString());

            int sum2023 = 0;
            int sum2024 = 0;

            var listprices = prices.GroupBy(p => p.price).Select(g => g.First());

            foreach (var p in listprices)
            {
                if (p.fromDate.Year == 2023)
                {
                    sum2023 += p.price;
                }
                else if (p.fromDate.Year == 2024)
                {
                    sum2024 += p.price;
                }
            }

            int évesReggelik = 0;
            foreach (var foglalás in foglalasLista)
            {
                if (foglalás.Ev == ev)
                {
                    évesReggelik += foglalás.letszam;
                }
            }

            int pótÁgy = 0;
            foreach (var foglalás in foglalasLista)
            {
                if (foglalás.Ev == ev)
                {
                    pótÁgy += foglalás.letszam - 1;
                }
            }
            if (ev == 2023)
            {
                MessageBox.Show("Éves bevétel: "+ sum2023 + "\nÉves reggelik: " + évesReggelik + "\nPót ágy: " + pótÁgy);
            }else if (ev == 2024)
            {
                MessageBox.Show("Éves bevétel: "+ sum2024 + "\nÉves reggelik: " + évesReggelik + "\nPót ágy: " + pótÁgy);
            }
        }

        private void BtnFoglalas_Click(object sender, EventArgs e)
        {
            BtnStat.Visible = false;
            BtnTel.Visible = false;
            BtnKi.Visible = false;

            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
        }
        private void matrix(int napokSzama)
        {
            for (int i = 0; i < napokSzama; i++)
            {
                for (int j = 0; j < 27; j++)
                {
                    napok[i, j] = new CheckBox();
                    napok[i, j].Location = new Point(75 + i * 20, 80 + j * 20);
                    napok[i, j].Size = new Size(20, 20);
                    napok[i, j].BackColor = Color.Green;
                    napok[i, j].Enabled = true;
                    napok[i, j].Checked = false;
                    Controls.Add(napok[i, j]);
                    Szinezes();
                }
            }

            for (int i = 0; i < napokSzama; i++)
            {
                nap[i] = new Label();
                nap[i].Location = new Point(75 + i * 20, 55);
                nap[i].Size = new Size(20, 16);
                nap[i].Font = new Font("Arial", 8, FontStyle.Bold);
                nap[i].Text = $"{i + 1}.";
                Controls.Add(nap[i]);
            }
            
        }
        private void BtnVissza_Click(object sender, EventArgs e)
        {
            BtnStat.Visible = true;
            BtnTel.Visible = true;
            BtnKi.Visible = true;
            BtnFoglalas.Visible = true;

            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            comboBox1.Text = DateTime.Now.ToString("yyyy");
            comboBox2.Text = DateTime.Now.ToString("MMMM");

        }
        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("szalloda.data.txt");
            while (!reader.EndOfStream)
            {
                foglalas.Add(new Reservation(reader.ReadLine()));
            }
            reader.Close();

            reader = new StreamReader("arak.txt");
            while (!reader.EndOfStream)
            {
                prices.Add(new Price(reader.ReadLine()));
            }
            reader.Close();

            foreach (var r in foglalas)
            {
                Debug.WriteLine($"Foglalás: Szoba {r.room}, {r.year}.{r.startingMonth}-{r.endingMonth}, {r.firstDay}-{r.lastDay}");
            }
            foreach (var r in prices)
            {
                Debug.WriteLine($"Ár: Szoba {r.fromDate}-{r.toDate}-{r.price}");
            }
            
        }
        List<Reservation> foglalas = new List<Reservation>();
        List<Price> prices = new List<Price>();

        private void Szinezes()
        {
            int selectedYear = int.Parse(comboBox1.Text);
            int selectedMonth = comboBox2.SelectedIndex + 1;

            for (int i = 0; i < 31; i++)
            {
                for (int j = 0; j < 27; j++)
                {
                    if (napok[i, j] != null)
                    {
                        napok[i, j].BackColor = Color.Green;
                    }
                }
            }

            foreach (var r in foglalas)
            {
                if (r.year == selectedYear && r.startingMonth == selectedMonth)
                {
                    for (int i = r.firstDay - 1; i <= r.lastDay - 1; i++)
                    {
                        if (i >= 0 && i < 31 && r.room - 1 >= 0 && r.room - 1 < 27 && napok[i, r.room - 1] != null)
                        {
                            napok[i, r.room - 1].BackColor = Color.Red;
                        }
                    }
                }
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Controls.OfType<Label>().ToList().ForEach(x => Controls.Remove(x));
            Controls.OfType<CheckBox>().ToList().ForEach(x => Controls.Remove(x));


            if (int.TryParse(comboBox1.SelectedItem.ToString(), out int year))
            {
                int month = comboBox2.SelectedIndex + 1;
                int honapSzam = DateTime.DaysInMonth(year, month);


                CheckBox[,] matrix = new CheckBox[27, honapSzam];

                for (int y = 0; y < matrix.GetLength(0); y++)
                {
                    for (int x = 0; x < matrix.GetLength(1); x++)
                    {
                        matrix[y, x] = new CheckBox();
                        matrix[y, x].Location = new Point(60 + x * 20, 100 + y * 20);
                        matrix[y, x].AutoSize = false;
                        matrix[y, x].Size = new Size(20, 20);
                        matrix[y, x].Visible = true;
                        matrix[y, x].Enabled = true;
                        matrix[y, x].Checked = false;
                        matrix[y, x].Text = null;
                        matrix[y, x].Name = y.ToString() + x.ToString();
                        matrix[y, x].BackColor = Color.Green;
                        Controls.Add(matrix[y, x]);
                    }
                }

                foreach (var foglalas in foglalasLista)
                {
                    if (foglalas.Ev == int.Parse(comboBox1.SelectedItem.ToString()) && foglalas.bejel <= honapSzam && foglalas.kijel >= 1)
                    {
                        for (int i = foglalas.bejel - 1; i < foglalas.kijel; i++)
                        {
                            if (i >= 0 && i < honapSzam)
                            {
                                matrix[foglalas.szoba - 1, i].BackColor = Color.Red;
                                matrix[foglalas.szoba - 1, i].Enabled = false;
                            }
                        }
                    }
                }

                matrix2 = matrix;

                Label[,] label = new Label[28, honapSzam + 1];

                for (int i = 0; i < label.GetLength(0); i++)
                {
                    for (int j = 0; j < label.GetLength(1); j++)
                    {
                        if (i == 0 && j != 0)
                        {
                            label[i, j] = new Label();
                            label[i, j].Location = new Point(40 + j * 20, 80 + i * 20);
                            label[i, j].AutoSize = false;
                            label[i, j].Size = new Size(20, 20);
                            label[i, j].Visible = true;
                            label[i, j].Enabled = true;
                            label[i, j].Text = j.ToString();
                        }

                        if (i != 0 && j == 0)
                        {
                            label[i, j] = new Label();
                            label[i, j].Location = new Point(5 + j * 20, 80 + i * 20);
                            label[i, j].AutoSize = false;
                            label[i, j].Size = new Size(60, 20);
                            label[i, j].Visible = true;
                            label[i, j].Enabled = true;
                            label[i, j].Text = i.ToString() + ". szoba";
                        }
                        Controls.Add(label[i, j]);
                    }
                }
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 31; i++)
            {
                for (int j = 0; j < 27; j++)
                {
                    if (napok[i, j] != null)
                    {
                        napok[i, j].Checked = false;
                    }
                }
            }
        }
    }
}
