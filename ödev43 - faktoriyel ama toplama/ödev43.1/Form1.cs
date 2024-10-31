using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev43._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text), num2 = Convert.ToInt32(textBox2.Text), output;
            for (output = 0;  num1 <= num2; num1++) 
            {
                output = output + num1;
            }
            MessageBox.Show(output.ToString());
        }
    }
}
