using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev51
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int i;
            if (radioButton1.Checked == true)
            {
                for (i = 1; i <= 10; i=i+2)
                {
                    if (i >= 7)
                    {
                        continue;
                    }
                    listBox1.Items.Add(i);
                }
            }
            else if (radioButton2.Checked == true)
            {
                for (i = 1; i <= 10; i = i + 2)
                {
                    listBox1.Items.Add(i);
                    if (i >= 7)
                    {
                        continue;
                    }
                }
            }
        }
    }
}
