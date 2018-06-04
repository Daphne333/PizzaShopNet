using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDB
{
    class Program
    {
        static void Main(string[] args)
        {
            using (PizzaShopDBEntities dbDriver = new PizzaShopDBEntities())
            {

                Product p1 = new Product
                {
                    Name = "Pizza Margherita",
                    Price = 7.50,
                    Amount = 100
                };
                Product p2 = new Product
                {
                    Name = "Pizza Marinara",
                    Price = 7.00,
                    Amount = 100
                };
                Product p3 = new Product
                {
                    Name = "Pizza Pepperoni",
                    Price = 8.00,
                    Amount = 100
                };
                Product p4 = new Product
                {
                    Name = "Pizza Hawaii",
                    Price = 8.00,
                    Amount = 10
                };
                dbDriver.ProductSet.Add(p1);
                dbDriver.ProductSet.Add(p2);
                dbDriver.ProductSet.Add(p3);
                dbDriver.ProductSet.Add(p4);
                dbDriver.SaveChanges();

                Customer c1 = new Customer
                {
                    Username = "Admin",
                    Password = "nimdA",
                    Money = 20
                };
                Customer c2 = new Customer
                {
                    Username = "Daphne",
                    Password = "enhpaD",
                    Money = 100
                };

                Customer c3 = new Customer
                {
                    Username = "a",
                    Password = "a",
                    Money = 100
                };

                dbDriver.CustomerSet.Add(c1);
                dbDriver.CustomerSet.Add(c2);
                dbDriver.CustomerSet.Add(c3);
                dbDriver.SaveChanges();



            }
        }
    }
}
