using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Globalization;

namespace VacationLib
{
    public class UIBridge
    {
        public Personnel CurrentUser;
        private Department department;
        public Factory Factory;

        public UIBridge()
        {
            Factory = new Factory();
        }
        public bool Login(string id, string password)
        {
            bool isValid;
            try
            {
                Login login = new Login(id, password);
                if (login.Person != null)
                {
                    CurrentUser = login.Person;
                    department = InitializeDepartment();
                    isValid = true;
                }
                else isValid = false;
            }
            catch
            {
                isValid = false;
            }
            return isValid;
        }

        public bool AdminsExist()
        {
            List<Personnel> personnelList = Database.GetPersonnel();
            bool adminExists = false;
            foreach(Personnel person in personnelList)
            {
                adminExists = person.isManager;
                if (adminExists) break;
            }
            return adminExists;
        }

        private Department InitializeDepartment()
        {
            string departmentName = CurrentUser.Department;
            List<Department> departments = Database.GetDepartments();
            foreach (Department department in departments)
            {
                if (department.DepartmentName == departmentName)
                {
                    return department;
                }
            }
            return null;
        }

        public IEnumerable<DateTime> GetInbetweenDays(DateTime start, DateTime end)
        {
            List<DateTime> days = new List<DateTime>();
            while (start <= end)
            {
                yield return start;
                start = start.AddDays(1);
                days.Add(start);
            }
        }

        public string GetNextVacationDateStart()
        {
            List<VacationDate> allVacations = Database.GetCalendar(CurrentUser.Department);
            VacationDate mostRecentVacation = null;
            string daysLeft = "";
            foreach (VacationDate vacation in allVacations)
            {
                if (vacation.EmployeeID == CurrentUser.ID)
                {
                    if (mostRecentVacation == null)
                    {
                        mostRecentVacation = vacation;
                    }
                    else
                    {
                        if (vacation.StartDate < mostRecentVacation.StartDate) mostRecentVacation = vacation;
                    }
                }
            }
            try
            {
                daysLeft = (((int)(mostRecentVacation.StartDate - DateTime.Now).TotalDays) + 1).ToString();
            }
            catch(NullReferenceException)
            {
                daysLeft = "No Vacation Scheduled";
            }
            return daysLeft;
        }

        public List<DateTime> GetBlackoutDates()
        {
            List<DateTime> allDates = new List<DateTime>();
            List<DateTime> duplicateDates = new List<DateTime>();
            List<DateTime> blackoutDates = new List<DateTime>();
            List<VacationDate> calendar = Database.GetCalendar(department.DepartmentName);
            int employeeOutLimit = int.Parse(department.EmployeeOutLimit);
            if (employeeOutLimit == -1) employeeOutLimit = 100; //change later
            foreach (VacationDate vacation in calendar)
            {
                var blackoutDay = vacation.StartDate;
                while(blackoutDay <= vacation.EndDate)
                {
                    blackoutDay = blackoutDay.AddDays(1);
                    if (allDates.Contains(blackoutDay))
                        duplicateDates.Add(blackoutDay);
                    else
                        allDates.Add(blackoutDay);
                }
                if (employeeOutLimit < 2) return allDates;
                else if (employeeOutLimit == -1) return blackoutDates;
                else
                {
                    foreach (DateTime duplicateDay in duplicateDates)
                    {
                        if (employeeOutLimit > 2)
                        {
                            int count = 1;
                            foreach (DateTime day in allDates)
                            {
                                if (day == duplicateDay)
                                {
                                    count++;
                                    if (count == employeeOutLimit)
                                    {
                                        blackoutDates.Add(day);
                                        break;
                                    }
                                }
                            }
                        }
                        else blackoutDates.Add(duplicateDay);
                    }
                }
            }
            if (blackoutDates == null)
            {
                blackoutDates = new List<DateTime>();
            }
            return blackoutDates;
        }

        public bool CheckDateAvailability(DateTime start, DateTime end)
        {
            int employeesOnVacation = 0;
            int employeeOutLimit = int.Parse(department.EmployeeOutLimit);
            List<VacationDate> calendar = Database.GetCalendar(department.DepartmentName);
            foreach (VacationDate vacation in calendar)
            {
                if (start < vacation.StartDate && vacation.StartDate < end)
                {
                    employeesOnVacation++;
                }
            }
            if (employeesOnVacation > employeeOutLimit)
            {
                return false;
            }
            else return true;
        }

          public List<VacationDate> GetUnapprovedVacations()
        {
            List<VacationDate> allVacations = Database.GetCalendar(CurrentUser.Department);
            List<VacationDate> unapprovedVacations = new List<VacationDate>();
            foreach (VacationDate vacation in allVacations)
            {
                if (vacation.IsVerified == false) unapprovedVacations.Add(vacation);
            }
            return unapprovedVacations;
        }

        public void ApproveVacationDate(VacationDate approvedVacation)
        {
            approvedVacation.IsVerified = true;
            List<VacationDate> allVacations = Database.GetCalendar(CurrentUser.Department);
            for (int i = 0; i < allVacations.Count; i++)
            {
                if (allVacations[i].EmployeeID == approvedVacation.EmployeeID && allVacations[i].StartDate == approvedVacation.StartDate)
                {
                    allVacations[i] = approvedVacation;
                    break;
                }
            }
            Database.AddVacationDate(allVacations);
        }

         public void ApproveVacationDate(List<VacationDate> approvedVacations)
        {
            List<VacationDate> allVacations = Database.GetCalendar(CurrentUser.Department);
            foreach (VacationDate approvedVacation in approvedVacations)
            { 
                approvedVacation.IsVerified = true;
                for (int i = 0; i < allVacations.Count; i++)
                {
                    if (allVacations[i].EmployeeID == approvedVacation.EmployeeID && allVacations[i].StartDate == approvedVacation.StartDate)
                    {
                        allVacations[i] = approvedVacation;
                        break;
                    }
                }
            }
            Database.AddVacationDate(allVacations);
        }

        public List<string> GetObjectInfo<T>(T anObject)
        {
            List<string> ignoreList = new List<string>
            {
                "isManager"
                ,"isAdmin"
                ,"Password"
            };
            FieldInfo[] fields = anObject.GetType().GetFields();
            List<string> fieldNamesAndValues = new List<string>();
            foreach (FieldInfo f in fields)
            {
                if (ignoreList.Contains(f.Name) == false)
                {
                    string nameAndValue = string.Format("{0}: {1}", SplitPascalCase(f.Name), f.GetValue(anObject));
                    fieldNamesAndValues.Add(nameAndValue);
                }
            }
            return fieldNamesAndValues;
        }

        private string SplitPascalCase(string input)
        {
            string output = Regex.Replace(input, "([a-z])_?([A-Z])", "$1 $2");
            output = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(output);
            return output;
        }
    }
}
