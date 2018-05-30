using PizzaClientNew.PizzaReference;
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
using System.Windows.Shapes;

namespace PizzaClientNew
{
    /// <summary>
    /// Interaction logic for Shop.xaml
    /// </summary>
    public partial class Shop : Window
    {
        PizzaServiceClient pizzaproxy = new PizzaServiceClient();
        public Shop()
        {
            InitializeComponent();

            
            foreach (Product p in pizzaproxy.ProductList())
            {
                ListBoxItem itm = new ListBoxItem();
                itm.Tag = p.Id;
                itm.Content = p.Name + ": " + p.Price + ": " + p.Amount.ToString() + " beschikbaar";
                ProductsBox.Items.Add(itm);
            }
            

        }

        private void BuyButton_Click(object sender, RoutedEventArgs e)
        {
            string selTag = ((TextBox)ProductsBox.SelectedItem).Tag.ToString();
            MessageBox.Show(selTag);
        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            ProductsBox.Items.Clear();

            foreach (Product p in pizzaproxy.ProductList())
            {
                ListBoxItem itm = new ListBoxItem();
                itm.Tag = p.Id;
                itm.Content = p.Name + ": " + p.Price + ": " + p.Amount.ToString() + " beschikbaar";
                ProductsBox.Items.Add(itm);
            }
        }
    }
}
