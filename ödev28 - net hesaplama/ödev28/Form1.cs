using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int point;
            point = Convert.ToInt32(textBox1.Text);
            if (point >= 85)
            {
                label2.Text = "Takdir Belgesi Almaya Hak Kazandınız!";
            }
            else if (point >= 75)
            {
                label2.Text = "Teşekkür Belgesi Almaya Hak Kazandınız!";
            }
            else if (point < 50)
            {
                label2.Text = "Sınıfı Geçmek İçin Yeterli Not Alamadınız.";
            }
            else
            {
                label2.Text = "Belge Almyarak Sınıfı Geçtin.";
            }
        }
    }
}
