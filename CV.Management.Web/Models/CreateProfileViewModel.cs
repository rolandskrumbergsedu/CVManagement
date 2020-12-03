using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace CV.Management.Web.Models
{
    public class CreateProfileViewModel
    {
        [Display(Name = "FullName", ResourceType = typeof(Resources))]
        public string FullName { get; set; }
        [Display(Name = "Email", ResourceType = typeof(Resources))]
        public string Email { get; set; }
        public string Name { get; set; }
        [Display(Name = "Language", ResourceType = typeof(Resources))]
        public string SelectedLanguage { get; set; }
        public IEnumerable<SelectListItem> Languages { get; set; }
    }
}