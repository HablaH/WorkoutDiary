using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using WorkoutLogger.Core.DomainModel;
using WorkoutLogger.Core.DomainServices;

namespace WorkoutLogger.Infrastructure.DataAccess.Repository
{
    public class WlModelRepository : IWorkoutRepository
    {
        private const string connectionStr = @"(localdb)\ProjectsV13;Initial Catalog=WorkoutLogger.DB;Integrated Security=True;";
        
        
        
        public async Task<int> Create(Workout workout)
        {
            await using var connection = new SqlConnection(connectionStr);
            var tableName = $"Session{workout.DateTime}";
            string createTable = @"CREATE TABLE [dbo].["+
                                 tableName+
                                 @"](
                                    [Id] [int] IDENTITY(1,1) NOT NULL,
	                                [Exercise] [nvarchar](max) NOT NULL,
	                                [Set] [int](max) NOT NULL,
	                                [Weight] [int] NOT NULL,
	                                [Reps] [int] NOT NULL
                                    ) ";
            return await connection.ExecuteAsync(createTable);

        }

        public Task<Workout> Read(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Workout workout)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
