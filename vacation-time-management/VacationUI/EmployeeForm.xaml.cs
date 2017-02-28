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
    /// Interaction logic for EmployeeForm.xaml
    /// </summary>
    public partial class EmployeeForm : Window
    {
        UIBridge bridge;
        public EmployeeForm()
        {
            InitializeComponent();
            bridge = (UIBridge)Application.Current.Resources["bridge"];
            Show();
            Start.SelectedDate = DateTime.Today.AddDays(1);
            End.SelectedDate = DateTime.Today.AddDays(1);
            GetBlackoutDates();
            AvailableVacationDays.Content = DisplayAvailableVacationDays();

        }

        private string DisplayAvailableVacationDays()
        {
            string availableVacationDays;
            if (bridge.CurrentUser.AvailableVacationDays < 0)
            {
                availableVacationDays = "N/A";
            }
            else
            {
                availableVacationDays = bridge.CurrentUser.AvailableVacationDays.ToString();
            }
            return availableVacationDays;
        }

        public void GetBlackoutDates()
        {
            List<DateTime> blackoutDates = bridge.GetBlackoutDates();
            foreach (DateTime day in blackoutDates)
            {
                MonthlyCalendar.BlackoutDates.Add(new CalendarDateRange(day));
                Start.BlackoutDates.Add(new CalendarDateRange(day));
                End.BlackoutDates.Add(new CalendarDateRange(day));
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (bridge.Factory.CreateNewVacationDate(Start.SelectedDate.Value, End.SelectedDate.Value, bridge.CurrentUser))
                {
                    MessageBox.Show("Your dates have been submitted to HR");
                    if (bridge.CurrentUser.isManager)
                    {
                        AdminMenu adminMenu = new AdminMenu();
                    }
                    else
                    {
                        EmployeeMenu employeeMenu = new EmployeeMenu();
                    }
                    Close();
                }
                else
                {
                    MessageBox.Show("Sorry, you do not have enough vacation days available or already have this vacation.");
                }
            }
            catch(ArgumentException)
            {
                MessageBox.Show("Make sure your start date is before your end date and in the future.");
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            if (bridge.CurrentUser.isManager)
            {
                AdminMenu adminMenu = new AdminMenu();
            }
            else
            {
                EmployeeMenu employeeMenu = new EmployeeMenu();
            }
            Close();
        }

        private void Start_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Start.SelectedDate < DateTime.Today.AddDays(1)) Start.SelectedDate = DateTime.Today.AddDays(1);
            if (End.SelectedDate < Start.SelectedDate) End.SelectedDate = Start.SelectedDate;
        }

        private void End_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (End.SelectedDate < Start.SelectedDate) End.SelectedDate = Start.SelectedDate;
        }
    }
}
