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
    public class ContentWorkspace
    {
        [Key]
        [Display(Name = "Library ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string Name { get; set; }

        [Createable(false), Updateable(false)]
        public string Description { get; set; }

        [Display(Name = "Tag Model")]
        [Createable(false), Updateable(false)]
        public string TagModel { get; set; }

        [Display(Name = "Created By ID")]
        [Createable(false), Updateable(false)]
        public string CreatedById { get; set; }

        [Display(Name = "Created Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset CreatedDate { get; set; }

        [Display(Name = "Last Modified By ID")]
        [Createable(false), Updateable(false)]
        public string LastModifiedById { get; set; }

        [Display(Name = "System Modstamp")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset SystemModstamp { get; set; }

        [Display(Name = "Last Modified Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset LastModifiedDate { get; set; }

        [Display(Name = "Record Type ID")]
        [Createable(false), Updateable(false)]
        public string DefaultRecordTypeId { get; set; }

        [Display(Name = "Restrict Record Types")]
        [Createable(false), Updateable(false)]
        public bool IsRestrictContentTypes { get; set; }

        [Display(Name = "Restrict Linked Record Types")]
        [Createable(false), Updateable(false)]
        public bool IsRestrictLinkedContentTypes { get; set; }

    }
}
