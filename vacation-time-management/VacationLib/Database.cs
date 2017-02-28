using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacationLib
{
 public static class Database 
    {
        public static List<Department> GetDepartments()
        {
            string fileName = FormatFileName("allDepartments");
            List<Department> departments = ReadDatabase<Department>(fileName);
            return departments;
        }

        //public static List<Department> GetDepartments(string departmentName)
        //{
        //    string fileName = FormatFileName("allDepartments");
        //    List<Department> departments = ReadDatabase<Department>(fileName);
        //    return departments;
        //}

        public static List<VacationDate> GetCalendar(string departmentName)
        {
            if (departmentName != "admin") //not super admin
            {
                string fileName = FormatFileName(departmentName);
                List<VacationDate> vacationDates = ReadDatabase<VacationDate>(fileName);
                return vacationDates;
            }
            else
            {
                List<VacationDate> allVacationDates = new List<VacationDate>();
                List<string> departmentsNames = GetDepartmentNames();
                foreach (string dName in departmentsNames)
                {
                    string fileName = FormatFileName(dName);
                    List<VacationDate> someVacations = ReadDatabase<VacationDate>(fileName);
                    allVacationDates.AddRange(someVacations);
                }
                return allVacationDates;
            }
        }

        public static List<string> GetDepartmentNames()
        {
            List<Department> departments = GetDepartments();
            List<string> departmentNames = new List<string>();
            foreach (Department department in departments)
            {
                departmentNames.Add(department.DepartmentName);
            }
            return departmentNames;
        }

        public static List<Personnel> GetPersonnel()
        {
            string fileName = FormatFileName("all_personnel");
            List<Personnel> allPersonnel = ReadDatabase<Personnel>(fileName);
            return allPersonnel;
        }

        private static string FormatFileName(string name)
        {
            string fileName = string.Format("!{0}.xml", name);
            return fileName;
        }

        public static void AddVacationDate(VacationDate vacation)
        {
            string fileName = FormatFileName(vacation.Department);
            List<VacationDate> vacationDates = ReadDatabase<VacationDate>(fileName);
            vacationDates.Add(vacation);
            UpdateDatabase(fileName, vacationDates);
        }

        public static void AddVacationDate(List<VacationDate> vacationDates)
        {
            string fileName = FormatFileName(vacationDates[0].Department);
            UpdateDatabase(fileName, vacationDates);
        }

        public static void AddPersonnel(Personnel person)
        {
            string fileName = FormatFileName("all_personnel");
            List<Personnel> allPersonnel = ReadDatabase<Personnel>(fileName);
            allPersonnel.Add(person);
            UpdateDatabase(fileName, allPersonnel);
        }

        public static void AddDepartment(Department department)
        {
            string fileName = FormatFileName("allDepartments");
            List<Department> departments = ReadDatabase<Department>(fileName);
            departments.Add(department);
            UpdateDatabase(fileName, departments);
        }

        public static List<int> ViewIDS()
        {
            string fileName = FormatFileName("allIDStorage");
            List<int> allID = ReadDatabase<int>(fileName);
            if (allID.Count < 1)
            {
                UpdateIDS();
                ViewIDS();
            }
            return allID;
        }

        public static string GetNewID()
        {
            int newID = UpdateIDS();
            return newID.ToString();
        }

        private static int UpdateIDS()
        {
            string fileName = FormatFileName("allIDStorage");
            List<int> allID = ReadDatabase<int>(fileName);
            int newID;
            if (allID.Count > 0 )
            {
                int lastID = allID[allID.Count-1];
                newID = lastID + 1;
            }
            else
            {
                newID = 1000;
            }
            allID.Add(newID);
            UpdateDatabase(fileName, allID);
            return newID;
        }

        private static void UpdateDatabase<T>(string fileName, T list)
        {
            using (var file = new StreamWriter(fileName))
            {
                XmlSerializer serializer = new XmlSerializer(list.GetType());
                serializer.Serialize(file, list);
                file.Flush();
            }
        }

        private static List<T> ReadDatabase<T>(string fileName)
        {
            List<T> infoList;
            try
            {
                using (var file = new StreamReader(fileName))
                {
                    XmlSerializer reader = new XmlSerializer(typeof(List<T>));
                    infoList = (List<T>)reader.Deserialize(file);
                }
            }
            catch(Exception ex) when (ex is FileNotFoundException || ex is DirectoryNotFoundException)
            {
                    infoList = new List<T>();
            }
            return infoList;
        }
    }
}
