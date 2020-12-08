using System;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool turn = true;
        int turnCount = 0;
        public Form1()
        {
            InitializeComponent();
        }
        public void Check()
        {
            bool winner = false;

            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (A1.Text != ""))
                winner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (B1.Text != ""))
                winner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (C1.Text != ""))
                winner = true;
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (A1.Text != ""))
                winner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (A2.Text != ""))
                winner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (A3.Text != ""))
                winner = true;
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (A1.Text != ""))
                winner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (A3.Text != ""))
                winner = true;

            if (winner)
            {
                string w = "";
                if (turn)
                {
                    w = "Player O";
                }
                else w = "Player X";
                MessageBox.Show("The winner is " + w + "! Press restart to continue playing game.");

            }
            else if (turnCount == 9)
            {
                MessageBox.Show("Game draw! Press restart to continue playing game.");
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            try
            {
                Button b = (Button)sender;
                if (turn == true)
                    b.Text = "X";
                else b.Text = "O";
                turn = !turn;
                turnCount++;
                b.Enabled = false;
                Check();
            }
            catch { }
        }

        private void Restart(object sender, EventArgs e)
        {
            A1.Enabled = true;
            A1.Text = "";
            A2.Enabled = true;
            A2.Text = "";
            A3.Enabled = true;
            A3.Text = "";
            B1.Enabled = true;
            B1.Text = "";
            B2.Enabled = true;
            B2.Text = "";
            B3.Enabled = true;
            B3.Text = "";
            C1.Enabled = true;
            C1.Text = "";
            C2.Enabled = true;
            C2.Text = "";
            C3.Enabled = true;
            C3.Text = "";
            turnCount = 0;
            turn = true;
        }
    }
}
