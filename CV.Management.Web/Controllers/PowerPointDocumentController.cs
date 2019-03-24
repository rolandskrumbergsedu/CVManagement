using CV.Management.Generation.Ppt;
using CV.Management.Web.DbContexts;
using CV.Management.Web.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CV.Management.Web.Controllers
{
    [Authorize]
    public class PowerPointDocumentController : ApiController
    {
        [HttpGet]
        [Route("api/pptdocument/{id}")]
        public HttpResponseMessage DownloadPdfFile(string id)
        {
            try
            {
                var documentManager = new PresentationDocumentManager();

                var bytes = documentManager.GetDocument(GetGenerationData(id));

                var result = Request.CreateResponse(HttpStatusCode.OK);
                result.Content = new ByteArrayContent(bytes);
                result.Content.Headers.ContentDisposition =
                    new System.Net.Http.Headers.ContentDispositionHeaderValue(
                            "attachment")
                    { FileName = "Test" + ".pptx" };

                return result;
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }

        private PresentationGenerationData GetGenerationData(string id)
        {
            using (var db = new ProfileInformationDbContext())
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

        private PresentationGenerationData DataFromProfile(Profile profile)
        {
            return new PresentationGenerationData
            {
                Date = GetCurrentDate(),
                FullName = profile.FullName,
                Email = profile.Email,
                Phone = profile.Phone,
                PictureContent = profile.PictureContent,
                PictureType = profile.PictureType,
                Education = GetEducationItems(profile.Educations),
                Languages = GetLanguageItems(profile.Languages),
                Motivation = GetMotivationItems(profile),
                Experience = GetExperienceItems(profile.Companies)
            };
        }

        private static List<EducationItem> GetEducationItems(ICollection<Education> educations)
        {
            return educations.Select(x => new EducationItem
            {
                Degree = x.Degree,
                EndYear = x.ToYear.HasValue ? x.ToYear.Value.ToString() : "Currently studying",
                University = x.Institution
            }).ToList();
        }

        private static List<LanguageItem> GetLanguageItems(ICollection<Language> languages)
        {
            var result = new List<LanguageItem>();

            foreach (var language in languages)
            {
                if ((int)language.SpokenLevel < (int)language.WrittenLevel)
                {
                    result.Add(new LanguageItem
                    {
                        LanguageLevel = language.SpokenLevel.ToString(),
                        LanguageName = language.LanguageName.ToString()
                    });
                }
                else
                {
                    result.Add(new LanguageItem
                    {
                        LanguageLevel = language.WrittenLevel.ToString(),
                        LanguageName = language.LanguageName.ToString()
                    });
                }
            }

            return result;
        }

        private static List<MotivationItem> GetMotivationItems(Profile profile)
        {
            var result = new List<MotivationItem>();

            if (!string.IsNullOrEmpty(profile.SalaryRequest))
            {
                result.Add(new MotivationItem
                {
                    Label = "Remuneration",
                    Content = profile.SalaryRequest
                });
            }

            if(!string.IsNullOrEmpty(profile.BonusRequest))
            {
                result.Add(new MotivationItem
                {
                    Label = "Requested bonuses",
                    Content = profile.BonusRequest
                });
            }

            if (!string.IsNullOrEmpty(profile.AdditionalBonuses))
            {
                result.Add(new MotivationItem
                {
                    Label = "Additional bonuses",
                    Content = profile.AdditionalBonuses
                });
            }

            return result;
        }

        private static List<ExperienceItem> GetExperienceItems(ICollection<Company> companies)
        {
            var result = new List<ExperienceItem>();

            foreach (var company in companies)
            {
                foreach (var position in company.Positions)
                {
                    result.Add(new ExperienceItem
                    {
                        Company = company.Name,
                        Position = position.Name,
                        StartingYear = position.FromTime.HasValue ? position.FromTime.Value.ToString() : string.Empty,
                        EndingYear = position.Now ? "present" : position.ToTime.HasValue ? position.ToTime.Value.ToString() : string.Empty
                    });
                }
            }

            return result;
        }
    }
}
