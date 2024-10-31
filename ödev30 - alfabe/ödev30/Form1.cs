using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int alphabet;
            alphabet = Convert.ToInt32(comboBox1.SelectedIndex) + 1;
            switch (alphabet)
            {
                case 1: 
                    label1.Text = "A harfi, alfabenin 1. harfi.";
                    break;
                case 2:
                    label1.Text = "B harfi, alfabenin 2. harfi.";
                    break;
                case 3:
                    label1.Text = "C harfi, alfabenin 3. harfi.";
                    break;
                case 4:
                    label1.Text = "Ç harfi, alfabenin 4. harfi.";
                    break;
                case 5:
                    label1.Text = "D harfi, alfabenin 5. harfi.";
                    break;
                case 6:
                    label1.Text = "E harfi, alfabenin 6. harfi.";
                    break;
                case 7:
                    label1.Text = "F harfi, alfabenin 7. harfi.";
                    break;
                case 8:
                    label1.Text = "G harfi, alfabenin 8. harfi.";
                    break;
                case 9:
                    label1.Text = "Ğ harfi, alfabenin 9. harfi.";
                    break;
                case 10:
                    label1.Text = "H harfi, alfabenin 10. harfi.";
                    break;
                case 11:
                    label1.Text = "I harfi, alfabenin 11. harfi.";
                    break;
                case 12:
                    label1.Text = "İ harfi, alfabenin 12. harfi.";
                    break;
                case 13:
                    label1.Text = "J harfi, alfabenin 13. harfi.";
                    break;
                case 14:
                    label1.Text = "K harfi, alfabenin 14. harfi.";
                    break;
                case 15:
                    label1.Text = "L harfi, alfabenin 15. harfi.";
                    break;
                case 16:
                    label1.Text = "M harfi, alfabenin 16. harfi.";
                    break;
                case 17:
                    label1.Text = "N harfi, alfabenin 17. harfi.";
                    break;
                case 18:
                    label1.Text = "O harfi, alfabenin 18. harfi.";
                    break;
                case 19:
                    label1.Text = "Ö harfi, alfabenin 19. harfi.";
                    break;
                case 20:
                    label1.Text = "P harfi, alfabenin 20. harfi.";
                    break;
                case 21:
                    label1.Text = "R harfi, alfabenin 21. harfi.";
                    break;
                case 22:
                    label1.Text = "S harfi, alfabenin 22. harfi.";
                    break;
                case 23:
                    label1.Text = "Ş harfi, alfabenin 23. harfi.";
                    break;
                case 24:
                    label1.Text = "T harfi, alfabenin 24. harfi.";
                    break;
                case 25:
                    label1.Text = "U harfi, alfabenin 25. harfi.";
                    break;
                case 26:
                    label1.Text = "Ü harfi, alfabenin 26. harfi.";
                    break;
                case 27:
                    label1.Text = "V harfi, alfabenin 27. harfi.";
                    break;
                case 28:
                    label1.Text = "Y harfi, alfabenin 28. harfi.";
                    break;
                case 29:
                    label1.Text = "Z harfi, alfabenin 29. harfi.";
                    break;

            }
        }
        }
    }
