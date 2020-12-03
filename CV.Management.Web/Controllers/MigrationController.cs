using CV.Management.Web.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace CV.Management.Web.Controllers
{
    public class MigrationController : ApiController
    {
        [HttpGet]
        [Route("api/migrations/profileLanguage")]
        public HttpResponseMessage MigrateProfileDefaultLanguage()
        {
            using (var db = new ProfileInformationDbContext())
            {
                var emptyProfiles = db.Profiles.Where(x => x.Language == null);

                foreach (var profile in emptyProfiles)
                {
                    profile.Language = "en";
                }

                db.SaveChanges();
            }

            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}