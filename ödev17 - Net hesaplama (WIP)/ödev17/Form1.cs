using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double matd, türd, maty, türy, matn, türn;
            matd = Convert.ToDouble(textBox4.Text);
            türd = Convert.ToDouble(textBox1.Text);
            maty = Convert.ToDouble(textBox5.Text);
            türy = Convert.ToDouble(textBox2.Text);

            matn = matd - (maty / 100 * 25);
            türn = türd - (türy / 100 * 25);

            textBox3.Text = Convert.ToString(matn);
            textBox6.Text = Convert.ToString(türn);
        }
    }
}
