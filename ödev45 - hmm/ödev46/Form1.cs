using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev46
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal input, output, faiz, years;
            input = Convert.ToDecimal(textBox1.Text);
            faiz = Convert.ToDecimal(textBox2.Text);
            years = Convert.ToDecimal(textBox3.Text);
            output = input*(1+faiz)
        }
    }
}
