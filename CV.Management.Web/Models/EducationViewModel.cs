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
        [Required]
        public int? FromYear { get; set; }
        public int? ToYear { get; set; }
        public bool Now { get; set; }
        [Required]
        public string Institution { get; set; }
        [Required]
        public string Degree { get; set; }
    }
}