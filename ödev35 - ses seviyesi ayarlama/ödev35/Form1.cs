using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev35
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int ahhhh;
            ahhhh = Convert.ToInt32(trackBar1.Value);
            if (ahhhh < 11)
            {
                label2.Text = "Normal Ses Seviyesi";
                label2.ForeColor = Color.Green;
            }
            else
            {
                label2.Text = "Yüksek Ses Seviyesi";
                label2.ForeColor = Color.Red;
            }
        }
    }

        
    }

