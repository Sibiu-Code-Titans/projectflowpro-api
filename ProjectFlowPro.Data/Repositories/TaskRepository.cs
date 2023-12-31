﻿using ProjectFlowPro.Data.DatabaseAccess;
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

        public async Task<TaskModel?> GetTaskById(int taskId)
        {
            var query = @"
                SELECT 
                    TaskId,
                    Title,
                    Description,
                    CreatedDateTime,
                    UpdatedDateTime,
                    Deadline,
                    Columnid
                FROM Task
                WHERE TaskId = @TaskId";

            var param = new
            {
                TaskId = taskId,
            };

            return await DBAccess.Get<TaskModel>(query, param);
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
