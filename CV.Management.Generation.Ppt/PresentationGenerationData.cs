using System.Collections.Generic;

namespace CV.Management.Generation.Ppt
{
    public class PresentationGenerationData
    {
        public string Date { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string PictureContent { get; set; }
        public string PictureType { get; set; }
        public List<EducationItem> Education { get; set; }
        public List<LanguageItem> Languages { get; set; }
        public List<ExperienceItem> Experience { get; set; }
        public List<MotivationItem> Motivation { get; set; }
    }

    public class EducationItem
    {
        public string EndYear { get; set; }
        public string University { get; set; }
        public string Degree { get; set; }
    }

    public class LanguageItem
    {
        public string LanguageName { get; set; }
        public string LanguageLevel { get; set; }
    }

    public class ExperienceItem
    {
        public string StartingYear { get; set; }
        public string EndingYear { get; set; }
        public string Company { get; set; }
        public string Position { get; set; }
    }

    public class MotivationItem
    {
        public string Label { get; set; }
        public string Content { get; set; }
    }
}
