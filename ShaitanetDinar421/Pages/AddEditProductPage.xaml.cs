using Microsoft.Win32;
using ShaitanetDinar421.Databases;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для AddEditProductPage.xaml
    /// </summary>
    public partial class AddEditProductPage : Page
    {
        public Product Product { get; private set; }
        public AddEditProductPage(Product product)
        {
            InitializeComponent();
            Product = product;
            DataContext = product;
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Navigation.BackPage();
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(NameTb.Text) || string.IsNullOrWhiteSpace(PriceTb.Text))
                {
                    Logger.ShowWarning("Заполните наименование и цену!");
                    return;
                }
                if (Product.Id == 0)
                    App.db.Product.Add(Product);
                App.db.SaveChanges();
                Navigation.NextPage(new ProductListPage());
                Logger.ShowInformation("Изменения успешно сохранены!");
            }
            catch
            {
                Logger.ShowWarning("Заполните поля правильно!");
            }
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var opn = new OpenFileDialog();
                opn.Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg|All files (*.*)|*.*";
                if (opn.ShowDialog() == true)
                {
                    Product.ImageBytes = File.ReadAllBytes(opn.FileName);
                    MainImage.Source = Methods.GetImageFromBytes(Product.ImageBytes);
                }
            }
            catch
            {
                Logger.ShowWarning("Вы выбрали не тот файл!");
            }
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            Product.ImageBytes = null;
            MainImage.Source = null;
        }
    }
}
