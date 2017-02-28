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
    public class WebLink
    {
        [Key]
        [Display(Name = "Custom Link ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Page Or sObject Type Name")]
        [Updateable(false)]
        public string PageOrSobjectType { get; set; }

        [StringLength(240)]
        public string Name { get; set; }

        [Display(Name = "Protected Component")]
        public bool IsProtected { get; set; }

        [Display(Name = "URL")]
        public string Url { get; set; }

        [Display(Name = "Link Encoding")]
        public string EncodingKey { get; set; }

        [Display(Name = "Content Source")]
        public string LinkType { get; set; }

        [Display(Name = "Behavior")]
        public string OpenType { get; set; }

        [Display(Name = "Height (in pixels)")]
        public int? Height { get; set; }

        [Display(Name = "Width (in pixels)")]
        public int? Width { get; set; }

        [Display(Name = "Show Address Bar")]
        public bool ShowsLocation { get; set; }

        [Display(Name = "Show Scrollbars")]
        public bool HasScrollbars { get; set; }

        [Display(Name = "Show Toolbars")]
        public bool HasToolbar { get; set; }

        [Display(Name = "Show Menu Bar")]
        public bool HasMenubar { get; set; }

        [Display(Name = "Show Status Bar")]
        public bool ShowsStatus { get; set; }

        [Display(Name = "Resizeable")]
        public bool IsResizable { get; set; }

        [Display(Name = "Window Position")]
        public string Position { get; set; }

        [Display(Name = "Custom S-Control ID")]
        public string ScontrolId { get; set; }

        [Display(Name = "Label")]
        [StringLength(240)]
        public string MasterLabel { get; set; }

        public string Description { get; set; }

        [Display(Name = "Display Type")]
        public string DisplayType { get; set; }

        [Display(Name = "Require Row Selection")]
        public bool RequireRowSelection { get; set; }

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

    }
}
