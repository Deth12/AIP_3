using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hangman2
{
    public class Word
    {
        public string word;
        public int difficulty;
        public Word(string word)
        {
            this.word = word;
            this.difficulty = GetWordDifficulty(word);
        }
        private int GetWordDifficulty(string word)
        {
            if (word.Length <= 5)
            {
                return 0;
            }
            else if (word.Length >= 6 && word.Length <= 9)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
        public string GetDifficultyName()
        {
            switch(difficulty)
            {
                case 0:
                    return "Легко";
                case 1:
                    return "Средне";
                case 2:
                    return "Тяжело";
                default:
                    return null;
            }
        }
        public static string GetDifficultyDescription(int difficulty)
        {
            switch (difficulty)
            {
                case 0:
                    return "до 5 букв";
                case 1:
                    return "от 6 до 9 букв";
                case 2:
                    return "10 и более букв";
                default:
                    return null;
            }
        }
    }
}
