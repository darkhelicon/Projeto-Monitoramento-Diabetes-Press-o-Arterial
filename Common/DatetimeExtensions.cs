using System;

namespace Common
{
    public static class DateTimeExtensions
    {
        public static DateTime AddWeeks(this DateTime dateTime, int index)
        {
            dateTime = dateTime.AddDays(DayOfWeek.Monday - dateTime.DayOfWeek);
            return dateTime.AddDays(index * 7);
        }
        public static DateTime GetLastDayOfMonth(this DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, DateTime.DaysInMonth(dateTime.Year, dateTime.Month));
        }
        public static DateTime ToEndOfDay(this DateTime date)
        {
            return date.Date.AddDays(1).AddTicks(-1);
        }
        public static string ToString_yyyyMMdd(this DateTime d)
        {
            return String.Format("{0:yyyy-MM-dd}", d);
        }
        public static string ToString_yyyyMMdd(this DateTime? d)
        {
            return !d.HasValue ? string.Empty : String.Format("{0:yyyy-MM-dd}", d);
        }
        public static string ToString_ddMMyyyy(this DateTime d)
        {
            return string.Format("{0:dd/MM/yyyy}", d);
        }
        public static string ToDate_ddMMyyyy(this string dateString)
        {
            var date = Convert.ToDateTime(dateString);

            return string.Format("{0:dd/MM/yyyy}", date);
        }
        public static string ToDate_ddMMyyyyHmm(this DateTime date)
        {
            return string.Format("{0:dd/MM/yyyy H:mm:ss}", date);
        }
        public static string ToStringUTC_yyyyMMddHHmmssZ(this DateTime d)
        {
            return string.Format("{0:yyyy-MM-ddTHH:mm:ssZ}", d);
        }
        public static int QuantityDays(this DateTime date)
        {
            return (int)DateTime.Now.Subtract(date).TotalDays;
        }
        public static int DelayedDays(this DateTime date1, DateTime date2)
        {
            return (int)date1.Subtract(date2).TotalDays;
        }
        public static DateTime LastDaysOfMonth(this DateTime date)
        {
            return new DateTime(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month));
        }
        public static DateTime? ToUserTimeZone(this DateTime? d, int timezone)
        {
            return d == null ? null : (DateTime?)d.Value.ToUserTimeZone(timezone);
        }

        public static DateTime ToUserTimeZone(this DateTime d, int timezone)
        {
            return new DateTime(d.Ticks).AddMinutes(timezone);
        }
        public static DateTime? ToUserTimeZone(this DateTime? d, long timezone)
        {
            return d == null ? null : (DateTime?)d.Value.ToUserTimeZone(timezone);
        }

        public static DateTime ToUserTimeZone(this DateTime d, long timezone)
        {
            return new DateTime(d.Ticks).AddMinutes(timezone);
        }
    }
}