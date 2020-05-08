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
        [HttpGet]
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

        [HttpGet]
        public ActionResult ConfirmUserDelete(string id)
        {
            using (var db = new ProfileInformationDbContext())
            {
                telemetry.TrackPageView("ConfirmUserDelete");

                var currentUsername = User.Identity.Name;

                telemetry.TrackEvent("ConfirmUserDelete", new Dictionary<string, string> { { "User", currentUsername } });

                var profile = db.Profiles.FirstOrDefault(x => x.ProfileId.ToString() == id);

                var userModel = new ConfirmUserDeleteViewModel
                {
                    Name = currentUsername,
                    Id = id,
                    Email = profile.Email,
                    FullName = profile.FullName,
                    LinkedInLink = profile.LinkedInLink,
                    Project = profile.Project,
                    Username = profile.Username
                };

                return View(userModel);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteUser(ConfirmUserDeleteViewModel model)
        {
            using (var db = new ProfileInformationDbContext())
            {
                telemetry.TrackPageView("DeleteUser");

                var currentUsername = User.Identity.Name;

                telemetry.TrackEvent("DeleteUser", new Dictionary<string, string> { { "User", currentUsername } });

                var profile = db.Profiles
                    .Include("Educations")
                    .Include("AdditionalCourses")
                    .Include("Languages")
                    .Include("Companies.Positions.KeyTasks")
                    .Include("Memberships")
                    .Include("AdditionalFiles")
                    .FirstOrDefault(x => x.ProfileId.ToString() == model.Id);
                
                db.Profiles.Remove(profile);
                db.SaveChanges();

                return RedirectToAction("Overview"); 
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