using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CV.Management.Web.Models.Database
{
    public class AdditionalCourse
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AdditionalCourseId { get; set; }
        public int? NumberOfDays { get; set; }
        public int? Year { get; set; }
        public string CourseName { get; set; }
        public string Trainer { get; set; }

        public virtual Profile Profile { get; set; }
    }
}