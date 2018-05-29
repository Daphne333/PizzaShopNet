using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDB
{
    public class UserModel
    {
        public string Register(string username)
        {
            using (PizzaShopDBEntities dbDriver = new PizzaShopDBEntities())
            {

                var customer = (from c in dbDriver.CustomerSet
                                where c.Username == username
                                select c).SingleOrDefault();

                if (customer == null)
                {

                    char[] charArray = username.ToCharArray();
                    Array.Reverse(charArray);
                    string password = new string(charArray);

                    Customer c1 = new Customer
                    {
                        Username = username,
                        Password = password
                    };

                    dbDriver.CustomerSet.Add(c1);
                    dbDriver.SaveChanges();
                    return password;
                }
                else
                {
                    return "Username already exists!";
                }
            }
        }

        public Boolean Login(string username, string password)
        {
            if (username == null || password == null)
            {
                return false;
            }

            using (PizzaShopDBEntities dbDriver = new PizzaShopDBEntities())
            {
                Customer c1 = dbDriver.CustomerSet.Single(c => c.Username == username);
                return c1.Password == password;

            }

        }
    }
}
