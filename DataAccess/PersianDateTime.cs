using System.Globalization;

namespace DataAccess
{
    internal class PersianDateTime
    {
        public static string GetDate(DateTime dateTime)
        {
            PersianCalendar pc = new PersianCalendar();
            string date;
            int year, month, day;
            year = pc.GetYear(dateTime);
            month = pc.GetMonth(dateTime);
            day = pc.GetDayOfMonth(dateTime);
            date = $"{year}/{month}/{day}";
            return date;
        }

        public static string GetDateTime(DateTime dateTime)
        {
            PersianCalendar pc = new PersianCalendar();
            string date=GetDate(dateTime);
            int hour, minute;
            hour = pc.GetHour(dateTime);
            minute = pc.GetMinute(dateTime);
            date += $"\n {hour}:{minute}";
            return date;
        }
    }
}
