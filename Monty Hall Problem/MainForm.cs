using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MontyHallProblem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            NewSimulation();
        }

        #region Simulation
        // [gameStage]: 1 - 1st user choice + host choice, 2 - 2nd user choice, 3 - results 
        int gameStage = 1;

        int winningDoor, firstChoice, hostChoice, secondChoice;

        // Statistics
        double k_winrate, c_winrate;
        int k_wins = 0, k_loses = 0, c_wins = 0, c_loses = 0;

        Random r = new Random();

        private void NewSimulation()
        {
            gameStage = 1;
            for(int i = 1; i <= 3; i++)
            {
                ((PictureBox)this.Controls[$"pbDoor{i}"]).Image = Properties.Resources.Door;
                ((PictureBox)this.Controls[$"pbDoor{i}"]).Enabled = true;
            }
            for (int i = 1; i <= 3; i++)
            {
                ((PictureBox)this.Controls[$"pbArrow{i}"]).Visible = true;
            }
            lblAnnouncer.Text = "Pick one of three doors or start auto-simulation";
            winningDoor = r.Next(1, 4);
        }

        private void ProceedSimulation(int userChoice)
        {
            switch(gameStage)
            {
                case 1:
                    FirstTurn(userChoice);
                    break;
                case 2:
                    SecondTurn(userChoice);
                    break;
                case 3:
                    NewSimulation();
                    break;
            }
        }

        private void FirstTurn(int choice)
        {
            firstChoice = choice;
            do
            {
                hostChoice = r.Next(1, 4);
            }
            while (hostChoice == winningDoor || hostChoice == firstChoice);
            ((PictureBox)this.Controls[$"pbArrow{hostChoice}"]).Visible = false;
            ((PictureBox)this.Controls[$"pbDoor{hostChoice}"]).Image = Properties.Resources.Goat;
            ((PictureBox)this.Controls[$"pbDoor{hostChoice}"]).Enabled = false;
            lblAnnouncer.Text = $"Host opens the door №{hostChoice}.\nDo you want to keep your choice or change it?";
            gameStage++;
        }

        private void SecondTurn(int choice)
        {
            secondChoice = choice;
            int remainingDoor;
            do
            {
                remainingDoor = r.Next(1, 4);
            }
            while (remainingDoor == secondChoice || remainingDoor == hostChoice);
            ((PictureBox)this.Controls[$"pbArrow{remainingDoor}"]).Visible = false;

            bool isKeeping = (secondChoice == firstChoice);
            bool result = (secondChoice == winningDoor);
            if (result)
            {
                ((PictureBox)this.Controls[$"pbDoor{secondChoice}"]).Image = Properties.Resources.Car;
                ((PictureBox)this.Controls[$"pbDoor{remainingDoor}"]).Image = Properties.Resources.Goat;
            }
            else
            {
                ((PictureBox)this.Controls[$"pbDoor{secondChoice}"]).Image = Properties.Resources.Goat;
                ((PictureBox)this.Controls[$"pbDoor{remainingDoor}"]).Image = Properties.Resources.Car;
            }
            UpdateStatistics(result, isKeeping);
            gameStage++;
        }

        private void UpdateStatistics(bool result, bool isKeeping)
        {
            if(isKeeping)
            {
                if(result)
                {
                    lblAnnouncer.Text = "[KEEP]\nYou WIN!\nClick any door to play again...";
                    k_wins++;
                }
                else
                {
                    lblAnnouncer.Text = "[KEEP]\nYou LOSE!\nClick any door to play again...";
                    k_loses++;
                }
                k_winrate = (double)k_wins / ((double)k_wins + (double)k_loses);
                lblWinsByKeep.Text = $"{k_wins}({(k_winrate * 100).ToString("F1")}%)";
                lblLosesByKeep.Text = $"{k_loses}({((1 - k_winrate) * 100).ToString("F1")}%)";
            }
            else
            {
                if (result)
                {
                    lblAnnouncer.Text = "[CHANGE]\nYou WIN!\nClick any door to play again...";
                    c_wins++;
                }
                else
                {
                    lblAnnouncer.Text = "[CHANGE]\nYou LOSE!\nClick any door to play again...";
                    c_loses++;
                }
                c_winrate = (double)c_wins / ((double)c_wins + (double)c_loses);
                lblWinsByChange.Text = $"{c_wins}({(c_winrate * 100).ToString("F1")}%)";
                lblLosesByChange.Text = $"{c_loses}({((1 - c_winrate) * 100).ToString("F1")}%)";
            }
        }

        private void RunAutoSimulation(bool isKeeping)
        {
            NewSimulation();
            ProceedSimulation(r.Next(1, 4));
            if (isKeeping)
            {
                ProceedSimulation(firstChoice);
            }
            else
            {
                do
                {
                    secondChoice = r.Next(1, 4);
                }
                while (secondChoice == firstChoice || secondChoice == hostChoice);
                ProceedSimulation(secondChoice);
            }
        }
        #endregion

        #region Event handlers
        private void pbDoor1_Click(object sender, EventArgs e)
        {
            ProceedSimulation(1);
        }
        private void pbDoor2_Click(object sender, EventArgs e)
        {
            ProceedSimulation(2);
        }
        private void pbDoor3_Click(object sender, EventArgs e)
        {
            ProceedSimulation(3);
        }
        private void btnRun_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(nAmount.Value);
            bool isKeeping = false;
            foreach (var element in gbAutoSim.Controls.OfType<RadioButton>())
            {
                if (element.Checked)
                {
                    isKeeping = (element.Name == "rbKeep") ? true : false;
                    break;
                }
            }
            for (int i = 0; i < amount; i++)
            {
                RunAutoSimulation(isKeeping);
            }
        }
        #endregion
    }
}
