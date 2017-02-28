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
    /// Interaction logic for AdminMenu.xaml
    /// </summary>
    public partial class AdminMenu : Window
    {
        UIBridge bridge;
        public AdminMenu()
        {
            InitializeComponent();
            bridge = (UIBridge)Application.Current.Resources["bridge"];
            Show();
        }

        private void exitToLogin_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            Close();
        }

        private void addEmployees_Click(object sender, RoutedEventArgs e)
        {
            AddEmployees addEmployees = new AddEmployees();
            
            Close();
        }

        private void addDepartments_Click(object sender, RoutedEventArgs e)
        {
            if (bridge.CurrentUser.isAdmin)
            {
                AddDepartments addDepartments = new AddDepartments();
                Close();
            }
            else
            {
                MessageBox.Show("Special administrator priveleges required. See your supervisor to add a department.");
            }

        }

        private void approveVacations_Click(object sender, RoutedEventArgs e)
        {
            AdminForm approvalForm = new AdminForm();

            approvalForm.Show();
            Close();
        }

        private void vacationRequest_Click(object sender, RoutedEventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.Show();
            Close();
        }
    }
}
