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
    //[Authorize]
    public class WordDocumentController : ApiController
    {
        [HttpGet]
        [Route("api/worddocument")]
        public HttpResponseMessage DownloadPdfFile()
        {
            try
            {
                var documentManager = new WordDocumentManager();

                var bytes = documentManager.GetDocument(GetGenerationData());

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
                return Request.CreateResponse(HttpStatusCode.Gone);
            }
        }

        private GenerationData GetGenerationData()
        {
            using(var db = new ProfileInformationDbContext())
            {
                var userName = "rolands.krumbergs@outlook.com";
               // var userName = User.Identity.Name;
                var profile = db.Profiles.FirstOrDefault(x => x.Username == userName);

                return DataFromProfile(profile);
            }
        }

        private string GetCurrentDate()
        {
            var year = DateTime.Now.Year.ToString();

            switch (DateTime.Now.Month)
            {
                case 1:
                    return $"January {year}";
                case 2:
                    return $"February {year}";
                case 3:
                    return $"March {year}";
                case 4:
                    return $"April {year}";
                case 5:
                    return $"May {year}";
                case 6:
                    return $"June {year}";
                case 7:
                    return $"July {year}";
                case 8:
                    return $"August {year}";
                case 9:
                    return $"September {year}";
                case 10:
                    return $"October {year}";
                case 11:
                    return $"November {year}";
                case 12:
                    return $"December {year}";
                default:
                    return "Unknown";
            }
        }

        private GenerationData DataFromProfile(Profile profile)
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
                Date = GetCurrentDate(),
                Name = profile.FullName,
                Title = "Confidential candidate CV",
                Project = profile.Project
            };

            var personal = new PersonalInformation
            {
                FullName = profile.FullName,
                Mobile = profile.Phone,
                Email = profile.Email,
                Address = profile.Address,
                Skype = profile.Skype,
                LinkedIn = profile.LinkedInLink
            };

            var education = profile.Educations.Select(x => new EducationItem
            {
                Degree = x.Degree,
                EndingYear = x.ToYear.Value,
                StartingYear = x.FromYear.Value,
                University = x.Institution
            }).ToList();

            var courses = profile.AdditionalCourses.Select(x => new AdditionalCoursesItem
            {
                AmountOfDays = x.NumberOfDays.Value,
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
                    EndingYear = y.ToTime.HasValue ? y.ToTime.Value : 0,
                    Now = y.Now,
                    ReasonForLeaving = y.ReasonForLeaving,
                    ReportingTo = y.ReportingTo,
                    Role = y.Name,
                    StartingYear = y.FromTime.HasValue ? y.FromTime.Value : 0,
                    Subordinates = y.DirectSubordinates,
                    Tasks = y.KeyTasks.Select(z => z.Name).ToList()
                }).ToList()

            }).ToList();

            var activities = profile.Memberships.Select(x => new SocialActivity
            {
                StartingYear = x.FromTime.HasValue ? x.FromTime.Value : 0,
                EndingYear = x.ToTime.HasValue ? x.ToTime.Value : 0,
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
                AdditionalComments = profile.Comments
            };
        }

        public string GetKeyTasks(List<KeyTask> tasks)
        {
            var sb = new StringBuilder();

            foreach (var task in tasks)
            {
                sb.Append("- " + task.Name + "\r\n");
            }

            return sb.ToString();
        }
    }
}
