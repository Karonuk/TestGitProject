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
using TestShop.DAL;

namespace TestShop.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ProductContext context;
        public List <ProductVM> Products { get; set; }        
        public MainWindow()
        {
            context = new ProductContext();
            InitializeComponent();          
            var prods = context.Products.ToList();
            Products=prods.Select(x => new ProductVM
            {
                Name = x.Name,
                Category = x.Category,
                ID = x.ID,
                Price = x.Price
            }).ToList();
            ProductList.ItemsSource = Products;
        }
    }
}
