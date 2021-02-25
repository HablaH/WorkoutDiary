namespace WorkoutLogger.Core.DomainModel
{
    public class WeightSet
    {
        public ushort Repetitions { get; private set; }

        public ushort Weight { get; private set; }

        public WeightSet(ushort reps, ushort weight)
        {
            Repetitions = reps;
            Weight = weight;
        }

        public void EditReps(ushort newReps)
        {
            Repetitions = newReps;
        }

        public void EditWeight(ushort newWeight)
        {
            Weight = newWeight;
        }
    }
}
