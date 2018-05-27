using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PizzaService" in both code and config file together.
    public class PizzaService : IPizzaService
    {
        public string Register(string username)
        {
            char[] charArray = username.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public void Login(string username, string password)
        {

        }
    }
}
