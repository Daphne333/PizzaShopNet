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
                dbDriver.Configuration.ProxyCreationEnabled = false;

                OrderEntry orderentry = (from o in dbDriver.OrderEntrySet
                                  where o.OrderId == orderid && o.Product_Id == productid
                                select o).SingleOrDefault();
                Customer cust = (from c in dbDriver.CustomerSet
                                 where c.Id == custid
                                 select c).SingleOrDefault();
                Product product = (from p in dbDriver.ProductSet
                                   where p.Id == productid
                                   select p).SingleOrDefault();

                if (cust.Money >= product.Price && product.Amount > 0)
                {


                    if (orderentry == null)
                    {
                        OrderEntry oe = new OrderEntry
                        {
                            Amount = 1,
                            OrderId = orderid,
                            Product_Id = productid
                        };
                        dbDriver.OrderEntrySet.Add(oe);
                        cust.Money = cust.Money - product.Price;
                        product.Amount -= 1;
                        dbDriver.SaveChanges();
                        return oe;
                    }
                    else
                    {
                        orderentry.Amount += 1;
                        cust.Money = cust.Money - product.Price;
                        product.Amount -= 1;
                        dbDriver.SaveChanges();
                        return orderentry;
                    }
                }
                else
                {
                    return null;
                }
            }
        }

        public List<OrderEntry> OrderEntryList(int orderId)
        {
            using (PizzaShopDBEntities dbDriver = new PizzaShopDBEntities())
            {
                dbDriver.Configuration.ProxyCreationEnabled = false;
                List<OrderEntry> orderEntryList = new List<OrderEntry>();

                var orderEntries =
                    from oe in dbDriver.OrderEntrySet
                    where oe.OrderId == orderId
                    select oe;

                foreach (OrderEntry oe in orderEntries)
                    orderEntryList.Add(oe);

                return orderEntryList;

            }
        }
    }
}
