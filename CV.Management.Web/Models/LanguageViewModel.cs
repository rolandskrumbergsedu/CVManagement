using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CV.Management.Web.Models
{
    public class LanguageViewModel
    {
        public List<LanguageItem> Languages { get; set; }
    }

    public class LanguageItem
    {
        public LanguageEnum? LanguageName { get; set; }
        public LevelEnum? SpokenLevel { get; set; }
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