using System.ComponentModel.DataAnnotations.Schema;

namespace CV.Management.Web.Models.Database
{
    public class ProfileImage
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProfileImageId { get; set; }
        public string ImageContent { get; set; }
        public string Type { get; set; }

        public virtual Profile Profile { get; set; }
    }
}