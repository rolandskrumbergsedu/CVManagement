using System.ComponentModel.DataAnnotations;
using System.Resources;

namespace CV.Management.Web.Models
{
    public class PersonalInformationViewModel
    {
        [Required]
        [Display(Name = "FullName", ResourceType = typeof(Resources))]
        public string FullName { get; set; }
        [Display(Name = "LinkedInLink", ResourceType = typeof(Resources))]
        public string LinkedInLink { get; set; }
        [Display(Name = "Address", ResourceType = typeof(Resources))]
        public string Address { get; set; }
        [Required]
        [Display(Name = "Email", ResourceType = typeof(Resources))]
        public string Email { get; set; }
        [Required]
        public string PhoneCode { get; set; }
        [Required]
        [Display(Name = "Phone", ResourceType = typeof(Resources))]
        public string Phone { get; set; }
        [Display(Name = "Skype", ResourceType = typeof(Resources))]
        public string Skype { get; set; }
        [Display(Name = "Project", ResourceType = typeof(Resources))]
        public string Project { get; set; }
    }
}