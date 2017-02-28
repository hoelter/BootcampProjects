using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacationLib;

namespace VacationManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Department department = new Department();
            //department.departmentName = "test";
            //department.employeeOutLimit = "3";
            //db.AddDepartment(department);

            //Personnel person = new Personnel();
            //person.ID = 000;
            //person.Name = "Jim Testy";
            //person.SetPassword("apple");
            //person.Department = department.departmentName;
            //person.isAdmin = false;
            //person.AvailableVacationDays = 10;
            //db.AddPersonnel(person);

            //var allP = db.GetPersonnel();
            //foreach (var p in allP)
            //{
            //    Console.WriteLine(p.Name);
            //}
            List<Department> dpts = Database.GetDepartments();
            Console.WriteLine(dpts.Count);
            Console.WriteLine((dpts).GetType().ToString());
        
        }
    }
}
