using System.ComponentModel.DataAnnotations.Schema;

namespace CV.Management.Web.Models.Database
{
    public class AdditionalFile
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AdditionalFileId { get; set; }
        public string FileContent { get; set; }
        public string FileType { get; set; }
        public string FileName { get; set; }

        public virtual Profile Profile { get; set; }
    }
}