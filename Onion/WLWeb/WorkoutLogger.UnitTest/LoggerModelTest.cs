using NUnit.Framework;
using WorkoutLogger.Core.DomainModel;

namespace WorkoutLogger.UnitTest
{
    public class LoggerModelTest
    {
        [Test]
        public void TestCreationAndInitialValues()
        {
            var workout = new Workout();
            Assert.NotNull(workout.Id);
            Assert.NotNull(workout.DateTime);
        }

        [Test]
        public void TestWorkoutWithExercises()
        {
            var workout = new Workout();

            workout.AddWeightExercise("Benk");
            workout.AddWeightSet(10, 50);
            workout.AddWeightSet(8, 55);
            workout.AddWeightSet(6, 60);

            var exercise = (WeightExercise) workout.Exercises[0];

            Assert.AreEqual("Benk",exercise.Name );
            Assert.AreEqual(10,exercise.Sets[0].Repetitions );
            Assert.AreEqual(55, exercise.Sets[1].Weight);
            Assert.AreEqual(6, exercise.Sets[2].Repetitions);

        }

    }
}