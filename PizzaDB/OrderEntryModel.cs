using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDB
{
    public class OrderEntryModel
    {
        public OrderEntry Buy(int orderid, int productid, int custid)
        {
            using (PizzaShopDBEntities dbDriver = new PizzaShopDBEntities())
            {
                var orderentry = (from o in dbDriver.OrderEntrySet
                                  where o.OrderId == orderid && o.Product_Id == productid
                                select o).SingleOrDefault();
                var money = from customer in dbDriver.CustomerSet
                                  where customer.Id.Equals(custid)
                                  select customer.Money;

                if (orderentry == null) {
                    OrderEntry oe = new OrderEntry
                {
                    Amount = 1,
                    OrderId = orderid,
                    Product_Id = productid
                };
                    dbDriver.OrderEntrySet.Add(oe);
                    dbDriver.SaveChanges();
                    return oe;
                }
                else
                {
                    orderentry.Amount += 1;
                    dbDriver.SaveChanges();
                    return orderentry;
                }
            }
        }

    }
}
