using System.ComponentModel.DataAnnotations;

namespace CV.Management.Web.Models
{
    public class PersonalInformationViewModel
    {
        [Required]
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