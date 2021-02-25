using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DomainModel;

namespace DomainService
{
    public interface IWorkoutRepository
    {
        Task<bool> Create(Workout workout);
        Task<Workout> Read(Guid id);
        Task<bool> Update(Workout workout);
        Task<bool> Delete(Guid id);
    }
}
