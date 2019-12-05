using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Configuration;

namespace hangman2
{
    public static class SQLiteAccess
    {
        public static SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString());
        public static SQLiteDataAdapter da = new SQLiteDataAdapter();

        public static DataSet ds = new DataSet();

        public static DataSet tempDataSet = new DataSet();
        public static DataTable tempDataTable = new DataTable();

        private static string LoadConnectionString()
        {
            return @"DataSource=.\Dictionary.db;"; 
        }
        public static void LoadDataTable()
        {
            ds.Clear();
            SQLiteCommand cmd = new SQLiteCommand(cnn);
            cmd.CommandText = "SELECT Word as 'Слово', " +
                              "CASE Difficulty "         +
                              "WHEN 0 THEN 'Легко' "     +
                              "WHEN 1 THEN 'Средне' "    +
                              "WHEN 2 THEN 'Тяжело' "    +
                              "END AS 'Сложность' "      +
                              "FROM Words; "             +
                              "SELECT CASE Difficulty "  +
                              "WHEN 0 THEN 'Легко' "     +
                              "WHEN 1 THEN 'Средне' "    +
                              "WHEN 2 THEN 'Тяжело' "    +
                              "WHEN 3 THEN 'Random' "    +
                              "END AS 'Сложность', "     +
                              "Played as 'Всего', Win as 'Побед', Lose as 'Поражений'" +
                              "FROM Stats";
            da = new SQLiteDataAdapter(cmd);
            da.Fill(ds);
        }
        public static bool Insert(ref Word w)
        {
            SQLiteCommand cmd = new SQLiteCommand(cnn);
            cmd.CommandText = $"INSERT INTO Words (Word, Difficulty) VALUES ('{w.word}',{w.difficulty})";
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch(SQLiteException)
            {
                return false;
            }
        }
        public static bool Delete(string word)
        {
            SQLiteCommand cmd = new SQLiteCommand(cnn);
            cmd.CommandText = $"DELETE FROM Words WHERE Word = '{word}'";
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch(SQLiteException)
            {
                return false;
            }
        }

        public static bool GetTableOfWords(int difficulty)
        {
            SQLiteCommand cmd = new SQLiteCommand(cnn);
            if (difficulty < 3)
            {
                cmd.CommandText = $"SELECT COUNT() FROM Words WHERE Difficulty = {difficulty}";
                int resultRowsCount = Int32.Parse(cmd.ExecuteScalar().ToString());
                if (resultRowsCount > 0)
                {
                    tempDataTable.Clear();
                    tempDataSet.Clear();
                    cmd.CommandText = $"SELECT Word FROM Words WHERE Difficulty = {difficulty}";
                    da = new SQLiteDataAdapter(cmd);
                    da.Fill(tempDataSet);
                    tempDataTable = tempDataSet.Tables[0];
                    return true;
                }
                else return false;
            }
            else
            {
                cmd.CommandText = $"SELECT COUNT() FROM Words";
                int resultRowsCount = Int32.Parse(cmd.ExecuteScalar().ToString());
                if (resultRowsCount > 0)
                {
                    tempDataTable.Clear();
                    tempDataSet.Clear();
                    cmd.CommandText = $"SELECT Word FROM Words";
                    da = new SQLiteDataAdapter(cmd);
                    da.Fill(tempDataSet);
                    tempDataTable = tempDataSet.Tables[0];
                    return true;
                }
                else return false;
            }
        }

        public static bool ResetStatistics()
        {
            SQLiteCommand cmd = new SQLiteCommand(cnn);
            cmd.CommandText = $"UPDATE Stats SET Played=0,Win=0,Lose=0";
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SQLiteException)
            {
                return false;
            }
        }

        public static bool UpdateStatistics(int difficulty, bool result)
        {
            SQLiteCommand cmd = new SQLiteCommand(cnn);
            if (result)
            {
                cmd.CommandText = $"UPDATE Stats SET Played=Played+1,Win=Win+1 WHERE Difficulty={difficulty}";
            }
            else
            {
                cmd.CommandText = $"UPDATE Stats SET Played=Played+1,Lose=Lose+1 WHERE Difficulty={difficulty}";
            }
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SQLiteException)
            {
                return false;
            }
        }
    }
}
