using ProjectFlowPro.Data.DatabaseAccess;
using ProjectFlowPro.Data.Models;
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

        public async Task<TaskModel?> GetTaskById(int taskId)
        {
            var query = @"
                SELECT 
                    Task.TaskId,
                    Task.Title,
                    Task.Description,
                    Task.CreatedDateTime,
                    Task.UpdatedDateTime,
                    Task.Deadline,
                    Task.ColumnId,
                    BoardColumn.columnid AS Column_Id,
                    BoardColumn.StatusName,
                    BoardColumn.StatusDescription,
                    BoardColumn.StatusColor,
                    BoardColumn.Position
                FROM Task
                INNER JOIN BoardColumn ON Task.ColumnId = BoardColumn.ColumnId
                WHERE TaskId = @TaskId";

            var param = new
            {
                TaskId = taskId,
            };

            return await DBAccess.Get<TaskModel, BoardColumnModel>
                (
                    query,
                    (task, boardColumn) =>
                    {
                        task.BoardColumn = boardColumn;
                        return task;
                    },
                    param,
                    splitOn: "Column_Id"
                );
        }

        public async Task<TaskModel?> GetTaskDescription(int taskId)
        {
            var query = @"
                SELECT 
                    Description
                FROM Task
                WHERE TaskId = @TaskId";

            var param = new
            {
                TaskId = taskId,
            };

            return await DBAccess.Get<TaskModel>(query, param);
        }

        public async Task<int> DeleteTask(int taskId)
        {
            var query = @"
                DELETE 
                FROM Task 
                WHERE TaskId = @TaskId";

            var param = new
            {
                TaskId = taskId,
            };

            return await DBAccess.Delete(query, param);
        }
    }
}
