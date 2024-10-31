﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev50
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double giriş, kare;
            try
            {
                giriş = Convert.ToDouble(textBox1.Text);
                kare = giriş * giriş;
                MessageBox.Show(kare.ToString());
            }
            catch
            {
                MessageBox.Show("hatalı giriş");
            }
            finally
            {
                //"normal" kod
            }
        }
    }
}
