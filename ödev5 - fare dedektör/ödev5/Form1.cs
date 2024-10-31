using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Text = "Lütfen gel!";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.Text = "Yürü git!";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Text = "Lütfen gel!";
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.Text = "Yürü git!";
        }
    }
}
