using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using PizzaServiceLibrary;

namespace PizzaHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(PizzaService)))
            {
                host.OpenTimeout = new TimeSpan(0, 10, 0);
                host.CloseTimeout = new TimeSpan(0, 10, 0);
                
                host.Open();
                Console.WriteLine("Service ready");

                Console.ReadKey();
            }
        }
    }
}
