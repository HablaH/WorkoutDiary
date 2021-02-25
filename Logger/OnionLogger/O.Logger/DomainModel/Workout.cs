using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModel
{
    public class Workout
    {
        public Guid Id;
        private DateTime _dateTime;
        private List<IExercise> _exercises;

        public Workout()
        {
            Id = new Guid();
            _dateTime = DateTime.Now;
        }

        public void AddWeightExercise(string name )
        {
            if (ExercisesNotInitialized()) InitializeExercises();
            _exercises.Add(new WeightExercise(name));
        }

        private bool ExercisesNotInitialized()
        {
            return _exercises == null;
        }

        private void InitializeExercises()
        {
            _exercises = new List<IExercise>();
        }
    }
}
