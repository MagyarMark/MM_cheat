using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        /*private Timer timer;
        private float angle = 0;*/
        private Button[,] gridButtons;
        private const int Rows = 4;
        private const int Columns = 15;
        private string[,] labels = new string[Rows, Columns]
        {
            { "0", "", "3", "6", "9", "12", "15", "18", "21", "24", "27", "30", "33", "36", "2:1" },
            { "", "", "2", "5", "8", "11", "14", "17", "20", "23", "26", "29", "32", "35", "2:1" },
            { "", "", "1", "4", "7", "10", "13", "16", "19", "22", "25", "28", "31", "34", "2:1" },
            { "1 to 12", "", "", "", "", "", "13 to 24", "", "", "", "", "25 to 36", "", "", "" }
        };

        private TextBox fixMoney;
        private TextBox txtMoney;
        private Button btnBet;
        private Button clickedButton;

        public Form1()
        {
            InitializeComponent();
            InitializeGrid();
            InitializeControls();
            this.Text = "Roulette Board";
            this.Size = new Size(900, 500);
            this.StartPosition = FormStartPosition.CenterScreen;
            /*timer = new Timer();
            timer.Interval = 850; // Adjust speed
            timer.Tick += Timer_Tick;

            // Start the timer
            timer.Start();*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void InitializeGrid()
        {
            gridButtons = new Button[Rows, Columns];

            int buttonWidth = 60;
            int buttonHeight = 40;

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    if (string.IsNullOrEmpty(labels[i, j]))
                        continue;

                    gridButtons[i, j] = new Button();
                    gridButtons[i, j].Size = new Size(buttonWidth, buttonHeight);
                    gridButtons[i, j].Location = new Point(j * buttonWidth + 270, i * buttonHeight + 250);
                    gridButtons[i, j].Text = labels[i, j];
                    gridButtons[i, j].FlatStyle = FlatStyle.Popup;
                    gridButtons[i, j].Font = new Font("Microsoft Times New Roman", 12F, FontStyle.Bold);
                    gridButtons[i, j].TextAlign = ContentAlignment.MiddleCenter;

                    if (labels[i, j] == "0")
                    {
                        gridButtons[i, j].BackColor = Color.Green;
                        gridButtons[i, j].ForeColor = Color.White;
                    }
                    else if (int.TryParse(labels[i, j], out int number))
                    {
                        gridButtons[i, j].BackColor = number % 2 == 0 ? Color.Red : Color.Black;
                        gridButtons[i, j].ForeColor = Color.White;
                    }
                    else
                    {
                        gridButtons[i, j].BackColor = Color.Gray;
                        gridButtons[i, j].ForeColor = Color.White;
                    }

                    gridButtons[i, j].Click += Button_Click;
                    this.Controls.Add(gridButtons[i, j]);
                }
            }
        }

        private void InitializeControls()
        {
            fixMoney = new TextBox
            {
                Text = "Money: 1000",
                Location = new Point(35, 10),
                Size = new Size(200, 20),
                Enabled = false,
                TextAlign = HorizontalAlignment.Center,
                Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold)
            };
            this.Controls.Add(fixMoney);

            txtMoney = new TextBox
            {
                Text = "Enter Bet Amount",
                Location = new Point(35, 40),
                Size = new Size(200, 20),
                BackColor = Color.Gray,
                TextAlign = HorizontalAlignment.Center
            };
            this.Controls.Add(txtMoney);

            btnBet = new Button
            {
                Text = "Bet",
                FlatStyle = FlatStyle.Popup,
                Location = new Point(35, 70),
                Size = new Size(200, 30),
                BackColor = Color.Green,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold),
                ForeColor = Color.White
            };
            btnBet.Click += BtnBet_Click;
            this.Controls.Add(btnBet);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            clickedButton = (Button)sender;
            MessageBox.Show($"You clicked on: {clickedButton.Text}", "Button Clicked", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnBet_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMoney.Text, out int betAmount) || betAmount <= 0)
            {
                MessageBox.Show("Please enter a valid bet amount.", "Invalid Bet", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string moneyText = fixMoney.Text.Replace("Money: ", "");
            if (!int.TryParse(moneyText, out int currentMoney))
            {
                MessageBox.Show("Failed to retrieve current money.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (betAmount > currentMoney)
            {
                MessageBox.Show("You don't have enough money to place this bet.", "Insufficient Funds", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            currentMoney -= betAmount;

            // Random spin logic
            Random random = new Random();
            int winningNumber = random.Next(0, 37); // Random number between 0 and 36

            MessageBox.Show($"Winning Number: {winningNumber}", "Spin Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (clickedButton != null && int.TryParse(clickedButton.Text, out int chosenNumber) && chosenNumber == winningNumber)
            {
                int payout = betAmount * 35; // Standard roulette payout for a single number
                currentMoney += payout;
                MessageBox.Show($"You won! Payout: {payout}", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("You lost. Better luck next time!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            fixMoney.Text = $"Money: {currentMoney}";
        }


        /*private void Timer_Tick(object sender, EventArgs e)
        {
            angle += 5; // Rotate by 5 degrees
            if (angle >= 360)
                angle -= 360;

            this.Invalidate(); // Trigger repaint
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Get Graphics object
            Graphics g = e.Graphics;

            // Set the center of the wheel
            int centerX = this.ClientSize.Width / 2;
            int centerY = this.ClientSize.Height / 2;
            int radius = 150;

            // Draw the roulette wheel
            DrawRouletteWheel(g, centerX, centerY, radius);
        }

        private void DrawRouletteWheel(Graphics g, int centerX, int centerY, int radius)
        {
            // Define the numbers and colors
            int[] numbers = { 0, 32, 15, 19, 4, 21, 2, 25, 17, 34, 6, 27, 13, 36, 11, 30, 8, 23, 10, 5, 24, 16, 33, 1, 20, 14, 31, 9, 22, 18, 29, 7, 28, 12, 35, 3, 26 };
            Color[] colors = { Color.Green, Color.Red, Color.Black }; // Green for 0, alternating Red and Black

            int segmentCount = numbers.Length;
            float sweepAngle = 360f / segmentCount;

            // Rotate the wheel
            g.TranslateTransform(centerX, centerY);
            g.RotateTransform(angle);
            g.TranslateTransform(-centerX, -centerY);

            // Draw segments
            for (int i = 0; i < segmentCount; i++)
            {
                float startAngle = i * sweepAngle;

                // Alternate colors
                Color segmentColor = (i == 0) ? colors[0] : (i % 2 == 0 ? colors[2] : colors[1]);

                using (Brush brush = new SolidBrush(segmentColor))
                {
                    using (Pen pen = new Pen(Color.White, 2))
                    {
                        g.FillPie(brush, centerX - radius, centerY - radius, radius * 2, radius * 2, startAngle, sweepAngle);
                        g.DrawPie(pen, centerX - radius, centerY - radius, radius * 2, radius * 2, startAngle, sweepAngle);
                    }
                }

                // Draw the number
                float textAngle = (startAngle + sweepAngle / 2) * (float)Math.PI / 180;
                float textRadius = radius - 20;
                float textX = centerX + textRadius * (float)Math.Cos(textAngle);
                float textY = centerY + textRadius * (float)Math.Sin(textAngle);

                using (Font font = new Font("Arial", 10, FontStyle.Bold))
                using (Brush textBrush = new SolidBrush(Color.White))
                {
                    StringFormat format = new StringFormat
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    };

                    g.DrawString(numbers[i].ToString(), font, textBrush, textX, textY, format);
                }
            }

            // Reset transform
            g.ResetTransform();

            // Draw center hub
            using (Brush brush = new SolidBrush(Color.Yellow))
            {
                g.FillEllipse(brush, centerX - 20, centerY - 20, 40, 40);
            }
        }*/
    }
}
