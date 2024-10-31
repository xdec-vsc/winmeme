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
            double days, hourrate, weekly, monthly;
            string msg;
            days = Convert.ToDouble(textBox1.Text);
            hourrate = Convert.ToDouble(textBox2.Text);
            weekly = days * (hourrate * 8);
            monthly = weekly * 4;
            msg = ("Haftada " + weekly.ToString() + " TL kazanıyorsunuz, ayda " + monthly.ToString() + " TL kazanıyorsunuz.");
            MessageBox.Show(msg);
    }
    }
}