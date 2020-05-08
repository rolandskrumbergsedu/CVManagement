using CV.Management.Web.DbContexts;
using Microsoft.ApplicationInsights;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CV.Management.Web.Controllers
{
    [Authorize]
    public class FileDeletionController : ApiController
    {
        private readonly TelemetryClient telemetry = new TelemetryClient();

        [HttpGet]
        [Route("api/delete/{id}")]
        public HttpResponseMessage DeleteFile(string id)
        {
            using (var db = new ProfileInformationDbContext())
            {
                var userName = User.Identity.Name;

                telemetry.TrackEvent("DeleteFile", new Dictionary<string, string> { { "User", userName }, { "FileId", id} });

                var profile = db.Profiles.FirstOrDefault(x => x.Username == userName);

                var file = profile.AdditionalFiles.FirstOrDefault(x => x.AdditionalFileId == int.Parse(id));
                db.Entry(file).State = System.Data.Entity.EntityState.Deleted;

                db.SaveChanges();
            }

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpGet]
        [Route("api/deletebyusername")]
        public HttpResponseMessage DeleteFileByUsername()
        {
            using (var db = new ProfileInformationDbContext())
            {
                var userName = User.Identity.Name;

                telemetry.TrackEvent("DeleteFileByUsername", new Dictionary<string, string> { { "User", userName } });

                var profile = db.Profiles.FirstOrDefault(x => x.Username == userName);

                profile.PictureContent = null;
                profile.PictureType = null;

                db.SaveChanges();
            }

            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
