using System;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using WorkoutLogger.Core.ApplicationServices;
using WorkoutLogger.Core.DomainModel;
using WorkoutLogger.Core.DomainServices;

namespace WorkoutLogger.UnitTest
{
    public class AppServiceTest
    {
        [Test]
        public async Task CreateWorkout()
        {
            var mock = new Mock<IWorkoutRepository>();
            mock.Setup(repo => repo.Create(It.IsAny<Workout>()))
                                                         .Returns(Task.FromResult(1));
            var loggerService = new LoggerService(mock.Object);
            var workout = await loggerService.CreateWorkout();
            Assert.IsNotNull(workout);
            mock.Verify(repo => repo.Create(workout), Times.Once);
            mock.VerifyNoOtherCalls();

        }

        [Test]
        public async Task ReadWorkout()
        {
            var Id = new Guid("96AED30E-7C6D-43C5-B7CC-2768525FE9F8");
            var workout = new Workout(Id);
            var mock = new Mock<IWorkoutRepository>();
            mock.Setup(repo => repo.Read(Id))
                .Returns(Task.FromResult(workout));
            var loggerService = new LoggerService(mock.Object);
            var workout2 = await loggerService.Read(Id);
            Assert.AreEqual(workout, workout2);
            mock.Verify(repo => repo.Read(Id), Times.Once);
            mock.VerifyNoOtherCalls();

        }
    }
}