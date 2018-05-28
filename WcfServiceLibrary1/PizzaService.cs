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
    public class PizzaService : IPizzaService
    {

        public static UserModel usermodel = new UserModel();
        
        public string Register(string username)
        {
            return usermodel.Register(username);
        }

        public Boolean Login(string username, string password)
        {
            return usermodel.Login(username, password);
        }
    }
}
