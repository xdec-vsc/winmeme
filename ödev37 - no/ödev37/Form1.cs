using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev37
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int firstdig, seconddig, thirddig;
            firstdig = Convert.ToInt32(textBox1.Text);
            seconddig = Convert.ToInt32(textBox2.Text);
            thirddig = Convert.ToInt32(textBox3.Text);

            if (firstdig == seconddig)
            {
                if (seconddig == thirddig)
                {
                    listBox1.Items.Add("Hepsi birbirine eşit.");
                }
                else if (seconddig > thirddig)
                {
                    listBox1.Items.Add("1. ve 2. sayı eşit ve en büyük sayılar.");
                    listBox1.Items.Add("3. sayı en küçük.");
                }
                else if (thirddig > seconddig)
                {
                    listBox1.Items.Add("3. sayı en büyük.");
                    listBox1.Items.Add("1. ve 2. sayı eşit ve en küçük sayılar.");
                }
            }
            else if (seconddig == thirddig)
            {
                if (firstdig == thirddig)
                {
                    listBox1.Items.Add("Hepsi birbirine eşit.");
                }
                else if (firstdig > thirddig)
                {
                    listBox1.Items.Add("2. ve 3. sayı eşit ve en büyük sayılar.");
                    listBox1.Items.Add("1. sayı en küçük.");
                }
                else if (thirddig > firstdig)
                {
                    listBox1.Items.Add("1. sayı en büyük.");
                    listBox1.Items.Add("2. ve 3. sayı eşit ve en küçük sayılar.");
                }
            }
            else if (seconddig == thirddig)
            {
                if (firstdig == thirddig)
                {
                    listBox1.Items.Add("Hepsi birbirine eşit.");
                }
                else if (firstdig > thirddig)
                {
                    listBox1.Items.Add("1. ve 2. sayı eşit ve en büyük sayılar.");
                    listBox1.Items.Add("3. sayı en küçük.");
                }
                else if (thirddig > firstdig)
                {
                    listBox1.Items.Add("3. sayı en büyük.");
                    listBox1.Items.Add("1. ve 2. sayı eşit ve en küçük sayılar.");
                }

            }
    }
}
