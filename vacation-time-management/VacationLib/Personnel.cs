using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.ComponentModel;

namespace VacationLib
{
   public class Personnel // :  INotifyPropertyChanged
    {
        public string ID;
        public string Name;
        public string Email;
        public string Password;
        public string Department;
        public bool isManager;
        public bool isAdmin;
        public int AvailableVacationDays;

        public Personnel()
        {
        }

        public void SetPassword(string password)
        {
            string hashed = PasswordHash.CreateHash(password);
            Password = hashed;
        }

        public bool VerifyPassword(string passwordToValidate)
        {
            bool isValid;
            isValid = PasswordHash.ValidatePassword(passwordToValidate, Password);
            return isValid;
        }

        public void SetID()
        {
            ID = Database.GetNewID();
        }

        public bool UpdateAvailableVacationDays(VacationDate vacation)
        {
            int vacationLengthInDays = ((int)(vacation.EndDate - vacation.StartDate).TotalDays) + 1;
            int checkAmount = AvailableVacationDays - vacationLengthInDays;
            if (checkAmount >= 0)
            {
                AvailableVacationDays = checkAmount;
                return true;
            }
            else if (AvailableVacationDays == -1) return true;
            return false;
        }

        //private void NotifyPropertyChanged(string info)
        //{
        //    if (PropertyChangedEventArgs != null)
        //    {
        //        PropertyChangedEventArgs(this, new PropertyChangedEventArgs(info));
        //    }
        //}
    }
}
