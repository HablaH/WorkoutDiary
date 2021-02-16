using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkoutLogger
{
    class Exercise
    {
        public string Name;
        public List<Set> Sets;

        public Exercise(string name)
        {
            Name = name;
            Sets = new List<Set>();
        }

        public string Show()
        {
            if (Sets.All(s =>s.Weight == Sets[0].Weight && s.Reps == Sets[0].Reps))
            {
                return $"{Sets.Count} sets of {Sets[0].Reps} x {Sets[0].Weight} kg";
            }

            var sb = new StringBuilder();
            sb.Append(Name + ":");
            foreach (var set in Sets)
            {
                sb.Append("\n\t" + set.Show());
            }

            return sb.ToString();
        }

        public void AddSet()
        {
            Console.WriteLine($"Set number {Sets.Count + 1}");
            var set = new Set();
            set.SetWeight();
            set.SetReps();
            Sets.Add(set);
        }
        
        
    }
}
