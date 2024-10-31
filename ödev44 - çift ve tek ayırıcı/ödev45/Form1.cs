using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev45
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Random bbc = new Random();
            for (int j = 0; j < 21; j++)
            {
                listBox1.Items.Add(bbc.Next(21));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int bl = 0; bl < 21; bl++)
            {
                if (listBox1.Items.Count > 0)
                {
                    if (Convert.ToInt32(listBox1.Items[0]) % 2 == 0)
                    {
                        listBox2.Items.Add(listBox1.Items[0]);
                        listBox1.Items.Remove(listBox1.Items[0]);
                    }
                    else
                    {
                        listBox3.Items.Add(listBox1.Items[0]);
                        listBox1.Items.Remove(listBox1.Items[0]);
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
