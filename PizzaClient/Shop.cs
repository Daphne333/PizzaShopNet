using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PizzaClient.PizzaReference;

namespace PizzaClient
{
    public partial class Shop : Form
    {

        PizzaServiceClient pizzaProxy = new PizzaServiceClient();

        public Shop()
        {
            InitializeComponent();

            //PizzaLijstProducts = pizzaProxy.ProductList();
        }

        private void Inventory_Click(object sender, EventArgs e)
        {

        }

        private void Refresh_Click(object sender, EventArgs e)
        {

        }

        private void PizzaLijstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
