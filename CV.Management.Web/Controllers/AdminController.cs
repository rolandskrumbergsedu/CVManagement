using CV.Management.Web.DbContexts;
using CV.Management.Web.Models;
using CV.Management.Web.Models.Database;
using Microsoft.ApplicationInsights;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace CV.Management.Web.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class AdminController : Controller
    {
        private readonly TelemetryClient telemetry = new TelemetryClient();
        private ApplicationUserManager _userManager;

        public AdminController()
        {
        }

        public AdminController(ApplicationUserManager userManager)
        {
            UserManager = userManager;
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        // GET: Admin
        [HttpGet]
        public ActionResult Overview()
        {
            try
            {
                var currentUsername = User.Identity.Name;

                telemetry.TrackPageView("Admin");
                telemetry.TrackEvent("OpenAdmin", new Dictionary<string, string> { { "User", currentUsername } });

                AdminOverviewViewModel viewmodel;

                using (var db = new ProfileInformationDbContext())
                {
                    using (var transaction = db.Database.BeginTransaction())
                    {
                        var profile = db.Profiles.FirstOrDefault(x => x.Username == currentUsername);

                        var profiles = db.Profiles.ToList();

                        viewmodel = ProfilesToViewModel(profile.FullName, profiles);

                        db.AuditLogs.Add(new AuditLog
                        {
                            AuditEvent = AuditEvent.ViewAdminPage.ToString(),
                            EventTime = DateTime.Now,
                            UserAffected = "None",
                            Username = currentUsername
                        });

                        db.SaveChanges();
                        transaction.Commit();
                    }

                    return View(viewmodel);
                }
            }
            catch (Exception ex)
            {
                telemetry.TrackException(ex);
                throw;
            }
        }

        [HttpGet]
        public ActionResult ConfirmUserDelete(string id)
        {
            try
            {
                telemetry.TrackPageView("ConfirmUserDelete");

                using (var db = new ProfileInformationDbContext())
                {
                    var currentUsername = User.Identity.Name;

                    telemetry.TrackPageView("ConfirmUserDelete");
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

                    db.AuditLogs.Add(new AuditLog
                    {
                        AuditEvent = AuditEvent.ViewConfirmDeleteUserPage.ToString(),
                        EventTime = DateTime.Now,
                        UserAffected = profile.Username,
                        UserAffectedId = id,
                        Username = currentUsername
                    });

                    db.SaveChanges();

                    return View(userModel);
                }
            }
            catch (Exception ex)
            {
                telemetry.TrackException(ex);
                throw;
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteUser(ConfirmUserDeleteViewModel viewModel)
        {
            try
            {
                var currentUsername = User.Identity.Name;

                telemetry.TrackEvent("DeleteUser", new Dictionary<string, string> { { "User", currentUsername } });

                using (var db = new ProfileInformationDbContext())
                {
                    using (var transaction = db.Database.BeginTransaction())
                    {
                        var profile = db.Profiles
                            .Include("Educations")
                            .Include("AdditionalCourses")
                            .Include("Languages")
                            .Include("Companies.Positions.KeyTasks")
                            .Include("Memberships")
                            .Include("AdditionalFiles")
                            .FirstOrDefault(x => x.ProfileId.ToString() == viewModel.Id);

                        db.Profiles.Remove(profile);

                        db.AuditLogs.Add(new AuditLog
                        {
                            AuditEvent = AuditEvent.DeleteUser.ToString(),
                            EventTime = DateTime.Now,
                            UserAffected = profile.Username,
                            UserAffectedId = viewModel.Id,
                            Username = currentUsername
                        });

                        db.SaveChanges();
                        transaction.Commit();

                        return RedirectToAction("Overview");
                    }
                }
            }
            catch (Exception ex)
            {
                telemetry.TrackException(ex);
                throw;
            }
        }

        [HttpGet]
        public async Task<ActionResult> UserMissing(UserMissingViewModel viewModel)
        {
            telemetry.TrackPageView("UserMissing");

            using (var db = new ProfileInformationDbContext())
            {
                var currentUsername = User.Identity.Name;

                telemetry.TrackPageView("ConfirmUserDelete");
                telemetry.TrackEvent("ConfirmUserDelete", new Dictionary<string, string> { { "User", currentUsername } });

                var profile = db.Profiles.FirstOrDefault(x => x.Username == currentUsername);

                return View(new UserMissingViewModel
                {
                    Name = profile.FullName
                });
            }
        }

        [HttpGet]
        public async Task<ActionResult> EditUser(string id)
        {
            telemetry.TrackPageView("EditUser");

            using (var db = new ProfileInformationDbContext())
            {
                var currentUsername = User.Identity.Name;

                telemetry.TrackPageView("EditUser");
                telemetry.TrackEvent("EditUser", new Dictionary<string, string> { { "User", currentUsername } });

                var profile = db.Profiles.FirstOrDefault(x => x.ProfileId.ToString() == id);

                var user = await UserManager.FindByEmailAsync(profile.Email);

                if (user == null)
                {
                    return RedirectToAction("UserMissing");
                }

                var isAdmin = (await UserManager.GetRolesAsync(user.Id)).Contains("Administrator");

                db.AuditLogs.Add(new AuditLog
                {
                    AuditEvent = AuditEvent.OpenEditUser.ToString(),
                    EventTime = DateTime.Now,
                    UserAffected = profile.Username,
                    UserAffectedId = id,
                    Username = currentUsername
                });

                return View(new EditUserViewModel()
                {
                    ProfileId = id,
                    UserId = user.Id,
                    Name = user.Name,
                    Surname = user.Surname,
                    Email = user.Email,
                    EmailConfirmed = user.EmailConfirmed,
                    IsAdmin = isAdmin,
                    SelectedAdminResponse = isAdmin ? "Yes" : "No"
                });
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditUser(EditUserViewModel user)
        {
            using (var db = new ProfileInformationDbContext())
            {
                var currentUsername = User.Identity.Name;

                telemetry.TrackEvent("EditUserSaved", new Dictionary<string, string> { { "User", currentUsername } });

                if (user.SelectedAdminResponse == "Yes")
                {
                    UserManager.AddToRole(user.UserId, "Administrator");

                    db.AuditLogs.Add(new AuditLog
                    {
                        AuditEvent = AuditEvent.UserAddedAsAdministrator.ToString(),
                        EventTime = DateTime.Now,
                        UserAffected = user.Email,
                        UserAffectedId = user.UserId,
                        Username = currentUsername
                    });
                }
                else
                {
                    UserManager.RemoveFromRole(user.UserId, "Administrator");
                    db.AuditLogs.Add(new AuditLog
                    {
                        AuditEvent = AuditEvent.UserRemovedFromAdministrators.ToString(),
                        EventTime = DateTime.Now,
                        UserAffected = user.Email,
                        UserAffectedId = user.UserId,
                        Username = currentUsername
                    });
                }

                db.SaveChanges();

                return RedirectToAction("Overview");
            }
        }

        [HttpGet]
        public ActionResult AccessDenied()
        {
            var currentUsername = User.Identity.Name;
            telemetry.TrackPageView("AdminAccessDenied");

            telemetry.TrackEvent("OpenAdminAccessDenied", new Dictionary<string, string> { { "User", currentUsername } });

            return View(new AdminAccessDeniedViewModel
            {
                Name = currentUsername
            });
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