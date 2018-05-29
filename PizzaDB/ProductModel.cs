using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDB
{
    class ProductModel
    {
        //public List[Product] ProductList()
        //{
        //    using (PizzaShopDBEntities dbDriver = new PizzaShopDBEntities())
        //    {

        //        var products =
        //        from Product in dbDriver.ProductSet
        //        select new
        //        {
        //            Name = Product.Name,
        //            Total = (from oe in Product.OrderEntry
        //                     select oe.Product.Price * oe.Amount).Sum()
        //        };

        //        foreach (var product in products)
        //            return product;
        //    }
        //}
    }
}
