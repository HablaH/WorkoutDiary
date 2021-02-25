using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DomainModel
{
    class WeightExercise : IExercise
    {
        private string _name;
        private List<WeightSet> _sets;

        public WeightExercise(string name )
        {
            _name = name;
        }

        public void Add(ushort reps, ushort weight)
        {
            if (SetsNotInitialized()) InitializeSets();
            _sets.Add(new WeightSet(reps,weight));
        }

        private bool SetsNotInitialized()
        {
            return _sets == null;
        }

        private void InitializeSets()
        {
            _sets = new List<WeightSet>();
        }
    }
}
