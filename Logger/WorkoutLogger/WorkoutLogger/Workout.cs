using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.Win32.SafeHandles;

namespace WorkoutLogger
{
    class Workout
    {
        public List<Exercise> Exercises;
        public DateTime Date;

        public Workout()
        {
            Exercises = new List<Exercise>();
        }

        public void AddExercises()
        {
            Console.Write("Enter number of exercises: ");
            try
            {
                var numberOfExercisesStr = Console.ReadLine();
                int numberOfExercises = int.Parse(numberOfExercisesStr);
                for (int i = 0; i < numberOfExercises; i++)
                {
                    Console.Write("Enter name of exercise: ");
                    var name = Console.ReadLine();
                    var ex = new Exercise(name);
                    Console.Write("Enter number of Sets: ");
                    var numberOfSetsStr = Console.ReadLine();
                    int numberOfSets = int.Parse(numberOfSetsStr);
                    for (int j = 0; j < numberOfSets; j++)
                    {
                        ex.AddSet();
                    }
                    Exercises.Add(ex);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("did a nono");
                AddExercises();
            }
        }

        public void GetTime()
        {
            Date = DateTime.Now;
        }

        public string Show()
        {
            return $"{ShowDate() ?? "NoDateSet"}\n" +
                   $"{ShowExercises() ?? "NoExercisesAdded"}";
        }
        public string ShowDate()
        {
            return Date.ToString("U");
        }
        public string ShowExercises()
        {
            var sb = new StringBuilder();
            foreach (var exercise in Exercises)
            {
                sb.AppendLine("\t" + exercise.Show());
            }

            return sb.ToString();
        }

        public void SetTime()
        {
            var year = GetYear();
            var month = GetMonth();
            var day = GetDay(year, month);
            var hour = GetHour();
            var minute = GetMinute();

            var date = new DateTime(year,month,day,hour,minute,0);
            
        }



        private int GetYear()
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

        private int GetMonth()
        {
            Console.Write("Set month: ");
            var monthStr = Console.ReadLine();
            int month = 0;
            try
            {
                month = int.Parse(monthStr);
                if (month <= 0 || month > 12) throw new Exception();
            }
            catch (Exception)
            {
                Console.WriteLine("Month has to be a number between 1 and 12");
                GetMonth();
            }
            return month;
        }

        private int GetDay(int year, int month)
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
        private int GetHour()
        {
            Console.Write("Set hour: ");
            var hourStr = Console.ReadLine();
            int hour = 0;
            try
            {
                hour = int.Parse(hourStr);
                if (hour <= 0 || hour > 24) throw new Exception();
            }
            catch (Exception)
            {
                Console.WriteLine("Hour has to be a number between 0 and 24");
                GetHour();
            }

            return hour;
        }

        private int GetMinute()
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
