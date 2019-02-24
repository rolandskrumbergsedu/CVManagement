using CV.Management.Generation.Word;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CV.Management.Web.Controllers
{
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

        private static GenerationData GetGenerationData()
        {
            return new GenerationData
            {
                TitleArea = new TitleArea
                {
                    Date = "December 2018",
                    Name = "Rolands Krumbergs",
                    Title = "Confidential candidate CV"
                }
            };
        }
    }
}
