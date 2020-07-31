using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CV.Management.Web.Models
{
    public class EditUserViewModel
    {
        private readonly List<string> _adminResponses = new List<string> { "Yes", "No" };

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        [Display(Name = "Email confirmed?")]
        public bool EmailConfirmed { get; set; }
        public bool IsAdmin { get; set; }
        [Display(Name = "Is admin?")]
        public string SelectedAdminResponse { get; set; }
        public IEnumerable<SelectListItem> AdminResponses { get 
            {
                return new SelectList(_adminResponses);
            }}
        public string ProfileId { get; set; }
        public string UserId { get; set; }
    }
}