using ShaitanetDinar421.Databases;
using ShaitanetDinar421.Pages;
using System.Windows.Controls;

namespace ShaitanetDinar421.Components
{
    /// <summary>
    /// Логика взаимодействия для ProductControl.xaml
    /// </summary>
    public partial class ProductControl : UserControl
    {
        private Product Product { get; set; }
        public ProductControl(Product product)
        {
            InitializeComponent();
            Product = product;
            DataContext = Product;
        }

        private void EditBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Navigation.NextPage(new AddEditProductPage(Product));
        }

        private void DeleteBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                if (Logger.ShowYesNo("Вы точно хотите удалить продукт?"))
                {
                    App.db.Product.Remove(Product);
                    App.db.SaveChanges();
                    Navigation.NextPage(new ProductListPage());
                    Logger.ShowInformation("Успешно удалено!");
                }
            }
            catch
            {
                Logger.ShowWarning("Невозможно удалить! Есть заказы на этот продукт!");
            }
        }
    }
}
