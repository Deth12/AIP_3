using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hangman2
{

    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SQLiteAccess.cnn.Open();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);       
            Application.Run(new MainMenu());
        }
    }
}
