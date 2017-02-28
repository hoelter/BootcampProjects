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
    public class Order
    {
        [Key]
        [Display(Name = "Order ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Owner ID")]
        [Updateable(false)]
        public string OwnerId { get; set; }

        [Display(Name = "Contract ID")]
        public string ContractId { get; set; }

        [Display(Name = "Account ID")]
        public string AccountId { get; set; }

        [Display(Name = "Price Book ID")]
        public string Pricebook2Id { get; set; }

        [Display(Name = "Order ID")]
        [Updateable(false)]
        public string OriginalOrderId { get; set; }

        [Display(Name = "Order Start Date")]
        public DateTimeOffset EffectiveDate { get; set; }

        [Display(Name = "Order End Date")]
        public DateTimeOffset? EndDate { get; set; }

        [Display(Name = "Reduction Order")]
        [Updateable(false)]
        public bool IsReductionOrder { get; set; }

        public string Status { get; set; }

        [Display(Name = "Internal Comments")]
        public string Description { get; set; }

        [Display(Name = "Customer Authorized By ID")]
        public string CustomerAuthorizedById { get; set; }

        [Display(Name = "Customer Authorized Date")]
        public DateTimeOffset? CustomerAuthorizedDate { get; set; }

        [Display(Name = "Company Authorized By ID")]
        public string CompanyAuthorizedById { get; set; }

        [Display(Name = "Company Authorized Date")]
        public DateTimeOffset? CompanyAuthorizedDate { get; set; }

        [Display(Name = "Order Type")]
        public string Type { get; set; }

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

        [Display(Name = "Shipping Street")]
        public string ShippingStreet { get; set; }

        [Display(Name = "Shipping City")]
        [StringLength(40)]
        public string ShippingCity { get; set; }

        [Display(Name = "Shipping State/Province")]
        [StringLength(80)]
        public string ShippingState { get; set; }

        [Display(Name = "Shipping Zip/Postal Code")]
        [StringLength(20)]
        public string ShippingPostalCode { get; set; }

        [Display(Name = "Shipping Country")]
        [StringLength(80)]
        public string ShippingCountry { get; set; }

        [Display(Name = "Shipping Latitude")]
        public double? ShippingLatitude { get; set; }

        [Display(Name = "Shipping Longitude")]
        public double? ShippingLongitude { get; set; }

        [Display(Name = "Order Name")]
        [StringLength(80)]
        public string Name { get; set; }

        [Display(Name = "PO Date")]
        public DateTimeOffset? PoDate { get; set; }

        [Display(Name = "PO Number")]
        [StringLength(80)]
        public string PoNumber { get; set; }

        [Display(Name = "Order Reference Number")]
        [StringLength(80)]
        public string OrderReferenceNumber { get; set; }

        [Display(Name = "Bill To Contact ID")]
        public string BillToContactId { get; set; }

        [Display(Name = "Ship To Contact ID")]
        public string ShipToContactId { get; set; }

        [Display(Name = "Activated Date")]
        [Createable(false)]
        public DateTimeOffset? ActivatedDate { get; set; }

        [Display(Name = "Activated By ID")]
        [Createable(false)]
        public string ActivatedById { get; set; }

        [Display(Name = "Status Category")]
        [Createable(false)]
        public string StatusCode { get; set; }

        [Display(Name = "Order Number")]
        [StringLength(30)]
        [Createable(false), Updateable(false)]
        public string OrderNumber { get; set; }

        [Display(Name = "Order Amount")]
        [Createable(false), Updateable(false)]
        public double TotalAmount { get; set; }

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

        [Display(Name = "Deleted")]
        [Createable(false), Updateable(false)]
        public bool IsDeleted { get; set; }

        [Display(Name = "System Modstamp")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset SystemModstamp { get; set; }

        [Display(Name = "Last Viewed Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? LastViewedDate { get; set; }

        [Display(Name = "Last Referenced Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? LastReferencedDate { get; set; }

    }
}
