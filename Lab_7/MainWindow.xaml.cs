using System;
using System.Windows;
using System.Windows.Data;
using System.IO;
using Microsoft.Win32;

namespace Lab_7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnMagic_Click(object sender, RoutedEventArgs e)
        {
            tbField2.Text = tbField1.Text;
        }

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (of.ShowDialog() == true)
            {
                tbField1.Text = File.ReadAllText(of.FileName);
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (tbField2.Text != "")
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (sf.ShowDialog() == true)
                {
                    File.WriteAllText(sf.FileName, tbField2.Text);
                }
            }
            else
            {
                MessageBox.Show("[Field 2] is empty. Enter some text");
            }
        }
    }
}
