using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_3_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }




        private void Result_Click(object sender, EventArgs e)
        {
            string str1 = textBox2.Text;
            string str2 = textBox3.Text;
            string str3 = textBox4.Text;

            str1 = str1.Replace('.', ',');
            str2 = str2.Replace('.', ',');
            str3 = str3.Replace('.', ',');


            double x = double.Parse(str1);
            double y = double.Parse(str2);
            double z = double.Parse(str3);
            double a=0;
                                            // |min(f(x),y)-max(y,z)|/2
            double mIn, mAx;
            if (radioButton1.Checked)
            {
                mIn = Math.Min(Math.Sinh(x), y);
                mAx = Math.Max(y, z);
                a = (Math.Abs(mIn - mAx)) / 2;
            }
            else if (radioButton2.Checked)
            {
                mIn = Math.Min(x*x, y);
                mAx = Math.Max(y, z);
                a = (Math.Abs(mIn - mAx)) / 2;
            }
            else if (radioButton3.Checked)
            {
                mIn = Math.Min(Math.Exp(x), y);
                mAx = Math.Max(y, z);
                a = (Math.Abs(mIn - mAx)) / 2;
            }
            textBox1.Text += Environment.NewLine + "U = " + a.ToString();


        }






        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8 && number != 46 && number != 45)
            {
                e.Handled = true;
                MessageBox.Show("Введите корректные данные!");
                textBox2.Clear();
            }

            int koL = 0;
            int koL1 = 0;

            for (int i = 0; i < textBox2.Text.Length; i++)
            {
                if (textBox2.Text[i] == '.')
                {
                    koL++;
                }
                if (textBox2.Text[i] == '-')
                {
                    koL1++;
                }
            }
            if (koL > 1 || koL1 > 1)
            {
                MessageBox.Show("Введены не корректные данные!");
                textBox2.Clear();
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8 && number != 46 && number != 45)
            {
                e.Handled = true;
                MessageBox.Show("Введите корректные данные!");
                textBox3.Clear();
            }

            int koL = 0;
            int koL1 = 0;

            for (int i = 0; i < textBox3.Text.Length; i++)
            {
                if (textBox3.Text[i] == '.')
                {
                    koL++;
                }
                if (textBox3.Text[i] == '-')
                {
                    koL1++;
                }
            }
            if (koL > 1 || koL1 > 1)
            {
                MessageBox.Show("Введены не корректные данные!");
                textBox3.Clear();
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8 && number != 46 && number != 45)
            {
                e.Handled = true;
                MessageBox.Show("Введите корректные данные!");
                textBox4.Clear();
            }

            int koL = 0;
            int koL1 = 0;

            for (int i = 0; i < textBox4.Text.Length; i++)
            {
                if (textBox4.Text[i] == '.')
                {
                    koL++;
                }
                if (textBox4.Text[i] == '-')
                {
                    koL1++;
                }
            }
            if (koL > 1 || koL1 > 1)
            {
                MessageBox.Show("Введены не корректные данные!");
                textBox4.Clear();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if ((textBox4.Text != "")&& (textBox3.Text != "") && (textBox2.Text != ""))
            {
                Result.Enabled = true;
            }
            else
            {
                Result.Enabled = false;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if ((textBox4.Text != "") && (textBox3.Text != "") && (textBox2.Text != ""))
            {
                Result.Enabled = true;
            }
            else
            {
                Result.Enabled = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if ((textBox4.Text != "") && (textBox3.Text != "") && (textBox2.Text != ""))
            {
                Result.Enabled = true;
            }
            else
            {
                Result.Enabled = false;
            }
        }
    }
}
