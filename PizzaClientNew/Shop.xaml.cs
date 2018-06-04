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
        private int userid;
        private Order orderObject;
        private double moneyleft;
        private Customer userObject;
        

        public Shop(string username)
        {
            InitializeComponent();

            userid = pizzaproxy.GetUserId(username);
            orderObject = pizzaproxy.NewOrder(userid);
            userObject = pizzaproxy.GetCustomerById(userid);
            moneyleft = userObject.Money;
            MoneyLeftMessage.Content = "Money left: "+ moneyleft.ToString();

            foreach (Product p in pizzaproxy.ProductList())
            {
                ListBoxItem itm = new ListBoxItem();
                itm.Tag = p.Id;
                if(p.Amount > 0)
                {
                    itm.Content = p.Name + ": " + p.Price + " euro: " + p.Amount.ToString() + " beschikbaar";
                    ProductsBox.Items.Add(itm);
                } 
            }



            

        }

        private void BuyButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ((ListBoxItem)ProductsBox.SelectedItem).Tag.ToString();
            }
            catch
            {
                MessageBox.Show("No item was selected");
                return;
            }

            string productidS = ((ListBoxItem)ProductsBox.SelectedItem).Tag.ToString();

            int productid = Int32.Parse(productidS);
            int orderid = orderObject.Id;
            Product productObject = pizzaproxy.GetProductById(productid);

            OrderEntry oe = pizzaproxy.Buy(orderid, productid, userid);
            if (oe != null)
            {
               InventoryBox.Items.Clear();

                foreach (OrderEntry o in pizzaproxy.OrderEntryList(orderid))
                {
                    ListBoxItem oeitm = new ListBoxItem();
                    oeitm.Content = pizzaproxy.GetProductById(o.Product_Id).Name + ", " + o.Amount;
                    InventoryBox.Items.Add(oeitm);
                }
                
            }
            else
            {
                if (pizzaproxy.GetCustomerById(userid).Money < pizzaproxy.GetProductById(productid).Price)
                {
                    MessageBox.Show("Not enough money!");
                }
                else if (pizzaproxy.GetProductById(productid).Amount <= 0)
                {
                    MessageBox.Show("Product out of stock!");
                }
                else
                {
                    MessageBox.Show("An error has occured!");
                }
                
            }
            
            RefreshButton_Click(sender, e);

        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            moneyleft = pizzaproxy.GetCustomerById(userid).Money;
            MoneyLeftMessage.Content = "Money left: " + moneyleft.ToString();
            ProductsBox.Items.Clear();

            foreach (Product p in pizzaproxy.ProductList()) { 
                ListBoxItem itm = new ListBoxItem();
                itm.Tag = p.Id;
                if (p.Amount > 0)
                {
                    itm.Content = p.Name + ": " + p.Price + " euro: " + p.Amount.ToString() + " beschikbaar";
                    ProductsBox.Items.Add(itm);
                }
            }
        }
    }
}
