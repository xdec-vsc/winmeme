using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clickspersecondtest
{
    public partial class Form1 : Form
    {
        int bff = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double timerbase, timer, clicks, cps;
            if (bff == 0)
            {
                bff = 1;
                clicks = 0;
                cps = 0;
                timerbase = DateTime.Now.Second;
                while (timerbase > timerbase +1)
                {
                    if (timerbase > 59)
                    {
                        timerbase = timerbase - 60;
                    }
                    button2.BackColor = Color.Red;
                    button2.ForeColor = Color.White;
                    button2.Text = "3...";
                }
                timerbase = DateTime.Now.Second;
                while (timerbase > timerbase + 1)
                {
                    if (timerbase > 59)
                    {
                        timerbase = timerbase - 60;
                    }
                    button2.BackColor = Color.Yellow;
                    button2.ForeColor = Color.Black;
                    button2.Text = "2..";
                }
                timerbase = DateTime.Now.Second;
                while (timerbase > timerbase + 1)
                {
                    if (timerbase > 59)
                    {
                        timerbase = timerbase - 60;
                    }
                    button2.BackColor = Color.LimeGreen;
                    button2.ForeColor = Color.White;
                    button2.Text = "1.";
                }
                timerbase = DateTime.Now.Second;
                while (timerbase > timerbase + 1)
                {
                    if (timerbase > 59)
                    {
                        timerbase = timerbase - 60;
                    }
                    button2.BackColor = Color.Black;
                    button2.ForeColor = Color.White;
                    button2.Text = "GO!";
                }
            }
            else if (bff == 1)
            {

                if (Convert.ToInt32(textBox1.Text) > 15)
                {
                    timer = 15;
                }
                else
                {
                    timer = Convert.ToInt32(textBox1.Text);
                }
                timerbase = DateTime.Now.Second;
                while (timerbase > timerbase + timer)
                {
                    if (timerbase > 59)
                    {
                        timerbase = timerbase - 60;
                    }
                    clicks = clicks + 1;
                }
            }
            }
        }
    }

