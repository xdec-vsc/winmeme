using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev48
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double r, p1, p2, ring, area;
            r = Convert.ToDouble(textBox1.Text);
            p1 = 22 / 7;
            p2 = 3.14159;
            ring = r * p1;
            area = r * (Math.Pow(p2, 2));
            MessageBox.Show("çember: " + ring + " ||| alan: " + area);
        }
    }
}
