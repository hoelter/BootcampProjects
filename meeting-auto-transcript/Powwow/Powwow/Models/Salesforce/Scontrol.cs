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
    public class Scontrol
    {
        [Key]
        [Display(Name = "Custom S-Control ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Label")]
        [StringLength(80)]
        [Createable(false)]
        public string Name { get; set; }

        [Display(Name = "S-Control Name")]
        [StringLength(80)]
        [Createable(false)]
        public string DeveloperName { get; set; }

        [StringLength(255)]
        [Createable(false)]
        public string Description { get; set; }

        [Display(Name = "Encoding")]
        [Createable(false)]
        public string EncodingKey { get; set; }

        [Display(Name = "HTML Body")]
        [Createable(false)]
        public string HtmlWrapper { get; set; }

        [StringLength(255)]
        [Createable(false)]
        public string Filename { get; set; }

        [Display(Name = "Binary Length")]
        [Createable(false), Updateable(false)]
        public int BodyLength { get; set; }

        [Createable(false)]
        public byte[] Binary { get; set; }

        [Display(Name = "Type")]
        [Createable(false)]
        public string ContentSource { get; set; }

        [Display(Name = "Prebuild In Page")]
        [Createable(false)]
        public bool SupportsCaching { get; set; }

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
