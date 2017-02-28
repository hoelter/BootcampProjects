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
    public class LeadCleanInfo
    {
        [Key]
        [Display(Name = "Lead Clean Info ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Deleted")]
        [Createable(false), Updateable(false)]
        public bool IsDeleted { get; set; }

        [Display(Name = "Lead Clean Info Name")]
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

        [Display(Name = "Lead ID")]
        [Createable(false), Updateable(false)]
        public string LeadId { get; set; }

        [Display(Name = "Last Matched Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset LastMatchedDate { get; set; }

        [Display(Name = "Last Status Changed Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? LastStatusChangedDate { get; set; }

        [Display(Name = "User ID")]
        [Createable(false), Updateable(false)]
        public string LastStatusChangedById { get; set; }

        [Display(Name = "Contact Status in Salesforce")]
        [Createable(false)]
        public bool IsInactive { get; set; }

        [Display(Name = "First Name")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string LastName { get; set; }

        [EmailAddress]
        [Createable(false), Updateable(false)]
        public string Email { get; set; }

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

        [StringLength(128)]
        [Createable(false), Updateable(false)]
        public string Title { get; set; }

        [Display(Name = "Annual Revenue")]
        [Createable(false), Updateable(false)]
        public double? AnnualRevenue { get; set; }

        [Display(Name = "Number of Employees")]
        [Createable(false), Updateable(false)]
        public int? NumberOfEmployees { get; set; }

        [Createable(false), Updateable(false)]
        public string Industry { get; set; }

        [Display(Name = "Company Name")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string CompanyName { get; set; }

        [Display(Name = "Company D-U-N-S Number")]
        [StringLength(9)]
        [Createable(false), Updateable(false)]
        public string CompanyDunsNumber { get; set; }

        [Display(Name = "Contact Status per Data.com")]
        [Createable(false), Updateable(false)]
        public string ContactStatusDataDotCom { get; set; }

        [Display(Name = "Name is Reviewed")]
        [Createable(false)]
        public bool IsReviewedName { get; set; }

        [Display(Name = "Email is Reviewed")]
        [Createable(false)]
        public bool IsReviewedEmail { get; set; }

        [Display(Name = "Phone is Reviewed")]
        [Createable(false)]
        public bool IsReviewedPhone { get; set; }

        [Display(Name = "Address is Reviewed")]
        [Createable(false)]
        public bool IsReviewedAddress { get; set; }

        [Display(Name = "Title is Reviewed")]
        [Createable(false)]
        public bool IsReviewedTitle { get; set; }

        [Display(Name = "Annual Revenue is Reviewed")]
        [Createable(false)]
        public bool IsReviewedAnnualRevenue { get; set; }

        [Display(Name = "Number of Employees is Reviewed")]
        [Createable(false)]
        public bool IsReviewedNumberOfEmployees { get; set; }

        [Display(Name = "Industry is Reviewed")]
        [Createable(false)]
        public bool IsReviewedIndustry { get; set; }

        [Display(Name = "Company Name is Reviewed")]
        [Createable(false)]
        public bool IsReviewedCompanyName { get; set; }

        [Display(Name = "Company D-U-N-S Number is Reviewed")]
        [Createable(false)]
        public bool IsReviewedCompanyDunsNumber { get; set; }

        [Display(Name = "D&B Company D-U-N-S Number is Reviewed")]
        [Createable(false)]
        public bool IsReviewedDandBCompanyDunsNumber { get; set; }

        [Display(Name = "First Name is Different")]
        [Createable(false), Updateable(false)]
        public bool IsDifferentFirstName { get; set; }

        [Display(Name = "Last Name is Different")]
        [Createable(false), Updateable(false)]
        public bool IsDifferentLastName { get; set; }

        [Display(Name = "Email is Different")]
        [Createable(false), Updateable(false)]
        public bool IsDifferentEmail { get; set; }

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

        [Display(Name = "Title is Different")]
        [Createable(false), Updateable(false)]
        public bool IsDifferentTitle { get; set; }

        [Display(Name = "Annual Revenue is Different")]
        [Createable(false), Updateable(false)]
        public bool IsDifferentAnnualRevenue { get; set; }

        [Display(Name = "Number of Employees is Different")]
        [Createable(false), Updateable(false)]
        public bool IsDifferentNumberOfEmployees { get; set; }

        [Display(Name = "Industry is Different")]
        [Createable(false), Updateable(false)]
        public bool IsDifferentIndustry { get; set; }

        [Display(Name = "Company Name is Different")]
        [Createable(false), Updateable(false)]
        public bool IsDifferentCompanyName { get; set; }

        [Display(Name = "Company D-U-N-S Number is Different")]
        [Createable(false), Updateable(false)]
        public bool IsDifferentCompanyDunsNumber { get; set; }

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

        [Display(Name = "D&B Company D-U-N-S Number")]
        [StringLength(9)]
        [Createable(false), Updateable(false)]
        public string DandBCompanyDunsNumber { get; set; }

        [Display(Name = "Data.com Company ID")]
        [StringLength(20)]
        [Createable(false), Updateable(false)]
        public string DataDotComCompanyId { get; set; }

        [Display(Name = "Name is Flagged Wrong")]
        [Createable(false)]
        public bool IsFlaggedWrongName { get; set; }

        [Display(Name = "Email is Flagged Wrong")]
        [Createable(false)]
        public bool IsFlaggedWrongEmail { get; set; }

        [Display(Name = "Phone is Flagged Wrong")]
        [Createable(false)]
        public bool IsFlaggedWrongPhone { get; set; }

        [Display(Name = "Address is Flagged Wrong")]
        [Createable(false)]
        public bool IsFlaggedWrongAddress { get; set; }

        [Display(Name = "Title is Flagged Wrong")]
        [Createable(false)]
        public bool IsFlaggedWrongTitle { get; set; }

        [Display(Name = "Annual Revenue is Flagged Wrong")]
        [Createable(false)]
        public bool IsFlaggedWrongAnnualRevenue { get; set; }

        [Display(Name = "Number of Employees is Flagged Wrong")]
        [Createable(false)]
        public bool IsFlaggedWrongNumberOfEmployees { get; set; }

        [Display(Name = "Industry is Flagged Wrong")]
        [Createable(false)]
        public bool IsFlaggedWrongIndustry { get; set; }

        [Display(Name = "Company Name is Flagged Wrong")]
        [Createable(false)]
        public bool IsFlaggedWrongCompanyName { get; set; }

        [Display(Name = "Company D-U-N-S Number is Flagged Wrong")]
        [Createable(false)]
        public bool IsFlaggedWrongCompanyDunsNumber { get; set; }

        [Display(Name = "Data.com ID")]
        [StringLength(20)]
        [Createable(false), Updateable(false)]
        public string DataDotComId { get; set; }

    }
}
