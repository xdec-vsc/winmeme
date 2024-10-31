using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int halfradius;
            halfradius = Convert.ToInt32(textBox1.Text);
            textBox2.Text = Convert.ToString(Math.Pow(halfradius,2) * 3);
            textBox3.Text = Convert.ToString(halfradius * 6);
        }
    }
}
