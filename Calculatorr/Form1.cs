using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatorr
{
    public partial class Form1 : Form
    {
        double x, y;
        string process;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text += "0";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="1")
            {
                textBox1.Text += ".";
            }
            if (textBox1.Text == "2")
            {
                textBox1.Text += ".";
            }
            if (textBox1.Text == "3")
            {
                textBox1.Text += ".";
            }
            if (textBox1.Text == "4")
            {
                textBox1.Text += ".";
            }
            if (textBox1.Text == "5")
            {
                textBox1.Text += ".";
            }
            if (textBox1.Text == "6")
            {
                textBox1.Text += ".";
            }
            if (textBox1.Text == "7")
            {
                textBox1.Text += ".";
            }
            if (textBox1.Text == "8")
            {
                textBox1.Text += ".";
            }
            if (textBox1.Text == "9")
            {
                textBox1.Text += ".";
            }
            if (textBox1.Text == "0")
            {
                textBox1.Text = ".";
            }
        }
        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label3.Text = "";
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(textBox1.Text)>0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1,1);
                if (textBox1.Text.Length==0)
                {
                    textBox1.Text = "0";
                    //label3.Text = "";
                }
            }
         
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            y = Convert.ToDouble(textBox1.Text);
            if (process=="+")
            {
                textBox1.Text = Convert.ToString(x + y);
                label3.Text = "";
            }
            if (process == "-")
            {
                textBox1.Text = Convert.ToString(x - y);
                label3.Text = "";
            }
            if (process == "*")
            {
                textBox1.Text = Convert.ToString(x * y);
                label3.Text = "";
            }
            if (process == "/")
            {
                textBox1.Text = Convert.ToString(x / y);
                label3.Text = "";
            }
            if (process == "%")
            {
                textBox1.Text = Convert.ToString(x % y);
                label3.Text = "";
            }
        }

        private void buttonSubt_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            process = "-";
            label3.Text = textBox1.Text + "-";
            textBox1.Text = "0";
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            process = "*";
            label3.Text = textBox1.Text + "*";
            textBox1.Text = "0";
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            process = "/";
            label3.Text = textBox1.Text + "/";
            textBox1.Text = "0";
        }

        private void button1_Divide_X_Click(object sender, EventArgs e)
        {
            double one_div_numb = Convert.ToDouble(textBox1.Text);
            one_div_numb = 1 / one_div_numb;
            textBox1.Text = Convert.ToString(one_div_numb);
        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            double sqrt = Convert.ToDouble(textBox1.Text);
            sqrt = Math.Sqrt(sqrt);
            textBox1.Text = Convert.ToString(sqrt);
        }

        private void buttonPow_Click(object sender, EventArgs e)
        {
            double pow = Convert.ToDouble(textBox1.Text);
            pow = Math.Pow(pow,2);
            textBox1.Text = Convert.ToString(pow);
      
        }

        private void buttonMod_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            process = "%";
            label3.Text = textBox1.Text + "(%)";
            textBox1.Text = "0";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {                        
            x = Convert.ToDouble(textBox1.Text);
            process = "+";
            label3.Text = textBox1.Text + "+";
            textBox1.Text = "0";
        }
    }
}
