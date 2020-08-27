using CV.Management.Web.Models.Database;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace CV.Management.Web.Tests2
{
    [TestClass]
    public class EducationOrderingTests
    {
        [TestMethod]
        public void TestEducation_ReturnsCorrectAmount_NoNow()
        {
            var educations = new List<Education>
            {
                new Education
                {
                    Institution = "A",
                    FromYear = 2010,
                    Now = false,
                    ToYear = 2014
                },
                new Education
                {
                    Institution = "B",
                    FromYear = 2007,
                    ToYear = 2010
                }
            };

            var result = educations.OrderEducation();

            Assert.IsTrue(result.Count == 2);
        }

        [TestMethod]
        public void TestEducation_ReturnsCorrectAmount_OneNow()
        {
            var educations = new List<Education>
            {
                new Education
                {
                    Institution = "A",
                    FromYear = 2010,
                    Now = true,
                    ToYear = null
                },
                new Education
                {
                    Institution = "B",
                    FromYear = 2007,
                    Now = false,
                    ToYear = 2010
                }
            };

            var result = educations.OrderEducation();

            Assert.IsTrue(result.Count == 2);
        }

        [TestMethod]
        public void TestEducation_ReturnsCorrectAmount_AllNow()
        {
            var educations = new List<Education>
            {
                new Education
                {
                    Institution = "A",
                    FromYear = 2010,
                    Now = true,
                    ToYear = null
                },
                new Education
                {
                    Institution = "B",
                    FromYear = 2007,
                    Now = true,
                    ToYear = null
                },
                new Education
                {
                    Institution = "B",
                    FromYear = 2008,
                    Now = true,
                    ToYear = null
                }
            };

            var result = educations.OrderEducation();

            Assert.IsTrue(result.Count == 3);
        }

        [TestMethod]
        public void TestEducation_ReturnsCorrectOrder_NoNow()
        {
            var educations = new List<Education>
            {
                new Education
                {
                    Institution = "B",
                    FromYear = 2007,
                    Now = false,
                    ToYear = 2010
                },
                new Education
                {
                    Institution = "A",
                    FromYear = 2010,
                    Now = false,
                    ToYear = 2014
                }                
            };

            var result = educations.OrderEducation();

            Assert.AreEqual(result[0].Institution, "A");
            Assert.AreEqual(result[1].Institution, "B");
        }

        [TestMethod]
        public void TestEducation_ReturnsCorrectOrder_OneNow()
        {
            var educations = new List<Education>
            {
                new Education
                {
                    Institution = "B",
                    FromYear = 2007,
                    Now = false,
                    ToYear = 2010
                },
                new Education
                {
                    Institution = "A",
                    FromYear = 2010,
                    Now = true,
                    ToYear = null
                },
            };

            var result = educations.OrderEducation();

            Assert.AreEqual(result[0].Institution, "A");
            Assert.AreEqual(result[1].Institution, "B");
        }

        [TestMethod]
        public void TestEducation_ReturnsCorrectOrder_AllNow()
        {
            var educations = new List<Education>
            {
                new Education
                {
                    Institution = "A",
                    FromYear = 2010,
                    Now = true,
                    ToYear = null
                },
                new Education
                {
                    Institution = "B",
                    FromYear = 2007,
                    Now = true,
                    ToYear = null
                },
                new Education
                {
                    Institution = "C",
                    FromYear = 2008,
                    Now = true,
                    ToYear = null
                }
            };

            var result = educations.OrderEducation();

            Assert.AreEqual(result[0].Institution, "A");
            Assert.AreEqual(result[1].Institution, "C");
            Assert.AreEqual(result[2].Institution, "B");
        }

        [TestMethod]
        public void TestEducation_ReturnsCorrectOrder_Example1()
        {
            var educations = new List<Education>
            {
                new Education
                {
                    Institution = "A",
                    FromYear = 2010,
                    Now = true,
                    ToYear = null
                },
                new Education
                {
                    Institution = "B",
                    FromYear = 2007,
                    Now = false,
                    ToYear = 2017
                },
                new Education
                {
                    Institution = "C",
                    FromYear = 2008,
                    Now = true,
                    ToYear = null
                },
                new Education
                {
                    Institution = "D",
                    FromYear = 2012,
                    Now = false,
                    ToYear = 2018
                },
            };

            var result = educations.OrderEducation();

            Assert.AreEqual(result[0].Institution, "A");
            Assert.AreEqual(result[1].Institution, "C");
            Assert.AreEqual(result[2].Institution, "D");
            Assert.AreEqual(result[3].Institution, "B");
        }
    }
}
