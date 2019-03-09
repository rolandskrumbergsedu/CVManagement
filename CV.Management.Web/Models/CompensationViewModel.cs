using System.ComponentModel.DataAnnotations;

namespace CV.Management.Web.Models
{
    public class CompensationViewModel
    {
        [Display(Name = "CurrentSalary", ResourceType = typeof(Resources))]
        public string CurrentSalary { get; set; }
        [Display(Name = "CurrentBonuses", ResourceType = typeof(Resources))]
        public string CurrentBonuses { get; set; }
        [Display(Name = "SalaryRequest", ResourceType = typeof(Resources))]
        public string SalaryRequest { get; set; }
        [Display(Name = "BonusRequest", ResourceType = typeof(Resources))]
        public string BonusRequest { get; set; }
        [Display(Name = "AdditionalBonuses", ResourceType = typeof(Resources))]
        public string AdditionalBonuses { get; set; }
    }
}