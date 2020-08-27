using CV.Management.Web.Models.Database;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace CV.Management.Web.Tests2
{
    [TestClass]
    public class MembershipOrderingTests
    {
        [TestMethod]
        public void TestMembership_ReturnsCorrectAmount_OneNoNow()
        {
            var memberships = new List<Membership>
            {
                new Membership
                {
                    Description = "A",
                    FromTime = 2007,
                    Now = false,
                    ToTime = 2010
                }
            };

            var result = memberships.OrderMembership();

            Assert.IsTrue(result.Count == 1);
        }

        [TestMethod]
        public void TestMembership_ReturnsCorrectAmount_NoNow()
        {
            var memberships = new List<Membership>
            {
                new Membership
                {
                    Description = "A",
                    FromTime = 2007,
                    Now = false,
                    ToTime = 2010
                },
                new Membership
                {
                    Description = "B",
                    FromTime = 2010,
                    Now = false,
                    ToTime = 2014
                }
            };

            var result = memberships.OrderMembership();

            Assert.IsTrue(result.Count == 2);
        }

        [TestMethod]
        public void TestMembership_ReturnsCorrectAmount_SomeNow()
        {
            var memberships = new List<Membership>
            {
                new Membership
                {
                    Description = "A",
                    FromTime = 2007,
                    Now = false,
                    ToTime = 2010
                },
                new Membership
                {
                    Description = "B",
                    FromTime = 2009,
                    Now = true
                },
                new Membership
                {
                    Description = "C",
                    FromTime = 2017,
                    Now = false,
                    ToTime = 2018
                },
                new Membership
                {
                    Description = "D",
                    FromTime = 2010,
                    Now = true
                }
            };

            var result = memberships.OrderMembership();

            Assert.IsTrue(result.Count == 4);
        }

        [TestMethod]
        public void TestMembership_ReturnsCorrectOrder_OneNoNow()
        {
            var memberships = new List<Membership>
            {
                new Membership
                {
                    Description = "A",
                    FromTime = 2007,
                    Now = false,
                    ToTime = 2010
                }
            };

            var result = memberships.OrderMembership();

            Assert.AreEqual(result[0].Description, "A");
        }

        [TestMethod]
        public void TestMembership_ReturnsCorrectOrder_NoNow()
        {
            var memberships = new List<Membership>
            {
                new Membership
                {
                    Description = "A",
                    FromTime = 2007,
                    Now = false,
                    ToTime = 2010
                },
                new Membership
                {
                    Description = "B",
                    FromTime = 2010,
                    Now = false,
                    ToTime = 2014
                }
            };

            var result = memberships.OrderMembership();

            Assert.AreEqual(result[0].Description, "B");
            Assert.AreEqual(result[1].Description, "A");
        }

        [TestMethod]
        public void TestMembership_ReturnsCorrectOrder_SomeNow()
        {
            var memberships = new List<Membership>
            {
                new Membership
                {
                    Description = "A",
                    FromTime = 2007,
                    Now = false,
                    ToTime = 2010
                },
                new Membership
                {
                    Description = "B",
                    FromTime = 2009,
                    Now = true
                },
                new Membership
                {
                    Description = "C",
                    FromTime = 2017,
                    Now = false,
                    ToTime = 2018
                },
                new Membership
                {
                    Description = "D",
                    FromTime = 2010,
                    Now = true
                }
            };

            var result = memberships.OrderMembership();

            Assert.AreEqual(result[0].Description, "D");
            Assert.AreEqual(result[1].Description, "B");
            Assert.AreEqual(result[2].Description, "C");
            Assert.AreEqual(result[3].Description, "A");
        }
    }
}
