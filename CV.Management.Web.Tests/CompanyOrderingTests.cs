using CV.Management.Web.Models.Database;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

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

        [TestMethod]
        public void TestOneCompany_MultiplePositions_ReturnsCorrectOrder()
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

            Assert.AreEqual("Company A", result[0].Name);
            Assert.AreEqual("Position B", result[0].Positions.ElementAt(0).Name);
            Assert.AreEqual("Position A", result[0].Positions.ElementAt(1).Name);
        }

        [TestMethod]
        public void TestOneCompany_MultiplePositions_OneCurrentPosition_ReturnsCorrectOrder()
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

            Assert.AreEqual("Company A", result[0].Name);
            Assert.AreEqual("Position B", result[0].Positions.ElementAt(0).Name);
            Assert.AreEqual("Position A", result[0].Positions.ElementAt(1).Name);
        }

        [TestMethod]
        public void TestMultipleCompanies_MultiplePositions_ReturnsCorrectOrder()
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
                            FromTime = 2012
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
                            Now = false,
                            ToTime = 2018,
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

            Assert.AreEqual("Company B", result[0].Name);
            Assert.AreEqual("Company A", result[1].Name);
            Assert.AreEqual("Position D", result[0].Positions.ElementAt(0).Name);
            Assert.AreEqual("Position E", result[0].Positions.ElementAt(1).Name);
            Assert.AreEqual("Position C", result[0].Positions.ElementAt(2).Name);
            Assert.AreEqual("Position B", result[1].Positions.ElementAt(0).Name);
            Assert.AreEqual("Position A", result[1].Positions.ElementAt(1).Name);
        }

        [TestMethod]
        public void TestMultipleCompanies_MultiplePositions_OneCurrentPosition_ReturnsCorrectOrder()
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
                            FromTime = 2012
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

            Assert.AreEqual("Company B", result[0].Name);
            Assert.AreEqual("Company A", result[1].Name);
            Assert.AreEqual("Position D", result[0].Positions.ElementAt(0).Name);
            Assert.AreEqual("Position E", result[0].Positions.ElementAt(1).Name);
            Assert.AreEqual("Position C", result[0].Positions.ElementAt(2).Name);
            Assert.AreEqual("Position B", result[1].Positions.ElementAt(0).Name);
            Assert.AreEqual("Position A", result[1].Positions.ElementAt(1).Name);

        }

        [TestMethod]
        public void TestMultipleCompanies_MultiplePositions_MultipleCurrentPositionInMultipleCompanies_ReturnsCorrectOrder()
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
                            FromTime = 2012
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

            Assert.AreEqual("Company A", result[0].Name);
            Assert.AreEqual("Company B", result[1].Name);
            Assert.AreEqual("Position D", result[1].Positions.ElementAt(0).Name);
            Assert.AreEqual("Position E", result[1].Positions.ElementAt(1).Name);
            Assert.AreEqual("Position C", result[1].Positions.ElementAt(2).Name);
            Assert.AreEqual("Position B", result[0].Positions.ElementAt(0).Name);
            Assert.AreEqual("Position A", result[0].Positions.ElementAt(1).Name);

        }

        [TestMethod]
        public void TestMultipleCompanies_MultiplePositions_MultipleCurrentPositionInOneCompany_ReturnsCorrectOrder()
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
                            FromTime = 2012
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
                            Now = true,
                            ToTime = null,
                            FromTime = 2008
                        },
                        new Position
                        {
                            Name = "Position D",
                            Now = false,
                            ToTime = 2018,
                            FromTime = 2010
                        },
                        new Position
                        {
                            Name = "Position E",
                            Now = true,
                            ToTime = null,
                            FromTime = 2010
                        }
                    }
                }
            };

            var result = companies.OrderCompanies();

            Assert.AreEqual("Company B", result[0].Name);
            Assert.AreEqual("Company A", result[1].Name);
            Assert.AreEqual("Position E", result[0].Positions.ElementAt(0).Name);
            Assert.AreEqual("Position C", result[0].Positions.ElementAt(1).Name);
            Assert.AreEqual("Position D", result[0].Positions.ElementAt(2).Name);
            Assert.AreEqual("Position B", result[1].Positions.ElementAt(0).Name);
            Assert.AreEqual("Position A", result[1].Positions.ElementAt(1).Name);

        }

        [TestMethod]
        public void TestMultipleCompanies_MultiplePositions_Example1_ReturnsCorrectOrder()
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
                            Now = true,
                            ToTime = null,
                            FromTime = 2009
                        },
                        new Position
                        {
                            Name = "Position B",
                            Now = false,
                            ToTime = 2009,
                            FromTime = 2007
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
                            Now = true,
                            ToTime = null,
                            FromTime = 2012
                        },
                        new Position
                        {
                            Name = "Position D",
                            Now = false,
                            ToTime = 2012,
                            FromTime = 2010
                        }
                    }
                },
                new Company
                {
                    Name = "Company C",
                    Positions = new List<Position>
                    {
                        new Position
                        {
                            Name = "Position E",
                            Now = false,
                            ToTime = 2010,
                            FromTime = 2008
                        }
                    }
                },
                new Company
                {
                    Name = "Company D",
                    Positions = new List<Position>
                    {
                        new Position
                        {
                            Name = "Position F",
                            Now = false,
                            ToTime = 2010,
                            FromTime = 2007
                        }
                    }
                }
            };

            var result = companies.OrderCompanies();

            Assert.AreEqual("Company B", result[0].Name);
            Assert.AreEqual("Company A", result[1].Name);
            Assert.AreEqual("Company C", result[2].Name);
            Assert.AreEqual("Company D", result[3].Name);
            Assert.AreEqual("Position C", result[0].Positions.ElementAt(0).Name);
            Assert.AreEqual("Position D", result[0].Positions.ElementAt(1).Name);
            Assert.AreEqual("Position A", result[1].Positions.ElementAt(0).Name);
            Assert.AreEqual("Position B", result[1].Positions.ElementAt(1).Name);
            Assert.AreEqual("Position E", result[2].Positions.ElementAt(0).Name);
            Assert.AreEqual("Position F", result[3].Positions.ElementAt(0).Name);
        }

        [TestMethod]
        public void TestMultipleCompanies_MultiplePositions_Example2_ReturnsCorrectOrder()
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
                            Now = true,
                            ToTime = null,
                            FromTime = 2009
                        },
                        new Position
                        {
                            Name = "Position B",
                            Now = false,
                            ToTime = 2009,
                            FromTime = 2007
                        }
                    }
                },                
                new Company
                {
                    Name = "Company C",
                    Positions = new List<Position>
                    {
                        new Position
                        {
                            Name = "Position E",
                            Now = false,
                            ToTime = 2010,
                            FromTime = 2008
                        }
                    }
                },
                new Company
                {
                    Name = "Company D",
                    Positions = new List<Position>
                    {
                        new Position
                        {
                            Name = "Position F",
                            Now = false,
                            ToTime = 2010,
                            FromTime = 2007
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
                            Now = true,
                            ToTime = null,
                            FromTime = 2012
                        },
                        new Position
                        {
                            Name = "Position D",
                            Now = false,
                            ToTime = 2017,
                            FromTime = 2015
                        }
                    }
                },
            };

            var result = companies.OrderCompanies();

            Assert.AreEqual("Company B", result[0].Name);
            Assert.AreEqual("Company A", result[1].Name);
            Assert.AreEqual("Company C", result[2].Name);
            Assert.AreEqual("Company D", result[3].Name);
            Assert.AreEqual("Position C", result[0].Positions.ElementAt(0).Name);
            Assert.AreEqual("Position D", result[0].Positions.ElementAt(1).Name);
            Assert.AreEqual("Position A", result[1].Positions.ElementAt(0).Name);
            Assert.AreEqual("Position B", result[1].Positions.ElementAt(1).Name);
            Assert.AreEqual("Position E", result[2].Positions.ElementAt(0).Name);
            Assert.AreEqual("Position F", result[3].Positions.ElementAt(0).Name);
        }

        [TestMethod]
        public void TestOneCompany_WithMonths_MultiplePositions_ReturnsCorrectAmount()
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
                            ToTimeMonth = 1,
                            FromTime = 2008,
                            FromTimeMonth = 5
                        },
                        new Position
                        {
                            Name = "Position B",
                            Now = false,
                            ToTime = 2016,
                            ToTimeMonth = 2,
                            FromTime = 2010,
                            FromTimeMonth = 3
                        }
                    }
                }
            };

            var result = companies.OrderCompanies();

            Assert.IsTrue(result.Count == 1);
            Assert.IsTrue(result[0].Positions.Count == 2);
        }

        [TestMethod]
        public void TestOneCompany_WithMonths_MultiplePositions_OneCurrentPosition_ReturnsCorrectAmount()
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
                            ToTimeMonth = 4,
                            FromTime = 2008
                        },
                        new Position
                        {
                            Name = "Position B",
                            Now = true,
                            ToTime = null,
                            ToTimeMonth = null,
                            FromTime = 2010,
                            FromTimeMonth = 4
                        }
                    }
                }
            };

            var result = companies.OrderCompanies();

            Assert.IsTrue(result.Count == 1);
            Assert.IsTrue(result[0].Positions.Count == 2);
        }

        [TestMethod]
        public void TestMultipleCompanies_WithMonths_MultiplePositions_ReturnsCorrectAmount()
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
                            ToTimeMonth = 8,
                            FromTime = 2008,
                            FromTimeMonth = 2
                        },
                        new Position
                        {
                            Name = "Position B",
                            Now = false,
                            ToTime = 2016,
                            ToTimeMonth = 4,
                            FromTime = 2010,
                            FromTimeMonth = 7
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
                            ToTimeMonth = 4,
                            FromTime = 2008,
                            FromTimeMonth = 7
                        },
                        new Position
                        {
                            Name = "Position D",
                            Now = true,
                            ToTime = null,
                            ToTimeMonth = null,
                            FromTime = 2010,
                            FromTimeMonth = 7
                        },
                        new Position
                        {
                            Name = "Position E",
                            Now = false,
                            ToTime = 2016,
                            ToTimeMonth = 4,
                            FromTime = 2010,
                            FromTimeMonth = 7
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
        public void TestMultipleCompanies_WithMonths_MultiplePositions_OneCurrentPosition_ReturnsCorrectAmount()
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
                            ToTimeMonth = 3,
                            FromTime = 2008,
                            FromTimeMonth = 7
                        },
                        new Position
                        {
                            Name = "Position B",
                            Now = false,
                            ToTime = 2016,
                            ToTimeMonth = 3,
                            FromTime = 2010,
                            FromTimeMonth = 7
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
                            ToTimeMonth = 3,
                            FromTime = 2008,
                            FromTimeMonth = 7
                        },
                        new Position
                        {
                            Name = "Position D",
                            Now = true,
                            ToTime = null,
                            ToTimeMonth = null,
                            FromTime = 2010,
                            FromTimeMonth = 7
                        },
                        new Position
                        {
                            Name = "Position E",
                            Now = false,
                            ToTime = 2016,
                            ToTimeMonth = 3,
                            FromTime = 2010,
                            FromTimeMonth = 7
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
        public void TestOneCompany_WithMonths_MultiplePositions_ReturnsCorrectOrder()
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
                            ToTimeMonth = 3,
                            FromTime = 2008,
                            FromTimeMonth = 7
                        },
                        new Position
                        {
                            Name = "Position B",
                            Now = false,
                            ToTime = 2016,
                            ToTimeMonth = 3,
                            FromTime = 2010,
                            FromTimeMonth = 7
                        }
                    }
                }
            };

            var result = companies.OrderCompanies();

            Assert.AreEqual("Company A", result[0].Name);
            Assert.AreEqual("Position B", result[0].Positions.ElementAt(0).Name);
            Assert.AreEqual("Position A", result[0].Positions.ElementAt(1).Name);
        }

        [TestMethod]
        public void TestOneCompany_WithMonths_MultiplePositions_OneCurrentPosition_ReturnsCorrectOrder()
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
                            ToTimeMonth = 3,
                            FromTime = 2008,
                            FromTimeMonth = 7
                        },
                        new Position
                        {
                            Name = "Position B",
                            Now = true,
                            ToTime = null,
                            ToTimeMonth = null,
                            FromTime = 2010,
                            FromTimeMonth = 7
                        }
                    }
                }
            };

            var result = companies.OrderCompanies();

            Assert.AreEqual("Company A", result[0].Name);
            Assert.AreEqual("Position B", result[0].Positions.ElementAt(0).Name);
            Assert.AreEqual("Position A", result[0].Positions.ElementAt(1).Name);
        }

        [TestMethod]
        public void TestMultipleCompanies_WithMonths_MultiplePositions_ReturnsCorrectOrder()
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
                            ToTimeMonth = 3,
                            FromTime = 2008,
                            FromTimeMonth = 7
                        },
                        new Position
                        {
                            Name = "Position B",
                            Now = false,
                            ToTime = 2016,
                            ToTimeMonth = 3,
                            FromTime = 2012,
                            FromTimeMonth = 7
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
                            ToTimeMonth = 3,
                            FromTime = 2008,
                            FromTimeMonth = 7
                        },
                        new Position
                        {
                            Name = "Position D",
                            Now = false,
                            ToTime = 2018,
                            ToTimeMonth = 3,
                            FromTime = 2010,
                            FromTimeMonth = 7
                        },
                        new Position
                        {
                            Name = "Position E",
                            Now = false,
                            ToTime = 2016,
                            ToTimeMonth = 3,
                            FromTime = 2010,
                            FromTimeMonth = 7
                        }
                    }
                }
            };

            var result = companies.OrderCompanies();

            Assert.AreEqual("Company B", result[0].Name);
            Assert.AreEqual("Company A", result[1].Name);
            Assert.AreEqual("Position D", result[0].Positions.ElementAt(0).Name);
            Assert.AreEqual("Position E", result[0].Positions.ElementAt(1).Name);
            Assert.AreEqual("Position C", result[0].Positions.ElementAt(2).Name);
            Assert.AreEqual("Position B", result[1].Positions.ElementAt(0).Name);
            Assert.AreEqual("Position A", result[1].Positions.ElementAt(1).Name);
        }

        [TestMethod]
        public void TestMultipleCompanies_WithMonths_MultiplePositions_OneCurrentPosition_ReturnsCorrectOrder()
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
                            ToTimeMonth = 3,
                            FromTime = 2008,
                            FromTimeMonth = 7
                        },
                        new Position
                        {
                            Name = "Position B",
                            Now = false,
                            ToTime = 2016,
                            ToTimeMonth = 3,
                            FromTime = 2012,
                            FromTimeMonth = 7
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
                            ToTimeMonth = 3,
                            FromTime = 2008,
                            FromTimeMonth = 7
                        },
                        new Position
                        {
                            Name = "Position D",
                            Now = true,
                            ToTime = null,
                            ToTimeMonth = null,
                            FromTime = 2010,
                            FromTimeMonth = 7
                        },
                        new Position
                        {
                            Name = "Position E",
                            Now = false,
                            ToTime = 2016,
                            ToTimeMonth = 3,
                            FromTime = 2010,
                            FromTimeMonth = 7
                        }
                    }
                }
            };

            var result = companies.OrderCompanies();

            Assert.AreEqual("Company B", result[0].Name);
            Assert.AreEqual("Company A", result[1].Name);
            Assert.AreEqual("Position D", result[0].Positions.ElementAt(0).Name);
            Assert.AreEqual("Position E", result[0].Positions.ElementAt(1).Name);
            Assert.AreEqual("Position C", result[0].Positions.ElementAt(2).Name);
            Assert.AreEqual("Position B", result[1].Positions.ElementAt(0).Name);
            Assert.AreEqual("Position A", result[1].Positions.ElementAt(1).Name);

        }

        [TestMethod]
        public void TestMultipleCompanies_WithMonths_MultiplePositions_MultipleCurrentPositionInMultipleCompanies_ReturnsCorrectOrder()
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
                            ToTimeMonth = 3,
                            FromTime = 2008,
                            FromTimeMonth = 7
                        },
                        new Position
                        {
                            Name = "Position B",
                            Now = true,
                            ToTime = null,
                            ToTimeMonth = null,
                            FromTime = 2012,
                            FromTimeMonth = 7
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
                            ToTimeMonth = 3,
                            FromTime = 2008,
                            FromTimeMonth = 7
                        },
                        new Position
                        {
                            Name = "Position D",
                            Now = true,
                            ToTime = null,
                            ToTimeMonth = 3,
                            FromTime = 2010,
                            FromTimeMonth = 7
                        },
                        new Position
                        {
                            Name = "Position E",
                            Now = false,
                            ToTime = 2016,
                            ToTimeMonth = 3,
                            FromTime = 2010,
                            FromTimeMonth = 7
                        }
                    }
                }
            };

            var result = companies.OrderCompanies();

            Assert.AreEqual("Company A", result[0].Name);
            Assert.AreEqual("Company B", result[1].Name);
            Assert.AreEqual("Position D", result[1].Positions.ElementAt(0).Name);
            Assert.AreEqual("Position E", result[1].Positions.ElementAt(1).Name);
            Assert.AreEqual("Position C", result[1].Positions.ElementAt(2).Name);
            Assert.AreEqual("Position B", result[0].Positions.ElementAt(0).Name);
            Assert.AreEqual("Position A", result[0].Positions.ElementAt(1).Name);

        }

        [TestMethod]
        public void TestMultipleCompanies_WithMonths_MultiplePositions_MultipleCurrentPositionInOneCompany_ReturnsCorrectOrder()
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
                            ToTimeMonth = 3,
                            FromTime = 2008,
                            FromTimeMonth = 7
                        },
                        new Position
                        {
                            Name = "Position B",
                            Now = false,
                            ToTime = 2016,
                            ToTimeMonth = 3,
                            FromTime = 2012,
                            FromTimeMonth = 7
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
                            Now = true,
                            ToTime = null,
                            ToTimeMonth = null,
                            FromTime = 2008,
                            FromTimeMonth = 7
                        },
                        new Position
                        {
                            Name = "Position D",
                            Now = false,
                            ToTime = 2018,
                            ToTimeMonth = 3,
                            FromTime = 2010,
                            FromTimeMonth = 7
                        },
                        new Position
                        {
                            Name = "Position E",
                            Now = true,
                            ToTime = null,
                            ToTimeMonth = null,
                            FromTime = 2010,
                            FromTimeMonth = 7
                        }
                    }
                }
            };

            var result = companies.OrderCompanies();

            Assert.AreEqual("Company B", result[0].Name);
            Assert.AreEqual("Company A", result[1].Name);
            Assert.AreEqual("Position E", result[0].Positions.ElementAt(0).Name);
            Assert.AreEqual("Position C", result[0].Positions.ElementAt(1).Name);
            Assert.AreEqual("Position D", result[0].Positions.ElementAt(2).Name);
            Assert.AreEqual("Position B", result[1].Positions.ElementAt(0).Name);
            Assert.AreEqual("Position A", result[1].Positions.ElementAt(1).Name);

        }

        [TestMethod]
        public void TestMultipleCompanies_WithMonths_MultiplePositions_Example1_ReturnsCorrectOrder()
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
                            Now = true,
                            ToTime = null,
                            ToTimeMonth = null,
                            FromTime = 2009,
                            FromTimeMonth = 7
                        },
                        new Position
                        {
                            Name = "Position B",
                            Now = false,
                            ToTime = 2009,
                            ToTimeMonth = 3,
                            FromTime = 2007,
                            FromTimeMonth = 7
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
                            Now = true,
                            ToTime = null,
                            ToTimeMonth = null,
                            FromTime = 2012,
                            FromTimeMonth = 7
                        },
                        new Position
                        {
                            Name = "Position D",
                            Now = false,
                            ToTime = 2012,
                            ToTimeMonth = 3,
                            FromTime = 2010,
                            FromTimeMonth = 7
                        }
                    }
                },
                new Company
                {
                    Name = "Company C",
                    Positions = new List<Position>
                    {
                        new Position
                        {
                            Name = "Position E",
                            Now = false,
                            ToTime = 2010,
                            ToTimeMonth = 3,
                            FromTime = 2008,
                            FromTimeMonth = 7
                        }
                    }
                },
                new Company
                {
                    Name = "Company D",
                    Positions = new List<Position>
                    {
                        new Position
                        {
                            Name = "Position F",
                            Now = false,
                            ToTime = 2010,
                            ToTimeMonth = 3,
                            FromTime = 2007,
                            FromTimeMonth = 7
                        }
                    }
                }
            };

            var result = companies.OrderCompanies();

            Assert.AreEqual("Company B", result[0].Name);
            Assert.AreEqual("Company A", result[1].Name);
            Assert.AreEqual("Company C", result[2].Name);
            Assert.AreEqual("Company D", result[3].Name);
            Assert.AreEqual("Position C", result[0].Positions.ElementAt(0).Name);
            Assert.AreEqual("Position D", result[0].Positions.ElementAt(1).Name);
            Assert.AreEqual("Position A", result[1].Positions.ElementAt(0).Name);
            Assert.AreEqual("Position B", result[1].Positions.ElementAt(1).Name);
            Assert.AreEqual("Position E", result[2].Positions.ElementAt(0).Name);
            Assert.AreEqual("Position F", result[3].Positions.ElementAt(0).Name);
        }

        [TestMethod]
        public void TestMultipleCompanies_WithMonths_MultiplePositions_Example2_ReturnsCorrectOrder()
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
                            Now = true,
                            ToTime = null,
                            ToTimeMonth = null,
                            FromTime = 2009,
                            FromTimeMonth = 7
                        },
                        new Position
                        {
                            Name = "Position B",
                            Now = false,
                            ToTime = 2009,
                            ToTimeMonth = 3,
                            FromTime = 2007,
                            FromTimeMonth = 7
                        }
                    }
                },
                new Company
                {
                    Name = "Company C",
                    Positions = new List<Position>
                    {
                        new Position
                        {
                            Name = "Position E",
                            Now = false,
                            ToTime = 2010,
                            ToTimeMonth = 3,
                            FromTime = 2008,
                            FromTimeMonth = 7
                        }
                    }
                },
                new Company
                {
                    Name = "Company D",
                    Positions = new List<Position>
                    {
                        new Position
                        {
                            Name = "Position F",
                            Now = false,
                            ToTime = 2010,
                            ToTimeMonth = 3,
                            FromTime = 2007,
                            FromTimeMonth = 7
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
                            Now = true,
                            ToTime = null,
                            ToTimeMonth = 3,
                            FromTime = 2012,
                            FromTimeMonth = 7
                        },
                        new Position
                        {
                            Name = "Position D",
                            Now = false,
                            ToTime = 2017,
                            ToTimeMonth = 3,
                            FromTime = 2015,
                            FromTimeMonth = 7
                        }
                    }
                },
            };

            var result = companies.OrderCompanies();

            Assert.AreEqual("Company B", result[0].Name);
            Assert.AreEqual("Company A", result[1].Name);
            Assert.AreEqual("Company C", result[2].Name);
            Assert.AreEqual("Company D", result[3].Name);
            Assert.AreEqual("Position C", result[0].Positions.ElementAt(0).Name);
            Assert.AreEqual("Position D", result[0].Positions.ElementAt(1).Name);
            Assert.AreEqual("Position A", result[1].Positions.ElementAt(0).Name);
            Assert.AreEqual("Position B", result[1].Positions.ElementAt(1).Name);
            Assert.AreEqual("Position E", result[2].Positions.ElementAt(0).Name);
            Assert.AreEqual("Position F", result[3].Positions.ElementAt(0).Name);
        }

        [TestMethod]
        public void TestMultipleCompanies_WithMonths_MultiplePositionsSameYearDifferentMonths_ReturnsCorrectOrder()
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
                            Now = true,
                            ToTime = null,
                            ToTimeMonth = null,
                            FromTime = 2009,
                            FromTimeMonth = 7
                        },
                        new Position
                        {
                            Name = "Position B",
                            Now = false,
                            ToTime = 2009,
                            ToTimeMonth = 3,
                            FromTime = 2007,
                            FromTimeMonth = 7
                        }
                    }
                },
                new Company
                {
                    Name = "Company C",
                    Positions = new List<Position>
                    {
                        new Position
                        {
                            Name = "Position C",
                            Now = false,
                            ToTime = 2015,
                            ToTimeMonth = 6,
                            FromTime = 2008,
                            FromTimeMonth = 4
                        },
                        new Position
                        {
                            Name = "Position D",
                            Now = false,
                            ToTime = 2018,
                            ToTimeMonth = 10,
                            FromTime = 2007,
                            FromTimeMonth = 4
                        },
                        new Position
                        {
                            Name = "Position E",
                            Now = false,
                            ToTime = 2015,
                            ToTimeMonth = 6,
                            FromTime = 2008,
                            FromTimeMonth = 7
                        }
                    }
                },
                new Company
                {
                    Name = "Company D",
                    Positions = new List<Position>
                    {
                        new Position
                        {
                            Name = "Position F",
                            Now = false,
                            ToTime = 2010,
                            ToTimeMonth = 3,
                            FromTime = 2007,
                            FromTimeMonth = 7
                        },
                        new Position
                        {
                            Name = "Position G",
                            Now = false,
                            ToTime = 2018,
                            ToTimeMonth = 10,
                            FromTime = 2007,
                            FromTimeMonth = 7
                        },
                        new Position
                        {
                            Name = "Position H",
                            Now = false,
                            ToTime = 2015,
                            ToTimeMonth = 6,
                            FromTime = 2008,
                            FromTimeMonth = 7
                            
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
                            Name = "Position I",
                            Now = true,
                            ToTime = null,
                            ToTimeMonth = null,
                            FromTime = 2012,
                            FromTimeMonth = 7
                        },
                        new Position
                        {
                            Name = "Position J",
                            Now = false,
                            ToTime = 2017,
                            ToTimeMonth = 3,
                            FromTime = 2015,
                            FromTimeMonth = 7
                        }
                    }
                },
            };

            var result = companies.OrderCompanies();

            Assert.AreEqual("Company B", result[0].Name);
            Assert.AreEqual("Company A", result[1].Name);
            Assert.AreEqual("Company D", result[2].Name);
            Assert.AreEqual("Company C", result[3].Name);
            Assert.AreEqual("Position I", result[0].Positions.ElementAt(0).Name);
            Assert.AreEqual("Position J", result[0].Positions.ElementAt(1).Name);
            Assert.AreEqual("Position A", result[1].Positions.ElementAt(0).Name);
            Assert.AreEqual("Position B", result[1].Positions.ElementAt(1).Name);
            Assert.AreEqual("Position G", result[2].Positions.ElementAt(0).Name);
            Assert.AreEqual("Position H", result[2].Positions.ElementAt(1).Name);
            Assert.AreEqual("Position F", result[2].Positions.ElementAt(2).Name);
            Assert.AreEqual("Position D", result[3].Positions.ElementAt(0).Name);
            Assert.AreEqual("Position E", result[3].Positions.ElementAt(1).Name);
            Assert.AreEqual("Position C", result[3].Positions.ElementAt(2).Name);
        }
    }
}
