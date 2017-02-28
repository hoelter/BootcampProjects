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
    public class Contract
    {
        [Key]
        [Display(Name = "Contract ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Account ID")]
        public string AccountId { get; set; }

        [Display(Name = "Price Book ID")]
        public string Pricebook2Id { get; set; }

        [Display(Name = "Owner Expiration Notice")]
        public string OwnerExpirationNotice { get; set; }

        [Display(Name = "Contract Start Date")]
        public DateTimeOffset? StartDate { get; set; }

        [Display(Name = "Contract End Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? EndDate { get; set; }

        [Display(Name = "Billing Street")]
        public string BillingStreet { get; set; }

        [Display(Name = "Billing City")]
        [StringLength(40)]
        public string BillingCity { get; set; }

        [Display(Name = "Billing State/Province")]
        [StringLength(80)]
        public string BillingState { get; set; }

        [Display(Name = "Billing Zip/Postal Code")]
        [StringLength(20)]
        public string BillingPostalCode { get; set; }

        [Display(Name = "Billing Country")]
        [StringLength(80)]
        public string BillingCountry { get; set; }

        [Display(Name = "Billing Latitude")]
        public double? BillingLatitude { get; set; }

        [Display(Name = "Billing Longitude")]
        public double? BillingLongitude { get; set; }

        [Display(Name = "Contract Term")]
        public int? ContractTerm { get; set; }

        [Display(Name = "Owner ID")]
        [Updateable(false)]
        public string OwnerId { get; set; }

        public string Status { get; set; }

        [Display(Name = "Company Signed By ID")]
        public string CompanySignedId { get; set; }

        [Display(Name = "Company Signed Date")]
        public DateTimeOffset? CompanySignedDate { get; set; }

        [Display(Name = "Customer Signed By ID")]
        public string CustomerSignedId { get; set; }

        [Display(Name = "Customer Signed Title")]
        [StringLength(40)]
        public string CustomerSignedTitle { get; set; }

        [Display(Name = "Customer Signed Date")]
        public DateTimeOffset? CustomerSignedDate { get; set; }

        [Display(Name = "Special Terms")]
        public string SpecialTerms { get; set; }

        [Display(Name = "Activated By ID")]
        [Createable(false)]
        public string ActivatedById { get; set; }

        [Display(Name = "Activated Date")]
        [Createable(false)]
        public DateTimeOffset? ActivatedDate { get; set; }

        [Display(Name = "Status Category")]
        [Createable(false), Updateable(false)]
        public string StatusCode { get; set; }

        public string Description { get; set; }

        [Display(Name = "Deleted")]
        [Createable(false), Updateable(false)]
        public bool IsDeleted { get; set; }

        [Display(Name = "Contract Number")]
        [StringLength(30)]
        [Createable(false), Updateable(false)]
        public string ContractNumber { get; set; }

        [Display(Name = "Last Approved Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? LastApprovedDate { get; set; }

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

    }
}
