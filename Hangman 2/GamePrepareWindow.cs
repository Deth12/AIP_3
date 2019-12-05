using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hangman2
{
    public partial class GamePrepareWindow : Form
    {
        int TimeLeft = 3;
        public GamePrepareWindow()
        {
            InitializeComponent();
            PrepareTimer.Text = $"{TimeLeft}";
            GameStartTimer.Start();
        }

        private void GameStartDelay_Tick(object sender, EventArgs e)
        {
            TimeLeft--;
            PrepareTimer.Text = $"{TimeLeft}";
            if(TimeLeft == 0)
            {
                this.Close();
            }
        }
    }
}
