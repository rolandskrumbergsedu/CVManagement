using CV.Management.Generation.Word;
using CV.Management.Web.DbContexts;
using CV.Management.Web.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http;

namespace CV.Management.Web.Controllers
{
    [Authorize]
    public class WordDocumentController : ApiController
    {
        [HttpGet]
        [Route("api/worddocument/{language}/{id}")]
        public HttpResponseMessage DownloadPdfFile(string language, string id)
        {
            try
            {
                var documentManager = new WordDocumentManager();

                var bytes = documentManager.GetDocument(GetGenerationData(language, id));

                var result = Request.CreateResponse(HttpStatusCode.OK);
                result.Content = new ByteArrayContent(bytes);
                result.Content.Headers.ContentDisposition =
                    new System.Net.Http.Headers.ContentDispositionHeaderValue(
                            "attachment")
                    { FileName = "Test" + ".docx" };

                return result;
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }

        private GenerationData GetGenerationData(string language, string id)
        {
            using(var db = new ProfileInformationDbContext())
            {
                Profile profile = null;

                if (!string.IsNullOrEmpty(id))
                {
                    profile = db.Profiles.FirstOrDefault(x => x.ProfileId.ToString() == id);
                }
                else
                {
                    var userName = User.Identity.Name;
                    profile = db.Profiles.FirstOrDefault(x => x.Username == userName);
                }

                return DataFromProfile(profile, language);
            }
        }

        private string GetCurrentDate(string language)
        {
            var year = DateTime.Now.Year.ToString();

            switch (DateTime.Now.Month)
            {
                case 1:
                    return $"{DocumentMetadataTexts.GetText(MetadataTexts.CV_MONTH_JANUARY, language)} {year}";
                case 2:
                    return $"{DocumentMetadataTexts.GetText(MetadataTexts.CV_MONTH_FEBRUARY, language)} {year}";
                case 3:
                    return $"{DocumentMetadataTexts.GetText(MetadataTexts.CV_MONTH_MARCH, language)} {year}";
                case 4:
                    return $"{DocumentMetadataTexts.GetText(MetadataTexts.CV_MONTH_APRIL, language)} {year}";
                case 5:
                    return $"{DocumentMetadataTexts.GetText(MetadataTexts.CV_MONTH_MAY, language)} {year}";
                case 6:
                    return $"{DocumentMetadataTexts.GetText(MetadataTexts.CV_MONTH_JUNE, language)} {year}";
                case 7:
                    return $"{DocumentMetadataTexts.GetText(MetadataTexts.CV_MONTH_JULY, language)} {year}";
                case 8:
                    return $"{DocumentMetadataTexts.GetText(MetadataTexts.CV_MONTH_AUGUST, language)} {year}";
                case 9:
                    return $"{DocumentMetadataTexts.GetText(MetadataTexts.CV_MONTH_SEPTEMBER, language)} {year}";
                case 10:
                    return $"{DocumentMetadataTexts.GetText(MetadataTexts.CV_MONTH_OCTOBER, language)} {year}";
                case 11:
                    return $"{DocumentMetadataTexts.GetText(MetadataTexts.CV_MONTH_NOVEMBER, language)} {year}";
                case 12:
                    return $"{DocumentMetadataTexts.GetText(MetadataTexts.CV_MONTH_DECEMBER, language)} {year}";
                default:
                    return "Unknown";
            }
        }

        private GenerationData DataFromProfile(Profile profile, string language)
        {
            var documentProperties = new DocumentProperties
            {
                Creator = "Agnese Zanriba",
                Category = "",
                Keywords = "",
                Subject = "",
                Description = "",
                Title = ""
            };

            var titleArea = new TitleArea
            {
                Date = GetCurrentDate(language),
                Name = profile.FullName,
                Title = DocumentMetadataTexts.GetText(MetadataTexts.CV_TITLE, language),
                Project = profile.Project
            };

            var personal = new PersonalInformation
            {
                FullName = profile.FullName,
                Mobile = profile.PhoneCode + profile.Phone,
                Email = profile.Email,
                Address = profile.Address,
                OtherInformation = profile.OtherInformation,
                LinkedIn = profile.LinkedInLink,
                ProfilePictureContent = profile.PictureContent,
                ProfilePictureType = profile.PictureType
            };

            var education = profile.Educations.Select(x => new EducationItem
            {
                Degree = x.Degree,
                EndingYear = x.ToYear,
                StartingYear = x.FromYear,
                University = x.Institution
            }).ToList();

            var courses = profile.AdditionalCourses.Select(x => new AdditionalCoursesItem
            {
                AmountOfDays = x.NumberOfDays,
                CourseName = x.CourseName,
                Instructor = x.Trainer,
                Year = x.Year.Value
            }).ToList();

            var languages = profile.Languages.Select(x => new LanguageItem
            {
                LanguageName = x.LanguageName.ToString(),
                SpokenLevel = ((int)x.SpokenLevel.Value) + 1,
                WrittenLevel = ((int)x.WrittenLevel.Value) + 1
            }).ToList();

            var careerSummary = profile.Companies.Select(x => new CareerSummaryItem
            {
                City = x.City,
                Industry = x.Industry.HasValue ? x.Industry.Value.ToString() : x.OtherIndustry,
                Company = x.Name,
                NumberOfEmployees = x.NumberOfEmployess,
                Services = x.MainProductions,
                ParentCompany = x.ParentCompanyName,
                Turnover = x.Turnover,
                Roles = x.Positions.Select(y => new RoleInformation
                {
                    Achievements = y.Achievements,
                    EndingYear = y.ToTime,
                    Now = y.Now,
                    ReasonForLeaving = y.ReasonForLeaving,
                    ReportingTo = y.ReportingTo,
                    Role = y.Name,
                    StartingYear = y.FromTime,
                    Subordinates = y.DirectSubordinates,
                    Tasks = y.KeyTasks.Select(z => z.Name).ToList()
                }).ToList()

            }).ToList();

            var activities = profile.Memberships.Select(x => new SocialActivity
            {
                StartingYear = x.FromTime,
                EndingYear = x.ToTime,
                Description = x.Description
            }).ToList();

            var compensation = new CompensationItem
            {
                AdditionalBonuses = profile.AdditionalBonuses,
                BonusRequest = profile.BonusRequest,
                CurrentBonuses = profile.CurrentBonuses,
                CurrentSalary = profile.CurrentSalary,
                SalaryRequest = profile.SalaryRequest
            };

            return new GenerationData
            {
                DocumentProperties = documentProperties,
                TitleArea = titleArea,
                Personal = personal,
                Education = education,
                AdditionalCourses = courses,
                Languages = languages,
                CareerSummary = careerSummary,
                SocialActivites = activities,
                Compensation = compensation,
                TransitionTime = profile.NoticePeriod,
                AdditionalComments = profile.Comments,
                Language = language
            };
        }

        public string GetKeyTasks(List<KeyTask> tasks)
        {
            if (tasks == null)
            {
                return string.Empty;
            }

            var sb = new StringBuilder();

            foreach (var task in tasks)
            {
                sb.Append("- " + task.Name + "\r\n");
            }

            return sb.ToString();
        }
    }
}
