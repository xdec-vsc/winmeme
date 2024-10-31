using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal input;
            input = Convert.ToDecimal(textBox1.Text);
            input = (input * 90) / 100;
            label3.Text = input.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal input;
            input = Convert.ToDecimal(textBox1.Text);
            input = (input * 75) / 100;
            label3.Text = input.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal input;
            input = Convert.ToDecimal(textBox1.Text);
            input = (input * 50) / 100;
            label3.Text = input.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            decimal input;
            input = Convert.ToDecimal(textBox1.Text);
            input = (input * 25) / 100;
            label3.Text = input.ToString();
        }
    }
}
