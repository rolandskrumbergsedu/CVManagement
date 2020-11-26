using System.Collections.Generic;

namespace CV.Management.Generation.Word
{
    public class GenerationData
    {
        public DocumentProperties DocumentProperties { get; set; }
        public TitleArea TitleArea { get; set; }
        public PersonalInformation Personal { get; set; }
        public List<EducationItem> Education { get; set; }
        public List<AdditionalCoursesItem> AdditionalCourses { get; set; }
        public List<LanguageItem> Languages { get; set; }
        public List<CareerSummaryItem> CareerSummary { get; set; }
        public List<SocialActivity> SocialActivites { get; set; }
        public CompensationItem Compensation { get; set; }
        public string TransitionTime { get; set; }
        public string AdditionalComments { get; set; }
        public string Language { get; set; }
    }

    public class CompensationItem
    {
        public string CurrentSalary { get; set; }
        public string CurrentBonuses { get; set; }
        public string SalaryRequest { get; set; }
        public string BonusRequest { get; set; }
        public string AdditionalBonuses { get; set; }
    }

    public class SocialActivity
    {
        public int? StartingYear { get; set; }
        public int? EndingYear { get; set; }
        public string Role { get; set; }
        public string Description { get; set; }
        public List<string> Tasks { get; set; }
    }

    public class TitleArea
    {
        public string Title { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public string Project { get; set; }
    }

    public class DocumentProperties
    {
        public string Creator { get; set; }
        public string Title { get; set; }
        public string Subject { get; set; }
        public string Category { get; set; }
        public string Keywords { get; set; }
        public string Description { get; set; }
    }

    public class PersonalInformation
    {
        public string Address { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string OtherInformation { get; set; }
        public string LinkedIn { get; set; }
        public string FullName { get; set; }
        public string ProfilePictureContent { get; set; }
        public string ProfilePictureType { get; set; }
    }

    public class EducationItem
    {
        public int? StartingYear { get; set; }
        public int? EndingYear { get; set; }
        public string University { get; set; }
        public string Degree { get; set; }
    }

    public class AdditionalCoursesItem
    {
        public int? AmountOfDays { get; set; }
        public int? Year { get; set; }
        public string CourseName { get; set; }
        public string Instructor { get; set; }
    }

    public class LanguageItem
    {
        public string LanguageName { get; set; }
        public string OtherLanguageName { get; set; }
        public int SpokenLevel { get; set; }
        public int WrittenLevel { get; set; }
    }

    public class CareerSummaryItem
    {
        public string Company { get; set; }
        public string City { get; set; }
        public string Industry { get; set; }
        public string Services { get; set; }
        public string Turnover { get; set; }
        public string NumberOfEmployees { get; set; }
        public string ParentCompany { get; set; }
        public List<RoleInformation> Roles { get; set; }
    }

    public class RoleInformation
    {
        public int? StartingYear { get; set; }
        public int? EndingYear { get; set; }
        public bool? Now { get; set; }
        public string Role { get; set; }
        public List<string> Tasks { get; set; }
        public string ReportingTo { get; set; }
        public string Subordinates { get; set; }
        public string Achievements { get; set; }
        public string ReasonForLeaving { get; set; }
    }
}
