﻿using PizzaClientNew.PizzaReference;
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
        private OrderEntry orderEntryObject;
        

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
            string productidS = ((ListBoxItem)ProductsBox.SelectedItem).Tag.ToString();
            int productid = Int32.Parse(productidS);
            int orderid = orderObject.Id;
            Product productObject = pizzaproxy.GetProductById(productid);
            if(userObject.Money > productObject.Price)
            {
                OrderEntry oe = pizzaproxy.Buy(orderid, productid, userid);
                ListBoxItem oeitm = new ListBoxItem();
                oeitm.Tag = productid;
                oeitm.Content = productObject.Name + ", " + oe.Amount;
                InventoryBox.Items.Add(oeitm);

                //Refresh

                MoneyLeftMessage.Content = "Money left: " + moneyleft.ToString();
                ProductsBox.Items.Clear();

                foreach (Product p in pizzaproxy.ProductList())
                {
                    ListBoxItem itm = new ListBoxItem();
                    itm.Tag = p.Id;
                    if (p.Amount > 0)
                    {
                        itm.Content = p.Name + ": " + p.Price + " euro: " + p.Amount.ToString() + " beschikbaar";
                        ProductsBox.Items.Add(itm);
                    }
                }
            }
            else
            {
                MessageBox.Show("Not enough money!");

                //Refresh

                MoneyLeftMessage.Content = "Money left: " + moneyleft.ToString();
                ProductsBox.Items.Clear();

                foreach (Product p in pizzaproxy.ProductList())
                {
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

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {

            MoneyLeftMessage.Content = "Money left: " + moneyleft.ToString();
            ProductsBox.Items.Clear();

            foreach (Product p in pizzaproxy.ProductList())
            {
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
