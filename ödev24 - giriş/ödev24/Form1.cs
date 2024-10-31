using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input;
            input = Convert.ToString(textBox1.Text);
            if (input == "milliegitim@meb.k12.tr")
            {
                MessageBox.Show("Giriş yaptınız.");
            }
            else
            {
                MessageBox.Show("İsim yanlış.");
            }
        }
    }
}
