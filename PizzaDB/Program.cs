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
                //Product p1 = new Product
                //{
                //    Name = "Pizza Margherita",
                //    Price = 7.50
                //};
                //Product p2 = new Product
                //{
                //    Name = "Pizza Marinara",
                //    Price = 7.00
                //};
                //Product p3 = new Product
                //{
                //    Name = "Pizza Pepperoni",
                //    Price = 8.00
                //};
                //dbDriver.ProductSet.Add(p1);
                //dbDriver.ProductSet.Add(p2);
                //dbDriver.ProductSet.Add(p3);
                //dbDriver.SaveChanges();
            }
        }
    }
}
