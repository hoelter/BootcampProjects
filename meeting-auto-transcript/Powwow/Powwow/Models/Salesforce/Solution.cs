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
    public class Solution
    {
        [Key]
        [Display(Name = "Solution ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Deleted")]
        [Createable(false), Updateable(false)]
        public bool IsDeleted { get; set; }

        [Display(Name = "Solution Number")]
        [StringLength(30)]
        [Createable(false), Updateable(false)]
        public string SolutionNumber { get; set; }

        [Display(Name = "Title")]
        [StringLength(255)]
        public string SolutionName { get; set; }

        [Display(Name = "Public")]
        public bool IsPublished { get; set; }

        [Display(Name = "Visible in Public Knowledge Base")]
        public bool IsPublishedInPublicKb { get; set; }

        public string Status { get; set; }

        [Display(Name = "Reviewed")]
        [Createable(false), Updateable(false)]
        public bool IsReviewed { get; set; }

        [Display(Name = "Description")]
        public string SolutionNote { get; set; }

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

        [Display(Name = "Num Related Cases")]
        [Createable(false), Updateable(false)]
        public int TimesUsed { get; set; }

        [Display(Name = "Last Viewed Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? LastViewedDate { get; set; }

        [Display(Name = "Last Referenced Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? LastReferencedDate { get; set; }

        [Display(Name = "Is Html")]
        [Createable(false), Updateable(false)]
        public bool IsHtml { get; set; }

    }
}
