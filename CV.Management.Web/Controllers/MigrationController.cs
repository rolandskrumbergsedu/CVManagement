using CV.Management.Web.DbContexts;
using CV.Management.Web.Models.Database;
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

        [HttpGet]
        [Route("api/migrations/achievements")]
        public HttpResponseMessage MigrateAchievements()
        {
            using (var db = new ProfileInformationDbContext())
            {
                var profiles = db.Profiles.ToList();

                foreach (var profile in profiles)
                {
                    var companies = profile.Companies.ToList();

                    foreach (var company in companies)
                    {
                        var positions = company.Positions.ToList();

                        foreach (var position in positions)
                        {
                            if ((position.AchievementList == null || position.AchievementList.Count == 0) && !string.IsNullOrEmpty(position.Achievements))
                            {
                                position.AchievementList = GetAchievements(position.Achievements);
                            }
                        }
                    }
                }

                db.SaveChanges();
            }

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        private static List<Achievement> GetAchievements(string achievements)
        {
            if (string.IsNullOrEmpty(achievements))
            {
                return null;
            }

            var achievementsList = achievements.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            var result = new List<Achievement>();

            foreach (var item in achievementsList)
            {
                var itemToAdd = item;
                if (itemToAdd.StartsWith("-"))
                {
                    itemToAdd = itemToAdd.Substring(1);
                }

                if (itemToAdd.StartsWith(" "))
                {
                    itemToAdd = itemToAdd.Substring(1);
                }

                result.Add(new Achievement
                {
                    Name = itemToAdd
                });
            }

            return result;
        }
    }
}