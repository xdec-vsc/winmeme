﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev40
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Left += 10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Left += 25;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox2.Left += 10;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox2.Left += 25;
        }
    }
}
