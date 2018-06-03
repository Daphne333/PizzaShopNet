using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PizzaClientNew.PizzaReference;

namespace PizzaClientNew
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PizzaServiceClient pizzaProxy = new PizzaServiceClient();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordBox.Password;
            if (pizzaProxy.Login(username, password) == false)
            {
                LoginErrorMessage.Visibility = Visibility.Visible;
            }
            else
            {
                Shop shop = new Shop(username);
                this.Hide();
                shop.ShowDialog();
            }
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBoxRegister.Text;
            string password = pizzaProxy.Register(username);
            if (password.Equals("Username already exists!"))
            {
                ErrorMessageRegister.Content = "Username already exists!";
            }
            else
            {
                ErrorMessageRegister.Content = "Your new password: " + password;
            }
        }
    }
}
