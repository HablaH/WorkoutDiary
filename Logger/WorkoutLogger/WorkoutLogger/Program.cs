using System;

namespace WorkoutLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            var workout = new Workout();
            workout.GetTime();
            workout.AddExercises();


            Console.WriteLine(workout.Show());

            //var ex = new Exercise("Benk");
            //ex.AddSet();
            //ex.AddSet();
            //ex.AddSet();
            //Console.WriteLine(ex.Show());



        }
    }
}
