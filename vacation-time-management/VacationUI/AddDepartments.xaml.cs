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
    /// Interaction logic for AddDepartments.xaml
    /// </summary>
    public partial class AddDepartments : Window
    {
        UIBridge bridge;
        List<string> departmentNames;
        public AddDepartments()
        {
            InitializeComponent();
            bridge = (UIBridge)Application.Current.Resources["bridge"];
            Show();
            RefreshDepartmentComboBox();
        }
        private void RefreshDepartmentComboBox()
        {
            departmentNames = new List<string>();
            List<Department> departments = Database.GetDepartments();
            foreach(Department dept in departments)
            {
               departmentNames.Add(dept.DepartmentName);
            }
        }

        private void AddDepartment_Click(object sender, RoutedEventArgs e)
        {
            Department newDepartment = bridge.Factory.CreateNewDepartment(DepartmentName.Text.Trim(), TotalPersonnelRequired.Text.Trim());
            if (newDepartment.DepartmentName != "invalid")
            {
                List<string> empInfo = bridge.GetObjectInfo(newDepartment);
                string message = "Employee Creation Success:\n" + string.Join(Environment.NewLine, empInfo);
                MessageBox.Show(message);
                RefreshDepartmentComboBox();
                RefreshThisForm();
            }
            else
            {
                MessageBox.Show("This department name is already taken, please enter another.");
            }
            
        }

        private void RefreshThisForm()
        {
           TotalPersonnelRequired.Clear();
           DepartmentName.Clear();
        }

        private void TotalDepartmentBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TotalDepartmentBox_DropDownOpened(object sender, EventArgs e)
        {
            TotalDepartmentBox.ItemsSource = departmentNames;
        }

        private void TotalDepartmentBox_Loaded(object sender, RoutedEventArgs e)
        {
            var comboBox = sender as ComboBox;
            RefreshDepartmentComboBox();
            comboBox.ItemsSource = departmentNames;
            comboBox.SelectedIndex = 0;

        }

        private void Done_Click(object sender, RoutedEventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu();
            Close();
        }

        private void TotalPersonnelRequired_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void DepartmentName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
