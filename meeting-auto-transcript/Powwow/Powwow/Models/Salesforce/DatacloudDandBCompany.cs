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
    public class DatacloudDandBCompany
    {
        [Key]
        [Display(Name = "D&B Company ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "D&B Company ID")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string ExternalId { get; set; }

        [Display(Name = "D&B Company Name")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string Name { get; set; }

        [Display(Name = "D-U-N-S Number")]
        [StringLength(9)]
        [Createable(false), Updateable(false)]
        public string DunsNumber { get; set; }

        [Display(Name = "D&B Company ID")]
        [StringLength(25)]
        [Createable(false), Updateable(false)]
        public string CompanyId { get; set; }

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

        [Display(Name = "Postal Code")]
        [StringLength(32)]
        [Createable(false), Updateable(false)]
        public string Zip { get; set; }

        [Display(Name = "Telephone Number")]
        [Phone]
        [Createable(false), Updateable(false)]
        public string Phone { get; set; }

        [Display(Name = "Facsimile Number")]
        [Phone]
        [Createable(false), Updateable(false)]
        public string Fax { get; set; }

        [Display(Name = "International Dialing Code")]
        [StringLength(4)]
        [Createable(false), Updateable(false)]
        public string CountryAccessCode { get; set; }

        [Display(Name = "Ownership Type Indicator")]
        [Createable(false), Updateable(false)]
        public string PublicIndicator { get; set; }

        [Display(Name = "Ticker Symbol")]
        [StringLength(6)]
        [Createable(false), Updateable(false)]
        public string StockSymbol { get; set; }

        [Display(Name = "Stock Exchange")]
        [StringLength(16)]
        [Createable(false), Updateable(false)]
        public string StockExchange { get; set; }

        [Display(Name = "Annual Sales Volume")]
        [Createable(false), Updateable(false)]
        public double? SalesVolume { get; set; }

        [Url]
        [Createable(false), Updateable(false)]
        public string URL { get; set; }

        [Display(Name = "Out Of Business Indicator")]
        [Createable(false), Updateable(false)]
        public string OutOfBusiness { get; set; }

        [Display(Name = "Number of Employees - Total")]
        [Createable(false), Updateable(false)]
        public double? EmployeesTotal { get; set; }

        [Display(Name = "FIPS MSA Code")]
        [StringLength(5)]
        [Createable(false), Updateable(false)]
        public string FipsMsaCode { get; set; }

        [Display(Name = "FIPS MSA Code Description")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string FipsMsaDesc { get; set; }

        [Display(Name = "Primary Tradestyle")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string TradeStyle1 { get; set; }

        [Display(Name = "Year Started")]
        [StringLength(4)]
        [Createable(false), Updateable(false)]
        public string YearStarted { get; set; }

        [Display(Name = "Mailing Street Address")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string MailingStreet { get; set; }

        [Display(Name = "Mailing City")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string MailingCity { get; set; }

        [Display(Name = "Mailing State")]
        [StringLength(50)]
        [Createable(false), Updateable(false)]
        public string MailingState { get; set; }

        [Display(Name = "Mailing Country")]
        [StringLength(50)]
        [Createable(false), Updateable(false)]
        public string MailingCountry { get; set; }

        [Display(Name = "Mailing Postal Code")]
        [StringLength(32)]
        [Createable(false), Updateable(false)]
        public string MailingZip { get; set; }

        [StringLength(11)]
        [Createable(false), Updateable(false)]
        public string Latitude { get; set; }

        [StringLength(11)]
        [Createable(false), Updateable(false)]
        public string Longitude { get; set; }

        [Display(Name = "Primary SIC Code")]
        [StringLength(4)]
        [Createable(false), Updateable(false)]
        public string PrimarySic { get; set; }

        [Display(Name = "Primary SIC Description")]
        [StringLength(80)]
        [Createable(false), Updateable(false)]
        public string PrimarySicDesc { get; set; }

        [Display(Name = "Second SIC Code")]
        [StringLength(4)]
        [Createable(false), Updateable(false)]
        public string SecondSic { get; set; }

        [Display(Name = "Second SIC Description")]
        [StringLength(80)]
        [Createable(false), Updateable(false)]
        public string SecondSicDesc { get; set; }

        [Display(Name = "Third SIC Code")]
        [StringLength(4)]
        [Createable(false), Updateable(false)]
        public string ThirdSic { get; set; }

        [Display(Name = "Third SIC Description")]
        [StringLength(80)]
        [Createable(false), Updateable(false)]
        public string ThirdSicDesc { get; set; }

        [Display(Name = "Fourth SIC Code")]
        [StringLength(4)]
        [Createable(false), Updateable(false)]
        public string FourthSic { get; set; }

        [Display(Name = "Fourth SIC Description")]
        [StringLength(80)]
        [Createable(false), Updateable(false)]
        public string FourthSicDesc { get; set; }

        [Display(Name = "Fourth SIC Description")]
        [StringLength(4)]
        [Createable(false), Updateable(false)]
        public string FifthSic { get; set; }

        [Display(Name = "Fifth SIC Description")]
        [StringLength(80)]
        [Createable(false), Updateable(false)]
        public string FifthSicDesc { get; set; }

        [Display(Name = "Sixth SIC Code")]
        [StringLength(4)]
        [Createable(false), Updateable(false)]
        public string SixthSic { get; set; }

        [Display(Name = "Sixth SIC Description")]
        [StringLength(80)]
        [Createable(false), Updateable(false)]
        public string SixthSicDesc { get; set; }

        [Display(Name = "Primary NAICS Code")]
        [StringLength(6)]
        [Createable(false), Updateable(false)]
        public string PrimaryNaics { get; set; }

        [Display(Name = "Primary NAICS Description")]
        [StringLength(120)]
        [Createable(false), Updateable(false)]
        public string PrimaryNaicsDesc { get; set; }

        [Display(Name = "Second NAICS Code")]
        [StringLength(6)]
        [Createable(false), Updateable(false)]
        public string SecondNaics { get; set; }

        [Display(Name = "Second NAICS Description")]
        [StringLength(120)]
        [Createable(false), Updateable(false)]
        public string SecondNaicsDesc { get; set; }

        [Display(Name = "Third NAICS Code")]
        [StringLength(6)]
        [Createable(false), Updateable(false)]
        public string ThirdNaics { get; set; }

        [Display(Name = "Third NAICS Description")]
        [StringLength(120)]
        [Createable(false), Updateable(false)]
        public string ThirdNaicsDesc { get; set; }

        [Display(Name = "Fourth NAICS Code")]
        [StringLength(6)]
        [Createable(false), Updateable(false)]
        public string FourthNaics { get; set; }

        [Display(Name = "Fourth NAICS Description")]
        [StringLength(120)]
        [Createable(false), Updateable(false)]
        public string FourthNaicsDesc { get; set; }

        [Display(Name = "Fifth NAICS Code")]
        [StringLength(6)]
        [Createable(false), Updateable(false)]
        public string FifthNaics { get; set; }

        [Display(Name = "Fifth NAICS Description")]
        [StringLength(120)]
        [Createable(false), Updateable(false)]
        public string FifthNaicsDesc { get; set; }

        [Display(Name = "Sixth NAICS Code")]
        [StringLength(6)]
        [Createable(false), Updateable(false)]
        public string SixthNaics { get; set; }

        [Display(Name = "Sixth NAICS Description")]
        [StringLength(120)]
        [Createable(false), Updateable(false)]
        public string SixthNaicsDesc { get; set; }

        [Display(Name = "Location Ownership Indicator")]
        [Createable(false), Updateable(false)]
        public string OwnOrRent { get; set; }

        [Display(Name = "Number of Employees - Location")]
        [Createable(false), Updateable(false)]
        public double? EmployeesHere { get; set; }

        [Display(Name = "Number of Employees - Location Indicator")]
        [Createable(false), Updateable(false)]
        public string EmployeesHereReliability { get; set; }

        [Display(Name = "Annual Sales Volume Indicator")]
        [Createable(false), Updateable(false)]
        public string SalesVolumeReliability { get; set; }

        [Display(Name = "Local Currency Code")]
        [Createable(false), Updateable(false)]
        public string CurrencyCode { get; set; }

        [Display(Name = "Legal Structure")]
        [Createable(false), Updateable(false)]
        public string LegalStatus { get; set; }

        [Display(Name = "Number of Employees - Global")]
        [Createable(false), Updateable(false)]
        public double? GlobalUltimateTotalEmployees { get; set; }

        [Display(Name = "Number of Employees - Total Indicator")]
        [Createable(false), Updateable(false)]
        public string EmployeesTotalReliability { get; set; }

        [Display(Name = "Minority-Owned Indicator")]
        [Createable(false), Updateable(false)]
        public string MinorityOwned { get; set; }

        [Display(Name = "Woman-Owned Indicator")]
        [Createable(false), Updateable(false)]
        public string WomenOwned { get; set; }

        [Display(Name = "Small Business Indicator")]
        [Createable(false), Updateable(false)]
        public string SmallBusiness { get; set; }

        [Display(Name = "Marketing Segmentation Cluster")]
        [Createable(false), Updateable(false)]
        public string MarketingSegmentationCluster { get; set; }

        [Display(Name = "Import/Export")]
        [Createable(false), Updateable(false)]
        public string ImportExportAgent { get; set; }

        [Display(Name = "Subsidiary Indicator")]
        [Createable(false), Updateable(false)]
        public string Subsidiary { get; set; }

        [Display(Name = "Second Tradestyle")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string TradeStyle2 { get; set; }

        [Display(Name = "Third Tradestyle")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string TradeStyle3 { get; set; }

        [Display(Name = "Fourth Tradestyle")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string TradeStyle4 { get; set; }

        [Display(Name = "Fifth Tradestyle")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string TradeStyle5 { get; set; }

        [Display(Name = "National Identification Number")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string NationalId { get; set; }

        [Display(Name = "National Identification System")]
        [Createable(false), Updateable(false)]
        public string NationalIdType { get; set; }

        [Display(Name = "US Tax ID Number")]
        [StringLength(9)]
        [Createable(false), Updateable(false)]
        public string UsTaxId { get; set; }

        [Display(Name = "Geocode Accuracy")]
        [Createable(false), Updateable(false)]
        public string GeoCodeAccuracy { get; set; }

        [Display(Name = "Number of Business Family Members")]
        [Createable(false), Updateable(false)]
        public int? FamilyMembers { get; set; }

        [Display(Name = "Delinquency Risk")]
        [Createable(false), Updateable(false)]
        public string MarketingPreScreen { get; set; }

        [Display(Name = "Global Ultimate D-U-N-S Number")]
        [StringLength(9)]
        [Createable(false), Updateable(false)]
        public string GlobalUltimateDunsNumber { get; set; }

        [Display(Name = "Global Ultimate Business Name")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string GlobalUltimateBusinessName { get; set; }

        [Display(Name = "Parent Company D-U-N-S Number")]
        [StringLength(9)]
        [Createable(false), Updateable(false)]
        public string ParentOrHqDunsNumber { get; set; }

        [Display(Name = "Parent Company Business Name")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string ParentOrHqBusinessName { get; set; }

        [Display(Name = "Domestic Ultimate D-U-N-S Number")]
        [StringLength(9)]
        [Createable(false), Updateable(false)]
        public string DomesticUltimateDunsNumber { get; set; }

        [Display(Name = "Domestic Ultimate Business Name")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string DomesticUltimateBusinessName { get; set; }

        [Display(Name = "Location Type")]
        [Createable(false), Updateable(false)]
        public string LocationStatus { get; set; }

        [Display(Name = "Local Currency ISO Code")]
        [Createable(false), Updateable(false)]
        public string CompanyCurrencyIsoCode { get; set; }

        [Display(Name = "Company Description")]
        [StringLength(1000)]
        [Createable(false), Updateable(false)]
        public string Description { get; set; }

        [Display(Name = "Owned Status")]
        [Createable(false), Updateable(false)]
        public bool IsOwned { get; set; }

        [Display(Name = "Parent")]
        [Createable(false), Updateable(false)]
        public bool IsParent { get; set; }

    }
}
