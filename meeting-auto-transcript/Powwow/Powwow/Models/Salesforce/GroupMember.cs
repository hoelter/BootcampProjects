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
    public class GroupMember
    {
        [Key]
        [Display(Name = "Group Member ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Group ID")]
        [Updateable(false)]
        public string GroupId { get; set; }

        [Display(Name = "User/Group ID")]
        [Updateable(false)]
        public string UserOrGroupId { get; set; }

        [Display(Name = "System Modstamp")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset SystemModstamp { get; set; }

    }
}
