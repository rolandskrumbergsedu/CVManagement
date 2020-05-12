using CV.Management.Web.DbContexts;
using CV.Management.Web.Models;
using CV.Management.Web.Models.Database;
using Microsoft.ApplicationInsights;
using System;
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
            try
            {
                telemetry.TrackPageView("Admin");

                var currentUsername = User.Identity.Name;

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

                    db.AuditLogs.Add(new AuditLog
                    {
                        AuditEvent = AuditEvent.ViewConfirmDeleteUserPage.ToString(),
                        EventTime = DateTime.Now,
                        UserAffected = profile.FullName,
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
                telemetry.TrackPageView("DeleteUser");

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
                            UserAffected = profile.FullName,
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