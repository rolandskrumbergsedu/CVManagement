﻿using System.ComponentModel.DataAnnotations;

namespace CV.Management.Web.Models
{
    public class EducationViewModel
    {
        [Required]
        public int FromYear { get; set; }
        [Required]
        public int ToYear { get; set; }
        [Required]
        public string Institution { get; set; }
        [Required]
        public string Degree { get; set; }
    }
}