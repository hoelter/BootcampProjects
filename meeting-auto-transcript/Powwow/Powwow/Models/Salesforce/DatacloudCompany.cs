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
    public class DatacloudCompany
    {
        [Key]
        [Display(Name = "System ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Data.com Company ID")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string ExternalId { get; set; }

        [Display(Name = "Data.com Company ID")]
        [StringLength(25)]
        [Createable(false), Updateable(false)]
        public string CompanyId { get; set; }

        [Display(Name = "Company Name")]
        [StringLength(128)]
        [Createable(false), Updateable(false)]
        public string Name { get; set; }

        [Display(Name = "Company Synopsis")]
        [StringLength(400)]
        [Createable(false), Updateable(false)]
        public string Description { get; set; }

        [Display(Name = "Inactive Status")]
        [Createable(false), Updateable(false)]
        public bool IsInactive { get; set; }

        [Display(Name = "Phone Number")]
        [Phone]
        [Createable(false), Updateable(false)]
        public string Phone { get; set; }

        [Display(Name = "Fax Number")]
        [Phone]
        [Createable(false), Updateable(false)]
        public string Fax { get; set; }

        [Display(Name = "Street Address")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string Street { get; set; }

        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string City { get; set; }

        [StringLength(50)]
        [Createable(false), Updateable(false)]
        public string State { get; set; }

        [StringLength(50)]
        [Createable(false), Updateable(false)]
        public string Country { get; set; }

        [StringLength(32)]
        [Createable(false), Updateable(false)]
        public string Zip { get; set; }

        [Display(Name = "Company Location")]
        [StringLength(128)]
        [Createable(false), Updateable(false)]
        public string Site { get; set; }

        [StringLength(128)]
        [Createable(false), Updateable(false)]
        public string Industry { get; set; }

        [Display(Name = "Employee Count")]
        [Createable(false), Updateable(false)]
        public int? NumberOfEmployees { get; set; }

        [Display(Name = "Annual Revenue")]
        [Createable(false), Updateable(false)]
        public double? AnnualRevenue { get; set; }

        [Display(Name = "Duns Number")]
        [StringLength(128)]
        [Createable(false), Updateable(false)]
        public string DunsNumber { get; set; }

        [Display(Name = "NAICS Code")]
        [StringLength(128)]
        [Createable(false), Updateable(false)]
        public string NaicsCode { get; set; }

        [Display(Name = "NAICS Description")]
        [StringLength(128)]
        [Createable(false), Updateable(false)]
        public string NaicsDesc { get; set; }

        [Display(Name = "SIC Code")]
        [StringLength(128)]
        [Createable(false), Updateable(false)]
        public string Sic { get; set; }

        [Display(Name = "SIC Description")]
        [StringLength(128)]
        [Createable(false), Updateable(false)]
        public string SicDesc { get; set; }

        [Display(Name = "Ownership Status")]
        [StringLength(16)]
        [Createable(false), Updateable(false)]
        public string Ownership { get; set; }

        [Display(Name = "Owned Status")]
        [Createable(false), Updateable(false)]
        public bool IsOwned { get; set; }

        [Display(Name = "Stock Ticker Symbol")]
        [StringLength(16)]
        [Createable(false), Updateable(false)]
        public string TickerSymbol { get; set; }

        [Display(Name = "Trade Style")]
        [StringLength(128)]
        [Createable(false), Updateable(false)]
        public string TradeStyle { get; set; }

        [Url]
        [Createable(false), Updateable(false)]
        public string Website { get; set; }

        [Display(Name = "Company Founding Date")]
        [StringLength(4)]
        [Createable(false), Updateable(false)]
        public string YearStarted { get; set; }

        [Display(Name = "Active Contacts")]
        [Createable(false), Updateable(false)]
        public int? ActiveContacts { get; set; }

        [Display(Name = "Updated Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? UpdatedDate { get; set; }

    }
}
