using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CV.Management.Web.Models.Database
{
    public class Company
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string ParentCompanyName { get; set; }
        public string MainProductions { get; set; }
        public Industry? Industry { get; set; }
        public string Turnover { get; set; }
        public string OtherIndustry { get; set; }
        public string NumberOfEmployess { get; set; }

        public virtual Profile Profile { get; set; }
        public virtual ICollection<Position> Positions { get; set; }
    }
}