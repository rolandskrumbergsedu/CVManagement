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

            while (companiesToOrder.Count() > 0)
            {
                var mostRecentCompanies = companiesToOrder.GetCompaniesWithMostRecentPositionTimesAndUpdateCompanyList();

                foreach (var company in mostRecentCompanies)
                {
                    result.Add(company.WithOrderedPositions());
                }
            }

            return result;
        }

        public static Company WithOrderedPositions(this Company company)
        {
            var positionsToReview = company.Positions.ToList();

            var result = new Company
            {
                City = company.City,
                Industry = company.Industry,
                MainProductions = company.MainProductions,
                Name = company.Name,
                NumberOfEmployess = company.NumberOfEmployess,
                OtherIndustry = company.OtherIndustry,
                ParentCompanyName = company.ParentCompanyName,
                Turnover = company.Turnover,
                Positions = new List<Position>()
            };

            while (positionsToReview.Count() > 0)
            {
                var mostRecentPositionTimes = positionsToReview.GetMostRecentPositionTimes();

                var positionsToAdd = mostRecentPositionTimes.Item4 == 9999 ?
                    positionsToReview.Where(x => x.Now && 
                                            x.FromTime == mostRecentPositionTimes.Item2 && 
                                            x.FromTimeMonth == mostRecentPositionTimes.Item1).ToList() :
                    positionsToReview.Where(x => x.ToTime == mostRecentPositionTimes.Item4 &&
                                            x.ToTimeMonth == mostRecentPositionTimes.Item3 &&
                                            x.FromTime == mostRecentPositionTimes.Item2 &&
                                            x.FromTimeMonth == mostRecentPositionTimes.Item1).ToList();

                foreach (var position in positionsToAdd)
                {
                    result.Positions.Add(position);
                }

                if (mostRecentPositionTimes.Item4 == 9999)
                {
                    positionsToReview.RemoveAll(x => x.Now &&
                                            x.FromTime == mostRecentPositionTimes.Item2 &&
                                            x.FromTimeMonth == mostRecentPositionTimes.Item1);
                }
                else
                {
                    positionsToReview.RemoveAll(x => x.ToTime == mostRecentPositionTimes.Item4 &&
                                            x.ToTimeMonth == mostRecentPositionTimes.Item3 &&
                                            x.FromTime == mostRecentPositionTimes.Item2 &&
                                            x.FromTimeMonth == mostRecentPositionTimes.Item1);
                }
            }

            return result;
        }

        public static Tuple<int?, int, int?, int> GetMostRecentPositionTimes(this List<Position> positions)
        {
            var isCurrent = false;
            var resultToMonth = (int?)null;
            var resultToYear = 0;
            var resultFromMonth = (int?)null;
            var resultFromYear = 0;

            var containsCurrentPosition = positions.Where(x => x.Now).Count() > 0;

            if (containsCurrentPosition)
            {
                resultToYear = 9999;
                isCurrent = true;
            }
            else
            {
                var maxYear = positions.Max(x => x.ToTime);
                var highestToYear = maxYear.HasValue ? maxYear.Value : 9999;

                resultToYear = highestToYear;

                var highestToYearPositions = positions.Where(x => x.ToTime == highestToYear);
                var highestToMonth = highestToYearPositions.Max(x => x.ToTimeMonth);

                resultToMonth = highestToMonth != null ? highestToMonth : null;
            }

            var mostRecentPositions = isCurrent ?
                positions.Where(x => x.Now) :
                positions.Where(x => x.ToTime == resultToYear && x.ToTimeMonth == resultToMonth);

            var highestFromYear = mostRecentPositions.Max(x => x.FromTime).Value;
            resultFromYear = highestFromYear;
            var highestFromYearPositions = mostRecentPositions.Where(x => x.FromTime == highestFromYear);
            var highestFromMonth = highestFromYearPositions.Max(x => x.FromTimeMonth);

            resultFromMonth = highestFromMonth != null ? highestFromMonth : null;

            return new Tuple<int?, int, int?, int>(resultFromMonth, resultFromYear, resultToMonth, resultToYear);
        }

        public static Tuple<int?, int, int?, int> GetMostRecentPositionTimes(this Company company)
        {
            return company.Positions.ToList().GetMostRecentPositionTimes();
        }

        public static List<Company> GetCompaniesWithMostRecentPositionTimesAndUpdateCompanyList(this List<Company> companies)
        {
            var result = new List<Company>();
            var highestResult = companies.GetMostRecentPositionTimes();

            result = highestResult.Item4 == 9999 ?
                companies.Where(x => x.Positions
                    .Where(y => y.Now && 
                           y.FromTime == highestResult.Item2 && 
                           y.FromTimeMonth == highestResult.Item1).Count() > 0).ToList() :
                companies.Where(x => x.Positions
                    .Where(y => y.FromTime == highestResult.Item2 && 
                           y.FromTimeMonth == highestResult.Item1 && 
                           y.ToTime == highestResult.Item4 && 
                           y.ToTimeMonth == highestResult.Item3).Count() > 0).ToList();

            if (highestResult.Item4 == 9999)
            {
                companies.RemoveAll(x => x.Positions
                    .Where(y => y.Now &&
                           y.FromTime == highestResult.Item2 &&
                           y.FromTimeMonth == highestResult.Item1).Count() > 0);
            }
            else
            {
                companies.RemoveAll(x => x.Positions
                    .Where(y => y.FromTime == highestResult.Item2 &&
                           y.FromTimeMonth == highestResult.Item1 &&
                           y.ToTime == highestResult.Item4 &&
                           y.ToTimeMonth == highestResult.Item3).Count() > 0);
            }
            

            return result;
        }

        public static Tuple<int?, int, int?, int> GetMostRecentPositionTimes(this List<Company> companies)
        {
            Tuple<int?, int, int?, int> highestResult = companies[0].GetMostRecentPositionTimes();

            foreach (var company in companies)
            {
                var currentRecentTime = company.GetMostRecentPositionTimes();

                // If year is higher, update all
                if (currentRecentTime.Item4 > highestResult.Item4)
                {
                    highestResult = currentRecentTime;
                }

                // If year is equal, check month
                if (currentRecentTime.Item4 == highestResult.Item4)
                {
                    // If month has value, but previous do not, update all
                    // If month is higher, update all
                    if (currentRecentTime.Item3.HasValue && !highestResult.Item3.HasValue || currentRecentTime.Item3 > highestResult.Item3)
                    {
                        highestResult = currentRecentTime;
                    }

                    // If month are equal, start checking from time
                    if (currentRecentTime.Item3 == highestResult.Item3)
                    {
                        // If year is higher, update all
                        if (currentRecentTime.Item2 > highestResult.Item2)
                        {
                            highestResult = currentRecentTime;
                        }

                        // If year is equal, check month
                        if (currentRecentTime.Item2 == highestResult.Item2)
                        {
                            // If month has value, but previous do not, update all
                            // If month is higher, update all
                            if (currentRecentTime.Item1.HasValue && !highestResult.Item1.HasValue || currentRecentTime.Item1 > highestResult.Item1)
                            {
                                highestResult = currentRecentTime;
                            }
                        }
                    }
                }
            }

            return highestResult;
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