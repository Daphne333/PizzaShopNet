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
                OrderEntry orderentry = (from o in dbDriver.OrderEntrySet
                                  where o.OrderId == orderid && o.Product_Id == productid
                                select o).SingleOrDefault();
                var money = from c in dbDriver.CustomerSet
                                  where c.Id.Equals(custid)
                                  select c.Money;
                Customer cust = (from c in dbDriver.CustomerSet
                                 where c.Id == custid
                                 select c).SingleOrDefault();
                Product product = (from p in dbDriver.ProductSet
                                   where p.Id == productid
                                   select p).SingleOrDefault();

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
