using System;
using System.Collections.Generic;
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
        public int? FromTime { get; set; }
        public int? ToTime { get; set; }
        public bool Now { get; set; }
        public string Description { get; set; }
    }
}