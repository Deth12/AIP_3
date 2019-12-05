using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Data;

namespace hangman2
{
    public static class Game
    { 
        public static byte Difficulty = 1;
        public static string DifficultyName;

        public static string CurrentWord;
        public static List<string> TrueLetters = new List<string>();
        public static int Lives = 10;

        public static int InitialTime = 0;
        public static int TimeLeft = 10;
        public static int TotalTime = 0;

        public static bool Win = false;

        public static void NewGame()
        {
            TrueLetters.Clear();
            Lives = 10;
            Win = false;
            ChooseRandomWordAndSetTimer();
            TotalTime = 0;
            TimeLeft = InitialTime;
        }
        public static void ChooseRandomWordAndSetTimer()
        {
            Random r = new Random();
            CurrentWord = SQLiteAccess.tempDataTable.Rows[r.Next(0, SQLiteAccess.tempDataTable.Rows.Count)].Field<string>("Word").ToUpper();
            switch (Difficulty)
            {
                case 0:
                    InitialTime = 16;
                    break;
                case 1:
                    InitialTime = 13;
                    break;
                case 2:
                    InitialTime = 11;
                    break;
                case 3:
                    GenerateNewInitialTime();
                    return;
            }           
        }
        public static void GenerateNewInitialTime()
        {
            Random r = new Random();
            InitialTime = r.Next(2, 11);
        }
        public static bool CheckForMatch(string letter)
        {
            if (CurrentWord.Contains(letter))
            {
                TrueLetters.Add(letter);
                return true;
            }
            else
            {
                return false;
            }
        }
        // Обновляет статус слова, которое отгадывает игрок
        public static string UpdateSecretWordState()
        {
            string result = "";
            foreach(var letter in CurrentWord)
            {
                if(TrueLetters.Contains($"{letter}"))
                {
                    result += $" {letter} ";
                }
                else
                {
                    result += " _ ";
                }
            }
            if(!result.Contains(" _ "))
            {
                Win = true;
            }
            return result;
        }

    }
}
