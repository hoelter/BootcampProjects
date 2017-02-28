using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Powwow.Models.Recordings
{
    public class SalesforceUser
    {
        [Key]
        public int ID { get; private set; }

        [Required]
        public string SalesforceIdCode { get; private set; }
        
        public virtual ICollection<Recording> Recordings { get; private set; }


        protected SalesforceUser() { }
        public SalesforceUser(string salesforceIdCode)
        {
            SalesforceIdCode = salesforceIdCode;
        }
    }
}