using System.Collections.Generic;

namespace WorkoutLogger.Core.DomainModel
{
    public class WeightExercise : IExercise
    {
        public string Name { get; private set; }
        public List<WeightSet> Sets { get; private set; }

        public WeightExercise(string name )
        {
            Name = name;
        }

        public void Add(ushort reps, ushort weight)
        {
            if (SetsNotInitialized()) InitializeSets();
            Sets.Add(new WeightSet(reps,weight));
        }

        private bool SetsNotInitialized()
        {
            return Sets == null;
        }

        private void InitializeSets()
        {
            Sets = new List<WeightSet>();
        }
    }
}
