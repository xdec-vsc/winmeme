using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev33
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal price;
            price = Convert.ToDecimal(textBox1.Text);
            if (radioButton1.Checked == true)
            {
                MessageBox.Show("Fiyat:" + Convert.ToString(price), "POS");
            }
            else if (radioButton2.Checked == true || radioButton3.Checked == true)
            {
                price = price + (price * 0.05);
            }
        }
    }
}
