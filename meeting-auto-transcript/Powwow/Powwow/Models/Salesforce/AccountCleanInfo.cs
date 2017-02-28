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
    public class AccountCleanInfo
    {
        [Key]
        [Display(Name = "Account Clean Info ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Deleted")]
        [Createable(false), Updateable(false)]
        public bool IsDeleted { get; set; }

        [Display(Name = "Account Clean Info Name")]
        [StringLength(255)]
        [Createable(false)]
        public string Name { get; set; }

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

        [Display(Name = "Account ID")]
        [Createable(false), Updateable(false)]
        public string AccountId { get; set; }

        [Display(Name = "Last Matched Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset LastMatchedDate { get; set; }

        [Display(Name = "Last Status Changed Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? LastStatusChangedDate { get; set; }

        [Display(Name = "User ID")]
        [Createable(false), Updateable(false)]
        public string LastStatusChangedById { get; set; }

        [Display(Name = "Company Status in Salesforce")]
        [Createable(false)]
        public bool IsInactive { get; set; }

        [Display(Name = "Company Name")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string CompanyName { get; set; }

        [Phone]
        [Createable(false), Updateable(false)]
        public string Phone { get; set; }

        [Createable(false), Updateable(false)]
        public string Street { get; set; }

        [StringLength(40)]
        [Createable(false), Updateable(false)]
        public string City { get; set; }

        [StringLength(80)]
        [Createable(false), Updateable(false)]
        public string State { get; set; }

        [Display(Name = "Zip")]
        [StringLength(20)]
        [Createable(false), Updateable(false)]
        public string PostalCode { get; set; }

        [StringLength(80)]
        [Createable(false), Updateable(false)]
        public string Country { get; set; }

        [Createable(false), Updateable(false)]
        public double? Latitude { get; set; }

        [Createable(false), Updateable(false)]
        public double? Longitude { get; set; }

        [Url]
        [Createable(false), Updateable(false)]
        public string Website { get; set; }

        [Display(Name = "Ticker Symbol")]
        [StringLength(20)]
        [Createable(false), Updateable(false)]
        public string TickerSymbol { get; set; }

        [Display(Name = "Annual Revenue")]
        [Createable(false), Updateable(false)]
        public double? AnnualRevenue { get; set; }

        [Display(Name = "Number of Employees")]
        [Createable(false), Updateable(false)]
        public int? NumberOfEmployees { get; set; }

        [Createable(false), Updateable(false)]
        public string Industry { get; set; }

        [Createable(false), Updateable(false)]
        public string Ownership { get; set; }

        [Display(Name = "D-U-N-S Number")]
        [StringLength(9)]
        [Createable(false), Updateable(false)]
        public string DunsNumber { get; set; }

        [Display(Name = "SIC Code")]
        [StringLength(20)]
        [Createable(false), Updateable(false)]
        public string Sic { get; set; }

        [Display(Name = "SIC Description")]
        [StringLength(80)]
        [Createable(false), Updateable(false)]
        public string SicDescription { get; set; }

        [Display(Name = "NAICS Code")]
        [StringLength(8)]
        [Createable(false), Updateable(false)]
        public string NaicsCode { get; set; }

        [Display(Name = "NAICS Description")]
        [StringLength(120)]
        [Createable(false), Updateable(false)]
        public string NaicsDescription { get; set; }

        [Display(Name = "Year Started")]
        [StringLength(12)]
        [Createable(false), Updateable(false)]
        public string YearStarted { get; set; }

        [Phone]
        [Createable(false), Updateable(false)]
        public string Fax { get; set; }

        [Display(Name = "Account Site")]
        [StringLength(80)]
        [Createable(false), Updateable(false)]
        public string AccountSite { get; set; }

        [Createable(false), Updateable(false)]
        public string Description { get; set; }

        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string Tradestyle { get; set; }

        [Display(Name = "D&B Company D-U-N-S Number")]
        [StringLength(9)]
        [Createable(false), Updateable(false)]
        public string DandBCompanyDunsNumber { get; set; }

        [Display(Name = "DUNSRight™ Match Grade")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string DunsRightMatchGrade { get; set; }

        [Display(Name = "DUNSRight™ Match Confidence")]
        [Createable(false), Updateable(false)]
        public int? DunsRightMatchConfidence { get; set; }

        [Display(Name = "Company Status per Data.com")]
        [Createable(false), Updateable(false)]
        public string CompanyStatusDataDotCom { get; set; }

        [Display(Name = "Company Name is Reviewed")]
        [Createable(false)]
        public bool IsReviewedCompanyName { get; set; }

        [Display(Name = "Phone is Reviewed")]
        [Createable(false)]
        public bool IsReviewedPhone { get; set; }

        [Display(Name = "Address is Reviewed")]
        [Createable(false)]
        public bool IsReviewedAddress { get; set; }

        [Display(Name = "Website is Reviewed")]
        [Createable(false)]
        public bool IsReviewedWebsite { get; set; }

        [Display(Name = "Ticker Symbol is Reviewed")]
        [Createable(false)]
        public bool IsReviewedTickerSymbol { get; set; }

        [Display(Name = "Annual Revenue is Reviewed")]
        [Createable(false)]
        public bool IsReviewedAnnualRevenue { get; set; }

        [Display(Name = "Number of Employees is Reviewed")]
        [Createable(false)]
        public bool IsReviewedNumberOfEmployees { get; set; }

        [Display(Name = "Industry is Reviewed")]
        [Createable(false)]
        public bool IsReviewedIndustry { get; set; }

        [Display(Name = "Ownership is Reviewed")]
        [Createable(false)]
        public bool IsReviewedOwnership { get; set; }

        [Display(Name = "D-U-N-S Number is Reviewed")]
        [Createable(false)]
        public bool IsReviewedDunsNumber { get; set; }

        [Display(Name = "SIC Code is Reviewed")]
        [Createable(false)]
        public bool IsReviewedSic { get; set; }

        [Display(Name = "SIC Description is Reviewed")]
        [Createable(false)]
        public bool IsReviewedSicDescription { get; set; }

        [Display(Name = "NAICS Code is Reviewed")]
        [Createable(false)]
        public bool IsReviewedNaicsCode { get; set; }

        [Display(Name = "NAICS Description is Reviewed")]
        [Createable(false)]
        public bool IsReviewedNaicsDescription { get; set; }

        [Display(Name = "Year Started is Reviewed")]
        [Createable(false)]
        public bool IsReviewedYearStarted { get; set; }

        [Display(Name = "Fax is Reviewed")]
        [Createable(false)]
        public bool IsReviewedFax { get; set; }

        [Display(Name = "Account Site is Reviewed")]
        [Createable(false)]
        public bool IsReviewedAccountSite { get; set; }

        [Display(Name = "Description is Reviewed")]
        [Createable(false)]
        public bool IsReviewedDescription { get; set; }

        [Display(Name = "Tradestyle is Reviewed")]
        [Createable(false)]
        public bool IsReviewedTradestyle { get; set; }

        [Display(Name = "D&B Company D-U-N-S Number is Reviewed")]
        [Createable(false)]
        public bool IsReviewedDandBCompanyDunsNumber { get; set; }

        [Display(Name = "Company Name is Different")]
        [Createable(false), Updateable(false)]
        public bool IsDifferentCompanyName { get; set; }

        [Display(Name = "Phone is Different")]
        [Createable(false), Updateable(false)]
        public bool IsDifferentPhone { get; set; }

        [Display(Name = "Street is Different")]
        [Createable(false), Updateable(false)]
        public bool IsDifferentStreet { get; set; }

        [Display(Name = "City is Different")]
        [Createable(false), Updateable(false)]
        public bool IsDifferentCity { get; set; }

        [Display(Name = "State is Different")]
        [Createable(false), Updateable(false)]
        public bool IsDifferentState { get; set; }

        [Display(Name = "ZIP is Different")]
        [Createable(false), Updateable(false)]
        public bool IsDifferentPostalCode { get; set; }

        [Display(Name = "Country is Different")]
        [Createable(false), Updateable(false)]
        public bool IsDifferentCountry { get; set; }

        [Display(Name = "Website is Different")]
        [Createable(false), Updateable(false)]
        public bool IsDifferentWebsite { get; set; }

        [Display(Name = "Ticker Symbol is Different")]
        [Createable(false), Updateable(false)]
        public bool IsDifferentTickerSymbol { get; set; }

        [Display(Name = "Annual Revenue is Different")]
        [Createable(false), Updateable(false)]
        public bool IsDifferentAnnualRevenue { get; set; }

        [Display(Name = "Number of Employees is Different")]
        [Createable(false), Updateable(false)]
        public bool IsDifferentNumberOfEmployees { get; set; }

        [Display(Name = "Industry is Different")]
        [Createable(false), Updateable(false)]
        public bool IsDifferentIndustry { get; set; }

        [Display(Name = "Ownership is Different")]
        [Createable(false), Updateable(false)]
        public bool IsDifferentOwnership { get; set; }

        [Display(Name = "D-U-N-S Number is Different")]
        [Createable(false), Updateable(false)]
        public bool IsDifferentDunsNumber { get; set; }

        [Display(Name = "SIC Code is Different")]
        [Createable(false), Updateable(false)]
        public bool IsDifferentSic { get; set; }

        [Display(Name = "SIC Description is Different")]
        [Createable(false), Updateable(false)]
        public bool IsDifferentSicDescription { get; set; }

        [Display(Name = "NAICS Code is Different")]
        [Createable(false), Updateable(false)]
        public bool IsDifferentNaicsCode { get; set; }

        [Display(Name = "NAICS Description is Different")]
        [Createable(false), Updateable(false)]
        public bool IsDifferentNaicsDescription { get; set; }

        [Display(Name = "Year Started is Different")]
        [Createable(false), Updateable(false)]
        public bool IsDifferentYearStarted { get; set; }

        [Display(Name = "Fax is Different")]
        [Createable(false), Updateable(false)]
        public bool IsDifferentFax { get; set; }

        [Display(Name = "Account Site is Different")]
        [Createable(false), Updateable(false)]
        public bool IsDifferentAccountSite { get; set; }

        [Display(Name = "Description is Different")]
        [Createable(false), Updateable(false)]
        public bool IsDifferentDescription { get; set; }

        [Display(Name = "Tradestyle is Different")]
        [Createable(false), Updateable(false)]
        public bool IsDifferentTradestyle { get; set; }

        [Display(Name = "D&B Company D-U-N-S Number is Different")]
        [Createable(false), Updateable(false)]
        public bool IsDifferentDandBCompanyDunsNumber { get; set; }

        [Display(Name = "State Code is Different")]
        [Createable(false), Updateable(false)]
        public bool IsDifferentStateCode { get; set; }

        [Display(Name = "Country Code is Different")]
        [Createable(false), Updateable(false)]
        public bool IsDifferentCountryCode { get; set; }

        [Display(Name = "Cleaned by Job")]
        [Createable(false), Updateable(false)]
        public bool CleanedByJob { get; set; }

        [Display(Name = "Cleaned by User")]
        [Createable(false), Updateable(false)]
        public bool CleanedByUser { get; set; }

        [Display(Name = "Company Name is Flagged Wrong")]
        [Createable(false)]
        public bool IsFlaggedWrongCompanyName { get; set; }

        [Display(Name = "Phone is Flagged Wrong")]
        [Createable(false)]
        public bool IsFlaggedWrongPhone { get; set; }

        [Display(Name = "Address is Flagged Wrong")]
        [Createable(false)]
        public bool IsFlaggedWrongAddress { get; set; }

        [Display(Name = "Website is Flagged Wrong")]
        [Createable(false)]
        public bool IsFlaggedWrongWebsite { get; set; }

        [Display(Name = "Ticker Symbol is Flagged Wrong")]
        [Createable(false)]
        public bool IsFlaggedWrongTickerSymbol { get; set; }

        [Display(Name = "Annual Revenue is Flagged Wrong")]
        [Createable(false)]
        public bool IsFlaggedWrongAnnualRevenue { get; set; }

        [Display(Name = "Number of Employees is Flagged Wrong")]
        [Createable(false)]
        public bool IsFlaggedWrongNumberOfEmployees { get; set; }

        [Display(Name = "Industry is Flagged Wrong")]
        [Createable(false)]
        public bool IsFlaggedWrongIndustry { get; set; }

        [Display(Name = "Ownership is Flagged Wrong")]
        [Createable(false)]
        public bool IsFlaggedWrongOwnership { get; set; }

        [Display(Name = "D-U-N-S Number is Flagged Wrong")]
        [Createable(false)]
        public bool IsFlaggedWrongDunsNumber { get; set; }

        [Display(Name = "SIC Code is Flagged Wrong")]
        [Createable(false)]
        public bool IsFlaggedWrongSic { get; set; }

        [Display(Name = "SIC Description is Flagged Wrong")]
        [Createable(false)]
        public bool IsFlaggedWrongSicDescription { get; set; }

        [Display(Name = "NAICS Code is Flagged Wrong")]
        [Createable(false)]
        public bool IsFlaggedWrongNaicsCode { get; set; }

        [Display(Name = "NAICS Description is Flagged Wrong")]
        [Createable(false)]
        public bool IsFlaggedWrongNaicsDescription { get; set; }

        [Display(Name = "Year Started is Flagged Wrong")]
        [Createable(false)]
        public bool IsFlaggedWrongYearStarted { get; set; }

        [Display(Name = "Fax is Flagged Wrong")]
        [Createable(false)]
        public bool IsFlaggedWrongFax { get; set; }

        [Display(Name = "Account Site is Flagged Wrong")]
        [Createable(false)]
        public bool IsFlaggedWrongAccountSite { get; set; }

        [Display(Name = "Description is Flagged Wrong")]
        [Createable(false)]
        public bool IsFlaggedWrongDescription { get; set; }

        [Display(Name = "Tradestyle is Flagged Wrong")]
        [Createable(false)]
        public bool IsFlaggedWrongTradestyle { get; set; }

        [Display(Name = "Data.com ID")]
        [StringLength(20)]
        [Createable(false), Updateable(false)]
        public string DataDotComId { get; set; }

    }
}
