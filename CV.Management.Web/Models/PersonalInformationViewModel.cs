using System.ComponentModel.DataAnnotations;
using System.Resources;

namespace CV.Management.Web.Models
{
    public class PersonalInformationViewModel
    {
        [Required]
        [Display(Name = "String1", ResourceType = typeof(Resources))]
        public string FullName { get; set; }
        public string LinkedInLink { get; set; }
        public string Address { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        public string Skype { get; set; }
        public string Project { get; set; }
    }
}