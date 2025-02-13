using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev79
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] list = new string[1000];
        int index = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            list[index] = textBox1.Text;
            index++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (string listing in list)
            {
                listBox1.Items.Add(listing);
            }
        }
    }
}
