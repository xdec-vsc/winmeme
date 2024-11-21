using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kendricks_scream_in_god_is_gangsta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1_level1.Visible=false;
            button2_level2.Visible = true;
            button1_level2.Visible = true;
        }

        private void button2_level2_Click(object sender, EventArgs e)
        {
            button2_level2.Visible = false;
            button1_level2.Visible = false;
            button3_lv3.Visible = true;
            button2_lv3.Visible = true;
            button1_lv3.Visible = true;
            button4_lv3.Visible = true;
        }

        private void button3_lv3_Click(object sender, EventArgs e)
        {
            button3_lv3.Visible=false;
            button2_lv3.Visible = false;
            button1_lv3.Visible = false;
            button4_lv3.Visible = false;
            button1_level4.Visible = true;
            button2_level4.Visible = true;
            button3_level4.Visible = true;
            button4_level4.Visible = true;
            button5_level4.Visible = true;
            button6_level4.Visible = true;
            button7_level4.Visible = true;
            button8_level4.Visible = true;

        }

        private void button1_level2_Click(object sender, EventArgs e)
        {

        }

        private void button5_level4_Click(object sender, EventArgs e)
        {
            button1_level4.Visible = false;
            button2_level4.Visible = false;
            button3_level4.Visible = false;
            button4_level4.Visible = false;
            button5_level4.Visible = false;
            button6_level4.Visible = false;
            button7_level4.Visible = false;
            button8_level4.Visible = false;

        }
    }
}
