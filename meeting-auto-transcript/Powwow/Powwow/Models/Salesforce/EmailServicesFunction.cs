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
    public class EmailServicesFunction
    {
        [Key]
        [Display(Name = "Service ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Active")]
        public bool IsActive { get; set; }

        [Display(Name = "Email Service Name")]
        [StringLength(64)]
        public string FunctionName { get; set; }

        [Display(Name = "Accept Email From")]
        public string AuthorizedSenders { get; set; }

        [Display(Name = "Advanced Email Security Settings")]
        public bool IsAuthenticationRequired { get; set; }

        [Display(Name = "TLS Required")]
        public bool IsTlsRequired { get; set; }

        [Display(Name = "Accept Attachments")]
        public string AttachmentOption { get; set; }

        [Display(Name = "Class ID")]
        public string ApexClassId { get; set; }

        [Display(Name = "Over Email Rate Limit Action")]
        public string OverLimitAction { get; set; }

        [Display(Name = "Deactivated Email Service Action")]
        public string FunctionInactiveAction { get; set; }

        [Display(Name = "Deactivated Email Address Action")]
        public string AddressInactiveAction { get; set; }

        [Display(Name = "Unauthenticated Sender Action")]
        public string AuthenticationFailureAction { get; set; }

        [Display(Name = "Unauthorized Sender Action")]
        public string AuthorizationFailureAction { get; set; }

        [Display(Name = "Enable Error Routing")]
        public bool IsErrorRoutingEnabled { get; set; }

        [Display(Name = "Route Error Emails to This Email Address")]
        [EmailAddress]
        public string ErrorRoutingAddress { get; set; }

        [Display(Name = "Convert Text Attachments to Binary Attachments")]
        public bool IsTextAttachmentsAsBinary { get; set; }

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
