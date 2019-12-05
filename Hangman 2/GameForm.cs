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
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
            
        }
        private void GameForm_Load(object sender, EventArgs e)
        { 
            StartGame();
        }
        private void StartGame()
        { 
            Game.NewGame();
            // Подготовка элементов UI 
            SecretWordTextBox.Text = Game.UpdateSecretWordState();
            TimerTextBox.Text = $"{Game.TimeLeft}";
            HpBox.Text = $"{Game.Lives}";
            DifficultyTextBox.Text = $"{Game.DifficultyName}";
            SetClickEventForEachLetter();
            // Запуск отсчета до начала игры
            GamePrepareWindow p = new GamePrepareWindow();
            p.ShowDialog();
            // Запуск таймеров
            RunTimers();
        }
        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            MainMenu menu = new MainMenu();
            menu.ShowDialog();
            this.Close();
        }

        Point lastPoint;
        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void G_CloseButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Game form closes...");
            this.Close();
        }
        private void G_MaximizeButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void G_MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Game.TimeLeft--;
            TimerTextBox.Text = $"{Game.TimeLeft}";
            if(Game.TimeLeft == 0)
            {
                StatusTextBox.ForeColor = Color.OrangeRed;
                StatusTextBox.Text = "Вы не успели выбрать букву!";
                Game.Lives--;
                UpdateHangmanState();
                ResetTimer();
            }
        }
        private void Letter_Click(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuFlatButton b = (Bunifu.Framework.UI.BunifuFlatButton)sender;
            if(Game.CheckForMatch(b.Text))
            {
                StatusTextBox.ForeColor = Color.SeaGreen;
                StatusTextBox.Text = $"> Буква: [{b.Text}] - Верно!";
                SecretWordTextBox.Text = Game.UpdateSecretWordState();
                if(Game.Win)
                {
                    GoodEnding();
                }
            }
            else
            {
                StatusTextBox.ForeColor = Color.Red;
                StatusTextBox.Text = $"> Буква: [{b.Text}] - Неверно!";
                Game.Lives--;
                UpdateHangmanState();
            }
            b.Enabled = false;
            ResetTimer();
        }

        // Добавление события при клике каждой кнопке в контейнере AlphabetContainer
        private void SetClickEventForEachLetter()
        {
            for(int i = 0; i < AlphabetContainer.Controls.Count; i++)
            {
                AlphabetContainer.Controls[i].Click += new EventHandler(Letter_Click);
            }
        }

        private void ResetTimer()
        {
            if (Game.Difficulty == 3)
            {
                Game.GenerateNewInitialTime();
            }
            Game.TimeLeft = Game.InitialTime;
        }
        private void StopTimers()
        {
            TotalTimeTimer.Start();
            Timer.Stop();
        }
        private void RunTimers()
        {
            TotalTimeTimer.Start();
            Timer.Start();
        }
        private void UpdateHangmanState()
        {
            HpBox.Text = $"{Game.Lives}";
            switch (Game.Lives)
            {
                case 9:
                    HangmanPictureBox.Image = hangman2.Properties.Resources.hangman_9;
                    break;
                case 8:
                    HangmanPictureBox.Image = hangman2.Properties.Resources.hangman_8;
                    break;
                case 7:
                    HangmanPictureBox.Image = hangman2.Properties.Resources.hangman_7;
                    break;
                case 6:
                    HangmanPictureBox.Image = hangman2.Properties.Resources.hangman_6;
                    break;
                case 5:
                    HangmanPictureBox.Image = hangman2.Properties.Resources.hangman_5;
                    break;
                case 4:
                    HangmanPictureBox.Image = hangman2.Properties.Resources.hangman_4;
                    break;
                case 3:
                    HangmanPictureBox.Image = hangman2.Properties.Resources.hangman_3;
                    break;
                case 2:
                    HangmanPictureBox.Image = hangman2.Properties.Resources.hangman_2;
                    break;
                case 1:
                    HangmanPictureBox.Image = hangman2.Properties.Resources.hangman_1;
                    break;
                case 0:
                    HangmanPictureBox.Image = hangman2.Properties.Resources.hangman_0;
                    BadEnding();
                    break;
            }
        }
        private void BadEnding()
        {
            if (!SQLiteAccess.UpdateStatistics(Game.Difficulty, false))
            {
                MessageBox.Show("Ошибка при обновлении статистики");
            }
            StopTimers();
            string text = $"Вы проиграли! \nОбщее время игры: {Game.TotalTime / 60}:{Game.TotalTime % 60}";
            if(MessageBox.Show(text, "Поражение", MessageBoxButtons.OK) == DialogResult.OK)
            {
                this.Close();
            }
        }
        private void GoodEnding()
        {
            if(!SQLiteAccess.UpdateStatistics(Game.Difficulty, true))
            {
                MessageBox.Show("Ошибка при обновлении статистики");
            }
            StopTimers();
            string text = $"Вы победили, человек спасен!\nОбщее время игры: {Game.TotalTime / 60}:{Game.TotalTime % 60}";
            if (MessageBox.Show(text, "Победа", MessageBoxButtons.OK) == DialogResult.OK)
            {
                this.Close();
            }
        }
        private void TotalTimeTimer_Tick(object sender, EventArgs e)
        {
            Game.TotalTime++;
        }
    }
}
