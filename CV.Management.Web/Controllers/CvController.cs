using CV.Management.Web.DbContexts;
using CV.Management.Web.Models;
using CV.Management.Web.Models.Database;
using Microsoft.ApplicationInsights;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace CV.Management.Web.Controllers
{
    [Authorize]
    public class CvController : Controller
    {
        private readonly TelemetryClient telemetry = new TelemetryClient();

        [HttpGet]
        public ActionResult Profile(string language)
        {
            try
            {
                telemetry.TrackPageView("Profile");

                if (!string.IsNullOrEmpty(language))
                {
                    if (language == "lv")
                    {
                        Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("lv");
                        Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("lv");
                        telemetry.TrackEvent("OpenProfile", new Dictionary<string, string> { { "Language", "lv" } });
                    }
                    else
                    {
                        Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en");
                        Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
                        telemetry.TrackEvent("OpenProfile", new Dictionary<string, string> { { "Language", "en" } });
                    }
                }
                else
                {
                    if (ControllerContext.HttpContext.Request.Cookies.AllKeys.Contains("language"))
                    {
                        HttpCookie cookie = ControllerContext.HttpContext.Request.Cookies["language"];

                        if (cookie.Value == "lv")
                        {
                            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("lv");
                            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("lv");
                            telemetry.TrackEvent("OpenProfile", new Dictionary<string, string> { { "Language", "lv" } });
                        }
                        else
                        {
                            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en");
                            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
                            telemetry.TrackEvent("OpenProfile", new Dictionary<string, string> { { "Language", "en" } });
                        };
                    }
                }
                return View(GetCurrentUserProfileViewModel());
            }
            catch (Exception ex)
            {
                telemetry.TrackException(ex);
                throw;
            }
        }

        [HttpGet]
        public ActionResult Error()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete()
        {
            try
            {
                telemetry.TrackPageView("Delete");

                var username = GetCurrentUsername();

                telemetry.TrackEvent("DeletePicture", new Dictionary<string, string> { { "User", username } });

                if (!string.IsNullOrEmpty(username))
                {
                    using (var db = new ProfileInformationDbContext())
                    {
                        var userProfile = db.Profiles.FirstOrDefault(x => x.Username == username);

                        if (userProfile != null)
                        {
                            userProfile.PictureContent = null;
                            userProfile.PictureType = null;

                            db.SaveChanges();
                        }
                    }
                }

                return RedirectToAction("Profile");
            }
            catch (Exception ex)
            {
                telemetry.TrackException(ex);
                throw;
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AdditionalFiles(IEnumerable<HttpPostedFileBase> files)
        {
            try
            {


                telemetry.TrackPageView("AdditionalFiles");

                if (files != null && files.Any())
                {
                    var allFilesToAdd = new List<AdditionalFile>();

                    foreach (var file in files)
                    {
                        if (file != null && file.ContentLength > 0)
                        {
                            using (var ms = new MemoryStream())
                            {
                                file.InputStream.CopyTo(ms);

                                var additionalFile = new AdditionalFile
                                {
                                    FileContent = Convert.ToBase64String(ms.ToArray()),
                                    FileName = file.FileName,
                                    FileType = file.ContentType
                                };

                                allFilesToAdd.Add(additionalFile);
                            }
                        }
                    }

                    using (var db = new ProfileInformationDbContext())
                    {
                        var username = GetCurrentUsername();
                        var userProfile = db.Profiles.FirstOrDefault(x => x.Username == username);

                        if (userProfile != null)
                        {
                            if (userProfile.AdditionalFiles == null)
                            {
                                userProfile.AdditionalFiles = allFilesToAdd;
                            }
                            else
                            {
                                foreach (var additionalFile in allFilesToAdd)
                                {
                                    userProfile.AdditionalFiles.Add(additionalFile);
                                }
                            }
                        }
                        else
                        {
                            db.Profiles.Add(new Profile
                            {
                                AdditionalFiles = allFilesToAdd
                            });
                        }

                        db.SaveChanges();
                    }
                }

                return RedirectToAction("Profile");
            }
            catch (Exception ex)
            {
                telemetry.TrackException(ex);
                throw;
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ProfileSummary(ProfileViewModel profileViewModel)
        {
            try
            {

                telemetry.TrackEvent("SubmitProfileSummary");

                if (ModelState.IsValid)
                {
                    using (var db = new ProfileInformationDbContext())
                    {
                        var username = GetCurrentUsername();
                        var userProfile = db.Profiles.FirstOrDefault(x => x.Username == username);

                        if (userProfile != null)
                        {
                            userProfile.Address = profileViewModel.PersonalInformationViewModel.Address;
                            userProfile.Email = profileViewModel.PersonalInformationViewModel.Email;
                            userProfile.FullName = profileViewModel.PersonalInformationViewModel.FullName;
                            userProfile.LinkedInLink = profileViewModel.PersonalInformationViewModel.LinkedInLink;
                            userProfile.Phone = profileViewModel.PersonalInformationViewModel.Phone;
                            userProfile.PhoneCode = profileViewModel.PersonalInformationViewModel.PhoneCode;
                            userProfile.Project = profileViewModel.PersonalInformationViewModel.Project;
                            userProfile.OtherInformation = profileViewModel.PersonalInformationViewModel.OtherInformation;
                            userProfile.CurrentBonuses = profileViewModel.CompensationViewModel.CurrentBonuses;
                            userProfile.CurrentSalary = profileViewModel.CompensationViewModel.CurrentSalary;
                            userProfile.SalaryRequest = profileViewModel.CompensationViewModel.SalaryRequest;
                            userProfile.BonusRequest = profileViewModel.CompensationViewModel.BonusRequest;
                            userProfile.AdditionalBonuses = profileViewModel.CompensationViewModel.AdditionalBonuses;
                            userProfile.NoticePeriod = profileViewModel.NoticePeriodViewModel.NoticePeriod;
                            userProfile.Comments = profileViewModel.AdditionalCommentsViewModel.Comments;

                            if (profileViewModel.PersonalInformationViewModel.ProfilePicture != null && profileViewModel.PersonalInformationViewModel.ProfilePicture.ContentLength > 0)
                            {
                                var ms = new MemoryStream();
                                profileViewModel.PersonalInformationViewModel.ProfilePicture.InputStream.CopyTo(ms);

                                userProfile.PictureContent = Convert.ToBase64String(ms.ToArray());
                                userProfile.PictureType = profileViewModel.PersonalInformationViewModel.ProfilePicture.ContentType;
                            }

                            if (userProfile.Educations != null)
                            {
                                userProfile.Educations.ToList().ForEach(x => db.Entry(x).State = System.Data.Entity.EntityState.Deleted);
                            }

                            foreach (var educationItem in profileViewModel.EducationViewModel.Education)
                            {
                                userProfile.Educations.Add(new Education
                                {
                                    Degree = educationItem.Degree,
                                    FromYear = educationItem.FromYear,
                                    Institution = educationItem.Institution,
                                    ToYear = educationItem.ToYear,
                                    Now = educationItem.Now
                                });
                            }

                            if (userProfile.AdditionalCourses != null)
                            {
                                userProfile.AdditionalCourses.ToList().ForEach(x => db.Entry(x).State = System.Data.Entity.EntityState.Deleted);

                                foreach (var item in profileViewModel.AdditionalCoursesViewModel.Courses)
                                {
                                    userProfile.AdditionalCourses.Add(new AdditionalCourse
                                    {
                                        CourseName = item.CourseName,
                                        NumberOfDays = item.NumberOfDays,
                                        Trainer = item.Trainer,
                                        Year = item.Year
                                    });
                                }
                            }

                            if (userProfile.Languages != null)
                            {
                                userProfile.Languages.ToList().ForEach(x => db.Entry(x).State = System.Data.Entity.EntityState.Deleted);

                                foreach (var item in profileViewModel.LanguageViewModel.Languages)
                                {
                                    userProfile.Languages.Add(new Language
                                    {
                                        LanguageName = item.LanguageName,
                                        SpokenLevel = item.SpokenLevel,
                                        WrittenLevel = item.WrittenLevel
                                    });
                                }
                            }

                            if (userProfile.Companies != null)
                            {
                                var companies = userProfile.Companies.ToList();
                                foreach (var item in companies)
                                {
                                    var positions = item.Positions.ToList();

                                    foreach (var position in positions)
                                    {
                                        position.KeyTasks.ToList().ForEach(x => db.Entry(x).State = System.Data.Entity.EntityState.Deleted);
                                        db.Entry(position).State = System.Data.Entity.EntityState.Deleted;
                                    }

                                    db.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                                }

                                foreach (var item in profileViewModel.CareerSummaryViewModel.Companies)
                                {
                                    var company = new Company
                                    {
                                        City = item.City,
                                        Industry = item.Industry,
                                        MainProductions = item.MainProductions,
                                        Name = item.Name,
                                        NumberOfEmployess = item.NumberOfEmployess,
                                        OtherIndustry = item.Industry != Industry.Other ? item.OtherIndustry : null,
                                        ParentCompanyName = item.ParentCompanyName,
                                        Turnover = item.Turnover,
                                        Positions = new List<Position>()
                                    };

                                    foreach (var position in item.Positions)
                                    {
                                        int? fromTime = null;
                                        int? fromTimeMonth = null;
                                        int? toTime = null;
                                        int? toTimeMonth = null;

                                        if (position.FromTime != null)
                                        {
                                            fromTime = position.FromTime.Contains(".") ? int.Parse(position.FromTime.Split('.')[1]) : int.Parse(position.FromTime);
                                            fromTimeMonth = position.FromTime.Contains(".") ? int.Parse(position.FromTime.Split('.')[0]) : (int?)null;
                                        }

                                        if (position.ToTime != null)
                                        {
                                            toTime = position.ToTime.Contains(".") ? int.Parse(position.ToTime.Split('.')[1]) : int.Parse(position.ToTime);
                                            toTimeMonth = position.ToTime.Contains(".") ? int.Parse(position.ToTime.Split('.')[0]) : (int?)null;
                                        }

                                        company.Positions.Add(new Position
                                        {
                                            Achievements = position.Achievements,
                                            DirectSubordinates = position.DirectSubordinates,
                                            FromTime = fromTime,
                                            FromTimeMonth = fromTimeMonth,
                                            KeyTasks = GetKeyTasks(position.KeyTasks),
                                            Name = position.Name,
                                            ReasonForLeaving = position.ReasonForLeaving,
                                            ReportingTo = position.ReportingTo,
                                            ToTime = toTime,
                                            ToTimeMonth = toTimeMonth,
                                            Now = position.Now
                                        });
                                    }

                                    userProfile.Companies.Add(company);
                                }
                            }

                            if (userProfile.Memberships != null)
                            {
                                userProfile.Memberships.ToList().ForEach(x => db.Entry(x).State = System.Data.Entity.EntityState.Deleted);

                                foreach (var item in profileViewModel.MembershipViewModel.Memberships)
                                {
                                    userProfile.Memberships.Add(new Membership
                                    {
                                        Description = item.Description,
                                        FromTime = item.FromTime,
                                        ToTime = item.ToTime,
                                        Now = item.Now
                                    });
                                }
                            }

                            if (userProfile.AdditionalFiles != null)
                            {
                                var listOfIdsToExclude = new List<int>();

                                if (profileViewModel.AdditionalFilesViewModel.Files != null && profileViewModel.AdditionalFilesViewModel.Files.Count() > 0)
                                {
                                    profileViewModel.AdditionalFilesViewModel.Files.ForEach(x => listOfIdsToExclude.Add(x.AdditionalFileId));
                                }

                                userProfile.AdditionalFiles.Where(x => !listOfIdsToExclude.Exists(y => y == x.AdditionalFileId)).ToList().ForEach(x => db.Entry(x).State = System.Data.Entity.EntityState.Deleted);

                                if (profileViewModel.AdditionalFilesViewModel.AdditionalFiles != null && profileViewModel.AdditionalFilesViewModel.AdditionalFiles.Count() > 0)
                                {
                                    foreach (var additionalFile in profileViewModel.AdditionalFilesViewModel.AdditionalFiles)
                                    {
                                        if (additionalFile != null)
                                        {
                                            var ms = new MemoryStream();
                                            additionalFile.InputStream.CopyTo(ms);

                                            userProfile.AdditionalFiles.Add(new AdditionalFile
                                            {
                                                FileContent = Convert.ToBase64String(ms.ToArray()),
                                                FileType = additionalFile.ContentType,
                                                FileName = additionalFile.FileName
                                            });
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            var profile = new Profile
                            {
                                Username = GetCurrentUsername(),
                                Address = profileViewModel.PersonalInformationViewModel.Address,
                                Email = profileViewModel.PersonalInformationViewModel.Email,
                                FullName = profileViewModel.PersonalInformationViewModel.FullName,
                                LinkedInLink = profileViewModel.PersonalInformationViewModel.LinkedInLink,
                                Phone = profileViewModel.PersonalInformationViewModel.Phone,
                                PhoneCode = profileViewModel.PersonalInformationViewModel.PhoneCode,
                                Project = profileViewModel.PersonalInformationViewModel.Project,
                                OtherInformation = profileViewModel.PersonalInformationViewModel.OtherInformation,
                                CurrentBonuses = profileViewModel.CompensationViewModel.CurrentBonuses,
                                CurrentSalary = profileViewModel.CompensationViewModel.CurrentSalary,
                                SalaryRequest = profileViewModel.CompensationViewModel.SalaryRequest,
                                BonusRequest = profileViewModel.CompensationViewModel.BonusRequest,
                                AdditionalBonuses = profileViewModel.CompensationViewModel.AdditionalBonuses,
                                NoticePeriod = profileViewModel.NoticePeriodViewModel.NoticePeriod,
                                Comments = profileViewModel.AdditionalCommentsViewModel.Comments,
                                Educations = new List<Education>(),
                                AdditionalCourses = new List<AdditionalCourse>(),
                                Languages = new List<Language>(),
                                Companies = new List<Company>(),
                                Memberships = new List<Membership>()
                            };

                            if (profileViewModel.PersonalInformationViewModel.ProfilePicture != null && profileViewModel.PersonalInformationViewModel.ProfilePicture.ContentLength > 0)
                            {
                                var ms = new MemoryStream();
                                profileViewModel.PersonalInformationViewModel.ProfilePicture.InputStream.CopyTo(ms);

                                profile.PictureContent = Convert.ToBase64String(ms.ToArray());
                                profile.PictureType = profileViewModel.PersonalInformationViewModel.ProfilePicture.ContentType;
                            }

                            foreach (var educationItem in profileViewModel.EducationViewModel.Education)
                            {
                                profile.Educations.Add(new Education
                                {
                                    Degree = educationItem.Degree,
                                    FromYear = educationItem.FromYear,
                                    Institution = educationItem.Institution,
                                    ToYear = educationItem.ToYear,
                                    Now = educationItem.Now
                                });
                            }

                            foreach (var item in profileViewModel.AdditionalCoursesViewModel.Courses)
                            {
                                profile.AdditionalCourses.Add(new AdditionalCourse
                                {
                                    CourseName = item.CourseName,
                                    NumberOfDays = item.NumberOfDays,
                                    Trainer = item.Trainer,
                                    Year = item.Year
                                });
                            }

                            foreach (var item in profileViewModel.LanguageViewModel.Languages)
                            {
                                userProfile.Languages.Add(new Language
                                {
                                    LanguageName = item.LanguageName,
                                    SpokenLevel = item.SpokenLevel,
                                    WrittenLevel = item.WrittenLevel
                                });
                            }

                            foreach (var item in profileViewModel.CareerSummaryViewModel.Companies)
                            {
                                var company = new Company
                                {
                                    City = item.City,
                                    Industry = item.Industry,
                                    MainProductions = item.MainProductions,
                                    Name = item.Name,
                                    NumberOfEmployess = item.NumberOfEmployess,
                                    OtherIndustry = item.Industry != Industry.Other ? item.OtherIndustry : null,
                                    ParentCompanyName = item.ParentCompanyName,
                                    Turnover = item.Turnover,
                                    Positions = new List<Position>()
                                };

                                foreach (var position in item.Positions)
                                {
                                    company.Positions.Add(new Position
                                    {
                                        Achievements = position.Achievements,
                                        DirectSubordinates = position.DirectSubordinates,
                                        FromTime = position.FromTime.Contains(".") ? int.Parse(position.FromTime.Split('.')[1]) : int.Parse(position.FromTime),
                                        FromTimeMonth = position.FromTime.Contains(".") ? int.Parse(position.FromTime.Split('.')[0]) : (int?)null,
                                        KeyTasks = GetKeyTasks(position.KeyTasks),
                                        Name = position.Name,
                                        ReasonForLeaving = position.ReasonForLeaving,
                                        ReportingTo = position.ReportingTo,
                                        ToTime = position.ToTime.Contains(".") ? int.Parse(position.ToTime.Split('.')[1]) : int.Parse(position.ToTime),
                                        ToTimeMonth = position.ToTime.Contains(".") ? int.Parse(position.ToTime.Split('.')[0]) : (int?)null,
                                        Now = position.Now
                                    });
                                }

                                userProfile.Companies.Add(company);
                            }

                            foreach (var item in profileViewModel.MembershipViewModel.Memberships)
                            {
                                userProfile.Memberships.Add(new Membership
                                {
                                    Description = item.Description,
                                    FromTime = item.FromTime,
                                    ToTime = item.ToTime,
                                    Now = item.Now
                                });
                            }



                            db.Profiles.Add(profile);
                        }

                        db.SaveChanges();
                    }
                }
                else
                {
                    var errors = ModelState.Where(x => x.Value.Errors.Count > 0);

                    var result = new Dictionary<string, string>();
                    result.Add("User", GetCurrentUsername());
                    foreach (var error in errors)
                    {
                        result.Add($"{Guid.NewGuid()}-{error.Key}", string.Join(", ", error.Value.Errors.Select(_ => _.ErrorMessage)));
                    }

                    telemetry.TrackEvent("InvalidProfileSummary", result);

                }
                return RedirectToAction("Profile");
            }
            catch (Exception ex)
            {
                telemetry.TrackException(ex);
                throw;
            }
        }

        private string GetCurrentUsername()
        {
            return User.Identity.Name;
        }

        private ProfileViewModel GetCurrentUserProfileViewModel()
        {
            using (var db = new ProfileInformationDbContext())
            {
                var currentUsername = GetCurrentUsername();
                var profile = db.Profiles.FirstOrDefault(x => x.Username == currentUsername);

                if (profile == null)
                {
                    return CreateEmptyProfileViewModel();
                }

                return new ProfileViewModel
                {
                    Name = profile.FullName,
                    PersonalInformationViewModel = CreatePersonalInformationViewModel(profile),
                    EducationViewModel = CreateEducationViewModel(profile),
                    AdditionalCoursesViewModel = CreateAdditionalCoursesViewModel(profile),
                    LanguageViewModel = CreateLanguageViewModel(profile),
                    CareerSummaryViewModel = CreateCareerSummaryViewModel(profile),
                    MembershipViewModel = CreateMembershipViewModel(profile),
                    CompensationViewModel = CreateCompensationViewModel(profile),
                    NoticePeriodViewModel = CreateNoticePeriodViewModel(profile),
                    AdditionalCommentsViewModel = CreateAdditionalCommentsViewModel(profile),
                    AdditionalFilesViewModel = CreateAdditionalFilesViewModel(profile)
                };
            }
        }

        private AdditionalFilesViewModel CreateAdditionalFilesViewModel(Profile profile)
        {
            if (profile.AdditionalFiles == null)
            {
                return new AdditionalFilesViewModel
                {
                    Files = new List<AdditionalFileItem>()
                };
            }
            else
            {
                return new AdditionalFilesViewModel
                {
                    Files = profile.AdditionalFiles.Select(x => new AdditionalFileItem
                    {
                        AdditionalFileId = x.AdditionalFileId,
                        FileName = x.FileName
                    }).ToList()
                };
            }
        }

        private PersonalInformationViewModel CreatePersonalInformationViewModel(Profile profile)
        {
            return new PersonalInformationViewModel
            {
                Address = profile.Address,
                Email = profile.Email,
                FullName = profile.FullName,
                LinkedInLink = profile.LinkedInLink,
                Phone = profile.Phone,
                PhoneCode = profile.PhoneCode,
                Project = profile.Project,
                OtherInformation = profile.OtherInformation,
                ImageSrc = !string.IsNullOrEmpty(profile.PictureContent) ? $"data:{profile.PictureType};base64,{profile.PictureContent}" : string.Empty
            };
        }

        private EducationViewModel CreateEducationViewModel(Profile profile)
        {
            if (profile.Educations == null)
            {
                return new EducationViewModel
                {
                    Education = new List<EducationItem>
                    {
                        new EducationItem
                        {
                            Degree = string.Empty,
                            FromYear = null,
                            Institution = string.Empty,
                            ToYear = null,
                            Now = false
                        }
                    }
                };
            }
            else
            {
                var educationViewModel = new EducationViewModel
                {
                    Education = new List<EducationItem>()
                };

                if (profile.Educations.Count == 0)
                {
                    educationViewModel.Education.Add(new EducationItem
                    {
                        Degree = string.Empty,
                        FromYear = null,
                        Institution = string.Empty,
                        ToYear = null,
                        Now = false
                    });
                }
                else
                {
                    var orderedEducation = profile.Educations.ToList().OrderEducation();

                    foreach (var educationItem in orderedEducation)
                    {
                        educationViewModel.Education.Add(new EducationItem
                        {
                            Degree = educationItem.Degree,
                            FromYear = educationItem.FromYear,
                            Institution = educationItem.Institution,
                            ToYear = educationItem.ToYear,
                            Now = educationItem.Now
                        });
                    }
                }

                return educationViewModel;
            }
        }

        private AdditionalCoursesViewModel CreateAdditionalCoursesViewModel(Profile profile)
        {
            if (profile.AdditionalCourses == null)
            {
                return new AdditionalCoursesViewModel
                {
                    Courses = new List<Course>
                    {
                        new Course
                        {
                            CourseName = string.Empty,
                            NumberOfDays = null,
                            Trainer = string.Empty,
                            Year = null
                        }
                    }
                };
            }
            else
            {
                var additionalCoursesViewModel = new AdditionalCoursesViewModel
                {
                    Courses = new List<Course>()
                };

                if (profile.AdditionalCourses.Count == 0)
                {
                    additionalCoursesViewModel.Courses.Add(new Course
                    {
                        CourseName = string.Empty,
                        NumberOfDays = null,
                        Trainer = string.Empty,
                        Year = null
                    });
                }
                else
                {
                    var orderedCourses = profile.AdditionalCourses.ToList().OrderAdditionalCourse();

                    foreach (var courseItem in orderedCourses)
                    {
                        additionalCoursesViewModel.Courses.Add(new Course
                        {
                            CourseName = courseItem.CourseName,
                            NumberOfDays = courseItem.NumberOfDays,
                            Trainer = courseItem.Trainer,
                            Year = courseItem.Year
                        });
                    }
                }

                return additionalCoursesViewModel;
            }
        }

        private LanguageViewModel CreateLanguageViewModel(Profile profile)
        {
            if (profile.Languages == null)
            {
                return new LanguageViewModel
                {
                    Languages = new List<LanguageItem>
                    {
                        new LanguageItem
                        {
                            LanguageName = null,
                            SpokenLevel = null,
                            WrittenLevel = null
                        }
                    }
                };
            }
            else
            {
                var languageViewModel = new LanguageViewModel
                {
                    Languages = new List<LanguageItem>()
                };

                if (profile.Languages.Count == 0)
                {
                    languageViewModel.Languages.Add(new LanguageItem
                    {
                        LanguageName = null,
                        SpokenLevel = null,
                        WrittenLevel = null
                    });
                }
                else
                {
                    foreach (var languageItem in profile.Languages)
                    {
                        languageViewModel.Languages.Add(new LanguageItem
                        {
                            LanguageName = languageItem.LanguageName,
                            SpokenLevel = languageItem.SpokenLevel,
                            WrittenLevel = languageItem.WrittenLevel
                        });
                    }
                }
                return languageViewModel;
            };
        }

        private CareerSummaryViewModel CreateCareerSummaryViewModel(Profile profile)
        {
            if (profile.Companies == null)
            {
                return new CareerSummaryViewModel
                {
                    Companies = new List<CompanyItem>
                    {
                        new CompanyItem
                        {
                            City = string.Empty,
                            Industry = null,
                            MainProductions = string.Empty,
                            Name = string.Empty,
                            NumberOfEmployess = null,
                            OtherIndustry = string.Empty,
                            ParentCompanyName = string.Empty,
                            Turnover = null,
                            Positions = new List<PositionItem>
                            {
                                new PositionItem()
                            }

                        }
                    }
                };
            }
            else
            {
                var careerSummaryViewModel = new CareerSummaryViewModel
                {
                    Companies = new List<CompanyItem>()
                };

                if (profile.Companies.Count == 0)
                {
                    var companyViewModel = new CompanyItem
                    {
                        City = string.Empty,
                        Industry = null,
                        MainProductions = string.Empty,
                        Name = string.Empty,
                        NumberOfEmployess = null,
                        OtherIndustry = string.Empty,
                        ParentCompanyName = string.Empty,
                        Turnover = null,
                        Positions = new List<PositionItem>
                        {
                            new PositionItem
                            {
                                Achievements = string.Empty,
                                DirectSubordinates = string.Empty,
                                FromTime = null,
                                KeyTasks = string.Empty,
                                Name = string.Empty,
                                ReasonForLeaving = string.Empty,
                                ReportingTo = string.Empty,
                                ToTime = null,
                                Now = false
                            }
                        }
                    };

                    careerSummaryViewModel.Companies.Add(companyViewModel);
                }
                else
                {
                    var companiesToReturn = profile.Companies.ToList().OrderCompanies();

                    foreach (var company in companiesToReturn)
                    {
                        var companyViewModel = new CompanyItem
                        {
                            City = company.City,
                            Industry = company.Industry,
                            MainProductions = company.MainProductions,
                            Name = company.Name,
                            NumberOfEmployess = company.NumberOfEmployess,
                            OtherIndustry = company.OtherIndustry,
                            ParentCompanyName = company.ParentCompanyName,
                            Turnover = company.Turnover,
                            Positions = new List<PositionItem>()
                        };

                        foreach (var position in company.Positions)
                        {
                            var fromTime = position.FromTimeMonth.HasValue ?
                                position.FromTime.HasValue ? position.FromTimeMonth + "." + position.FromTime.Value : position.FromTimeMonth + "." :
                                position.FromTime.HasValue ? position.FromTime.ToString() : "";

                            var toTime = position.ToTimeMonth.HasValue ?
                                position.ToTime.HasValue ? position.ToTimeMonth + "." + position.ToTime.Value : position.ToTimeMonth + "." :
                                position.ToTime.HasValue ? position.ToTime.ToString() : "";

                            companyViewModel.Positions.Add(new PositionItem
                            {
                                Achievements = position.Achievements,
                                DirectSubordinates = position.DirectSubordinates,
                                FromTime = fromTime,
                                KeyTasks = GetKeyTasks(position.KeyTasks.ToList()),
                                Name = position.Name,
                                ReasonForLeaving = position.ReasonForLeaving,
                                ReportingTo = position.ReportingTo,
                                ToTime = toTime,
                                Now = position.Now
                            });
                        }

                        careerSummaryViewModel.Companies.Add(companyViewModel);
                    }
                }
                return careerSummaryViewModel;
            }
        }

        private MembershipViewModel CreateMembershipViewModel(Profile profile)
        {
            var memberships = profile.Memberships;

            if (memberships == null)
            {
                return new MembershipViewModel
                {
                    Memberships = new List<MembershipItem>
                    {
                        new MembershipItem
                        {
                            Description = string.Empty,
                            FromTime = null,
                            ToTime = null,
                            Now = false
                        }
                    }
                };
            }
            else
            {
                var membershipViewModel = new MembershipViewModel
                {
                    Memberships = new List<MembershipItem>()
                };

                if (memberships.Count == 0)
                {
                    membershipViewModel.Memberships.Add(new MembershipItem
                    {
                        Description = string.Empty,
                        FromTime = null,
                        ToTime = null,
                        Now = false
                    });
                }
                else
                {
                    var orderedMemberships = memberships.ToList().OrderMembership();

                    foreach (var membership in orderedMemberships)
                    {
                        membershipViewModel.Memberships.Add(new MembershipItem
                        {
                            Description = membership.Description,
                            FromTime = membership.FromTime,
                            ToTime = membership.ToTime,
                            Now = membership.Now
                        });
                    }
                }

                return membershipViewModel;
            }
        }

        private CompensationViewModel CreateCompensationViewModel(Profile profile)
        {
            return new CompensationViewModel
            {
                AdditionalBonuses = profile.AdditionalBonuses,
                BonusRequest = profile.BonusRequest,
                CurrentBonuses = profile.CurrentBonuses,
                CurrentSalary = profile.CurrentSalary,
                SalaryRequest = profile.SalaryRequest
            };
        }

        private NoticePeriodViewModel CreateNoticePeriodViewModel(Profile profile)
        {
            return new NoticePeriodViewModel
            {
                NoticePeriod = profile.NoticePeriod
            };
        }

        private AdditionalCommentsViewModel CreateAdditionalCommentsViewModel(Profile profile)
        {
            return new AdditionalCommentsViewModel
            {
                Comments = profile.Comments
            };
        }

        private ProfileViewModel CreateEmptyProfileViewModel()
        {
            return new ProfileViewModel
            {
                PersonalInformationViewModel = new PersonalInformationViewModel
                {
                    Address = string.Empty,
                    Email = string.Empty,
                    FullName = string.Empty,
                    LinkedInLink = string.Empty,
                    PhoneCode = string.Empty,
                    Phone = string.Empty,
                    Project = string.Empty,
                    OtherInformation = string.Empty
                },
                EducationViewModel = new EducationViewModel
                {
                    Education = new List<EducationItem>()
                    {
                        new EducationItem
                        {
                            Degree = string.Empty,
                            FromYear = null,
                            Institution = string.Empty,
                            ToYear = null
                        }
                    }
                },
                AdditionalCoursesViewModel = new AdditionalCoursesViewModel
                {
                    Courses = new List<Course>
                    {
                        new Course
                        {
                            CourseName = string.Empty,
                            NumberOfDays = null,
                            Trainer = string.Empty,
                            Year = null
                        }
                    }
                },
                LanguageViewModel = new LanguageViewModel
                {
                    Languages = new System.Collections.Generic.List<LanguageItem>
                    {
                        new LanguageItem
                        {
                            LanguageName = null,
                            SpokenLevel = null,
                            WrittenLevel = null
                        }
                    }
                },
                CareerSummaryViewModel = new CareerSummaryViewModel
                {
                    Companies = new System.Collections.Generic.List<CompanyItem>
                    {
                        new CompanyItem
                        {
                            City = string.Empty,
                            Industry = null,
                            MainProductions = string.Empty,
                            Name = string.Empty,
                            NumberOfEmployess = null,
                            OtherIndustry = string.Empty,
                            ParentCompanyName = string.Empty,
                            Turnover = null,
                            Positions = new System.Collections.Generic.List<PositionItem>
                            {
                                new PositionItem
                                {
                                    Achievements = string.Empty,
                                    DirectSubordinates = string.Empty,
                                    FromTime = null,
                                    KeyTasks = string.Empty,
                                    Name = string.Empty,
                                    ReasonForLeaving = string.Empty,
                                    ReportingTo = string.Empty,
                                    ToTime = null
                                }
                            }
                        }
                    }
                },
                MembershipViewModel = new MembershipViewModel
                {
                    Memberships = new System.Collections.Generic.List<MembershipItem>
                    {
                        new MembershipItem
                        {
                            ToTime = null,
                            FromTime = null,
                            Description = string.Empty
                        }
                    }
                },
                CompensationViewModel = new CompensationViewModel
                {
                    AdditionalBonuses = string.Empty,
                    BonusRequest = string.Empty,
                    CurrentBonuses = string.Empty,
                    CurrentSalary = string.Empty,
                    SalaryRequest = string.Empty
                },
                NoticePeriodViewModel = new NoticePeriodViewModel
                {
                    NoticePeriod = string.Empty
                },
                AdditionalCommentsViewModel = new AdditionalCommentsViewModel
                {
                    Comments = string.Empty
                },
                AdditionalFilesViewModel = new AdditionalFilesViewModel
                {
                    Files = new List<AdditionalFileItem>()
                },
                //AddAdditionalFileUploadViewModel = new AddAdditionalFileUploadViewModel
                //{
                //    FileSrc = string.Empty
                //},
                Name = string.Empty
            };
        }

        private List<KeyTask> GetKeyTasks(string tasks)
        {
            if (string.IsNullOrEmpty(tasks))
            {
                return null;
            }

            var taskList = tasks.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            var result = new List<KeyTask>();

            foreach (var item in taskList)
            {
                var itemToAdd = item;
                if (itemToAdd.StartsWith("-"))
                {
                    itemToAdd = itemToAdd.Substring(1);
                }

                if (itemToAdd.StartsWith(""))
                {
                    itemToAdd = itemToAdd.Substring(1);
                }

                result.Add(new KeyTask
                {
                    Name = itemToAdd
                });
            }

            return result;
        }

        public string GetKeyTasks(List<KeyTask> tasks)
        {
            if (tasks == null)
            {
                return string.Empty;
            }

            var sb = new StringBuilder();

            foreach (var task in tasks)
            {
                sb.Append("- " + task.Name + "\r\n");
            }

            return sb.ToString();
        }
    }
}