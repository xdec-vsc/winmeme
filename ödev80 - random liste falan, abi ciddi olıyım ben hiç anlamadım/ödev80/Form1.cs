using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev80
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] on1 = new int[100];
        int[] onsum = new int[100];
        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 0; i < on1.Length; i++)
            {
                on1[i] = random.Next(0, 101);
            }

            for (int i = 0;i < on1.Length; i++)
            {
                listBox1.Items.Add(on1[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < on1.Length; i++)
            {
                onsum[i] = on1[i];
            }

            for (int i = 0; i < on1.Length; i++)
            {
                listBox2.Items.Add(onsum[i]);
            }
        }
    }
}
