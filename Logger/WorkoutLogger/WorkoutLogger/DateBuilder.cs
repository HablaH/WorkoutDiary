using System;
using System.Collections.Generic;
using System.Text;

namespace WorkoutLogger
{
    static class  DateBuilder
    {

        public static DateTime SetTime()
        {
            var _year = GetYear();
            var _month = GetMonth();
            var _day = GetDay(_year, _month);
            var _hour = GetHour();
            var _minute = GetMinute();

            return new DateTime(_year, _month, _day, _hour, _minute, 0);
        }

        private static int GetYear()
        {
            Console.Write("Set year: ");
            var yearStr = Console.ReadLine();
            int year = 0;
            try
            {
                year = int.Parse(yearStr);
                if (year < 0 || year > DateTime.Now.Year + 2) throw new Exception();
            }
            catch (Exception)
            {
                Console.WriteLine("Year has to be a number between 0 and current year + 2");
                GetYear();
            }
            return year;
        }

        private static int GetMonth()
       {
            Console.Write("Set month: ");
            var monthStr = Console.ReadLine();
            int month;
            month = 0;
            try
            {
                month = int.Parse(monthStr);
                if (month <= 0 || month > 12) throw new Exception("funker ikke");
                throw new NotImplementedException();
            }
            catch (Exception)
            {
                Console.WriteLine("Month has to be a number between 1 and 12");
                GetMonth();
            }
            return month;
        }

        private static int GetDay(int year, int month)
        {
            Console.Write("Set day: ");
            var daysInMonth = DateTime.DaysInMonth(year, month);
            var dayStr = Console.ReadLine();
            int day = 0;
            try
            {
                day = int.Parse(dayStr);
                if (day <= 0 || day > daysInMonth) throw new Exception();
            }
            catch (Exception)
            {
                Console.WriteLine($"Day Has to be a number between 1 and {daysInMonth}");
                GetDay(year, month);
            }
            return day;
        }
        private static int GetHour()
        {
            Console.Write("Set hour: ");
            var hourStr = Console.ReadLine();
            int hour = 0;
            try
            {
                hour = int.Parse(hourStr);
                if (hour <= 0 || hour >= 24) throw new Exception();
            }
            catch (Exception)
            {
                Console.WriteLine("Hour has to be a number between 0 and 24");
                GetHour();
            }

            return hour;
        }

        private static int GetMinute()
        {
            Console.Write("Set minute: ");
            var minuteStr = Console.ReadLine();
            int minute = 0;
            try
            {
                minute = int.Parse(minuteStr);
                if (minute <= 0 || minute >= 60) throw new Exception();
            }
            catch (Exception)
            {
                Console.WriteLine("Minute has to be a number between 0 and 59");
                GetHour();
            }

            return minute;
        }
    }
}
