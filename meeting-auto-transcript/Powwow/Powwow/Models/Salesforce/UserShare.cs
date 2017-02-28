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
    public class UserShare
    {
        [Key]
        [Display(Name = "User Share ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "User ID")]
        [Updateable(false)]
        public string UserId { get; set; }

        [Display(Name = "User/Group ID")]
        [Updateable(false)]
        public string UserOrGroupId { get; set; }

        [Display(Name = "User Access Level")]
        public string UserAccessLevel { get; set; }

        [Display(Name = "Row Cause")]
        [Updateable(false)]
        public string RowCause { get; set; }

        [Display(Name = "Last Modified Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset LastModifiedDate { get; set; }

        [Display(Name = "Last Modified By ID")]
        [Createable(false), Updateable(false)]
        public string LastModifiedById { get; set; }

        [Display(Name = "Active")]
        [Createable(false), Updateable(false)]
        public bool IsActive { get; set; }

    }
}
