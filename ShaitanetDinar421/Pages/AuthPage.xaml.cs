using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ShaitanetDinar421.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
            App.CurrentUser = null;
        }

        private void AthBtn_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(LoginTb.Text) || string.IsNullOrWhiteSpace(PasswordPb.Password))
            {
                Logger.ShowWarning("Заполните все поля!");
                return;
            }

            var user = App.db.User.FirstOrDefault(x => x.Login == LoginTb.Text && x.Password == PasswordPb.Password);
            if(user != null)
            {
                App.CurrentUser = user;
                Navigation.NextPage(new ProductListPage());
                Logger.ShowWarning($"Добро пожаловать, {user.FullName}");
            }
            else Logger.ShowWarning("Неверный логин или пароль!");
        }

        private void RegLink_Click(object sender, RoutedEventArgs e)
        {
            Navigation.NextPage(new RegPage());
        }
    }
}
