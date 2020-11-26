using CV.Management.Generation.Ppt;
using CV.Management.Web.DbContexts;
using CV.Management.Web.Models;
using CV.Management.Web.Models.Database;
using Microsoft.ApplicationInsights;
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
        private readonly TelemetryClient telemetry = new TelemetryClient();

        [HttpGet]
        [Route("api/pptdocument/{language}/{id}")]
        public HttpResponseMessage DownloadPdfFile(string language, string id)
        {
            try
            {
                telemetry.TrackEvent("DownloadPdfFile", new Dictionary<string, string> { { "User", User.Identity.Name } });

                var documentManager = new PresentationDocumentManager();

                var generationData = GetGenerationData(language, id);
                var cleanedFullName = !string.IsNullOrEmpty(generationData.FullName) ? generationData.FullName.Replace(' ', '_') : string.Empty;

                var bytes = documentManager.GetDocument(GetGenerationData(language, id));

                var result = Request.CreateResponse(HttpStatusCode.OK);
                result.Content = new ByteArrayContent(bytes);
                result.Content.Headers.ContentDisposition =
                    new System.Net.Http.Headers.ContentDispositionHeaderValue(
                            "attachment")
                    { FileName = $"CV_{cleanedFullName}_{language.ToUpper()}" + ".pptx" };

                using (var db = new ProfileInformationDbContext())
                {
                    db.AuditLogs.Add(new AuditLog
                    {
                        AuditEvent = AuditEvent.DownloadPpt.ToString(),
                        EventTime = DateTime.Now,
                        UserAffected = generationData.FullName,
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

        private PresentationGenerationData GetGenerationData(string language, string id)
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

                return DataFromProfile(profile, language);
            }
        }

        private string GetCurrentDate(string language)
        {
            var year = DateTime.Now.Year.ToString();

            switch (DateTime.Now.Month)
            {
                case 1:
                    return $"{PresentationMetadataTexts.GetText(PresentationMetadataTextsEnum.CV_MONTH_JANUARY, language)} {year}";
                case 2:
                    return $"{PresentationMetadataTexts.GetText(PresentationMetadataTextsEnum.CV_MONTH_FEBRUARY, language)} {year}";
                case 3:
                    return $"{PresentationMetadataTexts.GetText(PresentationMetadataTextsEnum.CV_MONTH_MARCH, language)} {year}";
                case 4:
                    return $"{PresentationMetadataTexts.GetText(PresentationMetadataTextsEnum.CV_MONTH_APRIL, language)} {year}";
                case 5:
                    return $"{PresentationMetadataTexts.GetText(PresentationMetadataTextsEnum.CV_MONTH_MAY, language)} {year}";
                case 6:
                    return $"{PresentationMetadataTexts.GetText(PresentationMetadataTextsEnum.CV_MONTH_JUNE, language)} {year}";
                case 7:
                    return $"{PresentationMetadataTexts.GetText(PresentationMetadataTextsEnum.CV_MONTH_JULY, language)} {year}";
                case 8:
                    return $"{PresentationMetadataTexts.GetText(PresentationMetadataTextsEnum.CV_MONTH_AUGUST, language)} {year}";
                case 9:
                    return $"{PresentationMetadataTexts.GetText(PresentationMetadataTextsEnum.CV_MONTH_SEPTEMBER, language)} {year}";
                case 10:
                    return $"{PresentationMetadataTexts.GetText(PresentationMetadataTextsEnum.CV_MONTH_OCTOBER, language)} {year}";
                case 11:
                    return $"{PresentationMetadataTexts.GetText(PresentationMetadataTextsEnum.CV_MONTH_NOVEMBER, language)} {year}";
                case 12:
                    return $"{PresentationMetadataTexts.GetText(PresentationMetadataTextsEnum.CV_MONTH_DECEMBER, language)} {year}";
                default:
                    return "Unknown";
            }
        }

        private PresentationGenerationData DataFromProfile(Profile profile, string language)
        {
            return new PresentationGenerationData
            {
                Date = GetCurrentDate(language),
                FullName = profile.FullName,
                Email = profile.Email,
                Phone = profile.PhoneCode + profile.Phone,
                PictureContent = profile.PictureContent,
                PictureType = profile.PictureType,
                Education = GetEducationItems(profile.Educations, language),
                Languages = GetLanguageItems(profile.Languages),
                Motivation = GetMotivationItems(profile, language),
                Experience = GetExperienceItems(profile.Companies, language),
                Language = language
            };
        }

        private static List<Generation.Ppt.EducationItem> GetEducationItems(ICollection<Education> educations, string language)
        {
            return educations.Select(x => new Generation.Ppt.EducationItem
            {
                Degree = x.Degree,
                EndYear = x.ToYear.HasValue ? x.ToYear.Value.ToString() : PresentationMetadataTexts.GetText(PresentationMetadataTextsEnum.PRESENT, language),
                University = x.Institution
            }).ToList();
        }

        private static List<Generation.Ppt.LanguageItem> GetLanguageItems(ICollection<Language> languages)
        {
            var result = new List<Generation.Ppt.LanguageItem>();

            foreach (var language in languages)
            {
                if ((int)language.SpokenLevel < (int)language.WrittenLevel)
                {
                    result.Add(new Generation.Ppt.LanguageItem
                    {
                        LanguageLevel = language.SpokenLevel.ToString(),
                        LanguageName = string.IsNullOrEmpty(language.OtherLanguage) ? language.LanguageName.ToString() : language.OtherLanguage,
                    });
                }
                else
                {
                    result.Add(new Generation.Ppt.LanguageItem
                    {
                        LanguageLevel = language.WrittenLevel.ToString(),
                        LanguageName = string.IsNullOrEmpty(language.OtherLanguage) ? language.LanguageName.ToString() : language.OtherLanguage,
                    });
                }
            }

            return result;
        }

        private static List<MotivationItem> GetMotivationItems(Profile profile, string language)
        {
            var result = new List<MotivationItem>();

            if (!string.IsNullOrEmpty(profile.SalaryRequest))
            {
                result.Add(new MotivationItem
                {
                    Label = PresentationMetadataTexts.GetText(PresentationMetadataTextsEnum.RENUMERATION, language),
                    Content = profile.SalaryRequest
                });
            }

            if (!string.IsNullOrEmpty(profile.BonusRequest))
            {
                result.Add(new MotivationItem
                {
                    Label = PresentationMetadataTexts.GetText(PresentationMetadataTextsEnum.REQUESTED_BONUSES, language),
                    Content = profile.BonusRequest
                });
            }

            if (!string.IsNullOrEmpty(profile.AdditionalBonuses))
            {
                result.Add(new MotivationItem
                {
                    Label = PresentationMetadataTexts.GetText(PresentationMetadataTextsEnum.ADDITIONAL_BONUSES, language),
                    Content = profile.AdditionalBonuses
                });
            }

            return result;
        }

        private static List<ExperienceItem> GetExperienceItems(ICollection<Company> companies, string language)
        {
            var result = new List<ExperienceItem>();

            foreach (var company in companies)
            {
                foreach (var position in company.Positions)
                {
                    result.Add(new ExperienceItem
                    {
                        Company = company.Name?.ToUpper(),
                        Position = position.Name,
                        StartingYear = position.FromTime.HasValue ? position.FromTime.Value.ToString() : string.Empty,
                        EndingYear = position.Now ? PresentationMetadataTexts.GetText(PresentationMetadataTextsEnum.PRESENT, language) : position.ToTime.HasValue ? position.ToTime.Value.ToString() : string.Empty
                    });
                }
            }

            return result;
        }
    }
}
