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
    public class Campaign
    {
        [Key]
        [Display(Name = "Campaign ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Deleted")]
        [Createable(false), Updateable(false)]
        public bool IsDeleted { get; set; }

        [StringLength(80)]
        public string Name { get; set; }

        [Display(Name = "Parent Campaign ID")]
        public string ParentId { get; set; }

        public string Type { get; set; }

        public string Status { get; set; }

        [Display(Name = "Start Date")]
        public DateTimeOffset? StartDate { get; set; }

        [Display(Name = "End Date")]
        public DateTimeOffset? EndDate { get; set; }

        [Display(Name = "Expected Revenue")]
        public double? ExpectedRevenue { get; set; }

        [Display(Name = "Budgeted Cost")]
        public double? BudgetedCost { get; set; }

        [Display(Name = "Actual Cost")]
        public double? ActualCost { get; set; }

        [Display(Name = "Expected Response (%)")]
        public double? ExpectedResponse { get; set; }

        [Display(Name = "Num Sent")]
        public double? NumberSent { get; set; }

        [Display(Name = "Active")]
        public bool IsActive { get; set; }

        public string Description { get; set; }

        [Display(Name = "Total Leads")]
        [Createable(false), Updateable(false)]
        public int NumberOfLeads { get; set; }

        [Display(Name = "Converted Leads")]
        [Createable(false), Updateable(false)]
        public int NumberOfConvertedLeads { get; set; }

        [Display(Name = "Total Contacts")]
        [Createable(false), Updateable(false)]
        public int NumberOfContacts { get; set; }

        [Display(Name = "Total Responses")]
        [Createable(false), Updateable(false)]
        public int NumberOfResponses { get; set; }

        [Display(Name = "Num Total Opportunities")]
        [Createable(false), Updateable(false)]
        public int NumberOfOpportunities { get; set; }

        [Display(Name = "Num Won Opportunities")]
        [Createable(false), Updateable(false)]
        public int NumberOfWonOpportunities { get; set; }

        [Display(Name = "Total Value Opportunities")]
        [Createable(false), Updateable(false)]
        public double AmountAllOpportunities { get; set; }

        [Display(Name = "Total Value Won Opportunities")]
        [Createable(false), Updateable(false)]
        public double AmountWonOpportunities { get; set; }

        [Display(Name = "Owner ID")]
        [Updateable(false)]
        public string OwnerId { get; set; }

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

        [Display(Name = "Last Activity")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? LastActivityDate { get; set; }

        [Display(Name = "Last Viewed Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? LastViewedDate { get; set; }

        [Display(Name = "Last Referenced Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? LastReferencedDate { get; set; }

        [Display(Name = "Record Type ID")]
        public string CampaignMemberRecordTypeId { get; set; }

    }
}
