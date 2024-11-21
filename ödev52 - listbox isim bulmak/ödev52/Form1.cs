using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev52
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int ss = 0; ss < listBox1.Items.Count+1;)
            {
                string wanted = textBox1.Text.ToLower();
                string aka = Convert.ToString(listBox1.Items[ss]).ToLower();
                if (wanted != aka)
                {
                    ss++;
                }
                else
                {
                    MessageBox.Show(textBox1.Text + " isimdeki kişi vardır");
                    break;
                }
            }
        }
    }
}
