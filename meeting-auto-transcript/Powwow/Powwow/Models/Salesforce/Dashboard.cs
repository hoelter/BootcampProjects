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
    public class Dashboard
    {
        [Key]
        [Display(Name = "Dashboard ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Deleted")]
        [Createable(false), Updateable(false)]
        public bool IsDeleted { get; set; }

        [Display(Name = "Folder ID")]
        [Createable(false), Updateable(false)]
        public string FolderId { get; set; }

        [StringLength(80)]
        [Createable(false), Updateable(false)]
        public string Title { get; set; }

        [Display(Name = "Dashboard Unique Name")]
        [StringLength(80)]
        [Createable(false), Updateable(false)]
        public string DeveloperName { get; set; }

        [Display(Name = "Namespace Prefix")]
        [StringLength(15)]
        [Createable(false), Updateable(false)]
        public string NamespacePrefix { get; set; }

        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string Description { get; set; }

        [Display(Name = "Left Size")]
        [Createable(false), Updateable(false)]
        public string LeftSize { get; set; }

        [Display(Name = "Middle Size")]
        [Createable(false), Updateable(false)]
        public string MiddleSize { get; set; }

        [Display(Name = "Right Size")]
        [Createable(false), Updateable(false)]
        public string RightSize { get; set; }

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

        [Display(Name = "Running User ID")]
        [Createable(false), Updateable(false)]
        public string RunningUserId { get; set; }

        [Display(Name = "Title Color")]
        [Createable(false), Updateable(false)]
        public int TitleColor { get; set; }

        [Display(Name = "Title Size")]
        [Createable(false), Updateable(false)]
        public int TitleSize { get; set; }

        [Display(Name = "Text Color")]
        [Createable(false), Updateable(false)]
        public int TextColor { get; set; }

        [Display(Name = "Starting Color")]
        [Createable(false), Updateable(false)]
        public int BackgroundStart { get; set; }

        [Display(Name = "Ending Color")]
        [Createable(false), Updateable(false)]
        public int BackgroundEnd { get; set; }

        [Display(Name = "Background Fade Direction")]
        [Createable(false), Updateable(false)]
        public string BackgroundDirection { get; set; }

        [Display(Name = "Dashboard Running User")]
        [Createable(false), Updateable(false)]
        public string Type { get; set; }

        [Display(Name = "Last Viewed Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? LastViewedDate { get; set; }

        [Display(Name = "Last Referenced Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? LastReferencedDate { get; set; }

        [Display(Name = "Last refreshed for this user")]
        [StringLength(256)]
        [Createable(false), Updateable(false)]
        public string DashboardResultRefreshedDate { get; set; }

        [Display(Name = "Running as")]
        [StringLength(256)]
        [Createable(false), Updateable(false)]
        public string DashboardResultRunningUser { get; set; }

    }
}
