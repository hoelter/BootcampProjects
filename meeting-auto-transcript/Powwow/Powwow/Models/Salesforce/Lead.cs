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
    public class Lead
    {
        [Key]
        [Display(Name = "Lead ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Deleted")]
        [Createable(false), Updateable(false)]
        public bool IsDeleted { get; set; }

        [Display(Name = "Master Record ID")]
        [Createable(false), Updateable(false)]
        public string MasterRecordId { get; set; }

        [Display(Name = "Last Name")]
        [StringLength(80)]
        public string LastName { get; set; }

        [Display(Name = "First Name")]
        [StringLength(40)]
        public string FirstName { get; set; }

        public string Salutation { get; set; }

        [Display(Name = "Full Name")]
        [StringLength(121)]
        [Createable(false), Updateable(false)]
        public string Name { get; set; }

        [StringLength(128)]
        public string Title { get; set; }

        [StringLength(255)]
        public string Company { get; set; }

        public string Street { get; set; }

        [StringLength(40)]
        public string City { get; set; }

        [Display(Name = "State/Province")]
        [StringLength(80)]
        public string State { get; set; }

        [Display(Name = "Zip/Postal Code")]
        [StringLength(20)]
        public string PostalCode { get; set; }

        [StringLength(80)]
        public string Country { get; set; }

        public double? Latitude { get; set; }

        public double? Longitude { get; set; }

        [Phone]
        public string Phone { get; set; }

        [Display(Name = "Mobile Phone")]
        [Phone]
        public string MobilePhone { get; set; }

        [Phone]
        public string Fax { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Url]
        public string Website { get; set; }

        [Display(Name = "Photo URL")]
        [Url]
        [Createable(false), Updateable(false)]
        public string PhotoUrl { get; set; }

        public string Description { get; set; }

        [Display(Name = "Lead Source")]
        public string LeadSource { get; set; }

        public string Status { get; set; }

        public string Industry { get; set; }

        public string Rating { get; set; }

        [Display(Name = "Annual Revenue")]
        public double? AnnualRevenue { get; set; }

        [Display(Name = "Employees")]
        public int? NumberOfEmployees { get; set; }

        [Display(Name = "Owner ID")]
        [Updateable(false)]
        public string OwnerId { get; set; }

        [Display(Name = "Converted")]
        [Updateable(false)]
        public bool IsConverted { get; set; }

        [Display(Name = "Converted Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? ConvertedDate { get; set; }

        [Display(Name = "Converted Account ID")]
        [Createable(false), Updateable(false)]
        public string ConvertedAccountId { get; set; }

        [Display(Name = "Converted Contact ID")]
        [Createable(false), Updateable(false)]
        public string ConvertedContactId { get; set; }

        [Display(Name = "Converted Opportunity ID")]
        [Createable(false), Updateable(false)]
        public string ConvertedOpportunityId { get; set; }

        [Display(Name = "Unread By Owner")]
        public bool IsUnreadByOwner { get; set; }

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

        [Display(Name = "Data.com Key")]
        [StringLength(20)]
        public string Jigsaw { get; set; }

        [Display(Name = "Jigsaw Contact ID")]
        [StringLength(20)]
        [Createable(false), Updateable(false)]
        public string JigsawContactId { get; set; }

        [Display(Name = "Clean Status")]
        public string CleanStatus { get; set; }

        [Display(Name = "Company D-U-N-S Number")]
        [StringLength(9)]
        public string CompanyDunsNumber { get; set; }

        [Display(Name = "D&B Company ID")]
        public string DandbCompanyId { get; set; }

        [Display(Name = "Email Bounced Reason")]
        [StringLength(255)]
        [Createable(false)]
        public string EmailBouncedReason { get; set; }

        [Display(Name = "Email Bounced Date")]
        [Createable(false)]
        public DateTimeOffset? EmailBouncedDate { get; set; }

        [Display(Name = "SIC Code")]
        [StringLength(15)]
        public string SICCode__c { get; set; }

        [Display(Name = "Product Interest")]
        public string ProductInterest__c { get; set; }

        [Display(Name = "Primary")]
        public string Primary__c { get; set; }

        [Display(Name = "Current Generator(s)")]
        [StringLength(100)]
        public string CurrentGenerators__c { get; set; }

        [Display(Name = "Number of Locations")]
        public double? NumberofLocations__c { get; set; }

    }
}
