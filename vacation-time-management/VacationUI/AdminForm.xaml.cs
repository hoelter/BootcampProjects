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
    /// Interaction logic for AdminForm.xaml
    /// </summary>
    public partial class AdminForm : Window
    {
        private UIBridge bridge;
        private List<VacationDate> allVacations;

        public AdminForm()
        {
            InitializeComponent();
            bridge = (UIBridge)Application.Current.Resources["bridge"];
            Show();
            allVacations = bridge.GetUnapprovedVacations();
            populateListBoxes();
        }

        public void populateListBoxes()
        {
            pendingListbox.Items.Clear();
            ApprovedListbox.Items.Clear();
         
            {
                foreach (VacationDate vacation in allVacations)
                {
                    if (vacation.IsVerified)
                    {
                        ApprovedListbox.Items.Add(CombineNameAndDate(vacation));
                    }
                    else
                    {
                        pendingListbox.Items.Add(CombineNameAndDate(vacation));
                    }
                }
            }
        }
        #region
        public string CombineNameAndDate(VacationDate vacation)
        {
            //need something more unique than employee name (id or email must be present) in case of two employees with same name. Don't modify now, for future reference.
            string formattedString =  string.Format("{0}) {1}", vacation.EmployeeName, vacation.StartDate);
            return formattedString;
        }

        private void backToAdminMenu_Click(object sender, RoutedEventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu();
            Close();
        }
        #endregion

        private void pendingListbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (pendingListbox.SelectedItem != null)
            {
                string selectedEmployee = pendingListbox.SelectedItem.ToString();
                BlackoutDates(selectedEmployee);
            }
        }

        private void ApprovedListbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ApprovedListbox.SelectedItem != null)
            {
                string selectedEmployee = ApprovedListbox.SelectedItem.ToString();
                BlackoutDates(selectedEmployee);
            }
        }

          public void BlackoutDates(string employee)
        {
            for (int i = 0; i < allVacations.Count; i++)
            {
                if (allVacations[i].EmployeeName == employee)
                {
                    var pendingIndex = i;
                    DateTime start = allVacations[i].StartDate;
                    DateTime end = allVacations[i].EndDate;
                    calendarDisplay.BlackoutDates.Clear();
                    calendarDisplay.BlackoutDates.Add(new CalendarDateRange(start, end));
                }
            }
        }

        private void approveButton_Click(object sender, RoutedEventArgs e)
        {
            if (pendingListbox.SelectedItem != null)
            {
                string vacationDateInfo = pendingListbox.SelectedItem.ToString();
                VerifyOrUnverify(vacationDateInfo);
                populateListBoxes();
            }
        }

        private void UndoButton_Click(object sender, RoutedEventArgs e)
        {
            if (ApprovedListbox.SelectedItem != null)
            {
            string vacationDateInfo = ApprovedListbox.SelectedItem.ToString();
            VerifyOrUnverify(vacationDateInfo);
            populateListBoxes();
            }
        }

        private void submit_Click(object sender, RoutedEventArgs e)
        {
            bridge.ApproveVacationDate(GetApprovedVacations(true));
            if (bridge.CurrentUser.isManager)
            {
                AdminMenu adminMenu = new AdminMenu();
            }
            else
            {
                EmployeeMenu employeeMenu = new EmployeeMenu();
            }
            MessageBox.Show("The selected vacations have now been approved.");
            Close();
        }

        private void VerifyOrUnverify(string nameAndStartDate)
        {
            string[] nameDate = nameAndStartDate.Split(')');
            string name = nameDate[0].TrimEnd();
            string date = nameDate[1].TrimStart();
            for (int i = 0; i < allVacations.Count; i++)
            {
                if (allVacations[i].EmployeeName == name && allVacations[i].StartDate.ToString() == date)
                {
                    if (allVacations[i].IsVerified) allVacations[i].IsVerified = false;
                    else allVacations[i].IsVerified = true;
                    break;
                }
            }
        }

        //private void VerifyOrUnverify(VacationDate vacation)
        //{
        //    for (int i = 0; i < allVacations.Count; i++)
        //    {
        //        if (allVacations[i].EmployeeID == vacation.EmployeeID && allVacations[i].StartDate == vacation.StartDate)
        //        {
        //            if (vacation.IsVerified) vacation.IsVerified = false;
        //            else vacation.IsVerified = true;
        //            allVacations[i] = vacation;
        //            break;
        //        }
        //    }
        //}

        private List<VacationDate> GetApprovedVacations(bool approvedOrNot)
        {
            List<VacationDate> output = new List<VacationDate>();
            foreach (VacationDate vacation in allVacations)
            {
                if (vacation.IsVerified == approvedOrNot) output.Add(vacation);
            }
            return output;
        }
    }
}
