using CV.Management.Generation.Word;
using CV.Management.Web.DbContexts;
using CV.Management.Web.Models;
using CV.Management.Web.Models.Database;
using Microsoft.ApplicationInsights;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace CV.Management.Web.Controllers
{
    [Authorize]
    public class WordDocumentController : ApiController
    {
        private readonly TelemetryClient telemetry = new TelemetryClient();

        [HttpGet]
        [Route("api/worddocument/{language}/{id}")]
        public HttpResponseMessage DownloadWordFile(string language, string id)
        {
            try
            {

                telemetry.TrackEvent("DownloadWordFile", new Dictionary<string, string> { { "User", User.Identity.Name } });

                var documentManager = new WordDocumentManager();

                var generationData = GetGenerationData(language, id);
                var cleanedFullName = !string.IsNullOrEmpty(generationData.Personal.FullName) ? generationData.Personal.FullName.Replace(' ', '_') : string.Empty;

                var bytes = documentManager.GetDocument(GetGenerationData(language, id));

                var result = Request.CreateResponse(HttpStatusCode.OK);
                result.Content = new ByteArrayContent(bytes);
                result.Content.Headers.ContentDisposition =
                    new System.Net.Http.Headers.ContentDispositionHeaderValue(
                            "attachment")
                    { FileName = $"CV_{cleanedFullName}_{language.ToUpper()}" + ".docx" };

                using (var db = new ProfileInformationDbContext())
                {
                    db.AuditLogs.Add(new AuditLog
                    {
                        AuditEvent = AuditEvent.DownloadDoc.ToString(),
                        EventTime = DateTime.Now,
                        UserAffected = generationData.Personal.FullName,
                        UserAffectedId = id,
                        Username = User.Identity.Name
                    });

                    db.SaveChanges();
                }

                return result;
            }
            catch (Exception ex)
            {
                telemetry.TrackException(ex);

                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }

        [HttpGet]
        [Route("api/myworddocument/{language}")]
        public HttpResponseMessage DownloadMyWordFile(string language)
        {
            try
            {
                telemetry.TrackEvent("DownloadMyWordFile", new Dictionary<string, string> { { "User", User.Identity.Name } });

                var documentManager = new WordDocumentManager();

                var generationData = GetGenerationData(language);
                var cleanedFullName = !string.IsNullOrEmpty(generationData.Personal.FullName) ? generationData.Personal.FullName.Replace(' ', '_') : string.Empty;

                var bytes = documentManager.GetDocument(generationData);

                var result = Request.CreateResponse(HttpStatusCode.OK);
                result.Content = new ByteArrayContent(bytes);
                result.Content.Headers.ContentDisposition =
                    new System.Net.Http.Headers.ContentDispositionHeaderValue(
                            "attachment")
                    { FileName = $"CV_{cleanedFullName}_{language.ToUpper()}" + ".docx" };

                return result;
            }
            catch (Exception ex)
            {
                telemetry.TrackException(ex);

                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }

        private GenerationData GetGenerationData(string language)
        {
            using (var db = new ProfileInformationDbContext())
            {
                var userName = User.Identity.Name;
                var profile = db.Profiles.FirstOrDefault(x => x.Username == userName);

                return DataFromProfile(profile, language);
            }
        }

        private GenerationData GetGenerationData(string language, string id)
        {
            using(var db = new ProfileInformationDbContext())
            {
                Profile profile = null;

                if (!string.IsNullOrEmpty(id))
                {
                    profile = db.Profiles
                        .Where(x => x.ProfileId.ToString() == id && x.Language == language)
                        .Include(_ => _.Educations)
                        .Include(_ => _.AdditionalCourses)
                        .Include(_ => _.Languages)
                        .Include(_ => _.Companies.Select(x => x.Positions.Select(y => y.KeyTasks)))
                        .Include(_ => _.Memberships)
                        .Include(_ => _.AdditionalFiles)
                        .FirstOrDefault();
                }
                else
                {
                    var userName = User.Identity.Name;
                    profile = db.Profiles
                        .Where(x => x.Username == userName)
                        .Include(_ => _.Educations)
                        .Include(_ => _.AdditionalCourses)
                        .Include(_ => _.Languages)
                        .Include(_ => _.Companies.Select(x => x.Positions.Select(y => y.KeyTasks)))
                        .Include(_ => _.Memberships)
                        .Include(_ => _.AdditionalFiles)
                        .FirstOrDefault();
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

            List<Generation.Word.EducationItem> education = new List<Generation.Word.EducationItem>();

            if (profile.Educations != null)
            {
                var educationList = profile.Educations.ToList();

                if (educationList != null && educationList.Count > 0)
                {
                    education = educationList.OrderEducation().Select(x => new Generation.Word.EducationItem
                    {
                        Degree = x.Degree,
                        EndingYear = x.ToYear,
                        StartingYear = x.FromYear,
                        University = x.Institution
                    }).ToList();
                }
            }

            List<AdditionalCoursesItem> courses = new List<AdditionalCoursesItem>();

            if (profile.AdditionalCourses != null)
            {
                var coursList = profile.AdditionalCourses.ToList();

                if (coursList != null && coursList.Count > 0)
                {
                    courses = coursList.OrderAdditionalCourse().Select(x => new AdditionalCoursesItem
                    {
                        AmountOfDays = x.NumberOfDays,
                        CourseName = x.CourseName,
                        Instructor = x.Trainer,
                        Year = x.Year ?? null
                    }).ToList();
                }
            }

            List<Generation.Word.LanguageItem> languages = new List<Generation.Word.LanguageItem>();

            if (profile.Languages != null && profile.Languages.Count > 0)
            {
                languages = profile.Languages.Select(x => new Generation.Word.LanguageItem
                {
                    LanguageName = x.LanguageName.HasValue ? x.LanguageName.ToString() : string.Empty,
                    OtherLanguageName = x.OtherLanguage,
                    SpokenLevel = x.SpokenLevel.HasValue ? ((int)x.SpokenLevel.Value) + 1 : 0,
                    WrittenLevel = x.WrittenLevel.HasValue ? ((int)x.WrittenLevel.Value) + 1 : 0
                }).ToList();
            }

            List<CareerSummaryItem> careerSummary = new List<CareerSummaryItem>();

            if (profile.Companies != null)
            {
                var careerSummaryList = profile.Companies.ToList();

                if (careerSummaryList != null && careerSummaryList.Count > 0)
                {
                    careerSummary = careerSummaryList.OrderCompanies().Select(x => new CareerSummaryItem
                    {
                        City = x.City,
                        Industry = x.Industry.HasValue ? (x.Industry.Value
                            .GetType()
                            .GetMember(x.Industry.Value.ToString())
                            .First()
                            .GetCustomAttributes(typeof(DisplayAttribute), false)
                            .First() as DisplayAttribute).Name : x.OtherIndustry,
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
                }
            }

            List<SocialActivity> activities = new List<SocialActivity>();

            if (profile.Memberships != null)
            {
                var activityList = profile.Memberships.ToList();

                if (activityList != null && activityList.Count > 0)
                {
                    activities = activityList.OrderMembership().Select(x => new SocialActivity
                    {
                        StartingYear = x.FromTime,
                        EndingYear = x.ToTime,
                        Description = x.Description
                    }).ToList();
                }
            }

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
