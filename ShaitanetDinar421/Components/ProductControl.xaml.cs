using ShaitanetDinar421.Databases;
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

        }

        private void DeleteBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {

        }
    }
}
