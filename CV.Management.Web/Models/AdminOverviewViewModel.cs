using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CV.Management.Web.Models
{
    public class AdminOverviewViewModel
    {
        public List<ProfileAdminViewModel> Profiles { get; set; }
    }

    public class ProfileAdminViewModel
    {
        public int ProfileId { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
    }
}