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
        private int countPage;
        private int currentPage = 0;
        private int countItemsInPage = 6;
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
            countPage = Products.Count / countItemsInPage + (Products.Count % countItemsInPage > 0? 1 : 0);
            currentPage = 0;

            ShowList(list.ToList());
        }
        private void ShowList(List<Product> products)
        {
            MyPanel.Children.Clear();

            products = products.Skip(countItemsInPage * currentPage).Take(countItemsInPage).ToList(); 

            foreach (var product in products)
                MyPanel.Children.Add(new ProductControl(product));

            int from = countItemsInPage * currentPage == 0? 1 : countItemsInPage * currentPage + 1;
            int to = countItemsInPage * (currentPage + 1) > Products.Count? Products.Count : countItemsInPage * (currentPage + 1);
            CountTb.Text = $"{from}-{to} из {Products.Count}";
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
                 SearchTextBlock.Visibility = Visibility.Collapsed;
            else SearchTextBlock.Visibility = Visibility.Visible;
            Refresh();
        }

        private void BackPage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (currentPage > 0)
            {
                currentPage--;
                ShowList(Products);
            }
        }

        private void NextPage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(currentPage < countPage - 1)
            {
                currentPage++;
                ShowList(Products);
            }
        }
    }
}
