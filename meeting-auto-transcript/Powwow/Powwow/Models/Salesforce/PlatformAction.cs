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
    public class PlatformAction
    {
        [Key]
        [Display(Name = "Not used ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Platform Action ID")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string ExternalId { get; set; }

        [Display(Name = "Last Modified Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? LastModifiedDate { get; set; }

        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string Label { get; set; }

        [Createable(false), Updateable(false)]
        public string Type { get; set; }

        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string Subtype { get; set; }

        [Display(Name = "API Name")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string ApiName { get; set; }

        [Display(Name = "Action Target URL")]
        [Url]
        [Createable(false), Updateable(false)]
        public string ActionTargetUrl { get; set; }

        [Display(Name = "Action Target Type")]
        [Createable(false), Updateable(false)]
        public string ActionTargetType { get; set; }

        [Display(Name = "Confirmation Message")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string ConfirmationMessage { get; set; }

        [Display(Name = "Group ID")]
        [Createable(false), Updateable(false)]
        public string GroupId { get; set; }

        [Display(Name = "Is Group Default")]
        [Createable(false), Updateable(false)]
        public bool IsGroupDefault { get; set; }

        [Createable(false), Updateable(false)]
        public string Category { get; set; }

        [Display(Name = "Invocation Status")]
        [Createable(false), Updateable(false)]
        public string InvocationStatus { get; set; }

        [Display(Name = "User ID")]
        [Createable(false), Updateable(false)]
        public string InvokedByUserId { get; set; }

        [Display(Name = "Source Entity")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string SourceEntity { get; set; }

        [Display(Name = "Action List Context")]
        [Createable(false), Updateable(false)]
        public string ActionListContext { get; set; }

        [Display(Name = "Device Format")]
        [Createable(false), Updateable(false)]
        public string DeviceFormat { get; set; }

        [Display(Name = "Icon Content Type")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string IconContentType { get; set; }

        [Display(Name = "Icon Height")]
        [Createable(false), Updateable(false)]
        public int? IconHeight { get; set; }

        [Display(Name = "Icon Width")]
        [Createable(false), Updateable(false)]
        public int? IconWidth { get; set; }

        [Display(Name = "Icon URL")]
        [Url]
        [Createable(false), Updateable(false)]
        public string IconUrl { get; set; }

        [Display(Name = "Primary Color")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string PrimaryColor { get; set; }

        [Display(Name = "Related Source Entity")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string RelatedSourceEntity { get; set; }

    }
}
