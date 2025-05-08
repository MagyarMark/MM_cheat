using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorMini
{
    public partial class Form1 : Form
    {
        public int dotFlag = 0;
        public int negFlag = 0;
        public double result = 0;
        public string opel = "";
        public bool flag = false;
        public Form1()
        {
            InitializeComponent();
            txbDisplay.Text = "0";
            txbDisplay.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            string a = txbDisplay.Text;
            double b = double.Parse(a);
            b *= -1;

            if (b < 0) negFlag = 1;
            else negFlag = 0;
            a = b.ToString();
            if (dotFlag == 1)
            {
                txbDisplay.Text = a + ",";
            }
            else
            {
                txbDisplay.Text = a;
            }
            
        }
        private double resultformat(double a)
        {
            return double.Parse((a.ToString()+ "            ").Substring(0, 8 + negFlag + dotFlag));
        }
        private void btndot_Click(object sender, EventArgs e)
        {
            if (!txbDisplay.Text.Contains(",") && txbDisplay.Text.Length < 8 + dotFlag + negFlag )
            {
                txbDisplay.Text += ",";
                dotFlag = 1;
            }
                
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbDisplay.Text))
            {
                txbDisplay.Text = txbDisplay.Text.Substring(0, txbDisplay.Text.Length - 1);
            }
            else
            {
                txbDisplay.Text = "0";
            }
            /*txbDisplay.Text = "0";
            dotFlag = 0;
            negFlag = 0;*/
            flag = false;
        }

        private void btnGyok_Click(object sender, EventArgs e)
        {
            result = Math.Sqrt(double.Parse(txbDisplay.Text));
            double r = double.Parse(result.ToString() + "             ".Substring(0, 10));
            txbDisplay.Text = r.ToString();
            flag = false;

        }
        private void numbers(string number)
        {
            if (flag)
            {
                txbDisplay.Text = "0";
                flag = false;
            }
            if (txbDisplay.Text == "0")
            {
                txbDisplay.Text = number;

            }
            else if (txbDisplay.Text.Length < 8 + negFlag + dotFlag)
            {
                txbDisplay.Text += number;

            }
        }
        private void btn1_Click(object sender, EventArgs e)
        {   
            numbers("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            numbers("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            numbers("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            numbers("4");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            numbers("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            numbers("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            numbers("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            numbers("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            numbers("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            numbers("0");
        }

        private void op()
        {
            if (opel == "+")
            {
                result += double.Parse(txbDisplay.Text);
                result = resultformat(result);
                flag = true;
                txbDisplay.Text = result.ToString();
                return;
            }
            if (opel == "-")
            {
                result -= double.Parse(txbDisplay.Text);
                result = resultformat(result);
                flag = true;
                txbDisplay.Text = result.ToString();
                return;
            }
            if (opel == "*")
            {
                result *= double.Parse(txbDisplay.Text);
                result = resultformat(result);
                flag = true;
                txbDisplay.Text = result.ToString();
                return;
            }
            if (opel == "/")
            {
                if (txbDisplay.Text == "0")
                {
                    txbDisplay.Text = "Hiba";
                    result = 0;
                    flag = true;
                    dotFlag = 0;
                    negFlag = 0;
                    opel = "";
                    return;
                }
                result /= double.Parse(txbDisplay.Text);
                result = resultformat(result);
                flag = true;
                txbDisplay.Text = result.ToString();
                return;
            }
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (opel == "")
            {
                opel = "+";
                flag = true;
                result = double.Parse(txbDisplay.Text);
            }
            else 
            {
                op();
                opel = "+";
            }
        }

        private void btnCA_Click(object sender, EventArgs e)
        {
            result = 0;
            flag = false;
            dotFlag = 0;
            negFlag = 0;
            opel = "";
            txbDisplay.Text = "0";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (opel == "")
            {
                opel = "/";
                flag = true;
                result = double.Parse(txbDisplay.Text);
            }
            else
            {
                op();
                opel = "/";
            }
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            if (opel == "")
            {
                opel = "*";
                flag = true;
                result = double.Parse(txbDisplay.Text);
            }
            else
            {
                op();
                opel = "*";
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (opel == "")
            {
                opel = "-";
                flag = true;
                result = double.Parse(txbDisplay.Text);
            }
            else
            {
                op();
                opel = "-";
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (opel == "")
            {
                return;
            }
            else
            {
                op();
                opel = "";
            }
        }
    }
}
