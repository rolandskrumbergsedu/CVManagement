using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CV.Management.Web.Models
{
    public class CareerSummaryViewModel
    {
        public List<CompanyItem> Companies { get; set; }
    }

    public class CompanyItem
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string ParentCompanyName { get; set; }
        public string MainProductions { get; set; }
        public Industry? Industry { get; set; }
        public int? Turnover { get; set; }
        public string OtherIndustry { get; set; }
        public int? NumberOfEmployess { get; set; }

        public List<PositionItem> Positions { get; set; }
    }

    public class PositionItem
    {
        public string Name { get; set; }
        public int? FromTime { get; set; }
        public int? ToTime { get; set; }
        public bool Now { get; set; }
        public string KeyTasks { get; set; }
        public string ReportingTo { get; set; }
        public string DirectSubordinates { get; set; }
        public string Achievements { get; set; }
        public string ReasonForLeaving { get; set; }
    }

    public enum Industry
    {
        [Display(Name = "Academic, Universities, College, Schools")]
        Academic,
        [Display(Name = "Automotive & Industrial")]
        AutomotiveAndIndustrial,
        [Display(Name = "Business Services")]
        BusinessServices,
        [Display(Name = "Construction / Engineering services / Infrastructure")]
        ConstructionEngineeringInfrastructure,
        [Display(Name = "Energy & Utilities")]
        EnergyAndUtilities,
        [Display(Name = "Financial Services / Insurance")]
        FinancialAndInsurance,
        [Display(Name = "FMCG / Consumer Electronics")]
        FmcgConsumerElectronics,
        [Display(Name = "FMCG / Food & Beverages")]
        FmcgFoodBeverages,
        [Display(Name = "Government & Public Sector")]
        GovernmentPublicSector,
        [Display(Name = "Hospitality / Foodservice")]
        HospitalityFoodService,
        [Display(Name = "Life Sciences / Medicine & Pharmacy")]
        LifeSciences,
        [Display(Name = "Logistics services / Distribution services / Supply chain sector")]
        LogisticsServices,
        [Display(Name = "Media / Entertainment")]
        MediaEntertainment,
        [Display(Name = "Natural Resources / Agriculture / Forestry / Oil & Gas")]
        NaturalResourcesAgriculture,
        [Display(Name = "Not-For-Profit")]
        NotForProfit,
        [Display(Name = "Professional Services / Audit / Legal Services / Training & Development")]
        ProfessionalServices,
        [Display(Name = "Production")]
        Production,
        [Display(Name = "Property / Real estate / Facilities management")]
        Property,
        [Display(Name = "Retail / Wholesale / Distributors")]
        Retail,
        [Display(Name = "Technology & Communication Services")]
        Technology,
        [Display(Name = "Tourism / Hotels")]
        Tourism,
        [Display(Name = "Transportation - passengers")]
        Transportation,
        [Display(Name = "Other (specify)")]
        Other
    }
}