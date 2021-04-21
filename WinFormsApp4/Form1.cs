using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    enum CurrentPlayer
    {
        Cross,
        Circle
    }
    public partial class Form1 : Form
    {
        CurrentPlayer CurrentPlayer;
        public Form1()
        {
            InitializeComponent();
            CurrentPlayer = CurrentPlayer.Cross;
            changeLabel();
        }

        private void Mark(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;
            if(CurrentPlayer == CurrentPlayer.Cross)
            {
                senderButton.Text = "X";
                CurrentPlayer = CurrentPlayer.Circle;
            }
            else
            {
                senderButton.Text = "O";
                CurrentPlayer = CurrentPlayer.Cross;
            }
            checkForWinner();
            changeLabel();
          
        }
        public void changeLabel()
        {
            if(CurrentPlayer == CurrentPlayer.Cross)
            {
                currentPlayerLabel.Text = "Krzyżyk";
            }
            else
            {
                currentPlayerLabel.Text = "Kółko";
            }
        }
        public void checkForWinner()
        {
            if(String.Compare(tl.Text, cl.Text) == 0 && String.Compare(cl.Text, bl.Text) == 0)
            {
                winnerLabel victoryScreen = new winnerLabel();
                victoryScreenScreen.winner = tl.Text;
                victoryScreen.Show();
            }
        }
    }
}
