
using System.Globalization;

namespace AloTaxi.Application.Utilities.Extensions
{
    public static class DateExtensions
    {
        public static string ToShamsi(this DateTime date)
        {
            var pc = new PersianCalendar();

            return pc.GetYear(date) + "/" + pc.GetMonth(date).ToString("00") + "/" + pc.GetDayOfMonth(date).ToString("00");
        }

        public static string? ToShamsi(this DateTime? date)
        {
            var pc = new PersianCalendar();

            if (date == null)
            {
                return default;
            }

            return pc.GetYear((DateTime)date) + "/" + pc.GetMonth((DateTime)date).ToString("00") + "/" + pc.GetDayOfMonth((DateTime)date).ToString("00");
        }

        public static string GetHourAndMinutes(this DateTime value)
        {
            return value.ToString("HH:mm");
        }

        public static string ToIraniDate(this DateTime dt)
        {
            var pc = new PersianCalendar();
            var intYear = pc.GetYear(dt);
            var intMonth = pc.GetMonth(dt);
            var intDayOfMonth = pc.GetDayOfMonth(dt);
            DayOfWeek enDayOfWeek = pc.GetDayOfWeek(dt);
            var strMonthName = intMonth switch
            {
                1 => "فروردین",
                2 => "اردیبهشت",
                3 => "خرداد",
                4 => "تیر",
                5 => "مرداد",
                6 => "شهریور",
                7 => "مهر",
                8 => "آبان",
                9 => "آذر",
                10 => "دی",
                11 => "بهمن",
                12 => "اسفند",
                _ => ""
            };

            var strDayName = enDayOfWeek switch
            {
                DayOfWeek.Friday => "جمعه",
                DayOfWeek.Monday => "دوشنبه",
                DayOfWeek.Saturday => "شنبه",
                DayOfWeek.Sunday => "یکشنبه",
                DayOfWeek.Thursday => "پنجشنبه",
                DayOfWeek.Tuesday => "سه شنبه",
                DayOfWeek.Wednesday => "چهارشنبه",
                _ => ""
            };

            return ($"{strDayName} {intDayOfMonth} {strMonthName} {intYear}");
        }

        public static DateTime ToMiladiDateTime(this string ts)
        {
            var splitDate = ts.Fa2En().Split('/');
            var year = int.Parse(splitDate[0]);
            var month = int.Parse(splitDate[1]);
            var day = int.Parse(splitDate[2]);
            var currentDate = new DateTime(year, month, day, new PersianCalendar());
            return currentDate;
        }
    }
}
