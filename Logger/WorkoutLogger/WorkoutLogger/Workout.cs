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

        public void SetTime()
        {
            Date = DateBuilder.SetTime();
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

        



        

    }
}
