using CV.Management.Web.Models.Database;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace CV.Management.Web.Tests
{
    [TestClass]
    public class AdditionalCoursesOrderingTests
    {
        [TestMethod]
        public void TestAdditionalCourses_ReturnsCorrectAmount_OneCourse()
        {
            var courses = new List<AdditionalCourse>
            {
                new AdditionalCourse
                {
                    CourseName = "A",
                    Year = 2010
                }
            };

            var result = courses.OrderAdditionalCourse();

            Assert.IsTrue(result.Count == 1);
        }

        [TestMethod]
        public void TestAdditionalCourses_ReturnsCorrectAmount_OneEmptyCourse()
        {
            var courses = new List<AdditionalCourse>
            {
                new AdditionalCourse
                {
                    CourseName = "A",
                    Year = null
                }
            };

            var result = courses.OrderAdditionalCourse();

            Assert.IsTrue(result.Count == 1);
        }

        [TestMethod]
        public void TestAdditionalCourses_ReturnsCorrectAmount_TwoCourses()
        {
            var courses = new List<AdditionalCourse>
            {
                new AdditionalCourse
                {
                    CourseName = "A",
                    Year = 2010
                },
                new AdditionalCourse
                {
                    CourseName = "B",
                    Year = 2008
                }
            };

            var result = courses.OrderAdditionalCourse();

            Assert.IsTrue(result.Count == 2);
        }

        [TestMethod]
        public void TestAdditionalCourses_ReturnsCorrectAmount_TwoCoursesOneEmpty()
        {
            var courses = new List<AdditionalCourse>
            {
                new AdditionalCourse
                {
                    CourseName = "A",
                    Year = null
                },
                new AdditionalCourse
                {
                    CourseName = "B",
                    Year = 2008
                }
            };

            var result = courses.OrderAdditionalCourse();

            Assert.IsTrue(result.Count == 2);
        }

        [TestMethod]
        public void TestAdditionalCourses_ReturnsCorrectOrder_TwoCoursesOneEmpty()
        {
            var courses = new List<AdditionalCourse>
            {
                new AdditionalCourse
                {
                    CourseName = "A",
                    Year = null
                },
                new AdditionalCourse
                {
                    CourseName = "B",
                    Year = 2008
                }
            };

            var result = courses.OrderAdditionalCourse();

            Assert.AreEqual(result[0].CourseName, "B");
            Assert.AreEqual(result[1].CourseName, "A");
        }

        [TestMethod]
        public void TestAdditionalCourses_ReturnsCorrectOrder_Example1()
        {
            var courses = new List<AdditionalCourse>
            {
                new AdditionalCourse
                {
                    CourseName = "A",
                    Year = null
                },
                new AdditionalCourse
                {
                    CourseName = "B",
                    Year = 2008
                },
                new AdditionalCourse
                {
                    CourseName = "C",
                    Year = null
                },
                new AdditionalCourse
                {
                    CourseName = "D",
                    Year = 2008
                },
                new AdditionalCourse
                {
                    CourseName = "E",
                    Year = 2007
                },
                new AdditionalCourse
                {
                    CourseName = "F",
                    Year = 2010
                },
            };

            var result = courses.OrderAdditionalCourse();

            Assert.AreEqual(result[0].CourseName, "F");
            Assert.AreEqual(result[1].CourseName, "B");
            Assert.AreEqual(result[2].CourseName, "D");
            Assert.AreEqual(result[3].CourseName, "E");
            Assert.AreEqual(result[4].CourseName, "A");
            Assert.AreEqual(result[5].CourseName, "C");
        }
    }
}
