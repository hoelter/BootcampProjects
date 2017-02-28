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
    public class Opportunity
    {
        [Key]
        [Display(Name = "Opportunity ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Deleted")]
        [Createable(false), Updateable(false)]
        public bool IsDeleted { get; set; }

        [Display(Name = "Account ID")]
        public string AccountId { get; set; }

        [Display(Name = "Private")]
        public bool IsPrivate { get; set; }

        [StringLength(120)]
        public string Name { get; set; }

        public string Description { get; set; }

        [Display(Name = "Stage")]
        public string StageName { get; set; }

        public double? Amount { get; set; }

        [Display(Name = "Probability (%)")]
        public double? Probability { get; set; }

        [Display(Name = "Expected Amount")]
        [Createable(false), Updateable(false)]
        public double? ExpectedRevenue { get; set; }

        [Display(Name = "Quantity")]
        public double? TotalOpportunityQuantity { get; set; }

        [Display(Name = "Close Date")]
        public DateTimeOffset CloseDate { get; set; }

        [Display(Name = "Opportunity Type")]
        public string Type { get; set; }

        [Display(Name = "Next Step")]
        [StringLength(255)]
        public string NextStep { get; set; }

        [Display(Name = "Lead Source")]
        public string LeadSource { get; set; }

        [Display(Name = "Closed")]
        [Createable(false), Updateable(false)]
        public bool IsClosed { get; set; }

        [Display(Name = "Won")]
        [Createable(false), Updateable(false)]
        public bool IsWon { get; set; }

        [Display(Name = "Forecast Category")]
        [Createable(false), Updateable(false)]
        public string ForecastCategory { get; set; }

        [Display(Name = "Forecast Category")]
        public string ForecastCategoryName { get; set; }

        [Display(Name = "Campaign ID")]
        public string CampaignId { get; set; }

        [Display(Name = "Has Line Item")]
        [Createable(false), Updateable(false)]
        public bool HasOpportunityLineItem { get; set; }

        [Display(Name = "Price Book ID")]
        public string Pricebook2Id { get; set; }

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

        [Display(Name = "Fiscal Quarter")]
        [Createable(false), Updateable(false)]
        public int? FiscalQuarter { get; set; }

        [Display(Name = "Fiscal Year")]
        [Createable(false), Updateable(false)]
        public int? FiscalYear { get; set; }

        [Display(Name = "Fiscal Period")]
        [StringLength(6)]
        [Createable(false), Updateable(false)]
        public string Fiscal { get; set; }

        [Display(Name = "Last Viewed Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? LastViewedDate { get; set; }

        [Display(Name = "Last Referenced Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? LastReferencedDate { get; set; }

        [Display(Name = "Delivery/Installation Status")]
        public string DeliveryInstallationStatus__c { get; set; }

        [Display(Name = "Tracking Number")]
        [StringLength(12)]
        public string TrackingNumber__c { get; set; }

        [Display(Name = "Order Number")]
        [StringLength(8)]
        public string OrderNumber__c { get; set; }

        [Display(Name = "Current Generator(s)")]
        [StringLength(100)]
        public string CurrentGenerators__c { get; set; }

        [Display(Name = "Main Competitor(s)")]
        [StringLength(100)]
        public string MainCompetitors__c { get; set; }

    }
}
