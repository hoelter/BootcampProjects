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
    public class EmailTemplate
    {
        [Key]
        [Display(Name = "Email Template ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Email Template Name")]
        [StringLength(80)]
        public string Name { get; set; }

        [Display(Name = "Template Unique Name")]
        [StringLength(80)]
        public string DeveloperName { get; set; }

        [Display(Name = "Namespace Prefix")]
        [StringLength(15)]
        [Createable(false), Updateable(false)]
        public string NamespacePrefix { get; set; }

        [Display(Name = "Owner ID")]
        [Updateable(false)]
        public string OwnerId { get; set; }

        [Display(Name = "Folder ID")]
        public string FolderId { get; set; }

        [Display(Name = "Letterhead ID")]
        [Updateable(false)]
        public string BrandTemplateId { get; set; }

        [Display(Name = "Style")]
        [Updateable(false)]
        public string TemplateStyle { get; set; }

        [Display(Name = "Available For Use")]
        public bool IsActive { get; set; }

        [Display(Name = "Template Type")]
        [Updateable(false)]
        public string TemplateType { get; set; }

        public string Encoding { get; set; }

        [StringLength(4000)]
        public string Description { get; set; }

        [StringLength(255)]
        public string Subject { get; set; }

        [Display(Name = "HTML Value")]
        public string HtmlValue { get; set; }

        [Display(Name = "Email Body")]
        public string Body { get; set; }

        [Display(Name = "Times Used")]
        [Createable(false), Updateable(false)]
        public int? TimesUsed { get; set; }

        [Display(Name = "Last Used Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? LastUsedDate { get; set; }

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

        [Display(Name = "API Version")]
        public double? ApiVersion { get; set; }

        public string Markup { get; set; }

    }
}
