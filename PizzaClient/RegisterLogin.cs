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
        {//nog afhandeling maken als de login is geslaagd
            string username = UsernameLogin.Text;
            string password = PasswordLogin.Text;
            if (pizzaProxy.Login(username, password) == false)
            {
                ErrorLogin.Visible = true;
            }
            else
            {
                Shop shop = new Shop();
                this.Hide();
                shop.ShowDialog();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {// Errorafhandeling verbeteren in Usermodel
            string username = UsernameRegister.Text;
            string password = pizzaProxy.Register(username);
            if(password.Equals("Username already exists!"))
            {
                RegisterPasswordMelding.Text = "Username already exists!";
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
