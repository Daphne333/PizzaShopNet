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
                        Password = password,
                        Money = 10
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
            if (username == "" || password == "")
            {
                return false;
            }

            using (PizzaShopDBEntities dbDriver = new PizzaShopDBEntities())
            {
                Customer c1 = dbDriver.CustomerSet.Single(c => c.Username == username);
                return c1.Password == password;

            }

        }

        public int GetUserId(string username)
        {
            using (PizzaShopDBEntities dbDriver = new PizzaShopDBEntities())
            {
                var user = (from u in dbDriver.CustomerSet
                              where u.Username == username
                              select u).SingleOrDefault();

                return user.Id;
            }
        }

        public Customer GetCustomerById(int userid)
        {
            using (PizzaShopDBEntities dbDriver = new PizzaShopDBEntities())
            {
                var user = (from u in dbDriver.CustomerSet
                            where u.Id == userid
                            select u).SingleOrDefault();

                return user;
            }
        }
    }
}
