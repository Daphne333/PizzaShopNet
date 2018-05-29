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
    public partial class RegisterLogin : Form
    {
        PizzaServiceClient pizzaProxy = new PizzaServiceClient();

        public RegisterLogin()
        {
            InitializeComponent();
        }

        private void RegisterLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {// Errorafhandeling
            string username = UsernameRegister.Text;
            string password = pizzaProxy.Register(username);
            if(password.Equals("Username bestaat al!"))
            {
                RegisterPasswordMelding.Text = "Username bestaat al!";
            }
            else
            {
                RegisterPasswordMelding.Text = "Your new password: " + password;
            }
            
        }

        private void UsernameLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
