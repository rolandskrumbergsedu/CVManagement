using System.ComponentModel.DataAnnotations.Schema;

namespace CV.Management.Web.Models.Database
{
    public class Achievement
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AchievementId { get; set; }
        public string Name { get; set; }

        public virtual Position Position { get; set; }
    }
}