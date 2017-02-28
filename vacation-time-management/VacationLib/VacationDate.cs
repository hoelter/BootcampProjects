using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VacationLib
{
    public class VacationDate : IEquatable<VacationDate>
    {
        public DateTime StartDate;
        public DateTime EndDate;
        public string EmployeeID;
        public string EmployeeEmail;
        public string EmployeeName;
        public bool IsVerified;
        public string Department;

        public VacationDate()
        {
        }

        public bool Equals(VacationDate vacation)
        {
            if(
                StartDate == vacation.StartDate &&
                EndDate == vacation.EndDate &&
                EmployeeID == vacation.EmployeeID &&
                EmployeeEmail == vacation.EmployeeEmail &&
                EmployeeName == vacation.EmployeeName &&
                IsVerified == vacation.IsVerified &&
                Department == vacation.Department
                ) return true;
            return false;
        
            //MessageBox.Show(ReferenceEquals(this, vacation).ToString());
           // return ReferenceEquals(this, vacation);
        }

        public void VerifyTimeIsLinear()
        {
            if (StartDate > EndDate)
            {
                throw new ArgumentException("The start date may not be after the end date.");
            }
            else if (StartDate <= DateTime.Today)
            {
                throw new ArgumentException("The start date may not be today or in the past.");
            }
        }

    }
}
