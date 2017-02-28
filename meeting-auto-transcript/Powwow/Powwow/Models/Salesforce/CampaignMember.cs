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
    public class CampaignMember
    {
        [Key]
        [Display(Name = "Campaign Member ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Deleted")]
        [Createable(false), Updateable(false)]
        public bool IsDeleted { get; set; }

        [Display(Name = "Campaign ID")]
        [Updateable(false)]
        public string CampaignId { get; set; }

        [Display(Name = "Lead ID")]
        [Updateable(false)]
        public string LeadId { get; set; }

        [Display(Name = "Contact ID")]
        [Updateable(false)]
        public string ContactId { get; set; }

        public string Status { get; set; }

        [Display(Name = "Responded")]
        [Createable(false), Updateable(false)]
        public bool HasResponded { get; set; }

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

        [Display(Name = "First Responded Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? FirstRespondedDate { get; set; }

    }
}
