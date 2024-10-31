using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int input1;
            int input2;
            input1 = Convert.ToInt32(textBox1.Text);
            input2 = Convert.ToInt32(textBox2.Text);
            textBox3.Text = Convert.ToString(input1 + input2);
            textBox4.Text = Convert.ToString(input1 - input2);
            textBox5.Text = Convert.ToString(input1 / input2);
            textBox6.Text = Convert.ToString(input1 * input2);
            textBox7.Text = Convert.ToString(input1 % input2);
            textBox8.Text = Convert.ToString(Math.Pow(input1,input2));
        }
    }
}
