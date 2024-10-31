using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.TextLength != 0)
            {
                int input;
                input = Convert.ToInt32(textBox1.Text);
                if (input % 2 == 0)
                {
                    textBox2.Text = "çift sayı";
                }
                if (input % 2 == 1)
                {
                    textBox2.Text = "tek sayı";
                }
            }
            else textBox2.Text = "boş";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}