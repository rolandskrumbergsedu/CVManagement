using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CV.Management.Web.Models
{
    public class MembershipViewModel
    {
        public List<MembershipItem> Memberships { get; set; }
    }

    public class MembershipItem
    {
        [Display(Name = "FromTime", ResourceType = typeof(Resources))]
        public int? FromTime { get; set; }
        [Display(Name = "ToTime", ResourceType = typeof(Resources))]
        public int? ToTime { get; set; }
        [Display(Name = "Now", ResourceType = typeof(Resources))]
        public bool Now { get; set; }
        [Display(Name = "MembershipDescription", ResourceType = typeof(Resources))]
        public string Description { get; set; }
    }
}