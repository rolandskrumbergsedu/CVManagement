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

            var filePath = "C:\\temp\\WordGeneration";
            var fileName = $"{Guid.NewGuid().ToString()}.docx";

            documentManager.SaveDocument(simpleFile, filePath, fileName);
        }

        private static GenerationData GetGenerationData()
        {
            return new GenerationData
            {
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
                    LinkedIn = "https://lv.linkedin.com/in/rolands-krumbergs-25599b37"
                },
                Education = new System.Collections.Generic.List<EducationItem>
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
