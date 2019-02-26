﻿using CV.Management.Web.DbContexts;
using CV.Management.Web.Models;
using CV.Management.Web.Models.Database;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace CV.Management.Web.Controllers
{
    public class CvController : Controller
    {
        public ActionResult Profile(string language)
        {
            if (language == "lv")
            {
                Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("lv");
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("lv");
            }
            else
            {
                Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en");
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            }

            return View(GetCurrentUserProfileViewModel());
        }

        public ActionResult Error()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Upload(HttpPostedFileBase file)
        {
            if (file != null && file.ContentLength > 0)
            {
                var fileName = Path.GetFileName(file.FileName);
                var path = Path.Combine(Server.MapPath("~/Images/"), fileName);
                file.SaveAs(path);
            }

            return RedirectToAction("Profile");
        }

        [HttpPost]
        public ActionResult PersonalInformation(PersonalInformationViewModel personal)
        {
            using (var db = new ProfileInformationDbContext())
            {
                var username = GetCurrentUsername();
                var userProfile = db.Profiles.FirstOrDefault(x => x.Username == username);

                if (userProfile != null)
                {
                    userProfile.Address = personal.Address;
                    userProfile.Email = personal.Email;
                    userProfile.FullName = personal.FullName;
                    userProfile.LinkedInLink = personal.LinkedInLink;
                    userProfile.Phone = personal.Phone;
                    userProfile.Project = personal.Project;
                    userProfile.Skype = personal.Skype;
                }
                else
                {
                    db.Profiles.Add(new Profile
                    {
                        Username = GetCurrentUsername(),
                        Address = personal.Address,
                        Email = personal.Email,
                        FullName = personal.FullName,
                        LinkedInLink = personal.LinkedInLink,
                        Phone = personal.Phone,
                        Project = personal.Project,
                        Skype = personal.Skype
                    });
                }

                db.SaveChanges();
            }

            return RedirectToAction("Profile");
        }

        [HttpPost]
        public ActionResult Education(EducationViewModel personal)
        {
            using (var db = new ProfileInformationDbContext())
            {
                var username = GetCurrentUsername();
                var userProfile = db.Profiles.FirstOrDefault(x => x.Username == username);

                if (userProfile != null)
                {
                    if (userProfile.Educations != null)
                    {
                        userProfile.Educations.ToList().ForEach(x => db.Entry(x).State = System.Data.Entity.EntityState.Deleted);
                    }

                    foreach (var educationItem in personal.Education)
                    {
                        userProfile.Educations.Add(new Education
                        {
                            Degree = educationItem.Degree,
                            FromYear = educationItem.FromYear,
                            Institution = educationItem.Institution,
                            ToYear = educationItem.ToYear
                        });
                    }
                }
                else
                {
                    var profile = new Profile
                    {
                        Username = GetCurrentUsername(),
                        Educations = new List<Education>()
                    };

                    foreach (var educationItem in personal.Education)
                    {
                        profile.Educations.Add(new Education
                        {
                            Degree = educationItem.Degree,
                            FromYear = educationItem.FromYear,
                            Institution = educationItem.Institution,
                            ToYear = educationItem.ToYear
                        });
                    }

                    db.Profiles.Add(profile);
                }

                db.SaveChanges();
            }

            return RedirectToAction("Profile");
        }

        [HttpPost]
        public ActionResult AdditionalCourses(AdditionalCoursesViewModel personal)
        {
            using (var db = new ProfileInformationDbContext())
            {
                var username = GetCurrentUsername();
                var userProfile = db.Profiles.FirstOrDefault(x => x.Username == username);

                if (userProfile != null)
                {
                    if (userProfile.AdditionalCourses != null)
                    {
                        userProfile.AdditionalCourses.ToList().ForEach(x => db.Entry(x).State = System.Data.Entity.EntityState.Deleted);

                        foreach (var item in personal.Courses)
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
                }
                else
                {
                    var profile = new Profile
                    {
                        Username = GetCurrentUsername(),
                        AdditionalCourses = new List<AdditionalCourse>()
                    };

                    foreach (var item in personal.Courses)
                    {
                        profile.AdditionalCourses.Add(new AdditionalCourse
                        {
                            CourseName = item.CourseName,
                            NumberOfDays = item.NumberOfDays,
                            Trainer = item.Trainer,
                            Year = item.Year
                        });
                    }

                    db.Profiles.Add(profile);
                }

                db.SaveChanges();
            }

            return RedirectToAction("Profile");
        }

        [HttpPost]
        public ActionResult Language(LanguageViewModel personal)
        {
            using (var db = new ProfileInformationDbContext())
            {
                var username = GetCurrentUsername();
                var userProfile = db.Profiles.FirstOrDefault(x => x.Username == username);

                if (userProfile != null)
                {
                    if (userProfile.Languages != null)
                    {
                        userProfile.Languages.ToList().ForEach(x => db.Entry(x).State = System.Data.Entity.EntityState.Deleted);

                        foreach (var item in personal.Languages)
                        {
                            userProfile.Languages.Add(new Language
                            {
                                LanguageName = item.LanguageName,
                                SpokenLevel = item.SpokenLevel,
                                WrittenLevel = item.WrittenLevel
                            });
                        }
                    }
                }
                else
                {
                    var profile = new Profile
                    {
                        Username = GetCurrentUsername(),
                        Languages = new List<Language>()
                    };

                    foreach (var item in personal.Languages)
                    {
                        userProfile.Languages.Add(new Language
                        {
                            LanguageName = item.LanguageName,
                            SpokenLevel = item.SpokenLevel,
                            WrittenLevel = item.WrittenLevel
                        });
                    }

                    db.Profiles.Add(profile);
                }

                db.SaveChanges();
            }

            return RedirectToAction("Profile");
        }

        [HttpPost]
        public ActionResult CareerSummary(CareerSummaryViewModel personal)
        {
            using (var db = new ProfileInformationDbContext())
            {
                var username = GetCurrentUsername();
                var userProfile = db.Profiles.FirstOrDefault(x => x.Username == username);

                if (userProfile != null)
                {
                    if (userProfile.Companies != null)
                    {
                        var companies = userProfile.Companies.ToList();
                        foreach (var item in companies)
                        {
                            item.Positions.ToList().ForEach(x => db.Entry(x).State = System.Data.Entity.EntityState.Deleted);

                            db.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                        }

                        foreach (var item in personal.Companies)
                        {
                            var company = new Company
                            {
                                City = item.City,
                                Industry = item.Industry,
                                MainProductions = item.MainProductions,
                                Name = item.Name,
                                NumberOfEmployess = item.NumberOfEmployess,
                                OtherIndustry = item.OtherIndustry,
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
                                    FromTime = position.FromTime,
                                    KeyTasks = position.KeyTasks,
                                    Name = position.Name,
                                    ReasonForLeaving = position.ReasonForLeaving,
                                    ReportingTo = position.ReportingTo,
                                    ToTime = position.ToTime
                                });
                            }

                            userProfile.Companies.Add(company);
                        }
                    }
                }
                else
                {
                    var profile = new Profile
                    {
                        Username = GetCurrentUsername(),
                        Companies = new List<Company>()
                    };

                    foreach (var item in personal.Companies)
                    {
                        var company = new Company
                        {
                            City = item.City,
                            Industry = item.Industry,
                            MainProductions = item.MainProductions,
                            Name = item.Name,
                            NumberOfEmployess = item.NumberOfEmployess,
                            OtherIndustry = item.OtherIndustry,
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
                                FromTime = position.FromTime,
                                KeyTasks = position.KeyTasks,
                                Name = position.Name,
                                ReasonForLeaving = position.ReasonForLeaving,
                                ReportingTo = position.ReportingTo,
                                ToTime = position.ToTime
                            });
                        }

                        userProfile.Companies.Add(company);
                    }

                    db.Profiles.Add(profile);
                }

                db.SaveChanges();
            }

            return RedirectToAction("Profile");
        }

        [HttpPost]
        public ActionResult Memberships(MembershipViewModel personal)
        {
            using (var db = new ProfileInformationDbContext())
            {
                var username = GetCurrentUsername();
                var userProfile = db.Profiles.FirstOrDefault(x => x.Username == username);

                if (userProfile != null)
                {
                    if (userProfile.Memberships != null)
                    {
                        userProfile.Memberships.ToList().ForEach(x => db.Entry(x).State = System.Data.Entity.EntityState.Deleted);

                        foreach (var item in personal.Memberships)
                        {
                            userProfile.Memberships.Add(new Membership
                            {
                                Description = item.Description,
                                FromTime = item.FromTime,
                                ToTime = item.ToTime
                            });
                        }
                    }
                }
                else
                {
                    var profile = new Profile
                    {
                        Username = GetCurrentUsername(),
                        Memberships = new List<Membership>()
                    };

                    foreach (var item in personal.Memberships)
                    {
                        userProfile.Memberships.Add(new Membership
                        {
                            Description = item.Description,
                            FromTime = item.FromTime,
                            ToTime = item.ToTime
                        });
                    }

                    db.Profiles.Add(profile);
                }

                db.SaveChanges();
            }

            return RedirectToAction("Profile");
        }

        [HttpPost]
        public ActionResult Compensation(CompensationViewModel personal)
        {
            using (var db = new ProfileInformationDbContext())
            {
                var username = GetCurrentUsername();
                var userProfile = db.Profiles.FirstOrDefault(x => x.Username == username);

                if (userProfile != null)
                {
                    userProfile.CurrentBonuses = personal.CurrentBonuses;
                    userProfile.CurrentSalary = personal.CurrentSalary;
                    userProfile.SalaryRequest = personal.SalaryRequest;
                    userProfile.BonusRequest = personal.BonusRequest;
                    userProfile.AdditionalBonuses = personal.AdditionalBonuses;
                }
                else
                {
                    db.Profiles.Add(new Profile
                    {
                        Username = GetCurrentUsername(),
                        CurrentBonuses = personal.CurrentBonuses,
                        CurrentSalary = personal.CurrentSalary,
                        SalaryRequest = personal.SalaryRequest,
                        BonusRequest = personal.BonusRequest,
                        AdditionalBonuses = personal.AdditionalBonuses
                    });
                }

                db.SaveChanges();
            }

            return RedirectToAction("Profile");
        }

        [HttpPost]
        public ActionResult NoticePeriod(NoticePeriodViewModel personal)
        {
            using (var db = new ProfileInformationDbContext())
            {
                var username = GetCurrentUsername();
                var userProfile = db.Profiles.FirstOrDefault(x => x.Username == username);

                if (userProfile != null)
                {
                    userProfile.NoticePeriod = personal.NoticePeriod;
                }
                else
                {
                    db.Profiles.Add(new Profile
                    {
                        Username = GetCurrentUsername(),
                        NoticePeriod = personal.NoticePeriod
                    });
                }

                db.SaveChanges();
            }

            return RedirectToAction("Profile");
        }

        [HttpPost]
        public ActionResult AdditionalComments(AdditionalCommentsViewModel personal)
        {
            using (var db = new ProfileInformationDbContext())
            {
                var username = GetCurrentUsername();
                var userProfile = db.Profiles.FirstOrDefault(x => x.Username == username);

                if (userProfile != null)
                {
                    userProfile.Comments = personal.Comments;
                }
                else
                {
                    db.Profiles.Add(new Profile
                    {
                        Username = GetCurrentUsername(),
                        Comments = personal.Comments
                    });
                }

                db.SaveChanges();
            }

            return RedirectToAction("Profile");
        }

        private string GetCurrentLanguage()
        {
            return Thread.CurrentThread.CurrentCulture.Name.Substring(0, 2);
        }

        private string GetCurrentUsername()
        {
            return "rolands.krumbergs@outlook.com";
            //return HttpContext.IsDebuggingEnabled ? "rolands.krumbergs@outlook.com" : User.Identity.Name;
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
                    FileUploadViewModel = CreateFileUploadViewModel(profile),
                    PersonalInformationViewModel = CreatePersonalInformationViewModel(profile),
                    EducationViewModel = CreateEducationViewModel(profile),
                    AdditionalCoursesViewModel = CreateAdditionalCoursesViewModel(profile),
                    LanguageViewModel = CreateLanguageViewModel(profile),
                    CareerSummaryViewModel = CreateCareerSummaryViewModel(profile),
                    MembershipViewModel = CreateMembershipViewModel(profile),
                    CompensationViewModel = CreateCompensationViewModel(profile),
                    NoticePeriodViewModel = CreateNoticePeriodViewModel(profile),
                    AdditionalCommentsViewModel = CreateAdditionalCommentsViewModel(profile)
                };
            }
        }

        private FileUploadViewModel CreateFileUploadViewModel(Profile profile)
        {
            return new FileUploadViewModel
            {
                ImageSrc = profile.Picture != null ? $"data:image/png;base64,{Convert.ToBase64String(profile.Picture)}" : string.Empty
            };
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
                Project = profile.Project,
                Skype = profile.Skype
            };
        }

        private EducationViewModel CreateEducationViewModel(Profile profile)
        {
            if (profile.Educations == null)
            {
                return new EducationViewModel
                {
                    Education = new System.Collections.Generic.List<EducationItem>
                    {
                        new EducationItem
                        {
                            Degree = string.Empty,
                            FromYear = null,
                            Institution = string.Empty,
                            ToYear = null
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
                        ToYear = null
                    });
                }
                else
                {
                    foreach (var educationItem in profile.Educations)
                    {
                        educationViewModel.Education.Add(new EducationItem
                        {
                            Degree = educationItem.Degree,
                            FromYear = educationItem.FromYear,
                            Institution = educationItem.Institution,
                            ToYear = educationItem.ToYear
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
                    foreach (var courseItem in profile.AdditionalCourses)
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
                                ToTime = null
                            }
                        }
                    };

                    careerSummaryViewModel.Companies.Add(companyViewModel);
                }
                else
                {
                    foreach (var company in profile.Companies)
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
                            companyViewModel.Positions.Add(new PositionItem
                            {
                                Achievements = position.Achievements,
                                DirectSubordinates = position.DirectSubordinates,
                                FromTime = position.FromTime,
                                KeyTasks = position.KeyTasks,
                                Name = position.Name,
                                ReasonForLeaving = position.ReasonForLeaving,
                                ReportingTo = position.ReportingTo,
                                ToTime = position.ToTime
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
            if (profile.Memberships == null)
            {
                return new MembershipViewModel
                {
                    Memberships = new List<MembershipItem>
                    {
                        new MembershipItem
                        {
                            Description = string.Empty,
                            FromTime = null,
                            ToTime = null
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

                if (profile.Memberships.Count == 0)
                {
                    membershipViewModel.Memberships.Add(new MembershipItem
                    {
                        Description = string.Empty,
                        FromTime = null,
                        ToTime = null
                    });
                }
                else
                {
                    foreach (var membership in profile.Memberships)
                    {
                        membershipViewModel.Memberships.Add(new MembershipItem
                        {
                            Description = membership.Description,
                            FromTime = membership.FromTime,
                            ToTime = membership.ToTime
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
                FileUploadViewModel = new FileUploadViewModel
                {
                    ImageSrc = string.Empty
                },
                PersonalInformationViewModel = new PersonalInformationViewModel
                {
                    Address = string.Empty,
                    Email = string.Empty,
                    FullName = string.Empty,
                    LinkedInLink = string.Empty,
                    Phone = string.Empty,
                    Project = string.Empty,
                    Skype = string.Empty
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
                }
            };
        }

    }
}