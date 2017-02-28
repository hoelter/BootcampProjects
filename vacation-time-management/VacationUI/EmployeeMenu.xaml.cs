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
    /// Interaction logic for EmployeeMenu.xaml
    /// </summary>
    public partial class EmployeeMenu : Window
    {
        UIBridge bridge;
        public EmployeeMenu()
        {
            InitializeComponent();
            bridge = (UIBridge)Application.Current.Resources["bridge"];
            string vacationDate = bridge.GetNextVacationDateStart();

            NextVacationBox.Text = vacationDate;
            //System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            //dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            //dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            //dispatcherTimer.Start();
            Show();
        }
        //private void dispatcherTimer_Tick(object sender, EventArgs e)
        //{
        //}
        private void exitToLogin_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            Close();
        }

        private void vacationRequest_Click(object sender, RoutedEventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            Close();
        }
    }
}
