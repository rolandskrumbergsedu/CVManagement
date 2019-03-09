using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CV.Management.Web.Models
{
    public class AdditionalCoursesViewModel
    {
        public List<Course> Courses { get; set; }
    }

    public class Course
    {
        [Display(Name = "NumberOfDays", ResourceType = typeof(Resources))]
        public int? NumberOfDays { get; set; }
        [Display(Name = "Year", ResourceType = typeof(Resources))]
        public int? Year { get; set; }
        [Display(Name = "CourseName", ResourceType = typeof(Resources))]
        public string CourseName { get; set; }
        [Display(Name = "Trainer", ResourceType = typeof(Resources))]
        public string Trainer { get; set; }
    }
}