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
        public LanguageProficiencyInformation LanguageProficiency { get; set; }
        public List<CareerSummaryItem> CareerSummary { get; set; }
        public List<SocialActivity> SocialActivites { get; set; }
        public string Compensation { get; set; }
        public string TransitionTime { get; set; }
        public string AdditionalComments { get; set; }
    }

    public class SocialActivity
    {
        public int StartingYear { get; set; }
        public int EndingYear { get; set; }
        public string Role { get; set; }
        public List<string> Tasks { get; set; }
    }

    public class TitleArea
    {
        public string Title { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public string Company { get; set; }
        public string Role { get; set; }
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
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Skype { get; set; }
        public string LinkedIn { get; set; }
    }

    public class EducationItem
    {
        public int StartingYear { get; set; }
        public int EndingYear { get; set; }
        public string University { get; set; }
        public string Degree { get; set; }
    }

    public class AdditionalCoursesItem
    {
        public int AmountOfDays { get; set; }
        public int Year { get; set; }
        public string CourseName { get; set; }
        public string Instructor { get; set; }
    }

    public class LanguageProficiencyInformation
    {
        public LanguageProficiencyItem Spoken { get; set; }
        public LanguageProficiencyItem Written { get; set; }
    }

    public class LanguageProficiencyItem
    {
        public int Latvian { get; set; }
        public int Russian { get; set; }
        public int English { get; set; }
    }

    public class CareerSummaryItem
    {
        public int StartingYear { get; set; }
        public int EndingYear { get; set; }
        public string Company { get; set; }
        public List<string> CompanyInformation { get; set; }
        public RoleInformation Role { get; set; }
        public List<string> Tasks { get; set; }
        public string ReportingTo { get; set; }
        public string ReasonForLeaving { get; set; }
    }

    public class RoleInformation
    {
        public int StartingYear { get; set; }
        public int EndingYear { get; set; }
        public string Role { get; set; }
    }
}
