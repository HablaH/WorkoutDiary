using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModel
{
    class WeightSet
    {
        private ushort _repetitions;
        private ushort _weight;

        public WeightSet(ushort reps, ushort weight)
        {
            _repetitions = reps;
            _weight = weight;
        }

        public void EditReps(ushort newReps)
        {
            _repetitions = newReps;
        }

        public void EditWeight(ushort newWeight)
        {
            _weight = newWeight;
        }
    }
}
