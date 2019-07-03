using CV.Management.Web.Models.Database;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CV.Management.Web.Tests
{
    [TestClass]
    public class CompanyOrderingTests
    {
        [TestMethod]
        public void TestOneCompany_MultiplePositions_ReturnsCorrectAmount()
        {
            var companies = new List<Company>
            {
                new Company
                {
                    Name = "Company A",
                    Positions = new List<Position>
                    {
                        new Position
                        {
                            Name = "Position A",
                            Now = false,
                            ToTime = 2010,
                            FromTime = 2008
                        },
                        new Position
                        {
                            Name = "Position B",
                            Now = false,
                            ToTime = 2016,
                            FromTime = 2010
                        }
                    }
                }
            };

            var result = companies.OrderCompanies();

            Assert.IsTrue(result.Count == 1);
            Assert.IsTrue(result[0].Positions.Count == 2);
        }

        [TestMethod]
        public void TestOneCompany_MultiplePositions_OneCurrentPosition_ReturnsCorrectAmount()
        {
            var companies = new List<Company>
            {
                new Company
                {
                    Name = "Company A",
                    Positions = new List<Position>
                    {
                        new Position
                        {
                            Name = "Position A",
                            Now = false,
                            ToTime = 2010,
                            FromTime = 2008
                        },
                        new Position
                        {
                            Name = "Position B",
                            Now = true,
                            ToTime = null,
                            FromTime = 2010
                        }
                    }
                }
            };

            var result = companies.OrderCompanies();

            Assert.IsTrue(result.Count == 1);
            Assert.IsTrue(result[0].Positions.Count == 2);
        }

        [TestMethod]
        public void TestMultipleCompanies_MultiplePositions_ReturnsCorrectAmount()
        {
            var companies = new List<Company>
            {
                new Company
                {
                    Name = "Company A",
                    Positions = new List<Position>
                    {
                        new Position
                        {
                            Name = "Position A",
                            Now = false,
                            ToTime = 2010,
                            FromTime = 2008
                        },
                        new Position
                        {
                            Name = "Position B",
                            Now = false,
                            ToTime = 2016,
                            FromTime = 2010
                        }
                    }
                },
                new Company
                {
                    Name = "Company B",
                    Positions = new List<Position>
                    {
                        new Position
                        {
                            Name = "Position C",
                            Now = false,
                            ToTime = 2010,
                            FromTime = 2008
                        },
                        new Position
                        {
                            Name = "Position D",
                            Now = true,
                            ToTime = null,
                            FromTime = 2010
                        },
                        new Position
                        {
                            Name = "Position E",
                            Now = false,
                            ToTime = 2016,
                            FromTime = 2010
                        }
                    }
                }
            };

            var result = companies.OrderCompanies();

            Assert.IsTrue(result.Count == 2);
            Assert.IsTrue(result[0].Positions.Count == 3);
            Assert.IsTrue(result[1].Positions.Count == 2);
        }

        [TestMethod]
        public void TestMultipleCompanies_MultiplePositions_OneCurrentPosition_ReturnsCorrectAmount()
        {
            var companies = new List<Company>
            {
                new Company
                {
                    Name = "Company A",
                    Positions = new List<Position>
                    {
                        new Position
                        {
                            Name = "Position A",
                            Now = false,
                            ToTime = 2010,
                            FromTime = 2008
                        },
                        new Position
                        {
                            Name = "Position B",
                            Now = false,
                            ToTime = 2016,
                            FromTime = 2010
                        }
                    }
                },
                new Company
                {
                    Name = "Company B",
                    Positions = new List<Position>
                    {
                        new Position
                        {
                            Name = "Position C",
                            Now = false,
                            ToTime = 2010,
                            FromTime = 2008
                        },
                        new Position
                        {
                            Name = "Position D",
                            Now = true,
                            ToTime = null,
                            FromTime = 2010
                        },
                        new Position
                        {
                            Name = "Position E",
                            Now = false,
                            ToTime = 2016,
                            FromTime = 2010
                        }
                    }
                }
            };

            var result = companies.OrderCompanies();

            Assert.IsTrue(result.Count == 2);
            Assert.IsTrue(result[0].Positions.Count == 3);
            Assert.IsTrue(result[1].Positions.Count == 2);
        }
    }
}
