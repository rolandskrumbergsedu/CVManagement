using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CV.Management.Generation.Ppt.Tests
{
    [TestClass]
    public class TestSimpleGeneration
    {
        [TestMethod]
        public void Test_FileStoring_TestRealData()
        {
            var documentManager = new PresentationDocumentManager();

            var simpleFile = GetGenerationData();

            var filePath = "E:\\Temp\\Amrop\\Generated\\PPT";
            var fileName = $"{Guid.NewGuid().ToString()}.pptx";

            documentManager.SaveDocument(simpleFile, filePath, fileName);
        }

        private static PresentationGenerationData GetGenerationData()
        {
            return new PresentationGenerationData
            {
                FullName = "Rolands Krumbergs",
                Email = "rolands.krumbergs@outlook.com",
                Phone = "+371 27164700",
                Date = "March 2019",
                Education = new System.Collections.Generic.List<EducationItem>
                {
                    new EducationItem
                    {
                        Degree = "Bachelor’s degree, Business Administration, Entrepreneurship",
                        EndYear = "2006",
                        University = "BA School of Business and Finance"
                    }
                },
                Languages = new System.Collections.Generic.List<LanguageItem>
                {
                    new LanguageItem
                    {
                        LanguageName = "Latvian",
                        LanguageLevel = "native"
                    },
                    new LanguageItem
                    {
                        LanguageName = "English",
                        LanguageLevel = "fluent"
                    },
                    new LanguageItem
                    {
                        LanguageName = "Russian",
                        LanguageLevel = "fluent"
                    },
                    new LanguageItem
                    {
                        LanguageName = "German",
                        LanguageLevel = "good"
                    }
                },
                Experience = new System.Collections.Generic.List<ExperienceItem>
                {
                    new ExperienceItem
                    {
                        StartingYear = "2017",
                        EndingYear = "present",
                        Company = "BANKA",
                        Position = "Head of Baltic Private banking",
                    },
                    new ExperienceItem
                    {
                        StartingYear = "2015",
                        EndingYear = "2017",
                        Company = "BANKA",
                        Position = "Head of Retail Baltic's",
                    },
                    new ExperienceItem
                    {
                        StartingYear = "2013",
                        EndingYear = "2015",
                        Company = "BANKA",
                        Position = "Head of Retail Lending Division",
                    },
                    new ExperienceItem
                    {
                        StartingYear = "2013",
                        EndingYear = "2014",
                        Company = "BANKA",
                        Position = "Head of Gold Service Lending Department",
                    },
                    new ExperienceItem
                    {
                        StartingYear = "2012",
                        EndingYear = "2015",
                        Company = "ASSOCIATION OF COMMERCIAL BANKS OF LATVIA ",
                        Position = "Chairman of Mortgage Committee",
                    },
                    new ExperienceItem
                    {
                        StartingYear = "2011",
                        EndingYear = "2013",
                        Company = "BANKA",
                        Position = "Head of Mortgage and SMEs Lending Division",
                    },
                    new ExperienceItem
                    {
                        StartingYear = "2009",
                        EndingYear = "2011",
                        Company = "BANKA",
                        Position = "Head of Riga Lending Department",
                    },
                    new ExperienceItem
                    {
                        StartingYear = "2008",
                        EndingYear = "2009",
                        Company = "BANKA",
                        Position = "2009",
                    }
                },
                Motivation = new System.Collections.Generic.List<MotivationItem>
                {
                    new MotivationItem
                    {
                        Label = "Remuneration",
                        Content = "8 500 EUR Gross (base salary)"
                    }
                }
            };
        }
    }
}
