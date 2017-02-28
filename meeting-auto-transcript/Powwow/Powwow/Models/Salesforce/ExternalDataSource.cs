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
    public class ExternalDataSource
    {
        [Key]
        [Display(Name = "External Data Source ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Deleted")]
        [Createable(false), Updateable(false)]
        public bool IsDeleted { get; set; }

        [Display(Name = "Name")]
        [StringLength(80)]
        [Createable(false), Updateable(false)]
        public string DeveloperName { get; set; }

        [Display(Name = "Master Language")]
        [Createable(false), Updateable(false)]
        public string Language { get; set; }

        [Display(Name = "External Data Source")]
        [StringLength(80)]
        [Createable(false), Updateable(false)]
        public string MasterLabel { get; set; }

        [Display(Name = "Namespace Prefix")]
        [StringLength(15)]
        [Createable(false), Updateable(false)]
        public string NamespacePrefix { get; set; }

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

        [Display(Name = "Class ID")]
        [Createable(false), Updateable(false)]
        public string Type { get; set; }

        [Display(Name = "URL")]
        [Createable(false), Updateable(false)]
        public string Endpoint { get; set; }

        [Display(Name = "Default External Repository")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string Repository { get; set; }

        [Display(Name = "Identity Type")]
        [Createable(false), Updateable(false)]
        public string PrincipalType { get; set; }

        [Display(Name = "API Key")]
        [StringLength(128)]
        [Createable(false), Updateable(false)]
        public string ApiKey { get; set; }

        [Display(Name = "Static Resource ID")]
        [Createable(false), Updateable(false)]
        public string LargeIconId { get; set; }

        [Display(Name = "Static Resource ID")]
        [Createable(false), Updateable(false)]
        public string SmallIconId { get; set; }

        [Display(Name = "Custom Configuration")]
        [Createable(false), Updateable(false)]
        public string CustomConfiguration { get; set; }

    }
}
