using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CV.Management.Web.Models
{
    public class EducationViewModel
    {
        public List<EducationItem> Education { get; set; }

        public EducationViewModel()
        {
            Education = new List<EducationItem>();
        }
    }

    public class EducationItem
    {
        [Range(1900, 3000)]
        [RegularExpression("^[12][0-9]{3}$", ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "InvalidYear")]
        [Display(Name = "FromYear", ResourceType = typeof(Resources))]
        public int? FromYear { get; set; }
        [Range(1900, 3000)]
        [RegularExpression("^[12][0-9]{3}$", ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "InvalidYear")]
        [Display(Name = "ToYear", ResourceType = typeof(Resources))]
        public int? ToYear { get; set; }
        [Display(Name = "Now", ResourceType = typeof(Resources))]
        public bool Now { get; set; }
        [Display(Name = "Institution", ResourceType = typeof(Resources))]
        public string Institution { get; set; }
        [Display(Name = "Degree", ResourceType = typeof(Resources))]
        public string Degree { get; set; }
    }
}