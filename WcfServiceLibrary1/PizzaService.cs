using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using PizzaDB;

namespace PizzaServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PizzaService" in both code and config file together.

    [ServiceBehavior(  InstanceContextMode = InstanceContextMode.Single,
  ConcurrencyMode = ConcurrencyMode.Reentrant)]

    public class PizzaService : IPizzaService
    {

        public static UserModel usermodel = new UserModel();
        public static ProductModel productmodel = new ProductModel();
        public static OrderModel ordermodel = new PizzaDB.OrderModel();
        
        public string Register(string username)
        {
            return usermodel.Register(username);
        }

        public Boolean Login(string username, string password)
        {
            return usermodel.Login(username, password);
        }

        public List<Product> ProductList()
        {
            return productmodel.ProductList();
        }

        public int GetUserId(string username)
        {
            return usermodel.GetUserId(username);
        }

        public Order NewOrder(int custid)
        {
            return ordermodel.NewOrder(custid);
        }

        public Customer GetCustomerById(int custid)
        {
            return usermodel.GetCustomerById(custid);
        }

    }
}
