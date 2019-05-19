using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CV.Management.Web.Models.Database
{
    public class Profile
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProfileId { get; set; }
        public string Username { get; set; }
        public string PictureContent { get; set; }
        public string PictureType { get; set; }
        public string FullName { get; set; }
        public string LinkedInLink { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneCode { get; set; }
        public string Phone { get; set; }
        public string OtherInformation { get; set; }
        public string Project { get; set; }
        public string CurrentSalary { get; set; }
        public string CurrentBonuses { get; set; }
        public string SalaryRequest { get; set; }
        public string BonusRequest { get; set; }
        public string AdditionalBonuses { get; set; }
        public string NoticePeriod { get; set; }
        public string Comments { get; set; }

        public virtual ICollection<Education> Educations { get; set; }
        public virtual ICollection<AdditionalCourse> AdditionalCourses { get; set; }
        public virtual ICollection<Language> Languages { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<Membership> Memberships { get; set; }
        public virtual ICollection<AdditionalFile> AdditionalFiles { get; set; }
    }
}