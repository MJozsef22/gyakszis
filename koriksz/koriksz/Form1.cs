using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace koriksz
{
    public partial class Form1 : Form
    {


        private bool currentPlayer = true; // true for player X, false for player O
        private Button[] buttons;

        private bool IsGameFinished()
        {
            // Check rows, columns, and diagonals for a win
            for (int i = 0; i < 3; i++)
            {
                // Rows
                if (buttons[i * 3].Text != "" && buttons[i * 3].Text == buttons[i * 3 + 1].Text && buttons[i * 3].Text == buttons[i * 3 + 2].Text)
                {
                    return true;
                }
                // Columns
                if (buttons[i].Text != "" && buttons[i].Text == buttons[i + 3].Text && buttons[i].Text == buttons[i + 6].Text)
                {
                    return true;
                }
            }
            // Diagonals
            if (buttons[0].Text != "" && buttons[0].Text == buttons[4].Text && buttons[0].Text == buttons[8].Text)
            {
                return true;
            }
            if (buttons[2].Text != "" && buttons[2].Text == buttons[4].Text && buttons[2].Text == buttons[6].Text)
            {
                return true;
            }

            // Check for a draw
            foreach (Button button in buttons)
            {
                if (button.Text == "")
                {
                    return false; // There are empty cells, the game is not finished
                }
            }

            MessageBox.Show("It's a draw!");
            return true; // All cells are filled, the game is a draw
        }

        private void gameFunction(object sender)
        {
            Button button = (Button)sender;

            if (button.Text == "" && !IsGameFinished())
            {
                if (currentPlayer)
                {
                    button.Text = "X";
                }
                else
                {
                    button.Text = "O";
                }

                currentPlayer = !currentPlayer;
                UpdateTurnLabel();

                if (IsGameFinished())
                {
                    string winner = currentPlayer ? "O" : "X";
                    MessageBox.Show($"Player {winner} wins!");
                }
            }
        }
        private void UpdateTurnLabel()
        {
            UpdateTurnLB.Text = currentPlayer ? "Player X's Turn" : "Player O's Turn";
        }

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttons = new Button[] { button1, button2, button3,
                button4, button5, button6, button7, button8, button9 };
            // Reset button click event handler
            foreach (Button button in buttons)
            {
                button.Text = "";
            }
            UpdateTurnLabel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gameFunction(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gameFunction(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gameFunction(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gameFunction(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            gameFunction(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            gameFunction(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            gameFunction(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            gameFunction(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            gameFunction(sender);
        }

        private void Resetbt_Click(object sender, EventArgs e)
        {
            // Reset button click event handler
            foreach (Button button in buttons)
            {
                button.Text = "";
            }

            currentPlayer = true; // Set the starting player to X
            UpdateTurnLabel();
        }
    }
}
