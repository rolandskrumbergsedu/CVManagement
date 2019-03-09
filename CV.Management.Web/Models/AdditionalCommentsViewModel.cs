using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CV.Management.Web.Models
{
    public class AdditionalCommentsViewModel
    {
        [Display(Name = "Comments", ResourceType = typeof(Resources))]
        public string Comments { get; set; }
    }
}