using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev78
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] isimler = new string[5];
        int index = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                isimler[index] = textBox1.Text;
                label1.Text = isimler[0] + ", " + isimler[1] + ", " + isimler[2] + ", " + isimler[3] + ", " + isimler[4];
                index++;
            }
            catch
            {
                MessageBox.Show("en fazla beş tane obje girebilirsin");
            }
        }
    }
}
