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
    public class ContentWorkspaceDoc
    {
        [Key]
        [Display(Name = "Library Document ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Library ID")]
        [Updateable(false)]
        public string ContentWorkspaceId { get; set; }

        [Display(Name = "ContentDocument ID")]
        [Updateable(false)]
        public string ContentDocumentId { get; set; }

        [Display(Name = "Created Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset CreatedDate { get; set; }

        [Display(Name = "System Modstamp")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset SystemModstamp { get; set; }

        [Display(Name = "Is Owning Library")]
        [Createable(false), Updateable(false)]
        public bool IsOwner { get; set; }

        [Display(Name = "Is Deleted")]
        [Createable(false), Updateable(false)]
        public bool IsDeleted { get; set; }

    }
}
