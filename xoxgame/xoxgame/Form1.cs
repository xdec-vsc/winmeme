using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xoxgame
{
    public partial class Form1 : Form
    {
        string a1 = "", a2 = "", a3 = "", b1 = "", b2 = "", b3 = "", c1 = "", c2 = "", c3 = "";
        bool playerside, gamecontinue; //playerside=true is x, playerside=false is O
        bool a1done, a2done, a3done, b1done, b2done, b3done, c1done, c2done, c3done;
        int squaredance = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            playerside = true;
            gamecontinue = true;
            squaredance = 0;
            a1done = false; a2done = false; a3done = false;
            b1done = false; b2done = false; b3done = false;
            c1done = false; c2done = false; c3done = false;
            a1 = "";a2 = "";a3 = "";
            b1 = "";b2 = "";b3 = "";
            c1 = "";c2 = "";c3 = "";
            a1b.Text = ""; a2b.Text = ""; a3b.Text = "";
            b1b.Text = ""; b2b.Text = ""; b3b.Text = "";
            c1b.Text = ""; c2b.Text = ""; c3b.Text = "";
        }

        private void c3b_Click(object sender, EventArgs e)
        {
            //3 win
            if (gamecontinue == true)
            {
                if (c3done != true)
                {
                    //X & O set
                    if (playerside == true)
                    {
                        c3done = true;
                        c3 = "x";
                        c3b.Text = "X";
                        playerside = false;
                        squaredance = squaredance + 1;
                    }
                    else if (playerside == false)
                    {
                        c3done = true;
                        c3 = "o";
                        c3b.Text = "O";
                        playerside = true;
                        squaredance = squaredance + 1;
                    }

                    //win check
                    if (c3 == "x")
                    {
                        if (c2 == "x")
                        {
                            if (c1 == "x")
                            {
                                gamecontinue = false;
                                MessageBox.Show("X KAZANDI!");
                            }
                        }
                        else if (b3 == "x")
                        {
                            if (a3 == "x")
                            {
                                gamecontinue = false;
                                MessageBox.Show("X KAZANDI!");
                            }
                        }
                        else if (b2 == "x")
                        {
                            if (a1 == "x")
                            {
                                gamecontinue = false;
                                MessageBox.Show("X KAZANDI!");
                            }
                        }
                    }
                    if (c3 == "o")
                    {
                        if (c2 == "o")
                        {
                            if (c1 == "o")
                            {
                                gamecontinue = false;
                                MessageBox.Show("O KAZANDI!");
                            }
                        }
                        else if (b3 == "o")
                        {
                            if (a3 == "o")
                            {
                                gamecontinue = false;
                                MessageBox.Show("O KAZANDI!");
                            }
                        }
                        else if (b2 == "o")
                        {
                            if (a1 == "o")
                            {
                                gamecontinue = false;
                                MessageBox.Show("O KAZANDI!");
                            }
                        }
                    }
                    else if (squaredance > 8)
                    {
                        if (gamecontinue == true)
                        {
                            gamecontinue = false;
                            MessageBox.Show("Oyun eşit bitti!");
                        }
                    }
                }
            }
        }

        
        private void c2b_Click(object sender, EventArgs e)
        {
            //2win
            if (gamecontinue == true)
            {
                if (c2done != true)
                {
                    //X & O set
                    if (playerside == true)
                    {
                        c2done = true;
                        c2 = "x";
                        c2b.Text = "X";
                        playerside = false;
                        squaredance = squaredance + 1;
                    }
                    else if (playerside == false)
                    {
                        c2done = true;
                        c2 = "o";
                        c2b.Text = "O";
                        playerside = true;
                        squaredance = squaredance + 1;
                    }

                    //win check
                    if (c2 == "x")
                    {
                        if (c3 == "x")
                        {
                            if (c1 == "x")
                            {
                                gamecontinue = false;
                                MessageBox.Show("X KAZANDI!");
                            }
                        }
                        else if (b2 == "x")
                        {
                            if (a2 == "x")
                            {
                                gamecontinue = false;
                                MessageBox.Show("X KAZANDI!");
                            }
                        }
                    }
                    else if (c2 == "o")
                    {
                        if (c3 == "o")
                        {
                            if (c1 == "o")
                            {
                                gamecontinue = false;
                                MessageBox.Show("O KAZANDI!");
                            }
                        }
                        else if (b2 == "o")
                        {
                            if (a2 == "o")
                            {
                                gamecontinue = false;
                                MessageBox.Show("O KAZANDI!");
                            }
                        }
                    }
                    else if (squaredance > 8)
                    {
                        if (gamecontinue == true)
                        {
                            gamecontinue = false;
                            MessageBox.Show("Oyun eşit bitti!");
                        }
                    }
                }
            }
        }

        
        private void c1b_Click(object sender, EventArgs e)
        {
            //3 win
            if (gamecontinue == true)
            {
                if (c1done != true)

                {
                    //X & O set
                    if (playerside == true)
                    {
                        c1done = true;
                        c1 = "x";
                        c1b.Text = "X";
                        playerside = false;
                        squaredance = squaredance + 1;
                    }
                    else if (playerside == false)
                    {
                        c1done = true;
                        c1 = "o";
                        c1b.Text = "O";
                        playerside = true;
                        squaredance = squaredance + 1;
                    }

                    //win check
                    if (c1 == "x")
                    {
                        if (c2 == "x")
                        {
                            if (c3 == "x")
                            {
                                gamecontinue = false;
                                MessageBox.Show("X KAZANDI!");
                            }
                        }
                        else if (a1 == "x")
                        {
                            if (b1 == "x")
                            {
                                gamecontinue = false;
                                MessageBox.Show("X KAZANDI!");
                            }
                        }
                        else if (b2 == "x")
                        {
                            if (a3 == "x")
                            {
                                gamecontinue = false;
                                MessageBox.Show("X KAZANDI!");
                            }
                        }
                    }
                    if (c1 == "o")
                    {
                        if (c2 == "o")
                        {
                            if (c3 == "o")
                            {
                                gamecontinue = false;
                                MessageBox.Show("O KAZANDI!");
                            }
                        }
                        else if (b1 == "o")
                        {
                            if (a1 == "o")
                            {
                                gamecontinue = false;
                                MessageBox.Show("O KAZANDI!");
                            }
                        }
                        else if (b2 == "o")
                        {
                            if (a3 == "o")
                            {
                                gamecontinue = false;
                                MessageBox.Show("O KAZANDI!");
                            }
                        }
                    }
                    else if (squaredance > 8)
                    {
                        if (gamecontinue == true)
                        {
                            gamecontinue = false;
                            MessageBox.Show("Oyun eşit bitti!");
                        }
                    }
                }
            }
        }

        
        private void b3b_Click(object sender, EventArgs e)
        {
            //2win
            if (gamecontinue == true)
            {
                if (b3done != true)
                {
                    //X & O set
                    if (playerside == true)
                    {
                        b3done = true;
                        b3 = "x";
                        b3b.Text = "X";
                        playerside = false;
                        squaredance = squaredance + 1;
                    }
                    else if (playerside == false)
                    {
                        b3done = true;
                        b3 = "o";
                        b3b.Text = "O";
                        playerside = true;
                        squaredance = squaredance + 1;
                    }

                    //win check
                    if (b3 == "x")
                    {
                        if (a3 == "x")
                        {
                            if (c3 == "x")
                            {
                                gamecontinue = false;
                                MessageBox.Show("X KAZANDI!");
                            }
                        }
                        else if (b2 == "x")
                        {
                            if (b1 == "x")
                            {
                                gamecontinue = false;
                                MessageBox.Show("X KAZANDI!");
                            }
                        }
                    }
                    else if (b3 == "o")
                    {
                        if (a3 == "o")
                        {
                            if (c3 == "o")
                            {
                                gamecontinue = false;
                                MessageBox.Show("O KAZANDI!");
                            }
                        }
                        else if (b1 == "o")
                        {
                            if (b2 == "o")
                            {
                                gamecontinue = false;
                                MessageBox.Show("O KAZANDI!");
                            }
                        }
                    }
                    else if (squaredance > 8)
                    {
                        if (gamecontinue == true)
                        {
                            gamecontinue = false;
                            MessageBox.Show("Oyun eşit bitti!");
                        }
                    }
                }
            }
        }

        
        private void b2b_Click(object sender, EventArgs e)
        {
            //2win
            if (gamecontinue == true)
            {
                if (b2done != true)
                {
                    //X & O set
                    if (playerside == true)
                    {
                        b2done = true;
                        b2 = "x";
                        b2b.Text = "X";
                        playerside = false;
                        squaredance = squaredance + 1;
                    }
                    else if (playerside == false)
                    {
                        b2done = true;
                        b2 = "o";
                        b2b.Text = "O";
                        playerside = true;
                        squaredance = squaredance + 1;
                    }

                    //win check
                    if (b2 == "x")
                    {
                        if (a2 == "x")
                        {
                            if (c2 == "x")
                            {
                                gamecontinue = false;
                                MessageBox.Show("X KAZANDI!");
                            }
                        }
                        else if (b1 == "x")
                        {
                            if (b3 == "x")
                            {
                                gamecontinue = false;
                                MessageBox.Show("X KAZANDI!");
                            }
                        }
                    }
                    else if (b2 == "o")
                    {
                        if (a2 == "o")
                        {
                            if (c2 == "o")
                            {
                                gamecontinue = false;
                                MessageBox.Show("O KAZANDI!");
                            }
                        }
                        else if (b1 == "o")
                        {
                            if (b3 == "o")
                            {
                                gamecontinue = false;
                                MessageBox.Show("O KAZANDI!");
                            }
                        }
                    }
                    else if (squaredance > 8)
                    {
                        if (gamecontinue == true)
                        {
                            gamecontinue = false;
                            MessageBox.Show("Oyun eşit bitti!");
                        }
                    }
                }
            }
        }

        
        private void b1b_Click(object sender, EventArgs e)
        {//2win
            if (gamecontinue == true)
            {
                if (b1done != true)
                {
                    //X & O set
                    if (playerside == true)
                    {
                        b1done = true;
                        b1 = "x";
                        b1b.Text = "X";
                        playerside = false;
                        squaredance = squaredance + 1;
                    }
                    else if (playerside == false)
                    {
                        b1done = true;
                        b1 = "o";
                        b1b.Text = "O";
                        playerside = true;
                        squaredance = squaredance + 1;
                    }

                    //win check
                    if (b1 == "x")
                    {
                        if (a1 == "x")
                        {
                            if (c1 == "x")
                            {
                                gamecontinue = false;
                                MessageBox.Show("X KAZANDI!");
                            }
                        }
                        else if (b2 == "x")
                        {
                            if (b3 == "x")
                            {
                                gamecontinue = false;
                                MessageBox.Show("X KAZANDI!");
                            }
                        }
                    }
                    else if (b1 == "o")
                    {
                        if (a1 == "o")
                        {
                            if (c1 == "o")
                            {
                                gamecontinue = false;
                                MessageBox.Show("O KAZANDI!");
                            }
                        }
                        else if (b2 == "o")
                        {
                            if (b3 == "o")
                            {
                                gamecontinue = false;
                                MessageBox.Show("O KAZANDI!");
                            }
                        }
                    }
                    else if (squaredance > 8)
                    {
                        if (gamecontinue == true)
                        {
                            gamecontinue = false;
                            MessageBox.Show("Oyun eşit bitti!");
                        }
                    }
                }
            }
        }

        
        private void a3b_Click(object sender, EventArgs e)
        {//3 win
            if (gamecontinue == true)
            {
                if (a3done != true)
                {
                    //X & O set
                    if (playerside == true)
                    {
                        a3done = true;
                        a3 = "x";
                        a3b.Text = "X";
                        playerside = false;
                        squaredance = squaredance + 1;
                    }
                    else if (playerside == false)
                    {
                        a3done = true;
                        a3 = "o";
                        a3b.Text = "O";
                        playerside = true;
                        squaredance = squaredance + 1;
                    }

                    //win check
                    if (a3 == "x")
                    {
                        if (a2 == "x")
                        {
                            if (a1 == "x")
                            {
                                gamecontinue = false;
                                MessageBox.Show("X KAZANDI!");
                            }
                        }
                        else if (b3 == "x")
                        {
                            if (c3 == "x")
                            {
                                gamecontinue = false;
                                MessageBox.Show("X KAZANDI!");
                            }
                        }
                        else if (b2 == "x")
                        {
                            if (c1 == "x")
                            {
                                gamecontinue = false;
                                MessageBox.Show("X KAZANDI!");
                            }
                        }
                    }
                    else if (a3 == "o")
                    {
                        if (a2 == "o")
                        {
                            if (a1 == "o")
                            {
                                gamecontinue = false;
                                MessageBox.Show("O KAZANDI!");
                            }
                        }
                        else if (b3 == "o")
                        {
                            if (c3 == "o")
                            {
                                gamecontinue = false;
                                MessageBox.Show("O KAZANDI!");
                            }
                        }
                        else if (b2 == "o")
                        {
                            if (c1 == "o")
                            {
                                gamecontinue = false;
                                MessageBox.Show("O KAZANDI!");
                            }
                        }
                    }
                    else if (squaredance > 8)
                    {
                        if (gamecontinue == true)
                        {
                            gamecontinue = false;
                            MessageBox.Show("Oyun eşit bitti!");
                        }
                    }
                }
            }

        }

        

        private void a2b_Click(object sender, EventArgs e)
        {//2win
            if (gamecontinue == true)
            {
                if (a2done != true)
                {
                    //X & O set
                    if (playerside == true)
                    {
                        a2done = true;
                        a2 = "x";
                        a2b.Text = "X";
                        playerside = false;
                        squaredance = squaredance + 1;
                    }
                    else if (playerside == false)
                    {
                        a2done = true;
                        a2 = "o";
                        a2b.Text = "O";
                        playerside = true;
                        squaredance = squaredance + 1;
                    }

                    //win check
                    if (a2 == "x")
                    {
                        if (a1 == "x")
                        {
                            if (a3 == "x")
                            {
                                gamecontinue = false;
                                MessageBox.Show("X KAZANDI!");
                            }
                        }
                        else if (b2 == "x")
                        {
                            if (c2 == "x")
                            {
                                gamecontinue = false;
                                MessageBox.Show("X KAZANDI!");
                            }
                        }
                    }
                    else if (a2 == "o")
                    {
                        if (a1 == "o")
                        {
                            if (a3 == "o")
                            {
                                gamecontinue = false;
                                MessageBox.Show("O KAZANDI!");
                            }
                        }
                        else if (b2 == "o")
                        {
                            if (c2 == "o")
                            {
                                gamecontinue = false;
                                MessageBox.Show("O KAZANDI!");
                            }
                        }
                    }
                    else if (squaredance > 8)
                    {
                        if (gamecontinue == true)
                        {
                            gamecontinue = false;
                            MessageBox.Show("Oyun eşit bitti!");
                        }
                    }
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
            playerside = true;
            gamecontinue = true;
            a1done = false; a2done = false; a3done = false;
            b1done = false; b2done = false; b3done = false;
            c1done = false; c2done = false; c3done = false;
        }

        private void a1b_Click(object sender, EventArgs e)
        {//3 win
            if (gamecontinue == true)
            {
                if (a1done != true)
                {
                    //X & O set
                    if (playerside == true)
                    {
                        a1done = true;
                        a1 = "x";
                        a1b.Text = "X";
                        playerside = false;
                        squaredance = squaredance + 1;
                    }
                    else if (playerside == false)
                    {
                        a1done = true;
                        a1 = "o";
                        a1b.Text = "O";
                        playerside = true;
                        squaredance = squaredance + 1;
                    }

                    //win check
                    if (a1 == "x")
                    {
                        if (a2 == "x")
                        {
                            if (a3 == "x")
                            {
                                gamecontinue = false;
                                MessageBox.Show("X KAZANDI!");
                            }
                        }
                        else if (b1 == "x")
                        {
                            if (c1 == "x")
                            {
                                gamecontinue = false;
                                MessageBox.Show("X KAZANDI!");
                            }
                        }
                        else if (b2 == "x")
                        {
                            if (c3 == "x")
                            {
                                gamecontinue = false;
                                MessageBox.Show("X KAZANDI!");
                            }
                        }
                    }
                    else if (a1 == "o")
                    {
                        if (a2 == "o")
                        {
                            if (a3 == "o")
                            {
                                gamecontinue = false;
                                MessageBox.Show("O KAZANDI!");
                            }
                        }
                        else if (b1 == "o")
                        {
                            if (c1 == "o")
                            {
                                gamecontinue = false;
                                MessageBox.Show("O KAZANDI!");
                            }
                        }
                        else if (b2 == "o")
                        {
                            if (c3 == "o")
                            {
                                gamecontinue = false;
                                MessageBox.Show("O KAZANDI!");
                            }
                        }
                    }
                    else if (squaredance > 8)
                    {
                        if (gamecontinue == true)
                        {
                            gamecontinue = false;
                            MessageBox.Show("Oyun eşit bitti!");
                        }
                    }
                }
            }
        }
    }
}
