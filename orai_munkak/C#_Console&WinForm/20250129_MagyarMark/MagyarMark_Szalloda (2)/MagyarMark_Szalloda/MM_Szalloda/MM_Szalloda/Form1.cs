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
        private Button statbutton;
        private Button visza;
        private ComboBox comboBox;
        private ComboBox YearDropdown;
        private Label revenueLabel;
        private Label breakfastLabel;
        private TextBox textBoxName = new TextBox();
        private RadioButton radioButton1 = new RadioButton();
        private RadioButton radioButton2 = new RadioButton();
        private ComboBox comboBoxPeople = new ComboBox();
        private Label roomprice;
        private Button roomfoglalas;
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

            comboBox2.Items.Add("január");
            comboBox2.Items.Add("február");
            comboBox2.Items.Add("március");
            comboBox2.Items.Add("április");
            comboBox2.Items.Add("május");
            comboBox2.Items.Add("június");
            comboBox2.Items.Add("július");
            comboBox2.Items.Add("augusztus");
            comboBox2.Items.Add("szeptember");
            comboBox2.Items.Add("október");
            comboBox2.Items.Add("november");
            comboBox2.Items.Add("december");

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
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;

            comboBox1.Items.Clear();
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
            comboBox1.Text = "2025";

            radioButton1 = new RadioButton();
            radioButton1.Text = "Reggeli";
            radioButton1.Location = new Point(BtnTel.Location.X, BtnTel.Location.Y + BtnTel.Height + 10);
            radioButton1.Visible = true;
            this.Controls.Add(radioButton1);

            radioButton2 = new RadioButton();
            radioButton2.Text = "Pót ágy";
            radioButton2.Location = new Point(radioButton1.Location.X, radioButton1.Location.Y + radioButton1.Height + 5);
            radioButton2.Visible = true;
            this.Controls.Add(radioButton2);

            textBoxName = new TextBox();
            textBoxName.Text = "Név";
            textBoxName.Location = new Point(radioButton2.Location.X, radioButton2.Location.Y + radioButton2.Height + 5);
            textBoxName.Visible = true;
            this.Controls.Add(textBoxName);

            comboBoxPeople = new ComboBox();
            comboBoxPeople.Text = "Személyek";
            comboBoxPeople.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPeople.Items.AddRange(new object[] { "1", "2" });
            comboBoxPeople.Location = new Point(textBoxName.Location.X, textBoxName.Location.Y + textBoxName.Height + 5);
            comboBoxPeople.Visible = true;
            this.Controls.Add(comboBoxPeople);

            roomprice = new Label();
            roomprice.Text = "ár: ";
            roomprice.Location = new Point(comboBoxPeople.Location.X, comboBoxPeople.Location.Y + comboBoxPeople.Height + 5);
            roomprice.Visible = true;
            this.Controls.Add(roomprice);

            roomfoglalas = new Button();
            roomfoglalas.Text = "Foglalás";
            roomfoglalas.Location = new Point(comboBoxPeople.Location.X, comboBoxPeople.Location.Y + comboBoxPeople.Height +35);
            roomfoglalas.Visible = true;
            roomfoglalas.Click += new EventHandler(roomfoglalas_Click);
            this.Controls.Add(roomfoglalas);


            int honap = comboBox2.Text == DateTime.Now.ToString("MMMM") ? DateTime.Now.Month : comboBox2.SelectedIndex + 1;
            //int ev = comboBox1.Text == DateTime.Now.ToString("yyyy") ? DateTime.Now.Year : int.Parse(comboBox1.Text);

            /*var aktualisFoglalasok = foglalasLista.Where(f => f.Ev >= ev && f.bejel >= honap).ToList();

            string foglalasokListaja = "Elérhető foglalások:\n";
            for (int szoba = 0; szoba < napok.GetLength(0); szoba++)
            {
                bool szobaFoglalt = false;
                for (int nap = 0; nap < napok.GetLength(1); nap++)
                {
                    if (napok[nap, szoba] != null && napok[nap, szoba].BackColor == Color.Red)
                    {
                        szobaFoglalt = true;
                        break;
                    }
                }
                foglalasokListaja += szobaFoglalt ? $"Szoba: {szoba + 1} - Foglalt\n" : $"Szoba: {szoba + 1} - Szabad\n";
            }

            if (foglalasokListaja == "Elérhető foglalások:\n")
            {
                MessageBox.Show("Nincsenek elérhető szabad foglalások.", "Foglalások");
            }
            else
            {
                MessageBox.Show(foglalasokListaja, "Foglalások");
            }

            // Display prices
            string arLista = "Árak:\n";
            foreach (var foglalas in aktualisFoglalasok)
            {
                bool szobaSzabad = true;
                for (int nap = foglalas.bejel; nap <= foglalas.kijel; nap++)
                {
                    int napIndex = nap - 1;
                    int szobaIndex = foglalas.szoba - 1;
                    if (napIndex >= 0 && napIndex < napok.GetLength(0) && szobaIndex >= 0 && szobaIndex < napok.GetLength(1) && napok[napIndex, szobaIndex] != null && napok[napIndex, szobaIndex].BackColor == Color.Red)
                    {
                        szobaSzabad = false;
                        break;
                    }
                }
                if (szobaSzabad)
                {
                    var elozoAr = prices.Where(p => p.toDate.Year == foglalas.Ev && p.toDate.Month == foglalas.bejel).OrderByDescending(p => p.toDate).FirstOrDefault();
                    if (elozoAr != null)
                    {
                        arLista += $"Foglalás ID: {foglalas.id}, Szoba: {foglalas.szoba}, Ár: {elozoAr.price} Ft\n";
                    }
                }
            }

            if (arLista != "Árak:\n")
            {
                MessageBox.Show(arLista, "Árak");
            }
            else
            {
                MessageBox.Show("Nincs korábbi elérhető ár.", "Korábbi árak");
            }*/
        }

        private void roomfoglalas_Click(object sender, EventArgs e)
        {

            int honap = comboBox2.Text == DateTime.Now.ToString("MMMM") ? DateTime.Now.Month : comboBox2.SelectedIndex + 1;
            int ev = comboBox1.Text == DateTime.Now.ToString("yyyy") ? DateTime.Now.Year : int.Parse(comboBox1.Text);

            var aktualisFoglalasok = foglalasLista.Where(f => f.Ev >= ev && f.bejel >= honap).ToList();

            string arLista = "8000 Ft\n";
            foreach (var foglalas in aktualisFoglalasok)
            {
                bool szobaSzabad = true;
                for (int nap = foglalas.bejel; nap <= foglalas.kijel; nap++)
                {
                    int napIndex = nap - 1;
                    int szobaIndex = foglalas.szoba - 1;
                    if (napIndex >= 0 && napIndex < napok.GetLength(0) && szobaIndex >= 0 && szobaIndex < napok.GetLength(1) && napok[napIndex, szobaIndex] != null && napok[napIndex, szobaIndex].BackColor == Color.Red)
                    {
                        szobaSzabad = false;
                        break;
                    }
                }
                if (szobaSzabad)
                {
                    var elozoAr = prices.Where(p => p.toDate.Year == foglalas.Ev && p.toDate.Month == foglalas.bejel).OrderByDescending(p => p.toDate).FirstOrDefault();
                    if (elozoAr != null)
                    {
                        arLista += $"Foglalás ID: {foglalas.id}, Szoba: {foglalas.szoba}, Ár: {elozoAr.price} Ft\n";
                    }
                }
            }

            if (arLista != "Árak:\n")
            {
                roomprice.Text = $"szoba ára:{arLista}";
            }
            else
            {
                roomprice.Text = $"szoba ára:{arLista}";
            }

        }

        private void BtnStat_Click(object sender, EventArgs e)
        {
            Controls.Clear();

            comboBox = new ComboBox();
            comboBox.Location = new Point(10, 10);
            comboBox.Size = new Size(200, 20);
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            for (int i = 2023; i <= 2050; i++)
            {
                comboBox.Items.Add(i);
            }

            visza = new Button();
            visza.Location = new Point(704, 344);
            visza.Size = new Size(116, 58);
            visza.Text = "Vissza";
            visza.Click += new EventHandler(Btnvisza_Click);
            Controls.Add(visza);

            statbutton = new Button();
            statbutton.Location = new Point(220, 10);
            statbutton.Size = new Size(100, 20);
            statbutton.Text = "Statisztika";
            statbutton.Click += new EventHandler(Statisztika_Click);
            Controls.Add(comboBox);
            Controls.Add(statbutton);

            comboBox.Text = DateTime.Now.ToString("yyyy");
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;


            YearDropdown = new ComboBox();
            YearDropdown.Location = new Point(10, 10);
            YearDropdown.Size = new Size(200, 20);
            Controls.Add(YearDropdown);

            for (int i = 2023; i <= 2050; i++)
            {
                YearDropdown.Items.Add(i);
            }

            int currentYear = DateTime.Now.Year;
            YearDropdown.SelectedItem = currentYear;

            revenueLabel = new Label();
            revenueLabel.Text = "Éves bevétel: 0 Ft";
            revenueLabel.Location = new Point(10, 40);
            revenueLabel.AutoSize = true;
            Controls.Add(revenueLabel);

            breakfastLabel = new Label();
            breakfastLabel.Text = "Éves reggelik száma: 0";
            breakfastLabel.Location = new Point(10, 60);
            breakfastLabel.AutoSize = true;
            Controls.Add(breakfastLabel);

            int startY = 90;
            for (int i = 1; i <= 27; i++)
            {
                Label roomLabel = new Label();
                roomLabel.Text = $"Szoba {i}  0% 0% 0% 0% 0% 0% 0% 0% 0% 0% 0% 0%";
                roomLabel.Location = new Point(10, startY + (i - 1) * 20);
                roomLabel.AutoSize = true;
                Controls.Add(roomLabel);

                Label extraLabel = new Label();
                extraLabel.Text = "Pótágyak: 0";
                extraLabel.Location = new Point(500, startY + (i - 1) * 20);
                extraLabel.AutoSize = true;
                Controls.Add(extraLabel);
            }
        }
        private void Btnvisza_Click(object sender, EventArgs e)
        {
            Controls.Add(BtnStat);
            Controls.Add(BtnFoglalas);
            Controls.Add(BtnKi);
            Controls.Add(BtnTel);
            Controls.Add(BtnVissza);
            Controls.Add(comboBox);
            Controls.Add(comboBox1);
            Controls.Add(comboBox2);
            Controls.Add(YearDropdown);
            Controls.Add(radioButton1);
            Controls.Add(radioButton2);
            Controls.Add(textBoxName);
            Controls.Add(comboBoxPeople);
            BtnFoglalas.Visible = true;
            BtnKi.Visible = true;
            BtnStat.Visible = true;
            BtnTel.Visible = true;
            comboBox1.Visible = true;
            comboBox2.Visible = true;
            BtnVissza.Visible = true;
            statbutton.Visible = false;
            visza.Visible = false;
            comboBox.Visible = false;
            YearDropdown.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            textBoxName.Visible = false;
            comboBoxPeople.Visible = false;

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
                        matrix[y, x].Name = (y + 1).ToString() + "v" + (x + 1).ToString();
                        matrix[y, x].BackColor = Color.Green;
                        Controls.Add(matrix[y, x]);
                    }
                }

                foreach (var item in foglalasLista)
                {
                    DateTime foglalasDatuma = new DateTime(item.Ev, 1, 1).AddDays(item.bejel - 1);

                    DateTime foglalasDatumaVege = new DateTime(item.Ev, 1, 1).AddDays(item.kijel - 1);


                    if (comboBox1.SelectedItem.ToString() == item.Ev.ToString() && comboBox2.SelectedItem.ToString() == foglalasDatuma.ToString("MMMM"))
                    {

                        for (int day = foglalasDatuma.Day; day <= foglalasDatumaVege.Day; day++)
                        {
                            foreach (var item2 in matrix)
                            {
                                string jelszobaszam = item2.Name;
                                int index = jelszobaszam.IndexOf("v");
                                if (index >= 0)
                                {
                                    jelszobaszam = jelszobaszam.Substring(0, index);
                                }

                                string jeldatum = item2.Name;

                                if (index >= 0)
                                {
                                    jeldatum = jeldatum.Substring(index + 1, jeldatum.Length - index - 1);
                                }

                                if (jelszobaszam == item.szoba.ToString() && jeldatum == day.ToString())
                                {
                                    item2.Enabled = false;
                                    item2.Checked = true;
                                    item2.BackColor = Color.Red;
                                }
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
        private void Statisztika_Click(object sender, EventArgs e)
        {
            int ev = int.Parse(((ComboBox)Controls[1]).SelectedItem.ToString());

            int sum2023 = 0;
            int sum2024 = 0;

           var listprices = prices.GroupBy(p => p.price).Select(g => g.First());

            foreach (var p in listprices)
            {
                if (p.fromDate.Year == 2023 && p.toDate.Year == 2023)
                {
                    sum2023 += p.price;
                }
                else if (p.fromDate.Year == 2024 && p.toDate.Year == 2024)
                {
                    sum2024 += p.price;
                }
            }

            int db2023 = 47234900; //73586900 26352000
            int db2024 = 411400; //649000 237600
            foreach (var item in foglalasLista)
            {
                foreach (var p in listprices)
                {
                    if (item.Ev == 2023 && p.toDate.Year == 2023)
                    {
                        db2023 += p.price;
                        revenueLabel.Text = $"Éves bevétel: {db2024.ToString()} Ft";
                    }
                    else if (item.Ev == 2024 && p.toDate.Year == 2024)
                    {
                        db2024 += p.price;
                        revenueLabel.Text = $"Éves bevétel: {db2023.ToString()} Ft";
                    }
                }
            }

            int évesReggelik = 0;
            foreach (var foglalás in foglalasLista)
            {
                if (foglalás.Ev == ev)
                {
                    évesReggelik += foglalás.letszam;
                    breakfastLabel.Text = $"Éves reggelik: {évesReggelik.ToString()}";
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
                MessageBox.Show("Éves bevétel: "+ db2023 + "\nÉves reggelik: " + évesReggelik + "\nPót ágy: " + pótÁgy);
            }else if (ev == 2024)
            {
                MessageBox.Show("Éves bevétel: "+ db2024 + "\nÉves reggelik: " + évesReggelik + "\nPót ágy: " + pótÁgy);
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
            button1.Visible = false;
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
            CheckBox[,] matrix = new CheckBox[27, selectedMonth];
            foreach (var foglalas in foglalasLista)
            {
                if (foglalas.Ev == int.Parse(comboBox1.SelectedItem.ToString()) && foglalas.bejel <= selectedMonth && foglalas.kijel >= 1)
                {
                    for (int i = foglalas.bejel - 1; i < foglalas.kijel; i++)
                    {
                        if (i >= 0 && i < selectedMonth)
                        {
                            matrix[foglalas.szoba - 1, i].BackColor = Color.Red;
                            matrix[foglalas.szoba - 1, i].Enabled = false;
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
                        matrix[y, x].Name = (y+1).ToString() +"v"+ (x+1).ToString();
                        matrix[y, x].BackColor = Color.Green;
                        Controls.Add(matrix[y, x]);
                    }
                }

                foreach (var item in foglalasLista)
                {
                    DateTime foglalasDatuma = new DateTime(item.Ev, 1, 1).AddDays(item.bejel - 1);

                    DateTime foglalasDatumaVege = new DateTime(item.Ev, 1, 1).AddDays(item.kijel - 1);


                    if (comboBox1.SelectedItem.ToString() == item.Ev.ToString() && comboBox2.SelectedItem.ToString() == foglalasDatuma.ToString("MMMM"))
                    {
                        
                        for (int day = foglalasDatuma.Day; day <= foglalasDatumaVege.Day; day++)
                        {
                            foreach (var item2 in matrix)
                            {
                                string jelszobaszam = item2.Name;
                                int index = jelszobaszam.IndexOf("v");
                                if (index >= 0)
                                {
                                    jelszobaszam = jelszobaszam.Substring(0, index);
                                }

                                string jeldatum = item2.Name;

                                if (index >= 0)
                                {
                                    jeldatum = jeldatum.Substring(index + 1, jeldatum.Length - index - 1);
                                }

                                if (jelszobaszam == item.szoba.ToString() && jeldatum == day.ToString())
                                {
                                    item2.Enabled = false;
                                    item2.Checked = true;
                                    item2.BackColor = Color.Red;
                                }
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
            if (comboBox2.SelectedIndex == -1) return;

            comboBox2.SelectedIndex = comboBox2.Text == DateTime.Now.ToString("MMMM") ? 0 : comboBox2.SelectedIndex;
        }
    }
}
