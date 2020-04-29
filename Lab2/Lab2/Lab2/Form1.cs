using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (textBox2.Text != "") && (textBox3.Text != "") && (textBox4.Text != ""))
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8 && number != 46 && number != 45)
            {
                e.Handled = true;
                MessageBox.Show("Введите корректные данные!");
                textBox1.Clear();
            }

            int koL = 0;
            int koL1 = 0;

            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (textBox1.Text[i] == '.')
                {
                    koL++;
                }
                if (textBox1.Text[i] == '-')
                {
                    koL1++;
                }
            }
            if (koL > 1 || koL1 > 1)
            {
                MessageBox.Show("Введены не корректные данные!");
                textBox1.Clear();
            }

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (textBox2.Text != "") && (textBox3.Text != "") && (textBox4.Text != ""))
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (textBox2.Text != "") && (textBox3.Text != "") && (textBox4.Text != ""))
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (textBox2.Text != "") && (textBox3.Text != "") && (textBox4.Text != ""))
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
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

        private void button1_Click(object sender, EventArgs e)
        {
        // textBox5.Clear();
            string str1 = textBox1.Text;
            string str2 = textBox2.Text;
            string str3 = textBox3.Text;
            string str4 = textBox4.Text;

            str1 = str1.Replace('.', ',');
            str2 = str2.Replace('.', ',');
            str3 = str3.Replace('.', ',');
            str4 = str4.Replace('.', ',');

            double x = double.Parse(str1);
            double Xn = double.Parse(str2);
            double delX = double.Parse(str3);
            double b = double.Parse(str4);


            if (x < Xn)
            {
                while (x < Xn)
                {
                    double resulte = Math.Abs(x - b);
                    if (Math.Abs(Math.Pow(b, 3) - Math.Pow(x, 3)) == 0)
                    {
                        MessageBox.Show("Error of ВЫЧИСЛЕНИЯ!");
                        textBox1.Clear();
                        textBox4.Clear();
                    }
                    double resulte1 = (Math.Pow(Math.Abs(Math.Pow(b, 3) - Math.Pow(x, 3)), 3));
                    if ((resulte / resulte1) < 0)
                    {
                        MessageBox.Show("Error of ВЫЧИСЛЕНИЯ!");
                        textBox1.Clear();
                        textBox4.Clear();

                    }
                    double resulete2 = resulte / resulte1;
                    double itog = Math.Pow(resulete2, 0.5);
                    textBox5.Text += x + "\t\t" + itog + Environment.NewLine;
                    x = x + delX;
                }
            }
            else
            {
                while (x > Xn)
                {
                    double resulte = Math.Abs(x - b);
                    if (Math.Abs(Math.Pow(b, 3) - Math.Pow(x, 3)) == 0)
                    {
                        MessageBox.Show("Error of ВЫЧИСЛЕНИЯ!");
                        textBox1.Clear();
                        textBox4.Clear();
                    }
                    double resulte1 = (Math.Pow(Math.Abs(Math.Pow(b, 3) - Math.Pow(x, 3)), 3));
                    if ((resulte / resulte1) < 0)
                    {
                        MessageBox.Show("Error of ВЫЧИСЛЕНИЯ!");
                        textBox1.Clear();
                        textBox4.Clear();

                    }
                    double resulete2 = resulte / resulte1;
                    double itog = Math.Pow(resulete2, 0.5);
                    textBox5.Text += x + "\t\t" + itog + Environment.NewLine;
                    x = x + delX;
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
