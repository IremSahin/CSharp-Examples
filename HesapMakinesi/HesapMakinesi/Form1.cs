using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayi = 0;
        double onceki = -1;
        double sonuc = 0;
        string op;
        double mIslem = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }  

        private void button13_Click(object sender, EventArgs e)
        {
            op = "+";

            if (onceki == -1)
            {
                onceki = Convert.ToDouble(textBox1.Text);
            }
            else
            {
                sayi = Convert.ToInt32(textBox1.Text);
            }

            textBox1.Text = "";
            if (sayi != 0)
            {
                onceki = onceki + sayi;
                label1.Text = onceki.ToString();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            op = "-";

            if (onceki == -1)
            {
                onceki = Convert.ToDouble(textBox1.Text);
            }
            else
            {
                sayi = Convert.ToInt32(textBox1.Text);
            }

            textBox1.Text = "";
            if (sayi != 0)
            {
                onceki = onceki - sayi;
                label1.Text = onceki.ToString();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            op = "*";

            if (onceki == -1)
            {
                onceki = Convert.ToDouble(textBox1.Text);
            }
            else
            {
                sayi = Convert.ToInt32(textBox1.Text);
            }

            textBox1.Text = "";
            if (sayi != 0)
            {
                onceki = onceki * sayi;
                label1.Text = onceki.ToString();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            op = "/";

            onceki = Convert.ToDouble(textBox1.Text);
            
            textBox1.Text = "";
            if (sayi != 0)
            {
                onceki = onceki / sayi;
                label1.Text = onceki.ToString();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            op = "1/x";
            onceki = Convert.ToDouble(textBox1.Text);
            
            textBox1.Text = "";
            sonuc = 1 / onceki;
            label1.Text = sonuc.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            op = "%";

            if (onceki == -1)
            {
                onceki = Convert.ToDouble(textBox1.Text);
            }
            else
            {
                sayi = Convert.ToInt32(textBox1.Text);
            }

            textBox1.Text = "";
            if (sayi != 0)
            {
                onceki = onceki % sayi;
                label1.Text = onceki.ToString();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            op = "sqrt";
            onceki = Convert.ToDouble(textBox1.Text);

            textBox1.Text = "";
            sonuc = Math.Sqrt(onceki);
            label1.Text = sonuc.ToString();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                mIslem += Convert.ToDouble(label1.Text);
                label2.Text = "M";
            }
            else
            {
                mIslem += Convert.ToDouble(textBox1.Text);
                label2.Text = "M";
            }
            
        }


        private void button25_Click(object sender, EventArgs e)
        {
            label1.Text = mIslem.ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            mIslem = 0;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                mIslem = Convert.ToDouble(label1.Text);
            }
            else
            {
                mIslem = Convert.ToDouble(textBox1.Text);
                label2.Text = "M";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (op == "+")
            {
                sonuc = onceki + Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
                onceki = -1;
                label1.Text = sonuc.ToString();
            }
            else if (op == "-")
            {
                sonuc = onceki - Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
                onceki = -1;
                label1.Text = sonuc.ToString();
            }
            else if (op == "*")
            {
                sonuc = onceki * Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
                onceki = -1;
                label1.Text = sonuc.ToString();
            }
            else if (op == "/")
            {
                sonuc = onceki / Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
                onceki = -1;
                label1.Text = sonuc.ToString();
            }
            else if (op == "%")
            {
                sonuc = onceki % Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
                onceki = -1;
                label1.Text = sonuc.ToString();
            }

        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
            label2.Text = "";
            op = "";
            sayi = 0;
            onceki = -1;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        }

        private void sxcvbnmöToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        

    }
}
