using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDB
{
    public class OrderModel
    {
        public Order NewOrder(int custid)
        {
            using (PizzaShopDBEntities dbDriver = new PizzaShopDBEntities())
            {
                Order o1 = new Order
                {
                    OrderDate = DateTime.Now,
                    CustomerId = custid
                };
                dbDriver.OrderSet.Add(o1);
                dbDriver.SaveChanges();
                return o1;
            }
        }
    }
}

