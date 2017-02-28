using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacationLib
{
    public class Login
    {
       
        private string userNameOrID;
        private string password;
        public Personnel Person { get; private set; }

        public Login(string id, string password)
        {
            userNameOrID = id;
            this.password = password;
            FindPersonnelObject();
        }

        private void FindPersonnelObject()
        {
            List<Personnel> allPersonnel = Database.GetPersonnel();
            Personnel person = allPersonnel.Find( personnel => (personnel.ID == userNameOrID || personnel.Email == userNameOrID) );
            bool isVerified = person.VerifyPassword(password);
            if (isVerified) Person = person;
            else Person = null;
        }
    }
}
