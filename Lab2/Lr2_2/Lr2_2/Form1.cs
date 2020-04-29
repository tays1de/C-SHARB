using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lr2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        int[] mass = new int[14];
        Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            for(int i=0; i<14; i++)
            {
                int k = rnd.Next(0, 100);
                listBox1.Items.Add("Mass["+i + "]= "+k);
                mass[i] = k;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
           
            for (int i =0; i < 8; i++)
            {
                int k = rnd.Next(0, 13);
                mass[k] = -mass[k];
            }
            for (int i = 0; i < 14; i++)
            {
                listBox2.Items.Add("Mass[" + i + "]= " + mass[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sum=0;
            for(int i = 0; i<14; i++)
            {
                if (i % 2 == 0)
                {
                    sum += mass[i];
                }
            }
            MessageBox.Show("Сумма равна: " + sum);
        }
    }
}
