using CV.Management.Web.DbContexts;
using CV.Management.Web.Models;
using CV.Management.Web.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CV.Management.Web.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Overview()
        {
            using (var db = new ProfileInformationDbContext())
            {
                var currentUsername = User.Identity.Name;
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