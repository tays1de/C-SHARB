using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lr3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }

            if (textBox1.Text.Length > 200)
            {
                textBox1.Clear();
                MessageBox.Show("Превышен лимит 200 символов");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str1 = textBox1.Text;

            int kolProb = 0;
            if (str1.Length % 2 != 0)
            {
                str1 = str1.Remove(str1.Length / 2 - 1, 3);
            }
            textBox2.Clear();
            textBox2.Text += str1 + Environment.NewLine;

            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] == ' ')
                {
                    kolProb++;
                }
            }
            int searchProb = kolProb / 2-1;
            kolProb = 0;
            int k=0, z=str1.Length;
            for (int i = 0; i < str1.Length; i++)
            {
               
                if (kolProb == searchProb)
                {
                    k = i;
                } 
                if (kolProb == (searchProb + 1))
                {
                      z = i;
                }
                if (str1[i] == ' ')
                {
                    kolProb++;
                }
            }

            str1 = str1.Insert(k, " (");
            str1 = str1.Insert(z+3, ") ");
            textBox2.Text += str1;
        }
    }
}
