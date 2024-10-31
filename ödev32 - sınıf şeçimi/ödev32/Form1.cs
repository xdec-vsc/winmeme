using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int gg;
            gg = Convert.ToInt32(comboBox1.SelectedIndex)+1;
            if (gg > 8)
            {
                MessageBox.Show("Lise öğrencisisin.");
            }
            else if (gg < 5)
            {
                MessageBox.Show("İlkokul öğrencisisin.");
            }
            else
            {
                MessageBox.Show("Ortaokul öğrencisisin");
            }

        }
    }
}
