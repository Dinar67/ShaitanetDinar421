﻿using ShaitanetDinar421.Pages;
using System.Windows;

namespace ShaitanetDinar421
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Navigation.Intialize(MainFrame);
            Navigation.NextPage(new AuthPage());
        }

        private void HideBtn_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;     
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            if(Logger.ShowYesNo("Вы точно хотите выйти из приложения?"))
                this.Close();
        }
    }
}
