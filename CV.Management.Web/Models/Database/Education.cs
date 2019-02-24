using System.ComponentModel.DataAnnotations.Schema;

namespace CV.Management.Web.Models.Database
{
    public class Education
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EducationId { get; set; }
        public int? FromYear { get; set; }
        public int? ToYear { get; set; }
        public string Institution { get; set; }
        public string Degree { get; set; }

        public virtual Profile Profile { get; set; }
    }
}