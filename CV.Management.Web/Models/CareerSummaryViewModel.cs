using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CV.Management.Web.Models
{
    public class CareerSummaryViewModel
    {
        public List<CompanyItem> Companies { get; set; }
    }

    public class CompanyItem
    {
        [Display(Name = "CompanyName", ResourceType = typeof(Resources))]
        public string Name { get; set; }
        [Display(Name = "City", ResourceType = typeof(Resources))]
        public string City { get; set; }
        [Display(Name = "ParentCompanyName", ResourceType = typeof(Resources))]
        public string ParentCompanyName { get; set; }
        [Display(Name = "MainProductions", ResourceType = typeof(Resources))]
        public string MainProductions { get; set; }
        [Display(Name = "Industry", ResourceType = typeof(Resources))]
        public Industry? Industry { get; set; }
        [Display(Name = "Turnover", ResourceType = typeof(Resources))]
        public string Turnover { get; set; }
        [Display(Name = "OtherIndustry", ResourceType = typeof(Resources))]
        public string OtherIndustry { get; set; }
        [Display(Name = "NumberOfEmployess", ResourceType = typeof(Resources))]
        public string NumberOfEmployess { get; set; }

        public List<PositionItem> Positions { get; set; }
    }

    public class PositionItem
    {
        [Display(Name = "PositionName", ResourceType = typeof(Resources))]
        public string Name { get; set; }
        [RegularExpression("^[0-9]*[0-9]{1}.[12][0-9]{3}|^[12][0-9]{3}$", ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "InvalidYearWithMonth")]
        [Display(Name = "FromTimeWithMonth", ResourceType = typeof(Resources))]
        public string FromTime { get; set; }
        [RegularExpression("^[0-9]*[0-9]{1}.[12][0-9]{3}|^[12][0-9]{3}$", ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "InvalidYearWithMonth")]
        [Display(Name = "ToTimeWithMonth", ResourceType = typeof(Resources))]
        public string ToTime { get; set; }
        [Display(Name = "Present", ResourceType = typeof(Resources))]
        public bool Now { get; set; }
        [Display(Name = "KeyTasks", ResourceType = typeof(Resources))]
        public string KeyTasks { get; set; }
        [Display(Name = "ReportingTo", ResourceType = typeof(Resources))]
        public string ReportingTo { get; set; }
        [Display(Name = "DirectSubordinates", ResourceType = typeof(Resources))]
        public string DirectSubordinates { get; set; }
        [Display(Name = "Achievements", ResourceType = typeof(Resources))]
        public string Achievements { get; set; }
        [Display(Name = "ReasonForLeaving", ResourceType = typeof(Resources))]
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