using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CV.Management.Web.Models
{
    public class ConfirmUserDeleteViewModel
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
        public string LinkedInLink { get; set; }
        public string Email { get; set; }
        public string Project { get; set; }
    }
}