using CV.Management.Web.DbContexts;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CV.Management.Web.Controllers
{
    [Authorize]
    public class FileDeletionController : ApiController
    {
        [HttpGet]
        [Route("api/delete/{id}")]
        public HttpResponseMessage DeleteFile(string id)
        {
            using (var db = new ProfileInformationDbContext())
            {
                var userName = User.Identity.Name;
                var profile = db.Profiles.FirstOrDefault(x => x.Username == userName);

                var file = profile.AdditionalFiles.FirstOrDefault(x => x.AdditionalFileId == int.Parse(id));
                db.Entry(file).State = System.Data.Entity.EntityState.Deleted;

                db.SaveChanges();
            }

            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
