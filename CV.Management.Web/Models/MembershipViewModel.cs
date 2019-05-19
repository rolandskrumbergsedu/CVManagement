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
        [Range(1900, 3000)]
        [RegularExpression("^[12][0-9]{3}$", ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "InvalidYear")]
        [Display(Name = "FromTime", ResourceType = typeof(Resources))]
        public int? FromTime { get; set; }
        [Range(1900, 3000)]
        [RegularExpression("^[12][0-9]{3}$", ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "InvalidYear")]
        [Display(Name = "ToTime", ResourceType = typeof(Resources))]
        public int? ToTime { get; set; }
        [Display(Name = "Now", ResourceType = typeof(Resources))]
        public bool Now { get; set; }
        [Display(Name = "MembershipDescription", ResourceType = typeof(Resources))]
        public string Description { get; set; }
    }
}