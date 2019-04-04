namespace CV.Management.Web.Models
{
    public class ProfileViewModel : ViewModelBase
    {
        public FileUploadViewModel FileUploadViewModel { get; set; }
        public PersonalInformationViewModel PersonalInformationViewModel { get; set; }
        public EducationViewModel EducationViewModel { get; set; }
        public AdditionalCoursesViewModel AdditionalCoursesViewModel { get; set; }
        public LanguageViewModel LanguageViewModel { get; set; }
        public CareerSummaryViewModel CareerSummaryViewModel { get; set; }
        public MembershipViewModel MembershipViewModel { get; set; }
        public CompensationViewModel CompensationViewModel { get; set; }
        public NoticePeriodViewModel NoticePeriodViewModel { get; set; }
        public AdditionalCommentsViewModel AdditionalCommentsViewModel { get; set; }
        public AdditionalFilesViewModel AdditionalFilesViewModel { get; set; }
        //public AddAdditionalFileUploadViewModel AddAdditionalFileUploadViewModel { get; set; }
    }
}