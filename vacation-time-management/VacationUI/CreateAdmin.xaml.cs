using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;
using VacationLib;
using System.IO;

namespace VacationUI
{
    /// <summary>
    /// Interaction logic for CreateAdmin.xaml
    /// </summary>
    public partial class CreateAdmin : Window
    {
        UIBridge bridge;
        public CreateAdmin()
        {
            InitializeComponent();
            bridge = (UIBridge)Application.Current.Resources["bridge"];
            Show();
        }
      

        //private void Password_TextChanged(object sender, TextChangedEventArgs e)
        //{

        //}

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            Personnel admin = bridge.Factory.CreateNewAdmin(UserName.Text.Trim(), passwordBox.Password.Trim());
            if (admin.Email != "invalid")
            {
                List<string> empInfo = bridge.GetObjectInfo(admin);
                empInfo.RemoveAt(empInfo.Count-1);
                string message = "You have created the master admin account:\n" + string.Join(Environment.NewLine, empInfo);
                MessageBox.Show(message);

                bridge.Login(admin.Email, passwordBox.Password);
                AdminMenu adminMenu = new AdminMenu();
                Close();
            }
            else
            {
                MessageBox.Show("Email is invalid format, please enter a new email.");
            }
        }
    }
}
