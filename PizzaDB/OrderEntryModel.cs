using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDB
{
    class OrderEntryModel
    {
        public OrderEntry Buy(int orderid, int productid)
        {
            using (PizzaShopDBEntities dbDriver = new PizzaShopDBEntities())
            {
                var orderentry = (from o in dbDriver.OrderEntrySet
                                  where o.OrderId == orderid && o.Product_Id == productid
                                select o).SingleOrDefault();

                if(orderentry == null) {
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
                    dbDriver.OrderEntrySet.Add(orderentry);
                    dbDriver.SaveChanges();
                    return orderentry;
                }
            }
        }

    }
}
