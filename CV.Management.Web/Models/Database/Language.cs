using System.ComponentModel.DataAnnotations.Schema;

namespace CV.Management.Web.Models.Database
{
    public class Language
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LanguageId { get; set; }
        public LanguageEnum? LanguageName { get; set; }
        public LevelEnum? SpokenLevel { get; set; }
        public LevelEnum? WrittenLevel { get; set; }

        public virtual Profile Profile { get; set; }
    }
}