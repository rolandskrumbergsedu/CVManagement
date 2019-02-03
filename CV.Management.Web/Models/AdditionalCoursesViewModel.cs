using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CV.Management.Web.Models
{
    public class AdditionalCoursesViewModel
    {
        public int NumberOfDays { get; set; }
        public int Year { get; set; }
        public string Course { get; set; }
        public string Trainer { get; set; }
    }
}