using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev36
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal height, weight, bmi;
            height = Convert.ToDecimal(textBox2.Text);
            weight = Convert.ToDecimal(textBox1.Text);
            weight = weight * 1000;
            bmi = weight / (height * height);
            if (bmi >= 30)
            {
                MessageBox.Show("BMI: " + bmi + ", Obez sayılıyorsun.", "DİKKAT!!!");
            }
            else if (bmi > 25)
            {
                MessageBox.Show("BMI: " + bmi + ", Obez olmaya yakınsın.", "Dikkat!!!");
            }
            else if (bmi == 25)
            {
                MessageBox.Show("BMI: " + bmi + ", Yüksek kilolusun.", "Dikkat!");
            }
            else
            {
                MessageBox.Show("BMI: " + bmi + ", Normalsin.");
            }
        }
    }
}
