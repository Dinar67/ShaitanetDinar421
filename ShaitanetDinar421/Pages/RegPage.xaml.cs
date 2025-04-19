using Microsoft.Win32;
using ShaitanetDinar421.Databases;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace ShaitanetDinar421.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegPage.xaml
    /// </summary>
    public partial class RegPage : Page
    {
        string oldLogin;
        public User User { get; private set; }
        public RegPage(User user)
        {
            InitializeComponent();
            User = user;
            if (User.Id != 0)
            {
                oldLogin = User.Login;
                MainTb.Text = "Мой профиль";
                if(User.ImageBytes != null)
                    MainImage.Source = Methods.GetImageFromBytes(User.ImageBytes);
                PasswordPb.Password = User.Password;
            }
            DataContext = User;
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Navigation.BackPage();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var opn = new OpenFileDialog();
                opn.Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg|All files (*.*)|*.*";
                if (opn.ShowDialog() == true)
                {
                    User.ImageBytes = File.ReadAllBytes(opn.FileName);
                    MainImage.Source = Methods.GetImageFromBytes(User.ImageBytes);
                }
            }
            catch
            {
                Logger.ShowWarning("Вы выбрали не тот файл!");
            }
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if((User.Id == 0 || oldLogin != LoginTb.Text) && App.db.User.Any(x => x.Login == LoginTb.Text))
                {
                    Logger.ShowWarning("Такой логин уже есть!");
                    return;
                }
                if (PasswordPb.Password.Length < 5)
                {
                    Logger.ShowWarning("Пароль должен содержать не менее 5 символов!");
                    return;
                }
                User.Password = PasswordPb.Password;
                if (User.Id == 0)
                    App.db.User.Add(User);
                App.db.SaveChanges();
                Navigation.BackPage();
                Logger.ShowInformation("Изменения успешно сохранены!");
            }
            catch
            {
                Logger.ShowWarning("Обязательно заполните поля логина и пароля!");
            }
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            User.ImageBytes = null;
            MainImage.Source = null;
        }
    }
}
