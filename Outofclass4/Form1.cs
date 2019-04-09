using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//this is my own work
//Enrique Tovar
namespace Outofclass4
{
    public partial class Form1 : Form
    {
        TicTacToeButton[,] grid = new TicTacToeButton[3, 3];
        bool xTurn = true;

        public Form1()
        {
            InitializeComponent();

            //initialize grid with buttons
            int x = 0, y = 0;
            Point loc = new Point(x, y);
            for(int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    x = 100 * r;
                    y = 100 * c;
                    grid[r, c] = new TicTacToeButton();
                    this.Controls.Add(grid[r, c]);
                    grid[r, c].Location = new Point(x, y);
                    grid[r, c].Click += new EventHandler(button_Click);
                }                  
                y = 0;    
            }
        }
        private bool checkWinO1()
        {
            if (grid[0, 0].Text == "O"  && (grid[0, 1].Text == "O") && (grid[0, 2].Text == "O"))
            {
             MessageBox.Show("O is winner");
            }
            //logic that checks for winner 
            return false;
        }
        private bool checkWinO2()
        {
            if (grid[1, 0].Text == "O" && (grid[1, 1].Text == "O") && (grid[1, 2].Text == "O"))
            {
                MessageBox.Show("O is winner");
            }
            //logic that checks for winner 
            return false;
        }
        private bool checkWinO3()
        {
            if (grid[2, 0].Text == "O" && (grid[2, 1].Text == "O") && (grid[2, 2].Text == "O"))
            {
                MessageBox.Show("O is winner");
            }
            //logic that checks for winner 
            return false;
        }
        private bool checkWinO4()
        {
            if (grid[0, 0].Text == "O" && (grid[1, 0].Text == "O") && (grid[2, 0].Text == "O"))
            {
                MessageBox.Show("O is winner");
            }
            //logic that checks for winner 
            return false;
        }
        private bool checkWinO5()
        {
            if (grid[0, 1].Text == "O" && (grid[1, 1].Text == "O") && (grid[2, 1].Text == "O"))
            {
                MessageBox.Show("O is winner");
            }
            //logic that checks for winner 
            return false;
        }
        private bool checkWinO6()
        {
            if (grid[2, 0].Text == "O" && (grid[2, 1].Text == "O") && (grid[2, 2].Text == "O"))
            {
                MessageBox.Show("O is winner");
            }
            //logic that checks for winner 
            return false;
        }
        private bool checkWinO7()
        {
            if (grid[0, 0].Text == "O" && (grid[1, 1].Text == "O") && (grid[2, 2].Text == "O"))
            {
                MessageBox.Show("O is winner");
            }
            //logic that checks for winner 
            return false;
        }
        private bool checkWinO8()
        {
            if (grid[2, 0].Text == "O" && (grid[1, 1].Text == "O") && (grid[0, 2].Text == "O"))
            {
                MessageBox.Show("O is winner");
            }
            //logic that checks for winner 
            return false;
        }

        private bool checkWinX1()
        {
            if (grid[0, 0].Text == "X" && (grid[0, 1].Text == "X") && (grid[0, 2].Text == "X"))
            {
                MessageBox.Show("X is winner");
            }
            //logic that checks for winner 
            return false;
        }
        private bool checkWinX2()
        {
            if (grid[1, 0].Text == "X" && (grid[1, 1].Text == "X") && (grid[1, 2].Text == "X"))
            {
                MessageBox.Show("X is winner");
            }
            //logic that checks for winner 
            return false;
        }
        private bool checkWinX3()
        {
            if (grid[2, 0].Text == "X" && (grid[2, 1].Text == "X") && (grid[2, 2].Text == "X"))
            {
                MessageBox.Show("X is winner");
            }
            //logic that checks for winner 
            return false;
        }
        private bool checkWinX4()
        {
            if (grid[0, 0].Text == "X" && (grid[1, 0].Text == "X") && (grid[2, 0].Text == "X"))
            {
                MessageBox.Show("X is winner");
            }
            //logic that checks for winner 
            return false;
        }
        private bool checkWinX5()
        {
            if (grid[0, 1].Text == "X" && (grid[1, 1].Text == "X") && (grid[2, 1].Text == "X"))
            {
                MessageBox.Show("X is winner");
            }
            //logic that checks for winner 
            return false;
        }
        private bool checkWinX6()
        {
            if (grid[2, 0].Text == "X" && (grid[2, 1].Text == "X") && (grid[2, 2].Text == "X"))
            {
                MessageBox.Show("X is winner");
            }
            //logic that checks for winner 
            return false;
        }
        private bool checkWinX7()
        {
            if (grid[0, 0].Text == "X" && (grid[1, 1].Text == "X") && (grid[2, 2].Text == "X"))
            {
                MessageBox.Show("X is winner");
            }
            //logic that checks for winner 
            return false;
        }
        private bool checkWinX8()
        {
            if (grid[2, 0].Text == "X" && (grid[1, 1].Text == "X") && (grid[0, 2].Text == "X"))
            {
                MessageBox.Show("X is winner");
            }
            //logic that checks for winner 
            return false;
        }


        private void button_Click(object sender, EventArgs e)
        {
            //capture the sender
            TicTacToeButton t = (TicTacToeButton)sender;

            if (xTurn)
            {
                t.BackColor = Color.Gold;
                t.Text = "X";
            }
            else
            {
                t.BackColor = Color.Silver;
                t.Text = "O";
            }
            xTurn = !xTurn;

            if (checkWinO1() || checkWinO2() || checkWinO3() || checkWinO4() || checkWinO5() || checkWinO6() || checkWinO7()
                || checkWinO8())
            {
                MessageBox.Show("Winner!");
            }
            if (checkWinX1() || checkWinX2() || checkWinX3() || checkWinX4() || checkWinX5() || checkWinX6() || checkWinX7()
                || checkWinX8())
            {
                MessageBox.Show("Winner!");
            }
            if (checkDraw())
            {
                MessageBox.Show("Draw!");
            }
 
        }
        private bool checkDraw()
        {
            if ((grid[0, 0].Text != "*" && (grid[0, 1].Text != "*") && (grid[0, 2].Text != "*") && (grid[1, 0].Text != "*")
                 && (grid[1, 1].Text != "*") && (grid[1, 2].Text != "*") && (grid[2, 0].Text != "*") && (grid[2, 1].Text != "*")
                  && (grid[2, 2].Text != "*")))
            {
                MessageBox.Show("Draw!");
            }
            //logic that checks for winner 
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grid[0, 0].Text = "*"; grid[0, 0].BackColor = System.Drawing.Color.Wheat ;
            grid[0, 1].Text = "*"; grid[0, 1].BackColor = System.Drawing.Color.Wheat;
            grid[0, 2].Text = "*"; grid[0, 2].BackColor = System.Drawing.Color.Wheat;
            grid[1, 0].Text = "*"; grid[1, 0].BackColor = System.Drawing.Color.Wheat;
            grid[1, 1].Text = "*"; grid[1, 1].BackColor = System.Drawing.Color.Wheat;
            grid[1, 2].Text = "*"; grid[1, 2].BackColor = System.Drawing.Color.Wheat;
            grid[2, 0].Text = "*"; grid[2, 0].BackColor = System.Drawing.Color.Wheat;
            grid[2, 1].Text = "*"; grid[2, 1].BackColor = System.Drawing.Color.Wheat;
            grid[2, 2].Text = "*"; grid[2, 2].BackColor = System.Drawing.Color.Wheat;
        }
    }
}
