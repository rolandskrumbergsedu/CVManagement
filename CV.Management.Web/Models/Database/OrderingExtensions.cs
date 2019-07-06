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
            
            var presentCompanies = companiesToOrder.Where(x => x.ContainsCurrentPosition()).ToList();

            var orderedPresentCompanies = GetOrderedCurrentPositionCompanies(presentCompanies);

            // Add all companies with Now positions
            result.AddCompaniesWithOrderedFromPositionsFromCurrentPositionCompanies(orderedPresentCompanies);

            // Get all companies with no Now positions
            var nonPresentCompanies = companiesToOrder.Where(x => x.ContainsNoCurrentPosition()).ToList();

            while (nonPresentCompanies.Count() > 0)
            {
                var highestYearAndMonth = GetHighestToYearInNonCurrentPositionCompanies(nonPresentCompanies);

                // Find the highest year companies
                var highestYearCompanies = nonPresentCompanies.Where(x => x.ContainsPositionWithSpecificToYearInNotCurrentPosition(highestYearAndMonth)).ToList();
                var highestFromYearAndMonth = GetHighestFromYearInNonCurrentPositionCompanies(highestYearCompanies, highestYearAndMonth);

                var highestYearCompaniesWithHighestFromTime = nonPresentCompanies.GetHighestYearCompanies(highestFromYearAndMonth);

                result.AddCompaniesWithOrderedFromPositions(highestYearCompaniesWithHighestFromTime);

                // Remove highest year companies
                nonPresentCompanies.RemoveCompaniesWithHighestToYearFromNotCurrent(highestYearAndMonth, highestFromYearAndMonth);
            }

            return result;
        }

        private static List<Company> GetHighestYearCompanies(this List<Company> nonPresentCompanies, Tuple<int?, int> highestYearAndMonth)
        {
            return nonPresentCompanies.Where(x => x.Positions.Where(y => y.FromTimeMonth == highestYearAndMonth.Item1 && y.FromTime == highestYearAndMonth.Item2).Count() > 0).ToList();
        }

        private static List<Company> GetOrderedCurrentPositionCompanies(List<Company> presentCompanies)
        {
            var orderedPresentCompanies = new List<Company>();

            while (presentCompanies.Count() > 0)
            {
                var highestFromYear = GetHighestFromYearInCurrentPositionCompanies(presentCompanies);

                var highestFromYearCompanies = presentCompanies.Where(x => x.ContainsPositionWithSpecificFromYearInCurrentPosition(highestFromYear)).ToList();

                orderedPresentCompanies.AddCompaniesWithOrderedFromPositions(highestFromYearCompanies);

                presentCompanies.RemoveCompaniesWithHighestFromYearFromCurrent(highestFromYear);
            }

            return orderedPresentCompanies;
        }

        private static int GetHighestFromYearInCurrentPositionCompanies(List<Company> presentCompanies)
        {
            var highestFromYear = 0;

            foreach (var company in presentCompanies)
            {
                var highestYearInPosition = company.GetHighestFromYearWhereCurrentPositions();

                if (highestYearInPosition > highestFromYear)
                {
                    highestFromYear = highestYearInPosition;
                }
            }

            return highestFromYear;
        }

        private static Tuple<int?, int> GetHighestToYearInNonCurrentPositionCompanies(List<Company> nonPresentCompanies)
        {
            var highestYear = 0;
            int? highestMonth = null;

            // Find the highest year in the list
            foreach (var company in nonPresentCompanies)
            {
                var highestYearInPosition = company.Positions.Max(x => x.ToTime).Value;
                var positionsWithHighestYear = company.Positions.Where(x => x.ToTime == highestYearInPosition);
                var highestMonthInHighestYearPositions = positionsWithHighestYear.Max(x => x.ToTimeMonth).HasValue ? positionsWithHighestYear.Max(x => x.ToTimeMonth).Value : (int?)null;

                if (highestYearInPosition >= highestYear)
                {
                    highestYear = highestYearInPosition;

                    if (highestMonthInHighestYearPositions.HasValue && highestMonth.HasValue && highestMonthInHighestYearPositions.Value > highestMonth.Value ||
                        highestMonthInHighestYearPositions.HasValue && !highestMonth.HasValue ||
                        !highestMonthInHighestYearPositions.HasValue)
                    {
                        highestMonth = highestMonthInHighestYearPositions;
                    }

                    
                }
            }

            return new Tuple<int?, int>(highestMonth, highestYear);
        }

        private static Tuple<int?, int> GetHighestFromYearInNonCurrentPositionCompanies(List<Company> nonPresentCompanies, Tuple<int?, int> highestYearAndMonth)
        {
            var highestYear = 0;
            int? highestMonth = null;

            // Find the highest year in the list
            foreach (var company in nonPresentCompanies)
            {
                var highestYearInPosition = company.Positions
                    .Where(x => x.ToTimeMonth == highestYearAndMonth.Item1 && x.ToTime == highestYearAndMonth.Item2)
                    .Max(x => x.FromTime).Value;
                var positionsWithHighestYear = company.Positions
                    .Where(x => x.ToTimeMonth == highestYearAndMonth.Item1 && x.ToTime == highestYearAndMonth.Item2)
                    .Where(x => x.FromTime == highestYearInPosition);
                var highestMonthInHighestYearPositions = positionsWithHighestYear.Max(x => x.FromTimeMonth).HasValue ? positionsWithHighestYear.Max(x => x.FromTimeMonth).Value : (int?)null;

                if (highestYearInPosition >= highestYear)
                {
                    highestYear = highestYearInPosition;

                    if (highestMonthInHighestYearPositions.HasValue && highestMonth.HasValue && highestMonthInHighestYearPositions.Value > highestMonth.Value ||
                        highestMonthInHighestYearPositions.HasValue && !highestMonth.HasValue ||
                        !highestMonthInHighestYearPositions.HasValue)
                    {
                        highestMonth = highestMonthInHighestYearPositions;
                    }


                }
            }

            return new Tuple<int?, int>(highestMonth, highestYear);
        }

        public static bool ContainsCurrentPosition(this Company company)
        {
            return company.Positions.Where(y => y.ToTime == null && y.Now).Count() > 0;
        }

        public static bool ContainsNoCurrentPosition(this Company company)
        {
            return company.Positions.Where(y => y.ToTime == null && y.Now).Count() == 0;
        }

        public static bool ContainsPositionWithSpecificFromYearInCurrentPosition(this Company company, int highestFromYear)
        {
            return company.Positions.Where(y => y.FromTime == highestFromYear && y.Now).Count() > 0;
        }

        public static bool ContainsPositionWithSpecificToYearInNotCurrentPosition(this Company company, Tuple<int?, int> highestYearAndTime)
        {
            return company.Positions.Where(y => y.ToTimeMonth == highestYearAndTime.Item1 && y.ToTime == highestYearAndTime.Item2 && !y.Now).Count() > 0;
        }

        public static int GetHighestFromYearWhereCurrentPositions(this Company company)
        {
            return company.Positions.Where(y => y.Now).Max(x => x.FromTime).Value;
        }

        public static void AddCompaniesWithOrderedFromPositions(this List<Company> companies, List<Company> companiesToAdd)
        {
            foreach (var company in companiesToAdd)
            {
                var nonEmptyTimePositions = company.GetNonEmptyOrderedFromTimePositions();
                var emptyTimePositions = company.GetEmptyFromTimePositions();

                company.Positions = nonEmptyTimePositions;
                foreach (var item in emptyTimePositions)
                {
                    company.Positions.Add(item);
                }

                companies.Add(company);
            }
        }

        public static void AddCompaniesWithOrderedFromPositionsFromCurrentPositionCompanies(this List<Company> companies, List<Company> companiesToAdd)
        {
            foreach (var company in companiesToAdd)
            {
                var nowPositions = company.GetCurrentOrderedPositions();
                var nonEmptyTimePositions = company.GetNotCurrentOrderedPositions();

                company.Positions = nowPositions;
                foreach (var item in nonEmptyTimePositions)
                {
                    company.Positions.Add(item);
                }

                companies.Add(company);
            }
        }

        public static void RemoveCompaniesWithHighestFromYearFromCurrent(this List<Company> presentCompanies, int highestFromYear)
        {
            presentCompanies.RemoveAll(x => x.Positions.Where(y => y.FromTime == highestFromYear && y.Now).Count() > 0);
        }

        public static void RemoveCompaniesWithHighestToYearFromNotCurrent(this List<Company> nonPresentCompanies, Tuple<int?, int> highestYearAndTime, Tuple<int?, int> highestFromYearAndTime)
        {
            nonPresentCompanies.RemoveAll(x => x.Positions.Where(y =>
                y.FromTimeMonth == highestFromYearAndTime.Item1 &&
                y.FromTime == highestFromYearAndTime.Item2 &&
                y.ToTimeMonth == highestYearAndTime.Item1 && 
                y.ToTime == highestYearAndTime.Item2 && 
                !y.Now).Count() > 0);
        }

        public static List<Position> GetNonEmptyOrderedFromTimePositions(this Company company)
        {
            var orderedPositions = new List<Position>();
            var positionsToReview = company.Positions.Where(x => x.FromTime.HasValue).ToList();

            while(positionsToReview.Count() > 0)
            {
                var highestYearPosition = positionsToReview.Max(x => x.FromTime).Value;

                var highestCurrentPositions = positionsToReview.Where(x => x.FromTime == highestYearPosition);

                orderedPositions.AddRange(highestCurrentPositions.Where(x => x.ToTimeMonth.HasValue).OrderByDescending(x => x.ToTimeMonth));
                orderedPositions.AddRange(highestCurrentPositions.Where(x => !x.ToTimeMonth.HasValue));

                positionsToReview.RemoveAll(x => x.FromTime == highestYearPosition);
            }
            
            return orderedPositions;
        }

        public static List<Position> GetCurrentOrderedPositions(this Company company)
        {
            var result = new List<Position>();

            result.AddRange(company.Positions.Where(x => x.Now && x.FromTime.HasValue).OrderByDescending(x => x.FromTime));
            result.AddRange(company.Positions.Where(x => x.Now && !x.FromTime.HasValue));

            return result;
        }

        public static List<Position> GetNotCurrentOrderedPositions(this Company company)
        {
            var result = new List<Position>();

            result.AddRange(company.Positions.Where(x => !x.Now && x.FromTime.HasValue).OrderByDescending(x => x.FromTime));
            result.AddRange(company.Positions.Where(x => !x.Now && !x.FromTime.HasValue));

            return result;
        }

        public static List<Position> GetEmptyFromTimePositions(this Company company)
        {
            return company.Positions.Where(x => !x.FromTime.HasValue).ToList();
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