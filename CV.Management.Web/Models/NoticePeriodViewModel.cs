using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CV.Management.Web.Models
{
    public class NoticePeriodViewModel
    {
        [Display(Name = "NoticePeriod", ResourceType = typeof(Resources))]
        public string NoticePeriod { get; set; }
    }
}