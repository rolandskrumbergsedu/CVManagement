using CV.Management.Generation.Word;
using CV.Management.Web.DbContexts;
using CV.Management.Web.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace CV.Management.Web.Controllers
{
    //[Authorize]
    public class WordDocumentController : ApiController
    {
        [HttpGet]
        [Route("api/worddocument")]
        public HttpResponseMessage DownloadPdfFile()
        {
            try
            {
                var documentManager = new WordDocumentManager();

                var bytes = documentManager.GetDocument(GetGenerationData());

                var result = Request.CreateResponse(HttpStatusCode.OK);
                result.Content = new ByteArrayContent(bytes);
                result.Content.Headers.ContentDisposition =
                    new System.Net.Http.Headers.ContentDispositionHeaderValue(
                            "attachment")
                    { FileName = "Test" + ".docx" };

                return result;
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.Gone);
            }
        }

        private GenerationData GetGenerationData()
        {
            using(var db = new ProfileInformationDbContext())
            {
                var userName = "rolands.krumbergs@outlook.com";
               // var userName = User.Identity.Name;
                var profile = db.Profiles.FirstOrDefault(x => x.Username == userName);

                return DataFromProfile(profile);
            }
        }

        private string GetCurrentDate()
        {
            var year = DateTime.Now.Year.ToString();

            switch (DateTime.Now.Month)
            {
                case 1:
                    return $"January {year}";
                case 2:
                    return $"February {year}";
                case 3:
                    return $"March {year}";
                case 4:
                    return $"April {year}";
                case 5:
                    return $"May {year}";
                case 6:
                    return $"June {year}";
                case 7:
                    return $"July {year}";
                case 8:
                    return $"August {year}";
                case 9:
                    return $"September {year}";
                case 10:
                    return $"October {year}";
                case 11:
                    return $"November {year}";
                case 12:
                    return $"December {year}";
                default:
                    return "Unknown";
            }
        }

        private GenerationData DataFromProfile(Profile profile)
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
                    Date = GetCurrentDate(),
                    Name = profile.FullName,
                    Title = "Confidential candidate CV",
                    Company = "SIA Awesome company",
                    Role = "CEO"
                },
                Personal = new PersonalInformation
                {
                    FullName = profile.FullName,
                    Mobile = profile.Phone,
                    Email = profile.Email,
                    Address = profile.Address,
                    Skype = profile.Skype,
                    LinkedIn = profile.LinkedInLink
                },
                Education = profile.Educations.Select(x => new EducationItem
                {
                    Degree = x.Degree,
                    EndingYear = x.ToYear.Value,
                    StartingYear = x.FromYear.Value,
                    University = x.Institution
                }).ToList(),
                AdditionalCourses = profile.AdditionalCourses.Select(x => new AdditionalCoursesItem
                {
                    AmountOfDays = x.NumberOfDays.Value,
                    CourseName = x.CourseName,
                    Instructor = x.Trainer,
                    Year = x.Year.Value
                }).ToList(),
                Languages = profile.Languages.Select(x => new LanguageItem
                {
                    LanguageName = x.LanguageName.ToString(),
                    SpokenLevel = ((int)x.SpokenLevel.Value) + 1,
                    WrittenLevel = ((int)x.WrittenLevel.Value) + 1
                }).ToList(),
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
                        NumberOfEmployees = "2",
                        Services = "Commodities export company",
                        Turnover = "Turnover 2018 (F) - EUR 2,2 M",
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
                        NumberOfEmployees = "1",
                        Services = "Investment management and advisory",
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
                        NumberOfEmployees = "2",
                        Services = "Investment company",
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
                        NumberOfEmployees = "10",
                        Services = "Global corporate finance advisory and alternative investment consulting",
                        Tasks = new List<string>
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
                        NumberOfEmployees = "~ 15",
                        Services = "One of the world's largest agricultural business investment funds exceeding $1.2B assets under management and controlling over 600,000 ha of farmland",
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
                        Industry = "Financial Services / Insurance",
                        NumberOfEmployees = "~ 10",
                        Services = "Investment fund",
                        ParentCompany = "NCH CAPITAL",
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
                SocialActivites = profile.Memberships.Select(x => new SocialActivity
                {
                    StartingYear = x.FromTime.Value,
                    EndingYear = x.ToTime.Value,
                    Description = x.Description
                }).ToList(),
                Compensation = profile.AdditionalBonuses,
                TransitionTime = profile.NoticePeriod,
                AdditionalComments = profile.Comments
            };
        }
    }
}
