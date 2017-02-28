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
using System.Windows.Shapes;
using VacationLib;

namespace VacationUI
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        UIBridge bridge;
        public Login()
        {
            InitializeComponent();
            Application.Current.Resources["bridge"] = new UIBridge();
            bridge = (UIBridge)Application.Current.Resources["bridge"];
            if (CheckForAdmins()) Show();
            else Close();
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            bool loginCorrect  = bridge.Login(ID.Text.Trim(), passwordBox.Password.Trim());
            if (loginCorrect == true)
            {
                MessageBox.Show(string.Format("Welcome back {0}!", bridge.CurrentUser.Name));
                if (bridge.CurrentUser.isManager)
                {
                    AdminMenu adminMenu = new AdminMenu();
                    Close();
                }
                else
                {
                    EmployeeMenu EmployeeMenu = new EmployeeMenu();
                    Close();
                }
            }
            else
            {
                //label2.Content = "Wrong Id or Password, please try again";
                MessageBox.Show("Wrong Id or Password, please try again");
                RefreshThisForm();
            }
        }

        private void RefreshThisForm()
        {
            ID.Clear();
            passwordBox.Clear();
        }

         private bool CheckForAdmins()
        {
            bool adminsExist = bridge.AdminsExist();
            if (adminsExist != true)
            {
                CreateAdmin createAdmin = new CreateAdmin();
                return false;
            }
            else return true;
        }

        private void Password_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
