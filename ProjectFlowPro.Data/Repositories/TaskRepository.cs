using ProjectFlowPro.Data.DatabaseAccess;
using ProjectFlowPro.Data.Models.TaskModels;
using ProjectFlowPro.Data.Repositories.IRepositories;

namespace ProjectFlowPro.Data.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        public async Task<int> AddTask(TaskModel task)
        {
            var query = @"
                INSERT INTO Task (Title, Description, Deadline, ColumnId)
                VALUES (@Title, @Description, @Deadline, @ColumnId)
                RETURNING TaskId";

            return await DBAccess.Insert(query, task);
        }
    }
}
