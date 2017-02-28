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
    public class ContentDocumentLink
    {
        [Key]
        [Display(Name = "ContentDocumentLink ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Linked Entity ID")]
        [Updateable(false)]
        public string LinkedEntityId { get; set; }

        [Display(Name = "ContentDocument ID")]
        [Updateable(false)]
        public string ContentDocumentId { get; set; }

        [Display(Name = "Is Deleted")]
        [Createable(false), Updateable(false)]
        public bool IsDeleted { get; set; }

        [Display(Name = "System Modstamp")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset SystemModstamp { get; set; }

        [Display(Name = "Share Type")]
        public string ShareType { get; set; }

        [Updateable(false)]
        public string Visibility { get; set; }

    }
}
