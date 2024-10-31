using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                decimal input1, input2, output;
                input1 = Convert.ToDecimal(textBox1.Text);
                input2 = Convert.ToDecimal(textBox2.Text);
                output = input1 + input2;
                textBox3.Text = output.ToString();
            }
            else
            {
                decimal input1, input2, output;
                input1 = Convert.ToDecimal(textBox1.Text);
                input2 = Convert.ToDecimal(textBox2.Text);
                output = input1 * input2;
                textBox3.Text = output.ToString();
            }
        }
    }
}
