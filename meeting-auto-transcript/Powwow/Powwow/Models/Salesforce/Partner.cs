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
    public class Partner
    {
        [Key]
        [Display(Name = "Partner ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Opportunity ID")]
        [Updateable(false)]
        public string OpportunityId { get; set; }

        [Display(Name = "Account From ID")]
        [Updateable(false)]
        public string AccountFromId { get; set; }

        [Display(Name = "Account To ID")]
        [Updateable(false)]
        public string AccountToId { get; set; }

        [Updateable(false)]
        public string Role { get; set; }

        [Display(Name = "Primary")]
        [Updateable(false)]
        public bool IsPrimary { get; set; }

        [Display(Name = "Created Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset CreatedDate { get; set; }

        [Display(Name = "Created By ID")]
        [Createable(false), Updateable(false)]
        public string CreatedById { get; set; }

        [Display(Name = "Last Modified Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset LastModifiedDate { get; set; }

        [Display(Name = "Last Modified By ID")]
        [Createable(false), Updateable(false)]
        public string LastModifiedById { get; set; }

        [Display(Name = "System Modstamp")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset SystemModstamp { get; set; }

        [Display(Name = "Deleted")]
        [Createable(false), Updateable(false)]
        public bool IsDeleted { get; set; }

        [Display(Name = "Reverse Partner ID")]
        [Createable(false), Updateable(false)]
        public string ReversePartnerId { get; set; }

    }
}
