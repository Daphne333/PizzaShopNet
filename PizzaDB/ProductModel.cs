using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDB
{
    public class ProductModel
    {
        public List<Product> ProductList()
        {
            using (PizzaShopDBEntities dbDriver = new PizzaShopDBEntities())
            {
                List<Product> productList = new List<Product>();

                var products = 
                    from p in dbDriver.ProductSet
                    select p;

                foreach (Product p in products)
                    productList.Add(p);

                return productList;

            }
        }

        public Product GetProductById(int productid)
        {
           using (PizzaShopDBEntities dbDriver = new PizzaShopDBEntities())
                {
                    dbDriver.Configuration.ProxyCreationEnabled = false;
                    var product = (from p in dbDriver.ProductSet
                                where p.Id == productid
                                select p).SingleOrDefault();

                    return product;
                }
            
        }
    }
}
