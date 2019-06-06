using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CV.Management.Generation.Word.Tests
{
    [TestClass]
    public class TestSimpleGeneration
    {
        [TestMethod]
        public void Test_FileStoring_TestRealData()
        {
            var documentManager = new WordDocumentManager();

            var simpleFile = GetGenerationData();

            var filePath = "E:\\Temp\\Amrop\\Generated\\Docs";
            var fileName = $"{Guid.NewGuid().ToString()}.docx";

            documentManager.SaveDocument(simpleFile, filePath, fileName);
        }

        private static GenerationData GetGenerationData()
        {
            return new GenerationData
            {
                Language = "lv",
                DocumentProperties = new DocumentProperties
                {
                    Creator = "Agnese Zanriba",
                    Category = "",
                    Keywords = "",
                    Subject = "",
                    Description = "",
                    Title = ""
                },
                TitleArea = new TitleArea
                {
                    Date = "December 2018",
                    Name = "Rolands Krumbergs",
                    Title = "Confidential candidate CV",
                    Project = "SIA Awesome company"
                },
                Personal = new PersonalInformation
                {
                    FullName = "Rolands Krumbergs",
                    Mobile = "+371 222222222",
                    Email = "spam@rolands.lv",
                    Address = "Neteiksu iela 22, Rīga, LV-0000",
                    OtherInformation = "-",
                    LinkedIn = "https://lv.linkedin.com/in/rolands-krumbergs-25599b37",
                    ProfilePictureContent = "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",
                    ProfilePictureType = "image/jpeg"
                },
                Education = new List<EducationItem>
                {
                    new EducationItem
                    {
                        Degree = "Master of Law",
                        University = "UNIVERSITY OF LATVIA",
                        StartingYear = 1998,
                        EndingYear = 2001
                    },
                    new EducationItem
                    {
                        Degree = "Bachelor of Business Administration",
                        University = "RIGA INTERNATIONAL SCHOOL OF ECONOMICS AND BUSINESS ADMINISTRATION",
                        StartingYear = 1994,
                        EndingYear = 1998
                    }
                },
                AdditionalCourses = new List<AdditionalCoursesItem>
                {
                    new AdditionalCoursesItem
                    {
                        AmountOfDays = 4,
                        Year = 2018,
                        CourseName = "SUCCESFUL INVESTING THROUGH IPO (INITIAL PUBLIC OFFERINGS)",
                        Instructor = "Edward Dubinsky/Fintelect"
                    },
                    new AdditionalCoursesItem
                    {
                        AmountOfDays = 3,
                        Year = 2018,
                        CourseName = "SUCCESS STORY BY MULTIMILLIONAIR ROBET ALLEN",
                        Instructor = "Robert Allen"
                    },
                    new AdditionalCoursesItem
                    {
                        AmountOfDays = 7,
                        Year = 2017,
                        CourseName = "7 WEEKS OF GENIUS MINDSET",
                        Instructor = "Mikola Latansky"
                    },
                    new AdditionalCoursesItem
                    {
                        AmountOfDays = 5,
                        Year = 2017,
                        CourseName = "MASTERPLAN ANALYSIS OF FINANCIAL MARKETS",
                        Instructor = "Davide Catanossi"
                    },
                    new AdditionalCoursesItem
                    {
                        AmountOfDays = 1,
                        Year = 2017,
                        CourseName = "REACHING PERSONAL MAXIMUM",
                        Instructor = "Brian Tracy"
                    },
                    new AdditionalCoursesItem
                    {
                        AmountOfDays = 1,
                        Year = 2017,
                        CourseName = "ART OF THE SPEECH",
                        Instructor = "Radislav Gandapas"
                    }
                },
                Languages = new List<LanguageItem>
                {
                    new LanguageItem
                    {
                        LanguageName = "Latvian",
                        SpokenLevel = 2,
                        WrittenLevel = 3
                    },
                    new LanguageItem
                    {
                        LanguageName = "English",
                        SpokenLevel = 4,
                        WrittenLevel = 3
                    }
                },
                CareerSummary = new List<CareerSummaryItem>
                {
                   new CareerSummaryItem
                    {
                        Company = "SIA B",
                        Roles = new List<RoleInformation>
                        {
                            new RoleInformation
                            {
                                ReportingTo = "Mr. Qwerty",
                                Role = "FINANCIAL ADVISER",
                                StartingYear = 2018,
                                Now = true,
                                Tasks = new List<string> { "Advisor on natural resource acquisition deals.  ", "Consulting on global commodity trends.", "Forging relationships with foreign business partners" }
                            }

                        },
                        Industry = "Natural Resources / Agriculture / Forestry / Oil & Gas",
                        NumberOfEmployees = "2",
                        Services = "Commodities export company",
                        Turnover = "Turnover 2018 (F) - EUR 2,2 M"
                    },
                    new CareerSummaryItem
                    {
                        Company = "SIA V",

                        Roles = new List<RoleInformation>
                        {
                            new RoleInformation
                            {
                            StartingYear = 2017,
                            EndingYear = 2018,
                            Now = false,
                            ReportingTo = "Mr. Asdfg",
                            Role = "INVESTMENT MANAGER",
                            Tasks = new List<string> { "Investment management and advisory (including public and direct real estate).", "Self owned enterprise executing personal investment deals.", "Currently involved in 10 investment / finance projects.", "Approximate asset value at the end of 2018 EUR 1M. 2017: Servicing of EUR 300M sell side mandate from key participants in the Latvian pharmaceutical sector for a 100% exit to UK/Polish equity investment fund" }
                            }
                        },
                        Industry = "Financial Services / Insurance",
                        NumberOfEmployees = "1",
                        Services = "Investment management and advisory"
                    }
                },
                SocialActivites = new List<SocialActivity>
                {
                    new SocialActivity
                    {
                        StartingYear = 2011,
                        EndingYear = 2016,
                        Role = "Travel Tour Leader",
                        Tasks = new List<string>
                        {
                            "Organized and led personal growth focused tour groups to India",
                            "Acted as a liaison between European individuals and Asian spiritual guides"
                        }
                    }
                },
                Compensation = new CompensationItem
                {
                    AdditionalBonuses = "Full investment executive remuneration package which includes base salary, short-term incentive/long-term incentive plan, relocation costs (if needed) including a car, full insurance package, travel costs, paid expenses, etc."
                },
                TransitionTime = "1-3 months",
                AdditionalComments = "Former council, board member or representative in several companies, including - Council member of NASDAQ Riga (former Riga Stock Exchange)."
            };
        }
    }
}
