using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace VacationLib
{
    public class Factory
    {
        
        public Factory() { }

        public Department CreateNewDepartment(string name, string employeeOutLimit)
        {
            Department department = new Department();
            if (DepartmentIsAvailable(name)) department.DepartmentName = MakeTitleCase(name);
            else department.DepartmentName = "invalid";
            department.EmployeeOutLimit = employeeOutLimit;
            Database.AddDepartment(department);
            return department;
        }

        private string MakeTitleCase(string input)
        {
            string output = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input);
            return output;
        }

        private void CreateAdminDepartmentIfNone()
        {
            if (Database.GetDepartments().Count < 1)
            { 
                Department admin = new Department();
                admin.DepartmentName = "Human Resources Department";
                admin.EmployeeOutLimit = "-1";
                Database.AddDepartment(admin);
            }
        }

        public bool CreateNewVacationDate(DateTime start, DateTime end, Personnel person)
        {
            VacationDate vacation = new VacationDate();
            vacation.StartDate = start;
            vacation.EndDate = end;
            vacation.EmployeeID = person.ID;
            vacation.EmployeeName = MakeTitleCase(person.Name);
            vacation.EmployeeEmail = person.Email;
            vacation.Department = person.Department;
            vacation.IsVerified = false;
            vacation.VerifyTimeIsLinear();
            if (VacationDateIsUnique(vacation))
            {
                if (person.UpdateAvailableVacationDays(vacation))
                {
                    Database.AddVacationDate(vacation);
                    return true;
                }
            }
            return false;
        }

        public Personnel CreateNewAdmin(string email, string password, string name = "Admin of the Human Resource Department")
        {
            CreateAdminDepartmentIfNone();
            Personnel admin = new Personnel();
            admin.SetPassword(password);
            admin.Name = MakeTitleCase(name);
            if (EmailIsAvailable(email)) admin.Email = email;
            else admin.Email = "invalid";
            admin.isManager = true;
            admin.isAdmin = true;
            admin.Department = "Human Resources Department";
            admin.SetID();
            admin.AvailableVacationDays = -1;
            Database.AddPersonnel(admin);
            return admin;
        }

        public Personnel CreateNewEmployee(string name, string password, string email, string department, int vacationDays, bool isManager = false)
        {
            Personnel employee = new Personnel();
            employee.SetPassword(password);
            employee.Name = MakeTitleCase(name);
            if (EmailIsAvailable(email)) employee.Email = email;
            else employee.Email = "invalid";
            employee.Department = department;
            employee.isManager = isManager;
            employee.isAdmin = false;
            employee.AvailableVacationDays = vacationDays;
            employee.SetID();
            Database.AddPersonnel(employee);
            return employee;
        }

        private bool EmailIsAvailable(string email)
        {
            if (email.Contains('@')) //can also make more comprehensive via regex
            {
                List<Personnel> allPersonnel = Database.GetPersonnel();
                foreach (Personnel person in allPersonnel)
                {
                    //check for period? more comprehensive?
                    if (person.Email.ToLower() == email.ToLower()) return false;
                }
                return true;
            }
            return false;
        }

        private bool DepartmentIsAvailable(string departmentName)
        {
            if (Database.GetDepartmentNames().Contains(MakeTitleCase(departmentName))) return false;
            return true;
        }

        private bool VacationDateIsUnique(VacationDate vacation)
        {
            List<VacationDate> allVacations = Database.GetCalendar(vacation.Department);
            foreach (VacationDate vd in allVacations)
            {
                if (vacation.Equals(vd)) return false;
            }
            return true;
        }
    }
}
