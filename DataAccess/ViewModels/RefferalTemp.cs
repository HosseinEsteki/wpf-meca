using DataAccess.Models;

namespace DataAccess.ViewModels
{
    internal class RefferalTemp
    {
        public DateTime? GetAlertTime(Job job)
        {
            Refferal refferal = job.Refferal;
            DateTime kilometerDate, monthDate;
            //Convert To Year
            float segmentKilometer = job.Segment.DurabilityPerKilloMetter;
            float carKilometer = refferal.Car.RunPerYear;
            float daysForService = 365 * segmentKilometer / carKilometer;
            kilometerDate = refferal.CreatedAt.AddDays(daysForService);
            int perMonth = job.Segment.DurabilityPerMonth;
            monthDate = refferal.CreatedAt.AddMonths(perMonth);
            if (monthDate < DateTime.Now || kilometerDate < DateTime.Now)
            {
                return monthDate < kilometerDate ? monthDate : kilometerDate;
            }
            else
            {
                return null;
            }
        }
        public DateTime GetRefferalDate(Refferal refferal)
        {
            DateTime kilometerDate = GetKilometerDate(refferal.Car, refferal.Jobs, refferal.CreatedAt);
            DateTime monthDate = GetMonthDate(refferal.Jobs, refferal.CreatedAt);
            return kilometerDate >= monthDate ? kilometerDate : monthDate;
        }
        public DateTime GetKilometerDate(Car car, ICollection<Job>? jobs, DateTime date)
        {
            DateTime result = DateTime.Now;
            int count = 0;
            foreach (var job in jobs)
            {
                float segmentKilometer = job.Segment.DurabilityPerKilloMetter;
                float carKilometer = car.RunPerYear;
                float daysForService = 365 * segmentKilometer / carKilometer;
                DateTime kilometerDate = date.AddDays(daysForService);
                if (count == 0)
                {
                    count++;
                    result = kilometerDate;
                }
                else
                {
                    if (result > kilometerDate)
                    {
                        result = kilometerDate;
                    }
                }
            }

            return result;
        }
        public DateTime GetMonthDate(ICollection<Job>? jobs, DateTime date)
        {
            int count = 0;
            DateTime result = DateTime.Now;
            foreach (var job in jobs)
            {
                int perMonth = jobs.First().Segment.DurabilityPerMonth;
                DateTime monthDate = date.AddMonths(perMonth);
                if (count == 0)
                {
                    count++;
                    result = monthDate;
                }
                else
                {
                    if (result > monthDate)
                    {
                        result = monthDate;
                    }
                }
            }
            return result;
        }
    }
}
