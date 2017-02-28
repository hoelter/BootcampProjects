using Newtonsoft.Json;
using Salesforce.Common.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powwow.Models.Salesforce
{
    public class EmailServicesAddress
    {
        [Key]
        [Display(Name = "Address ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Active")]
        public bool IsActive { get; set; }

        [Display(Name = "Email address")]
        [StringLength(64)]
        public string LocalPart { get; set; }

        [Display(Name = "Email address domain")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string EmailDomainName { get; set; }

        [Display(Name = "Accept Email From")]
        public string AuthorizedSenders { get; set; }

        [Display(Name = "User ID")]
        public string RunAsUserId { get; set; }

        [Display(Name = "Service ID")]
        public string FunctionId { get; set; }

        [Display(Name = "Created By ID")]
        [Createable(false), Updateable(false)]
        public string CreatedById { get; set; }

        [Display(Name = "Created Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset CreatedDate { get; set; }

        [Display(Name = "Last Modified By ID")]
        [Createable(false), Updateable(false)]
        public string LastModifiedById { get; set; }

        [Display(Name = "Last Modified Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset LastModifiedDate { get; set; }

        [Display(Name = "System Modstamp")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset SystemModstamp { get; set; }

    }
}
