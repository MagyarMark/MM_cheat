using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public class Szoba
    {
        public int sorszam { get; set; }
        public int szobaszam { get; set; }
        public int elsoNap { get; set; }
        public int utolsoNap { get; set; }
        public int letszam { get; set; }
        public int reggeli { get; set; }
        public string azonosito { get; set; }
        public int ev { get; set; }
        public bool fizetve { get; set; }
    }
    public partial class Form1 : Form
    {
        Label[] szobaLabels = new Label[27];
        Label[] napLabels = new Label[31];
        Label Foszam = new Label();
        Label Nev = new Label();
        Label TeljesAr = new Label();
        CheckBox[,] matrix = new CheckBox[31, 31];
        CheckBox Reggeli = new CheckBox();
        CheckBox Fizetve = new CheckBox();
        Button Telefon = new Button();
        Button Statisztika = new Button();
        Button Foglalas = new Button();
        Button Kilepes = new Button();
        Button UjFoglalas = new Button();
        ComboBox Evek = new ComboBox();
        ComboBox Honapok = new ComboBox();
        List<Szoba> foglalasok = new List<Szoba>();
        Dictionary<int, int> szobaIndexMap = new Dictionary<int, int>();
        TextBox FoszamText = new TextBox();
        TextBox NevText = new TextBox();


        public Form1()
        {
            InitializeComponent();
            BeolvasFoglalasok();
        }

        public static int EvNapjaEsHonap(int ev, int napSorszama)
        {
            int[] napokHonaponkent = DateTime.IsLeapYear(ev)
                ? new int[] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 }
                : new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            int honap = 1;

            while (napSorszama > napokHonaponkent[honap - 1])
            {
                napSorszama -= napokHonaponkent[honap - 1];
                honap++;
            }

            return honap;
        }
        public static int EvNapjaEsNap(int ev, int napSorszama)
        {
            int[] napokHonaponkent = DateTime.IsLeapYear(ev)
                ? new int[] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 }
                : new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            int honap = 1;

            while (napSorszama > napokHonaponkent[honap - 1])
            {
                napSorszama -= napokHonaponkent[honap - 1];
                honap++;
            }

            return napSorszama;
        }

        private void BeolvasFoglalasok()
        {
            string filePath = "pitypang.txt";
            if (!File.Exists(filePath))
            {
                MessageBox.Show("A foglalási fájl nem található!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foglalasok.Clear();
            szobaIndexMap.Clear();

            int aktualisEv = 0;
            HashSet<int> egyediSzobak = new HashSet<int>();

            foreach (var sor in File.ReadAllLines(filePath))
            {
                string[] adatok = sor.Split(' ');

                if (adatok.Length == 1 && int.TryParse(adatok[0], out int ev))
                {
                    aktualisEv = ev;
                }
                else if (adatok.Length == 7 && aktualisEv != 0)
                {
                    int szobaszam = int.Parse(adatok[1]);
                    egyediSzobak.Add(szobaszam);

                    foglalasok.Add(new Szoba
                    {
                        sorszam = int.Parse(adatok[0]),
                        szobaszam = szobaszam,
                        elsoNap = int.Parse(adatok[2]),
                        utolsoNap = int.Parse(adatok[3]),
                        letszam = int.Parse(adatok[4]),
                        reggeli = int.Parse(adatok[5]),
                        azonosito = adatok[6],
                        ev = aktualisEv,
                        fizetve = true
                    });
                }
            }

            int index = 0;
            foreach (int szoba in egyediSzobak.OrderBy(x => x))
            {
                szobaIndexMap[szoba] = index++;
            }
        }

        private void ResetMatrixColors()
        {
            if (matrix == null)
            {
                return;
            }

            for (int s = 0; s < matrix.GetLength(0); s++)
            {
                for (int o = 0; o < matrix.GetLength(1); o++)
                {
                    if (matrix[s, o] != null)
                    {
                        matrix[s, o].BackColor = Color.Green;
                        matrix[s, o].Checked = false;
                        matrix[s, o].Enabled = false;
                        matrix[s, o].Text = "";
                    }
                }
            }
        }

        private void MegjelenitFoglalasokat()
        {
            if (Evek.SelectedIndex == -1 || Honapok.SelectedIndex == -1)
            {
                MessageBox.Show("Válassz ki egy évet és egy hónapot!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int ev = int.Parse(Evek.SelectedItem.ToString());
            int honap = Honapok.SelectedIndex + 1;
            int napokSzama = DateTime.DaysInMonth(ev, honap);

            for (int s = 0; s < 31; s++)
            {
                for (int o = 0; o < 27; o++)
                {
                    if (matrix[s, o] != null)
                    {
                        matrix[s, o].BackColor = Color.Green;
                        matrix[s, o].Checked = false;
                        matrix[s, o].Enabled = false;
                        matrix[s, o].Text = "";
                    }
                }
            }

            List<Szoba> aktualisFoglalasok = foglalasok
            .Where(f => f.ev == ev)
            .Where(f => EvNapjaEsHonap(ev, f.elsoNap) <= honap)
            .Where(f => EvNapjaEsHonap(ev, f.utolsoNap) >= honap)
            .ToList();

            foreach (Szoba foglalas in aktualisFoglalasok)
            {
                int kezdoHonap = EvNapjaEsHonap(ev, foglalas.elsoNap);
                int kezdoNap = kezdoHonap == honap ? EvNapjaEsNap(ev, foglalas.elsoNap) : 1;
                int vegsoHonap = EvNapjaEsHonap(ev, foglalas.utolsoNap);
                int vegsoNap = vegsoHonap == honap ? EvNapjaEsNap(ev, foglalas.utolsoNap) : napokSzama;


                if (!szobaIndexMap.ContainsKey(foglalas.szobaszam))
                {
                    MessageBox.Show($"Hibás szobaszám: {foglalas.szobaszam}!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continue;
                }

                int szobaIndex = foglalas.szobaszam - 1;

                for (int nap = kezdoNap - 1; nap < vegsoNap; nap++)
                {
                    if (matrix[nap, szobaIndex] != null)
                    {
                        matrix[nap, szobaIndex].BackColor = foglalas.fizetve ? Color.Red : Color.Yellow;
                        matrix[nap, szobaIndex].Checked = !Foszam.Visible;
                        matrix[nap, szobaIndex].Enabled = false;
                        matrix[nap, szobaIndex].Text = foglalas.azonosito.Split('_')[0];
                    }
                }
            }
        }

        public void UpdateMatrix()
        {
            if (Evek.SelectedIndex == -1 || Honapok.SelectedIndex == -1)
            {
                return;
            }


            int ev = int.Parse(Evek.SelectedItem.ToString());
            int honap = Honapok.SelectedIndex + 1;
            int honapokNapjai = DateTime.DaysInMonth(ev, honap);

            for (int i = 0; i < napLabels.Length; i++)
            {
                if (napLabels[i] != null)
                {
                    Controls.Remove(napLabels[i]);
                    napLabels[i] = null;
                }
            }
            for (int i = 0; i < szobaLabels.Length; i++)
            {
                if (szobaLabels[i] != null)
                {
                    Controls.Remove(szobaLabels[i]);
                    szobaLabels[i] = null;
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] != null)
                    {
                        Controls.Remove(matrix[i, j]);
                        matrix[i, j] = null;
                    }
                }
            }


            for (int s = 0; s < honapokNapjai; s++)
            {
                napLabels[s] = new Label
                {
                    Location = new Point(70 + s * 22, 80),
                    Size = new Size(22, 20),
                    Text = $"{s + 1}.",
                    TextAlign = ContentAlignment.MiddleCenter
                };
                Controls.Add(napLabels[s]);
            }
            for (int o = 0; o < 27; o++)
            {
                szobaLabels[o] = new Label
                {
                    Location = new Point(10, 98 + o * 20),
                    Size = new Size(54, 20),
                    Text = $"{o + 1}. szoba",
                    TextAlign = ContentAlignment.MiddleRight
                };
                Controls.Add(szobaLabels[o]);
            }
            for (int s = 0; s < honapokNapjai; s++)
            {
                for (int o = 0; o < 27; o++)
                {
                    matrix[s, o] = new CheckBox
                    {
                        Location = new Point(74 + s * 22, 100 + o * 20),
                        Size = new Size(22, 20),
                        Enabled = false
                    };
                    matrix[s, o].BackColor = Color.Green;
                    Controls.Add(matrix[s, o]);
                }
            }

            if (Kilepes.Text == "Vissza")
            {
                MegjelenitFoglalasokat();
            }
            if (UjFoglalas.Visible)
            {
                for (int s = 0; s < honapokNapjai; s++)
                {
                    for (int o = 0; o < 27; o++)
                    {
                        if (matrix[s, o].BackColor == Color.Green)
                        {
                            matrix[s, o].Enabled = true;
                        }
                    }
                }
            }
        }

        private void btnKILEPES_Click(object sender, EventArgs e)
        {
            if (Kilepes.Text == "Vissza")
            {
                Statisztika.Visible = true;
                Telefon.Visible = true;
                Foglalas.Visible = true;
                UjFoglalas.Visible = false;
                Foszam.Visible = false;
                Nev.Visible = false;
                FoszamText.Visible = false;
                NevText.Visible = false;
                Reggeli.Visible = false;
                Fizetve.Visible = false;
                TeljesAr.Visible = false;
                Kilepes.Text = "Kilépés";

                Evek.Items.Clear();
                string[] evek = new string[]
                {
                    "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031",
                    "2032", "2033", "2034", "2035", "2036", "2037", "2038", "2039", "2040",
                    "2041", "2042", "2043", "2044", "2045", "2046", "2047", "2048", "2049",
                    "2050",
                };
                Evek.Items.AddRange(evek);
                Evek.Text = DateTime.Now.ToString("yyy");

                ResetMatrixColors();
            }
            else
            {
                Application.Exit();
            }
        }

        private void btnFOGLALAS_Click(object sender, EventArgs e)
        {
            Statisztika.Visible = false;
            Telefon.Visible = false;
            Kilepes.Text = "Vissza";
            MegjelenitFoglalasokat();
        }
        private void btnSTATISZTIKA_Click(object sender, EventArgs e)
        {
        }

        private void btnTELEFON_Click(object sender, EventArgs e)
        {
            Foglalas.Visible = false;
            Statisztika.Visible = false;
            Telefon.Visible = false;
            Kilepes.Text = "Vissza";
            UjFoglalas.Visible = true;
            Foszam.Visible = true;
            Nev.Visible = true;
            FoszamText.Visible = true;
            NevText.Visible = true;
            Reggeli.Visible = true;
            Fizetve.Visible = true;

            int aktualisEv = DateTime.Now.Year;

            Evek.Items.Clear();
            for (int i = aktualisEv; i <= 2050; i++)
            {
                Evek.Items.Add(i.ToString());
            }
            Evek.Text = aktualisEv.ToString();


        }

        private void BeolvasArakat()
        {
            string filePath = "arak.txt";
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Az árak fájl nem található!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnUJFOGLALAS_Click(object sender, EventArgs e)
        {
            TeljesAr.Visible = true;
            int ev = Evek.SelectedIndex + 2025;
            int honap = Honapok.SelectedIndex + 1;
            int napiAr = 0;
            int szobaindex = -1;
            int honapokNapjai = DateTime.DaysInMonth(ev, honap);
            

            for (int o = 0; o < 27; o++)
            {
                for (int s = 0; s < honapokNapjai; s++)
                {
                    if (matrix[s, o].Checked)
                    {
                        if (szobaindex == -1)
                        {
                            szobaindex = o;
                        }
                        else
                        {
                            MessageBox.Show("Egyszerre csak 1 szobát válassz", "Hiba");
                            return;
                        }
                        break;
                    }
                }
            }
            int elsoNap = -1;
            int utolsoNap = -1;

            int letszam = 0;
            try
            {
                letszam = Convert.ToInt32(FoszamText.Text);
            }
            catch (Exception)
            {
                MessageBox.Show($"Hibás létszám: {FoszamText.Text}", "Hiba");
                return;
            }

            if (letszam <= 0)
            {
                MessageBox.Show($"Hibás létszám: {letszam}", "Hiba");
                return;
            }
            if (szobaindex == -1)
            {
                MessageBox.Show("Nem jelöltél ki szobát", "Hiba");
                return;
            }
            for (int i = 0; i < honapokNapjai; i++)
            {
                if (matrix[i, szobaindex].Checked && elsoNap == -1)
                {
                    DateTime datum = new DateTime(ev, honap, i + 1);
                    elsoNap = datum.DayOfYear;
                }
                if (matrix[i, szobaindex].Checked)
                {
                    DateTime datum = new DateTime(ev, honap, i + 1);
                    if (utolsoNap == datum.DayOfYear - 1 || utolsoNap == -1)
                    {
                        utolsoNap = datum.DayOfYear;
                    }
                    else
                    {
                        MessageBox.Show("A napok nem követik egymást!", "Hiba");
                        return;
                    }
                }
            }
            if (NevText.Text.Length < 3)
            {
                MessageBox.Show("Nem adtál meg elég karaktert", "Hiba");
                return;
            }
            int teljesAr = napiAr * (utolsoNap - elsoNap);
            if (Reggeli.Checked)
            {
                teljesAr += letszam * (utolsoNap - elsoNap) * 1100;
            }
            TeljesAr.Text = $"Teljes ár: {teljesAr}Ft";

            Szoba foglalas = new Szoba()
            {
                reggeli = Reggeli.Checked ? 1 : 0,
                fizetve = Fizetve.Checked,
                letszam = letszam,
                ev = ev,
                szobaszam = szobaindex + 1,
                elsoNap = elsoNap,
                utolsoNap = utolsoNap,
                azonosito = NevText.Text

            };
            foglalasok.Add(foglalas);
            UpdateMatrix();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            UjFoglalas = new Button
            {
                Location = new Point(800, 290),
                AutoSize = false,
                Size = new Size(100, 50),
                Text = "Foglalás",
                Enabled = true,
                Name = "btnUJFOGLALAS",
                Visible = false
            };
            this.Controls.Add(UjFoglalas);
            UjFoglalas.Click += btnUJFOGLALAS_Click;

            Telefon = new Button
            {
                Location = new Point(800, 150),
                AutoSize = false,
                Size = new Size(100, 50),
                Text = "Telefon",
                Enabled = true,
                Name = "btnTELEFON",
                Visible = true
            };
            this.Controls.Add(Telefon);
            Telefon.Click += btnTELEFON_Click;

            Statisztika = new Button
            {
                Location = new Point(800, 220),
                AutoSize = false,
                Size = new Size(100, 50),
                Text = "Statisztika",
                Enabled = true,
                Name = "btnSTATISZTIKA",
                Visible = true
            };
            this.Controls.Add(Statisztika);
            Statisztika.Click += btnSTATISZTIKA_Click;

            Foglalas = new Button
            {
                Location = new Point(800, 290),
                AutoSize = false,
                Size = new Size(100, 50),
                Text = "Foglalás",
                Enabled = true,
                Name = "btnFOGLALAS",
                Visible = true
            };
            this.Controls.Add(Foglalas);
            Foglalas.Click += btnFOGLALAS_Click;

            Kilepes = new Button
            {
                Location = new Point(800, 360),
                AutoSize = false,
                Size = new Size(100, 50),
                Text = "Kilépés",
                Enabled = true,
                Name = "btnKILEPES",
                Visible = true
            };
            this.Controls.Add(Kilepes);
            Kilepes.Click += btnKILEPES_Click;

            Foszam = new Label
            {
                Location = new Point(800, 70),
                AutoSize = false,
                Size = new Size(100, 15),
                Text = "Főszám",
                Enabled = true,
                Name = "lblFOSZAM",
                Visible = false
            };
            this.Controls.Add(Foszam);

            FoszamText = new TextBox
            {
                Location = new Point(800, 90),
                Size = new Size(100, 20),
                AutoSize = false,
                Text = "1",
                Enabled = true,
                Name = "txtbFOSZAMTEXT",
                Visible = false
            };
            this.Controls.Add(FoszamText);

            Nev = new Label
            {
                Location = new Point(800, 120),
                AutoSize = false,
                Size = new Size(100, 15),
                Text = "Név",
                Enabled = true,
                Name = "lblNEV",
                Visible = false
            };
            this.Controls.Add(Nev);

            NevText = new TextBox
            {
                Location = new Point(800, 140),
                Size = new Size(150, 20),
                AutoSize = false,
                Text = "",
                Enabled = true,
                Name = "txtbNEVTEXT",
                Visible = false
            };
            this.Controls.Add(NevText);

            Reggeli = new CheckBox
            {
                Location = new Point(800, 180),
                Size = new Size(100, 20),
                AutoSize = false,
                Text = "Reggeli?",
                Enabled = true,
                Name = "chbREGGELI",
                Visible = false
            };
            this.Controls.Add(Reggeli);

            Fizetve = new CheckBox
            {
                Location = new Point(800, 200),
                Size = new Size(100, 20),
                AutoSize = false,
                Text = "Fizetve?",
                Enabled = true,
                Name = "chbFIZETVE",
                Visible = false
            };
            this.Controls.Add(Fizetve);

            TeljesAr = new Label
            {
                Location = new Point(800, 245),
                AutoSize = false,
                Size = new Size(100, 15),
                Text = "",
                Enabled = true,
                Name = "lblTELJESAR",
                Visible = false
            };
            this.Controls.Add(TeljesAr);

            Evek = new ComboBox
            {
                Location = new Point(70, 40),
                AutoSize = false,
                DropDownStyle = ComboBoxStyle.DropDownList,
                Text = DateTime.Now.ToString("yyy"),
                Enabled = true,
                Name = "cmbEVEK",
                Visible = true
            };
            this.Controls.Add(Evek);

            Honapok = new ComboBox
            {
                Location = new Point(300, 40),
                AutoSize = false,
                DropDownStyle = ComboBoxStyle.DropDownList,
                Text = DateTime.Now.ToString("MMMM"),
                Enabled = true,
                Name = "cmbHONAPOK",
                Visible = true

            };
            this.Controls.Add(Honapok);

            string[] honapok = new string[]
            {
                "január", "február", "március", "április", "május", "június",
                "július", "augusztus", "szeptember", "október", "november", "december"
            };
            string[] evek = new string[]
            {
                "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031",
                "2032", "2033", "2034", "2035", "2036", "2037", "2038", "2039", "2040",
                "2041", "2042", "2043", "2044", "2045", "2046", "2047", "2048", "2049",
                "2050",
            };
            Honapok.Items.AddRange(honapok);
            Evek.Items.AddRange(evek);


            Evek.SelectedIndex = Evek.Items.IndexOf(DateTime.Now.Year.ToString());
            Honapok.SelectedIndex = DateTime.Now.Month - 1;

            Evek.SelectedIndexChanged += (s, a) => UpdateMatrix();
            Honapok.SelectedIndexChanged += (s, a) => UpdateMatrix();
            UpdateMatrix();
            BeolvasArakat();
        }
    }
}
