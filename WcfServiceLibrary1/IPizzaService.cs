using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using PizzaDB;

namespace PizzaServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPizzaService" in both code and config file together.
    [ServiceContract]
    public interface IPizzaService
    {
        [OperationContract]
        String Register(string username);

        [OperationContract]
        Boolean Login(string username, string password);

        [OperationContract]
        List<Product> ProductList();

        [OperationContract]
        int GetUserId(string username);

        [OperationContract]
        Order NewOrder(int custid);

        [OperationContract]
        Customer GetCustomerById(int custid);

        [OperationContract]
        OrderEntry Buy(int orderid, int productid, int custid);

        [OperationContract]
        Product GetProductById(int productid);

        [OperationContract]
        List<OrderEntry> OrderEntryList(int orderId);
    }
}
