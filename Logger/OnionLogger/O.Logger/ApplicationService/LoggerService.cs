using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DomainModel;
using DomainService;

namespace ApplicationService
{
    public class LoggerService
    {
        private IWorkoutRepository _workoutRepository;

        public LoggerService(IWorkoutRepository workoutRepository)
        {
            _workoutRepository = workoutRepository;
        }

        public async Task<Workout> CreateWorkout()
        {
            var workout = new Workout();
            await _workoutRepository.Create(workout);
            return workout;
        }

        public async Task<Workout> Read(Guid id)
        {
            return await _workoutRepository.Read(id);
        }

        public async Task<Workout> Edit(Guid id)
        {
            throw new NotImplementedException();
            var workout = await _workoutRepository.Read(id);
            // do change
            await _workoutRepository.Update(workout);
            //return workout;
            
        }
    }
}
