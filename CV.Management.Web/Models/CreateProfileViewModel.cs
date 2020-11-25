using System.ComponentModel.DataAnnotations;

namespace CV.Management.Web.Models
{
    public class CreateProfileViewModel
    {
        [Display(Name = "FullName", ResourceType = typeof(Resources))]
        public string FullName { get; set; }
        [Display(Name = "Email", ResourceType = typeof(Resources))]
        public string Email { get; set; }
        public string Name { get; set; }
    }
}