﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.Text = "Mouse benim üzerimdedir.";
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.Text = "Mouse üzerinde değil.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = "Mouse iki (bir) kere tıkladı.";
                }
    }
}
