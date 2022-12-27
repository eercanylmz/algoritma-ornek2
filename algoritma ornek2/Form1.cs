using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace algoritma_ornek2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int singletotal = 0;
        int doubletotal = 0;
        private void clear()
        {
            label3.Text=("00");
            label4.Text = ("00");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int number;
            number = Convert.ToInt32(textBox1.Text);
            if (number % 2 == 0)
            {
                doubletotal = number + doubletotal;
                label4.Text = doubletotal.ToString();
                textBox1.Clear();
            }
            else
            {
                singletotal = number + singletotal;
                label3.Text = singletotal.ToString();
                textBox1.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
