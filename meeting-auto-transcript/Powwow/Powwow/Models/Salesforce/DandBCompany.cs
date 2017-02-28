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
    public class DandBCompany
    {
        [Key]
        [Display(Name = "D&B Company ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Deleted")]
        [Createable(false), Updateable(false)]
        public bool IsDeleted { get; set; }

        [Display(Name = "Primary Business Name")]
        [StringLength(255)]
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

        [Display(Name = "D-U-N-S Number")]
        [StringLength(9)]
        public string DunsNumber { get; set; }

        [Display(Name = "Street Address")]
        public string Street { get; set; }

        [StringLength(40)]
        public string City { get; set; }

        [StringLength(80)]
        public string State { get; set; }

        [Display(Name = "Postal Code")]
        [StringLength(20)]
        public string PostalCode { get; set; }

        [StringLength(80)]
        public string Country { get; set; }

        [Display(Name = "Telephone Number")]
        [Phone]
        public string Phone { get; set; }

        [Display(Name = "Facsimile Number")]
        [Phone]
        public string Fax { get; set; }

        [Display(Name = "International Dialing Code")]
        [StringLength(4)]
        public string CountryAccessCode { get; set; }

        [Display(Name = "Ownership Type Indicator")]
        public string PublicIndicator { get; set; }

        [Display(Name = "Ticker Symbol")]
        [StringLength(6)]
        public string StockSymbol { get; set; }

        [Display(Name = "Stock Exchange")]
        [StringLength(16)]
        public string StockExchange { get; set; }

        [Display(Name = "Annual Sales Volume")]
        public double? SalesVolume { get; set; }

        [Url]
        public string URL { get; set; }

        [Display(Name = "Out Of Business Indicator")]
        public string OutOfBusiness { get; set; }

        [Display(Name = "Number of Employees - Total")]
        public double? EmployeesTotal { get; set; }

        [Display(Name = "FIPS MSA Code")]
        [StringLength(5)]
        public string FipsMsaCode { get; set; }

        [Display(Name = "FIPS MSA Code Description")]
        [StringLength(255)]
        public string FipsMsaDesc { get; set; }

        [Display(Name = "Primary Tradestyle")]
        [StringLength(255)]
        public string TradeStyle1 { get; set; }

        [Display(Name = "Year Started")]
        [StringLength(4)]
        public string YearStarted { get; set; }

        [Display(Name = "Mailing Street Address")]
        public string MailingStreet { get; set; }

        [Display(Name = "Mailing City")]
        [StringLength(40)]
        public string MailingCity { get; set; }

        [Display(Name = "Mailing State")]
        [StringLength(80)]
        public string MailingState { get; set; }

        [Display(Name = "Mailing Postal Code")]
        [StringLength(20)]
        public string MailingPostalCode { get; set; }

        [Display(Name = "Mailing Country")]
        [StringLength(80)]
        public string MailingCountry { get; set; }

        [StringLength(11)]
        public string Latitude { get; set; }

        [StringLength(11)]
        public string Longitude { get; set; }

        [Display(Name = "Primary SIC Code")]
        [StringLength(4)]
        public string PrimarySic { get; set; }

        [Display(Name = "Primary SIC Description")]
        [StringLength(80)]
        public string PrimarySicDesc { get; set; }

        [Display(Name = "Second SIC Code")]
        [StringLength(4)]
        public string SecondSic { get; set; }

        [Display(Name = "Second SIC Description")]
        [StringLength(80)]
        public string SecondSicDesc { get; set; }

        [Display(Name = "Third SIC Code")]
        [StringLength(4)]
        public string ThirdSic { get; set; }

        [Display(Name = "Third SIC Description")]
        [StringLength(80)]
        public string ThirdSicDesc { get; set; }

        [Display(Name = "Fourth SIC Code")]
        [StringLength(4)]
        public string FourthSic { get; set; }

        [Display(Name = "Fourth SIC Description")]
        [StringLength(80)]
        public string FourthSicDesc { get; set; }

        [Display(Name = "Fifth SIC Code")]
        [StringLength(4)]
        public string FifthSic { get; set; }

        [Display(Name = "Fifth SIC Description")]
        [StringLength(80)]
        public string FifthSicDesc { get; set; }

        [Display(Name = "Sixth SIC Code")]
        [StringLength(4)]
        public string SixthSic { get; set; }

        [Display(Name = "Sixth SIC Description")]
        [StringLength(80)]
        public string SixthSicDesc { get; set; }

        [Display(Name = "Primary NAICS Code")]
        [StringLength(6)]
        public string PrimaryNaics { get; set; }

        [Display(Name = "Primary NAICS Description")]
        [StringLength(120)]
        public string PrimaryNaicsDesc { get; set; }

        [Display(Name = "Second NAICS Code")]
        [StringLength(6)]
        public string SecondNaics { get; set; }

        [Display(Name = "Second NAICS Description")]
        [StringLength(120)]
        public string SecondNaicsDesc { get; set; }

        [Display(Name = "Third NAICS Code")]
        [StringLength(6)]
        public string ThirdNaics { get; set; }

        [Display(Name = "Third NAICS Description")]
        [StringLength(120)]
        public string ThirdNaicsDesc { get; set; }

        [Display(Name = "Fourth NAICS Code")]
        [StringLength(6)]
        public string FourthNaics { get; set; }

        [Display(Name = "Fourth NAICS Description")]
        [StringLength(120)]
        public string FourthNaicsDesc { get; set; }

        [Display(Name = "Fifth NAICS Code")]
        [StringLength(6)]
        public string FifthNaics { get; set; }

        [Display(Name = "Fifth NAICS Description")]
        [StringLength(120)]
        public string FifthNaicsDesc { get; set; }

        [Display(Name = "Sixth NAICS Code")]
        [StringLength(6)]
        public string SixthNaics { get; set; }

        [Display(Name = "Sixth NAICS Description")]
        [StringLength(120)]
        public string SixthNaicsDesc { get; set; }

        [Display(Name = "Location Ownership Indicator")]
        public string OwnOrRent { get; set; }

        [Display(Name = "Number of Employees - Location")]
        public double? EmployeesHere { get; set; }

        [Display(Name = "Number of Employees - Location Indicator")]
        public string EmployeesHereReliability { get; set; }

        [Display(Name = "Annual Sales Volume Indicator")]
        public string SalesVolumeReliability { get; set; }

        [Display(Name = "Local Currency Code")]
        public string CurrencyCode { get; set; }

        [Display(Name = "Legal Structure")]
        public string LegalStatus { get; set; }

        [Display(Name = "Number of Employees - Global")]
        public double? GlobalUltimateTotalEmployees { get; set; }

        [Display(Name = "Number of Employees - Total Indicator")]
        public string EmployeesTotalReliability { get; set; }

        [Display(Name = "Minority-Owned Indicator")]
        public string MinorityOwned { get; set; }

        [Display(Name = "Woman-Owned Indicator")]
        public string WomenOwned { get; set; }

        [Display(Name = "Small Business Indicator")]
        public string SmallBusiness { get; set; }

        [Display(Name = "Marketing Segmentation Cluster")]
        public string MarketingSegmentationCluster { get; set; }

        [Display(Name = "Import/Export")]
        public string ImportExportAgent { get; set; }

        [Display(Name = "Subsidiary Indicator")]
        public string Subsidiary { get; set; }

        [Display(Name = "Second Tradestyle")]
        [StringLength(255)]
        public string TradeStyle2 { get; set; }

        [Display(Name = "Third Tradestyle")]
        [StringLength(255)]
        public string TradeStyle3 { get; set; }

        [Display(Name = "Fourth Tradestyle")]
        [StringLength(255)]
        public string TradeStyle4 { get; set; }

        [Display(Name = "Fifth Tradestyle")]
        [StringLength(255)]
        public string TradeStyle5 { get; set; }

        [Display(Name = "National Identification Number")]
        [StringLength(255)]
        public string NationalId { get; set; }

        [Display(Name = "National Identification System")]
        public string NationalIdType { get; set; }

        [Display(Name = "US Tax ID Number")]
        [StringLength(9)]
        public string UsTaxId { get; set; }

        [Display(Name = "Geocode Accuracy")]
        public string GeoCodeAccuracy { get; set; }

        [Display(Name = "Number of Business Family Members")]
        public int? FamilyMembers { get; set; }

        [Display(Name = "Delinquency Risk")]
        public string MarketingPreScreen { get; set; }

        [Display(Name = "Global Ultimate D-U-N-S Number")]
        [StringLength(9)]
        public string GlobalUltimateDunsNumber { get; set; }

        [Display(Name = "Global Ultimate Business Name")]
        [StringLength(255)]
        public string GlobalUltimateBusinessName { get; set; }

        [Display(Name = "Parent Company D-U-N-S Number")]
        [StringLength(9)]
        public string ParentOrHqDunsNumber { get; set; }

        [Display(Name = "Parent Company Business Name")]
        [StringLength(255)]
        public string ParentOrHqBusinessName { get; set; }

        [Display(Name = "Domestic Ultimate D-U-N-S Number")]
        [StringLength(9)]
        public string DomesticUltimateDunsNumber { get; set; }

        [Display(Name = "Domestic Ultimate Business Name")]
        [StringLength(255)]
        public string DomesticUltimateBusinessName { get; set; }

        [Display(Name = "Location Type")]
        public string LocationStatus { get; set; }

        [Display(Name = "Local Currency ISO Code")]
        public string CompanyCurrencyIsoCode { get; set; }

        [Display(Name = "Company Description")]
        public string Description { get; set; }

    }
}
