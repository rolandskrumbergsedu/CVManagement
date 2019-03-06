using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CV.Management.Web.Models.Database
{
    public class Position
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PositionId { get; set; }
        public string Name { get; set; }
        public int? FromTime { get; set; }
        public int? ToTime { get; set; }
        public bool Now { get; set; }
        public string ReportingTo { get; set; }
        public string DirectSubordinates { get; set; }
        public string Achievements { get; set; }
        public string ReasonForLeaving { get; set; }

        public virtual ICollection<KeyTask> KeyTasks { get; set; }
        public virtual Company Company { get; set; }
    }
}