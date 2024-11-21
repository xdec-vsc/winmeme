using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev53
{
    public partial class Form1 : Form
    {
        int gggg;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (gggg == 3) {
                gggg = 1;
            }
            switch(gggg)
            {
                case 1:
                    BackColor = Color.Blue;
                    groupBox1.BackColor = Color.Yellow;
                    break;
                case 2:
                    BackColor = Color.Yellow;
                    groupBox1.BackColor = Color.Red;
                    break;
                case 3:
                    BackColor = Color.White;
                    groupBox1.BackColor = Color.Black;
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
