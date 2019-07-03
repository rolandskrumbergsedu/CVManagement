using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CV.Management.Web.Models.Database
{
    public static class OrderingExtensions
    {
        public static List<Company> OrderCompanies(this List<Company> companiesToOrder)
        {
            var result = new List<Company>();

            // Get all companies with Now positions
            var presentCompanies = companiesToOrder.Where(x => x.Positions.Where(y => y.ToTime == null && y.Now).Count() > 0).ToList();

            // Add all companies with Now positions
            foreach (var company in presentCompanies)
            {
                var nonEmptyTimePositions = company.Positions.Where(x => x.FromTime.HasValue).OrderByDescending(x => x.FromTime).ToList();
                var emptyTimePositions = company.Positions.Where(x => !x.FromTime.HasValue);

                company.Positions = nonEmptyTimePositions;
                foreach (var item in emptyTimePositions)
                {
                    company.Positions.Add(item);
                }

                result.Add(company);
            }

            // Get all companies with no Now positions
            var nonPresentCompanies = companiesToOrder.Where(x => x.Positions.Where(y => y.ToTime == null && y.Now).Count() == 0).ToList();

            while (nonPresentCompanies.Count() > 0)
            {
                var highestYear = 0;

                // Find the highest year in the list
                foreach (var company in nonPresentCompanies)
                {
                    var highestYearInPosition = company.Positions.Max(x => x.ToTime).Value;

                    if (highestYearInPosition > highestYear)
                    {
                        highestYear = highestYearInPosition;
                    }
                }

                // Find the highest year companies
                var highestYearCompanies = nonPresentCompanies.Where(x => x.Positions.Where(y => y.ToTime == highestYear && !y.Now).Count() > 0).ToList();

                foreach (var company in highestYearCompanies)
                {
                    var nonEmptyTimePositions = company.Positions.Where(x => x.FromTime.HasValue).OrderByDescending(x => x.FromTime).ToList();
                    var emptyTimePositions = company.Positions.Where(x => !x.FromTime.HasValue).ToList();

                    company.Positions = nonEmptyTimePositions;
                    foreach (var item in emptyTimePositions)
                    {
                        company.Positions.Add(item);
                    }

                    result.Add(company);
                }

                // Remove highest year companies
                nonPresentCompanies.RemoveAll(x => x.Positions.Where(y => y.ToTime == highestYear && !y.Now).Count() > 0);
            }

            return result;
        }
    }
}