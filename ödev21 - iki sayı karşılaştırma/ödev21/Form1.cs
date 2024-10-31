using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev21
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

        private void button1_Click(object sender, EventArgs e)
        {
            decimal input1, input2;
            input1 = Convert.ToDecimal(textBox1.Text);
            input2 = Convert.ToDecimal(textBox2.Text);
            if (input1 > input2)
            {
                MessageBox.Show("İlk sayı ikinici sayıdan daha büyüktür.");
            }
            if (input1 < input2) 
            {
                MessageBox.Show("İkinci sayı ilk sayıdan daha büyüktür.");
            }
            if (input1 == input2)
            {
                MessageBox.Show("ilk ve ikinci sayı eşittir.");
            }
        }
    }
}