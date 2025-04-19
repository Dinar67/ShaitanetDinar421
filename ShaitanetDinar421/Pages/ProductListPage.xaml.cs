using ShaitanetDinar421.Components;
using ShaitanetDinar421.Databases;
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
    /// Логика взаимодействия для ProductListPage.xaml
    /// </summary>
    public partial class ProductListPage : Page
    {
        public List<Product> Products { get; private set; }

        public ProductListPage()
        {
            InitializeComponent();
            Refresh();
        }
        
        private async void Refresh()
        {
            IEnumerable<Product> list = App.db.Product;

            if (!string.IsNullOrWhiteSpace(SearchTb.Text))
                list = list.Where(x => x.Name.ToLower().Contains(SearchTb.Text.ToLower()));

            Products = list.ToList();

            ShowList(Products);
        }
        private void ShowList(List<Product> products)
        {
            MyPanel.Children.Clear();
            foreach (var product in products)
                MyPanel.Children.Add(new ProductControl(product));
        }

        private void ProductBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void UserBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SearchTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(SearchTb.Text))
            {
                SearchTextBlock.Visibility = Visibility.Collapsed;
                Refresh();
            }
            else SearchTextBlock.Visibility = Visibility.Visible;

        }

        private void BackPage_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void NextPage_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
