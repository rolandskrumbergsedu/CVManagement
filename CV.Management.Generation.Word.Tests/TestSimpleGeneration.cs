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
                    Company = "SIA Awesome company",
                    Role = "CEO"
                },
                Personal = new PersonalInformation
                {
                    FullName = "Rolands Krumbergs",
                    Mobile = "+371 222222222",
                    Email = "spam@rolands.lv",
                    Address = "Neteiksu iela 22, Rīga, LV-0000",
                    Skype = "-",
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
                AdditionalCourses = new System.Collections.Generic.List<AdditionalCoursesItem>
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
                        StartingYear = 2018,
                        EndingYear = 0,
                        ReportingTo = "Mr. Qwerty",
                        Role = new RoleInformation
                        {
                            Role = "FINANCIAL ADVISER",
                            StartingYear = 2018,
                            EndingYear = 0
                        },
                        Industry = "Natural Resources / Agriculture / Forestry / Oil & Gas",
                        Services = "Commodities export company",
                        Turnover = "Turnover 2018 (F) - EUR 2,2 M",
                        NumberOfEmployees = "2",
                        Tasks = new List<string>
                        {
                            "Advisor on natural resource acquisition deals",
                            "Consulting on global commodity trends",
                            "Forging relationships with foreign business partners"
                        }
                    },
                    new CareerSummaryItem
                    {
                        Company = "SIA V",
                        StartingYear = 2017,
                        EndingYear = 0,
                        ReportingTo = "Mr. Asdfg",
                        Role = new RoleInformation
                        {
                            Role = "INVESTMENT MANAGER ",
                            StartingYear = 2017,
                            EndingYear = 0
                        },
                        Industry = "Financial Services / Insurance",
                        Services = "Investment management and advisory",
                        NumberOfEmployees = "1",
                        Tasks = new List<string>
                        {
                            "Investment management and advisory (including public and direct real estate)",
                            "Self owned enterprise executing personal investment deals. Currently involved in 10 investment / finance projects. Approximate asset value at the end of 2018 EUR 1M",
                            "2017: Servicing of EUR 300M sell side mandate from key participants in the Latvian pharmaceutical sector for a 100% exit to UK/Polish equity investment fund"
                        }
                    },
                    new CareerSummaryItem
                    {
                        Company = "SIA U",
                        StartingYear = 2012,
                        EndingYear = 0,
                        ReportingTo = "Mr. Zxcvbn",
                        Role = new RoleInformation
                        {
                            Role = "BOARD MEMBER",
                            StartingYear = 2012,
                            EndingYear = 0
                        },
                        Industry = "Natural Resources / Agriculture / Forestry / Oil & Gas",
                        Services = "Investment company",
                        NumberOfEmployees = "2",
                        Tasks = new List<string>
                        {
                            "Investment management in Ukrainian agricultural sector. Company asset value of EUR 1.5M",
                            "Indirect shareholder, 33% (through Cyprus entities), of two Ukrainian agroholdings BioAgro and LatAgro. At the end of 2018, expected consolidated asset value of both holdings companies is projected to be EUR 200M, consolidated sales value of EUR 100M. EBITD EUR 45M. Total number of daughter companies approx. 30"
                        }
                    },
                    new CareerSummaryItem
                    {
                        Company = "SIA F",
                        StartingYear = 2013,
                        EndingYear = 2016,
                        ReportingTo = "Mr. Poiuytr",
                        Role = new RoleInformation
                        {
                            Role = "SENIOR ADVISER",
                            StartingYear = 2013,
                            EndingYear = 2016
                        },
                        Industry = "Financial Services / Insurance",
                        Services = "Global corporate finance advisory and alternative investment consulting",
                        NumberOfEmployees = "10",
                        Tasks = new System.Collections.Generic.List<string>
                        {
                            "Investment advisory on deal sourcing and structuring regarding opportunities in former Soviet Union countries, particular focus on real estate and private equity",
                            "Structuring a debt (EBRD USD 100M) and equity deal (USD 150M) for a Ukraine based premium foods company",
                            "Assisted in sourcing prospective investors from Eastern & Central Europe for the Fox Point/Keel Harbour mandate with Round Hill Capital, a panEuropean real estate investor",
                            "USD 500M EV Azimuth tanker project (UK/India)",
                            "Advised Fox Point on an emerging market focused hedge fund in the valuation and prospective liquidation of their USD 75M side pocket, which included assets domiciled in the CIS",
                            "Developed investment strategies for high profile pan European real estate investors",
                            "Provided macrolevel guidance for Fox Point Capital clientele"
                        },
                        ReasonForLeaving = "Car accident (21/9/2016) in South India. Severe injuries, recovery and rehabilitation for several months."
                    },
                    new CareerSummaryItem
                    {
                        Company = "SIA N",
                        StartingYear = 2007,
                        EndingYear = 2012,
                        ReportingTo = "Mr. Mnbvcxz",
                        Role = new RoleInformation
                        {
                            Role = "INVESTMENT MANAGER",
                            StartingYear = 2007,
                            EndingYear = 2012
                        },
                        Industry = "Natural Resources / Agriculture / Forestry / Oil & Gas",
                        Services = "One of the world's largest agricultural business investment funds exceeding $1.2B assets under management and controlling over 600,000 ha of farmland",
                        NumberOfEmployees = "~ 15",
                        Turnover = "Expected Net Profit for 2018: over USD 100M",
                        Tasks = new List<string>
                        {
                            "Development of investment strategies and policy for the development of agricultural investment holdings formation in Ukraine and Kazakhstan",
                            "Investment and financial management planning, organization and implementation, selection and management of top level employees",
                            "Acquisition and controlling of agribusiness assets; monitoring, controlling and consulting NCH venture partners in agricultural investment projects in Ukraine",
                            "Organizational management between NCH and fund venture partners in Ukraine. Total managed investment projects valued at approximately USD 450M"
                        },
                        ReasonForLeaving = "Fund was fully invested, and no new funds would be opened."
                    },
                    new CareerSummaryItem
                    {
                        Company = "SIA M",
                        StartingYear = 1996,
                        EndingYear = 2012,
                        ReportingTo = "Mr. Lkjhgfd",
                        Role = new RoleInformation
                        {
                            Role = "INVESTMENT MANAGER/FINANCIER ",
                            StartingYear = 1996,
                            EndingYear = 2012
                        },
                        ParentCompany = "NCH CAPITAL",
                        Industry = "Financial Services / Insurance",
                        Services = "Investment fund",
                        NumberOfEmployees = "~ 10",
                        Tasks = new List<string>
                        {
                            "Investment distribution of more than USD 350M through the capital and real estate investments in the Baltic region for one of the largest and most experienced Western investors in the former Soviet Union a US based investment fund New Century Holdings (more than 20 sub funds) with over $5 billion assets under management",
                            "Managed potential public, direct equity and real estate investment objects due diligence, managing of research projects, financial and investment risk analysis and related evaluation",
                            "Negotiated investment terms with selected companies; performed investments structuring, incl. business plans, financial and tax strategies; implementation of financial performance control, incl. budgeting, auditing, etc.",
                            "Managed NCH equity investments in public markets (bonds; equity)",
                            "Managed and supervised investments made by NCH during the investment period, exit management of any type of investments",
                            "Representing interests of NCH on boards, councils and shareholder meetings of several companies (incl. the banking and insurance sectors)",
                            "Managed the preparation of investment reports and submitted them to the head NCH office in New York City"
                        },
                        ReasonForLeaving = "Fund was fully invested, and no new funds would be opened"
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
                Compensation = "Full investment executive remuneration package which includes base salary, short-term incentive/long-term incentive plan, relocation costs (if needed) including a car, full insurance package, travel costs, paid expenses, etc.",
                TransitionTime = "1-3 months",
                AdditionalComments = "Former council, board member or representative in several companies, including - Council member of NASDAQ Riga (former Riga Stock Exchange)."
            };
        }
    }
}
