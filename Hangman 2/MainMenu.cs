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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        private void SetSettings()
        {
            switch (Game.Difficulty)
            {
                case 0:
                    S_EasyRadioButton.Checked = true;
                    S_MediumRadioButton.Checked = false;
                    S_HardRadioButton.Checked = false;
                    S_RandomRadioButton.Checked = false;
                    Game.DifficultyName = "Легко";
                    break;
                case 1:
                    S_EasyRadioButton.Checked = false;
                    S_MediumRadioButton.Checked = true;
                    S_HardRadioButton.Checked = false;
                    S_RandomRadioButton.Checked = false;
                    Game.DifficultyName = "Средне";
                    break;
                case 2:
                    S_EasyRadioButton.Checked = false;
                    S_MediumRadioButton.Checked = false;
                    S_HardRadioButton.Checked = true;
                    S_RandomRadioButton.Checked = false;
                    Game.DifficultyName = "Тяжело";
                    break;
                case 3:
                    S_EasyRadioButton.Checked = false;
                    S_MediumRadioButton.Checked = false;
                    S_HardRadioButton.Checked = false;
                    S_RandomRadioButton.Checked = true;
                    Game.DifficultyName = "Random";
                    break;
            }
        }
        private void MainMenu_Load(object sender, EventArgs e)
        {
            SetSettings();
            UpdateDataGrid();
        }

        #region Перемещение окна
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
        #endregion

        #region Главное меню
        private void MM_CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MM_MaximizeButton_Click(object sender, EventArgs e)
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

        private void MM_MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MM_NewGameButton_Click(object sender, EventArgs e)
        {
            if (SQLiteAccess.GetTableOfWords(Game.Difficulty))
            {
                this.Hide();
                GameForm gameForm = new GameForm();
                gameForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show($"Недостаточно слов для выбранной сложности [{Game.DifficultyName}]");
            }
        }

        private void MM_ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MM_SettingsButton_Click(object sender, EventArgs e)
        {
            MM_Pages.SelectTab(1);
        }
        #endregion

        #region Настройки
        private void S_EasyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Game.Difficulty = 0;
            Game.DifficultyName = "Легко";
        }
        private void S_MediumRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Game.Difficulty = 1;
            Game.DifficultyName = "Средне";
        }
        private void S_HardRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Game.Difficulty = 2;
            Game.DifficultyName = "Тяжело";
        }
        private void S_RandomRadioButton_Click(object sender, EventArgs e)
        {
            Game.Difficulty = 3;
            Game.DifficultyName = "Random";
        }

        private void S_OpenDictionaryButton_Click(object sender, EventArgs e)
        {
            MM_Pages.SelectTab(2);
        }
        private void S_BackButton_Click(object sender, EventArgs e)
        {
            MM_Pages.SelectTab(0);
        }
        #endregion

        #region Словарь
        private void UpdateDataGrid()
        {
            SQLiteAccess.LoadDataTable();
            ListOfWords.DataSource = SQLiteAccess.ds.Tables[0];
            ListOfWords.ClearSelection();
            Statistics.DataSource = SQLiteAccess.ds.Tables[1];
            Statistics.ClearSelection();
        }

        private void D_BackButton_Click(object sender, EventArgs e)
        {
            MM_Pages.SelectTab(1);
        }

        private void D_AddWordButton_Click(object sender, EventArgs e)
        {
            if(D_WordTextBox.Text.Length == 0)
            {
                StatusTextBox.ForeColor = Color.Gray;
                StatusTextBox.Text = $"Пустой ввод!";
                return;
            }
            Word tempWord = new Word(D_WordTextBox.Text);
            if(SQLiteAccess.Insert(ref tempWord))
            {
                // Результат операции в статус-боксе
                StatusTextBox.ForeColor = Color.SeaGreen;
                StatusTextBox.Text = $"[{tempWord.word}] [Букв: {tempWord.word.Length}]\n> Добавлено в словарь." +
                                      $"\nСложность: {tempWord.GetDifficultyName()} ({Word.GetDifficultyDescription(tempWord.difficulty)})";
                UpdateDataGrid();
            }
            else
            {
                StatusTextBox.ForeColor = Color.Red;
                StatusTextBox.Text = "Введенное слово уже есть в словаре.";
                return;
            }
            // Очистка текстбокса ввода
            D_WordTextBox.Text = "";
        }

        private void D_DeleteWordButton_Click(object sender, EventArgs e)
        {
            // Удаление слова из списка в форме
            if (ListOfWords.SelectedRows.Count > 0)
            {
                string word = ListOfWords.SelectedRows[0].Cells[0].Value.ToString();
                ListOfWords.Rows.Remove(ListOfWords.SelectedRows[0]);
                if(SQLiteAccess.Delete(word))
                {
                    StatusTextBox.ForeColor = Color.Red;
                    StatusTextBox.Text = $"[{word}]\n> Удалено из словаря.";
                }
                else
                {
                    StatusTextBox.ForeColor = Color.Red;
                    StatusTextBox.Text = $"[{word}]\n> Ошибка удаления.";
                }
                UpdateDataGrid();
            }
            else
            {
                // Результат операции в статус-боксе
                StatusTextBox.ForeColor = Color.Gray;
                StatusTextBox.Text = $"Не выбрано ни одно слово.";
            }
        }

        private void D_WordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((c < 'А' || c > 'я') && c != '\b' && c!= 13) // 13 - клавиша Enter
            {
                StatusTextBox.ForeColor = Color.Red;
                StatusTextBox.Text = "Слово должно состоять из букв русского алфавита.";
                e.Handled = true;
            }
            else if(c == 13)
            {
                D_AddWordButton_Click(sender, e);
            }
            else
                StatusTextBox.Text = "";
        }

        private void ListOfWords_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            D_DeleteWordButton_Click(sender, e);
        }
        #endregion

        #region Статистика
        private void MM_StatisticsButton_Click(object sender, EventArgs e)
        {
            MM_Pages.SelectTab(3);
        }

        private void ST_BackButton_Click(object sender, EventArgs e)
        {
            MM_Pages.SelectTab(0);
        }
        #endregion

        private void ST_ResetButton_Click(object sender, EventArgs e)
        {
            if(SQLiteAccess.ResetStatistics())
            {
                UpdateDataGrid();
            }
        }
    }
}
