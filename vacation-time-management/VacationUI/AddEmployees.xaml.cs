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
    /// Interaction logic for AddEmployees.xaml
    /// </summary>
    public partial class AddEmployees : Window
    {
        UIBridge bridge;
        List<string> departmentNames;
        List<string> personnelNames;
        public AddEmployees()
        {
            InitializeComponent();
            bridge = (UIBridge)Application.Current.Resources["bridge"];
            Show();
            RefreshDepartmentComboBox();
            RefreshAllPersonnelComboBox();
        }

        private void Done_Click(object sender, RoutedEventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu();
            Close();
        }

        private void RefreshDepartmentComboBox()
        {
            departmentNames = new List<string>();
            List<Department> departments = Database.GetDepartments();
            if (bridge.CurrentUser.isAdmin)
            {
                foreach(Department dept in departments)
                {
                   departmentNames.Add(dept.DepartmentName);
                }
            }
            else departmentNames.Add(bridge.CurrentUser.Department);
        }

        private void RefreshAllPersonnelComboBox()
        {
            personnelNames = new List<string>();
            List<Personnel> personnel = Database.GetPersonnel();
            foreach (Personnel person in personnel)
            {
                if (bridge.CurrentUser.isAdmin) personnelNames.Add(person.Name);
                else if (bridge.CurrentUser.Department == person.Department) personnelNames.Add(person.Name);
            }
        }

        private void DepartmentBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void DepartmentBox_Loaded(object sender, RoutedEventArgs e)
        {
            var comboBox = sender as ComboBox;
            RefreshDepartmentComboBox();
            comboBox.ItemsSource = departmentNames;
            comboBox.SelectedIndex = 0;
        }

        private void AllPersonnelBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AllPersonnelBox_Loaded(object sender, RoutedEventArgs e)
        {
            var comboBox = sender as ComboBox;
            RefreshAllPersonnelComboBox();
            comboBox.ItemsSource = personnelNames;
            comboBox.SelectedIndex = 0;
        }

        private void AllPersonnelBox_DropDownOpened(object sender, EventArgs e)
        {
            AllPersonnelBox.ItemsSource = personnelNames;
        }

        private void AddEmployee_Click(object sender, RoutedEventArgs e)
        {
            int vacationDays = -1;
            try { vacationDays = int.Parse(VacationDaysBox.Text.Trim()); }
            catch { MessageBox.Show("Please enter a number for vacation days."); }
            if (vacationDays > -1)
            { 
                Personnel newEmployee = bridge.Factory.CreateNewEmployee(UserName.Text.Trim(), Password.Text.Trim(), Email.Text.Trim(), DepartmentBox.Text.Trim(), vacationDays, (bool)Manager.IsChecked);
                if (newEmployee.Email != "invalid")
                {
                    List<string> empInfo = bridge.GetObjectInfo(newEmployee);
                    string message = "Employee Creation Success:\n" + string.Join(Environment.NewLine, empInfo);
                    MessageBox.Show(message);
                    RefreshThisForm();
                    RefreshAllPersonnelComboBox();
                }
                else
                {
                    MessageBox.Show("Email is invalid format or taken, please enter a new email.");
                }
            }
        }

        private void RefreshThisForm()
        {
            UserName.Clear(); Password.Clear(); Email.Clear(); Manager.IsChecked = false; VacationDaysBox.Clear();
        }

        private void Manager_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void VacationDaysBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Email_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
