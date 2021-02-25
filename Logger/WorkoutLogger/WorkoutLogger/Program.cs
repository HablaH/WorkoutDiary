using System;

namespace WorkoutLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            var workout = new Workout();
            workout.GetTime();

            //workout.SetTime();
            workout.AddExercises();

            Console.WriteLine(workout.Show());
        }
    }
}
