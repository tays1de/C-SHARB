using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_1._2_
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {  
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
            if ((textBox1.Text != "") && (textBox3.Text != "") && (textBox2.Text != ""))
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str1 = textBox1.Text;
            string str2 = textBox2.Text;
            string str3 = textBox3.Text;
            textBox4.Clear();
       //    str1 =  str1.Replace('.', ',');
        //   str2 = str2.Replace('.', ',');
        //   str3 = str3.Replace('.', ',');

            double x = double.Parse(str1);
            double y = double.Parse(str2);
            double z = double.Parse(str3);
            double a;
            
                if ((x - y) == 0)
                {
                    Console.Write("Деление на ноль! ОШИБКА!! ");
                    MessageBox.Show("НЕККОРЕКТНЫЕ ДАННЫЕ!");
                }
                else if (y + Math.Pow(x - 1,1/3) <= 0)
                {
                    Console.Write("Под корнем отрицательное число! Ошибка!! ");
                    MessageBox.Show("НЕККОРЕКТНЫЕ ДАННЫЕ!");
                }

                a = (Math.Pow(y + Math.Pow(x - 1, 0.33333333), 0.25)) / (Math.Abs(x - y) * (Math.Pow(Math.Sin(z), 2) + Math.Tan(z)));

                textBox4.Text += Environment.NewLine + "U = " + a.ToString();
            
        }

       
        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
      //      textBox4.Clear();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8 && number != 46 && number != 45 && number != 44)
            {
                e.Handled = true;
                MessageBox.Show("Введите корректные данные!");
                textBox1.Clear();
            }

            int koL = 0;
            int koL1 = 0;

            for(int i =0; i<textBox1.Text.Length; i++)
            {
                if(textBox1.Text[i]== '.')
                {
                    koL++;
                }
                if (textBox1.Text[i] == '-')
                {
                    koL1++;
                }
            }
            if (koL > 1|| koL1>1)
            {
                MessageBox.Show("Введены не корректные данные!");
                textBox1.Clear();
            }

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8 && number != 46 && number != 45 && number != 44)
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
                textBox1.Clear();
            }

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8 && number != 46 && number != 45 && number !=44)
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
                textBox1.Clear();
            }

        }
    }
}
