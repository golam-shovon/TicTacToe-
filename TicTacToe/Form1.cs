using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class GameScreen : Form
    {
        int i = 0;
        int a, b, c, d, r, f, g, k, l;
        bool n = true;
        
        public GameScreen()
        {
            InitializeComponent();
            test();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            i++;
            if (i % 2 == 0)
            {
                button4.Text = "X";
                a = 1;
                button4.Enabled = false;
                
            }
            else
            {
                button4.Text = "O";
                a = 2;
                button4.Enabled = false;
               
            }
            test();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i++;
            if (i % 2 == 0)
            {
                button1.Text = "X";
                b = 1;
                button1.Enabled = false;
            }
            else
            {
                button1.Text = "O";
                b = 2;
                button1.Enabled = false;
            }
            test();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i++;
            if (i % 2 == 0)
            {
                button2.Text = "X";
                c = 1;
                button2.Enabled = false;
            }
                
            else
            {
                button2.Text = "O";
                c = 2;
                button2.Enabled = false;
            }
            test();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            i++;
            if (i % 2 == 0)
            {
                button3.Text = "X";
                d = 1;
                button3.Enabled = false;
            }
            else
            {
                button3.Text = "O";
                d = 2;
                button3.Enabled = false;
            }
            test();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            i++;
            if (i % 2 == 0)
            {
                button5.Text = "X";
                r = 1;
                button5.Enabled = false;
            }
            else
            {
                button5.Text = "O";
                r = 2;
                button5.Enabled = false;
            }
            test();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            i++;
            if (i % 2 == 0)
            {
                button6.Text = "X";
                f = 1;
                button6.Enabled = false;
            }
            else
            {
                button6.Text = "O";
                f = 2;
                button6.Enabled = false;
            }
            test();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            i++;
            if (i % 2 == 0)
            {
                button7.Text = "X";
                g = 1;
                button7.Enabled = false;
            }
            else
            {
                button7.Text = "O";
                g = 2;
                button7.Enabled = false;
            }
            test();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            i++;
            if (i % 2 == 0)
            {
                button8.Text = "X";
                k=1;
                button8.Enabled = false;
            }
            else
            {
                button8.Text = "O";
                k=2;
                button8.Enabled = false;
            }
            test();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            i++;
            if (i % 2 == 0)
            {
                button9.Text = "X";
                l=1;
                button9.Enabled = false;
            }
            else
            {
                button9.Text = "O";
                l=2;
                button9.Enabled = false;
            }
            test();
        }
        
        public void test ()
            
        {
            try
            {
                if (b == 1 && a == 1 && g == 1|| b == 1 && c == 1 && d == 1 || a == 1 && r == 1 && f == 1 || g == 1 && k == 1 && l == 1 || c == 1 && r == 1 && k == 1 || f == 1 && l == 1 && d == 1 || b == 1 && r == 1 && l == 1 || r == 1 && g == 1 && d == 1)
                {
                    MessageBox.Show("Second Player Won ");
                    this.Hide();
                    Game_Over n = new Game_Over();
                    n.Show();




                }
                else if (b == 2 && a == 2 && g == 2 || b == 2 && c == 2 && d == 2 || a == 2 && r == 2 && f == 2 || g == 2 && k == 2 && l == 2 || c == 2 && r == 2 && k == 2 || f == 2 && l == 2 && d == 2 || b == 2 && r == 2 && l == 2 || r == 2 && g == 2 && d == 2)
                {
                    MessageBox.Show("First Player Won ");
                    this.Hide();
                    Game_Over n = new Game_Over();
                    n.Show();


                }
                else if (i == 9)
                {
                    MessageBox.Show("No one Wins ");
                    this.Hide();
                    Game_Over n = new Game_Over();
                    n.Show();


                }


            }
            catch (Exception e)
            {
 
            }

          

        }
           

        
    }
}
