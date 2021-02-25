using System;

namespace WorkoutLogger
{
    class Set
    {
        public int Weight;
        public int Reps;

        
        public Set(int weightInKgs, int repetitions)
        {
            Weight = weightInKgs;
            Reps = repetitions;
        }

        public Set()
        {
            Weight = 0;
            Reps = 0;
        }

        public string Show()
        {
            return  $"{Reps} x {Weight} kg";
        }

        public void SetWeight()
        {
            int weight = 0;
            try
            {
                Console.Write("Input weight in kgs: ");
                weight = int.Parse(Console.ReadLine());
                if (weight <= 0 || weight >= 1000) throw new Exception();
            }
            catch (Exception)
            {
                Console.WriteLine("Weight must be a number between 1 and 999");
                SetWeight();
            }
            finally
            {
                Weight = weight;
            }
        }

        public void SetReps()
        {
            var reps = 0;
            try
            {
                Console.Write("Input number of repetitions: ");
                reps = int.Parse(Console.ReadLine());
                if (reps <= 0 || reps >= 201) throw new Exception();
            }
            catch (Exception)
            {
                Console.WriteLine("Reps must be a number between 1 and 200");
                SetReps();
            }
            finally
            {
                Reps = reps;
            }
        }


    }
}
