using System.ComponentModel.DataAnnotations.Schema;

namespace CV.Management.Web.Models.Database
{
    public class Membership
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MembershipId { get; set; }
        public int? FromTime { get; set; }
        public int? ToTime { get; set; }
        public bool Now { get; set; }
        public string Description { get; set; }

        public virtual Profile Profile { get; set; }
    }
}