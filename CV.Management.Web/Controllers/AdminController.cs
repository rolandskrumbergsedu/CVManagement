using CV.Management.Web.DbContexts;
using CV.Management.Web.Models;
using CV.Management.Web.Models.Database;
using Microsoft.ApplicationInsights;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace CV.Management.Web.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class AdminController : Controller
    {
        private readonly TelemetryClient telemetry = new TelemetryClient();

        // GET: Admin
        public ActionResult Overview()
        {
            using (var db = new ProfileInformationDbContext())
            {
                telemetry.TrackPageView("Admin");

                var currentUsername = User.Identity.Name;

                telemetry.TrackEvent("OpenAdmin", new Dictionary<string, string> { { "User", currentUsername } });

                var profile = db.Profiles.FirstOrDefault(x => x.Username == currentUsername);

                var profiles = db.Profiles.ToList();
                var viewmodel = ProfilesToViewModel(profile.FullName, profiles);

                return View(viewmodel);
            }

        }

        private AdminOverviewViewModel ProfilesToViewModel(string name, List<Profile> profiles)
        {
            return new AdminOverviewViewModel
            {
                Name = name,
                Profiles = profiles.Select(x => new ProfileAdminViewModel
                {
                    FullName = x.FullName,
                    ProfileId = x.ProfileId,
                    Username = x.Username
                }).ToList()
            };
        }
    }
}