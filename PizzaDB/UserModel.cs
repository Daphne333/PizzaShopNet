﻿using System;
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
