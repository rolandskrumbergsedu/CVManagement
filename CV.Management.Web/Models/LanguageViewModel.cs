using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CV.Management.Web.Models
{
    public class LanguageViewModel
    {
        public List<LanguageItem> Languages { get; set; }
    }

    public class LanguageItem
    {
        [Display(Name = "LanguageName", ResourceType = typeof(Resources))]
        public LanguageEnum? LanguageName { get; set; }
        [Display(Name = "OtherLanguageName", ResourceType = typeof(Resources))]
        public string OtherLanguage { get; set; }
        [Display(Name = "SpokenLevel", ResourceType = typeof(Resources))]
        public LevelEnum? SpokenLevel { get; set; }
        [Display(Name = "WrittenLevel", ResourceType = typeof(Resources))]
        public LevelEnum? WrittenLevel { get; set; }
    }

    public enum LevelEnum
    {
        Basic,
        Satisfactory,
        Good,
        Excellent,
        Native
    }

    public enum LanguageEnum
    {
        Latvian,
        Lithuanian,
        Estonian,
        English,
        Russian,
        German,
        French,
        Spanish,
        Other
    }
}