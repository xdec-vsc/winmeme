using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace net_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.White;
            textBox1.BackColor = Color.White;
            textBox1.ForeColor = Color.Black;
            ForeColor = Color.Black;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string ggbro;
            try
            {
                ggbro = textBox1.Text.ToLower();
            }
            catch
            {

            }
            finally
            {
                
                try
                {
                    ggbro = textBox1.Text.ToLower();
                    switch (ggbro)
                    {
                        case "red":
                            BackColor = Color.Red;
                            textBox1.BackColor = Color.Red;
                            textBox1.ForeColor = Color.White;
                            ForeColor = Color.White;
                            break;
                        case "blue":
                            BackColor = Color.Blue;
                            textBox1.BackColor = Color.Blue;
                            textBox1.ForeColor = Color.White;
                            ForeColor = Color.White;
                            break;
                        case null:
                            BackColor = Color.White;
                            textBox1.BackColor = Color.White;
                            textBox1.ForeColor = Color.Black;
                            ForeColor = Color.Black;
                    }
                }
                catch
                {
                    BackColor = Color.White;
                    textBox1.BackColor = Color.White;
                    textBox1.ForeColor = Color.Black;
                    ForeColor = Color.Black;
                }
            }
        }
    }
}
