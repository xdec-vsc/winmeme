using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev29._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int day;
            day = Convert.ToInt32(DateTime.Now.DayOfWeek);
            switch (day)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    MessageBox.Show("Hafta İçi.");
                    break;
                case 6:
                case 7:
                    MessageBox.Show("Hafta Sonu.");
                    break;
            }
        }
    }
}
