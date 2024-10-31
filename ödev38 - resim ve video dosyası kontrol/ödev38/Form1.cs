using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev38
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (listBox1.SelectedIndex == 1 || listBox1.SelectedIndex == 3)
                {
                    MessageBox.Show(listBox1.Text + " resim dosyasıdır.");
                }
                else
                {
                    MessageBox.Show(listBox1.Text + " resim dosyası değildir.");
                }
            } 
            else if (radioButton2.Checked == true)
            {
                if (listBox1.SelectedIndex == 0 || listBox1.SelectedIndex == 2)
                {
                    MessageBox.Show(listBox1.Text + " video dosyasıdır.");
                }
                else
                {
                    MessageBox.Show(listBox1.Text + " video dosyası değildir.");
                }
            }
        }
    }
}
