using System;
using System.Threading.Tasks;
using WorkoutLogger.Core.DomainModel;

namespace WorkoutLogger.Core.DomainServices
{
    public interface IWorkoutRepository
    {
        Task<int> Create(Workout workout);
        Task<Workout> Read(Guid id);
        Task<bool> Update(Workout workout);
        Task<bool> Delete(Guid id);
    }
}
