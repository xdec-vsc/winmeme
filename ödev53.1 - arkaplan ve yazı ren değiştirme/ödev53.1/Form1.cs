using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev53._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kkmmss = textBox1.Text;
            if (kkmmss != "1"|| kkmmss != "2"|| kkmmss != "3")
            {
                BackColor = Color.White;
                richTextBox1.ForeColor = Color.Black;
                richTextBox1.BackColor = Color.White;
            }
            switch(kkmmss)
            {
                case "1":
                    BackColor = Color.Blue;
                    richTextBox1.ForeColor = Color.Blue;
                    richTextBox1.BackColor = Color.Yellow;
                    break;
                case "2":
                    BackColor = Color.Yellow;
                    richTextBox1.ForeColor = Color.Yellow;
                    richTextBox1.BackColor = Color.Red;
                    break;
                case "3":
                    BackColor = Color.Black;
                    richTextBox1.ForeColor = Color.White;
                    richTextBox1.BackColor = Color.Black;
                    break;
            }
        }
    }
}
