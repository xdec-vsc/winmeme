using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev49
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            for (i=0; i < listBox1.Items.Count; i++)
            {
                if (listBox1.Items[i].ToString() == textBox1.Text)
                {
                    MessageBox.Show(textBox1.Text + ", " + (i + 1) + ". sırada.");
                }
            }
        }
    }
}
