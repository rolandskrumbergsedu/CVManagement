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
        [Route("api/pptdocument")]
        public HttpResponseMessage DownloadPdfFile()
        {
            try
            {
                var documentManager = new PresentationDocumentManager();

                var bytes = documentManager.GetDocument(GetGenerationData());

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

        private PresentationGenerationData GetGenerationData()
        {
            using (var db = new ProfileInformationDbContext())
            {
                var userName = User.Identity.Name;
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

        private PresentationGenerationData DataFromProfile(Profile profile)
        {
            return new PresentationGenerationData
            {
                Date = GetCurrentDate(),
                FullName = profile.FullName,
                Email = profile.Email,
                Phone = profile.Phone
            };
        }
    }
}
