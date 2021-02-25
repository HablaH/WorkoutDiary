using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace WorkoutLogger.Core.DomainModel
{
    public class Workout
    {
        public Guid Id { get; }
        public DateTime DateTime { get; }

        public List<IExercise> Exercises { get; private set; }


        public Workout(Guid id = new Guid())
        {
            Id = id;
            DateTime = DateTime.Now;
        }

        public void AddWeightExercise(string name)
        {
            if (ExercisesNotInitialized()) InitializeExercises();
            Exercises.Add(new WeightExercise(name));
        }

        public void AddWeightSet(ushort reps, ushort weight)
        {
            if (ExercisesNotInitialized()) return;
            int index = Exercises.Count - 1;
            WeightExercise exercise = (WeightExercise)Exercises[index];
            exercise.Add(reps, weight);
            Exercises[index] = exercise;
        }

        public void AddWeightSets(int sets, ushort reps, ushort weight)
        {
            if (ExercisesNotInitialized()) return;
            int index = Exercises.Count - 1;
            WeightExercise exercise = (WeightExercise)Exercises[index];
            for (int i = 0; i < sets; i++)
            {
                exercise.Add(reps, weight);
            }
            Exercises[index] = exercise;
        }

        private bool ExercisesNotInitialized()
        {
            return Exercises == null;
        }

        private void InitializeExercises()
        {
            Exercises = new List<IExercise>();
        }
    };
}
