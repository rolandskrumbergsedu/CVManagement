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

            var orderedPresentCompanies = new List<Company>();

            while(presentCompanies.Count() > 0)
            {
                var highestFromYear = 0;

                foreach (var company in presentCompanies)
                {
                    var highestYearInPosition = company.Positions.Where(y => y.Now).Max(x => x.FromTime).Value;

                    if (highestYearInPosition > highestFromYear)
                    {
                        highestFromYear = highestYearInPosition;
                    }
                }

                var highestYearCompanies = presentCompanies.Where(x => x.Positions.Where(y => y.FromTime == highestFromYear && y.Now).Count() > 0).ToList();

                foreach (var company in highestYearCompanies)
                {
                    var nonEmptyTimePositions = company.Positions.Where(x => x.FromTime.HasValue).OrderByDescending(x => x.FromTime).ToList();
                    var emptyTimePositions = company.Positions.Where(x => !x.FromTime.HasValue).ToList();

                    company.Positions = nonEmptyTimePositions;
                    foreach (var item in emptyTimePositions)
                    {
                        company.Positions.Add(item);
                    }

                    orderedPresentCompanies.Add(company);
                }

                // Remove highest year companies
                presentCompanies.RemoveAll(x => x.Positions.Where(y => y.FromTime == highestFromYear && y.Now).Count() > 0);
            }

            // Add all companies with Now positions
            foreach (var company in orderedPresentCompanies)
            {
                var nowPositions = company.Positions.Where(x => x.Now).OrderByDescending(x => x.FromTime).ToList();
                var nonEmptyTimePositions = company.Positions.Where(x => x.FromTime.HasValue && !x.Now).OrderByDescending(x => x.FromTime).ToList();
                var emptyTimePositions = company.Positions.Where(x => !x.FromTime.HasValue);

                company.Positions = nowPositions;
                foreach (var item in nonEmptyTimePositions)
                {
                    company.Positions.Add(item);
                }
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

        public static List<Education> OrderEducation(this List<Education> educationToOrder)
        {
            var result = new List<Education>();

            var presentEducation = educationToOrder.Where(x => x.Now).OrderByDescending(y => y.FromYear).ToList();
            result.AddRange(presentEducation);

            var nonPresentEducation = educationToOrder.Where(x => !x.Now).ToList();

            while (nonPresentEducation.Count() > 0)
            {
                var highestYear = nonPresentEducation.Max(x => x.ToYear);
                
                var highestYeareducations = nonPresentEducation.Where(x => x.ToYear == highestYear).ToList();

                var orderedHighestYeareducations = highestYeareducations.OrderByDescending(x => x.FromYear).ToList();

                result.AddRange(orderedHighestYeareducations);

                nonPresentEducation.RemoveAll(x => x.ToYear == highestYear);
            }

            return result;
        }

        public static List<AdditionalCourse> OrderAdditionalCourse(this List<AdditionalCourse> additionalCoursesToOrder)
        {
            var result = new List<AdditionalCourse>();

            var nonEmptyCourses = additionalCoursesToOrder
                .Where(x => x.Year.HasValue)
                .OrderByDescending(x => x.Year)
                .ToList();
            result.AddRange(nonEmptyCourses);

            result.AddRange(additionalCoursesToOrder
                .Where(x => !x.Year.HasValue));

            return result;
        }

        public static List<Membership> OrderMembership(this List<Membership> membershipToOrder)
        {
            var result = new List<Membership>();

            var presentMembership = membershipToOrder.Where(x => x.Now).OrderByDescending(y => y.FromTime).ToList();
            result.AddRange(presentMembership);

            var nonPresentMemberships = membershipToOrder.Where(x => !x.Now).ToList();

            while (nonPresentMemberships.Count() > 0)
            {
                var highestYear = nonPresentMemberships.Max(x => x.ToTime);

                var highestYearMemberships = nonPresentMemberships.Where(x => x.ToTime == highestYear).ToList();

                var orderedHighestYearMemberships = highestYearMemberships.OrderByDescending(x => x.FromTime).ToList();

                result.AddRange(orderedHighestYearMemberships);

                nonPresentMemberships.RemoveAll(x => x.ToTime == highestYear);
            }

            return result;
        }
    }
}