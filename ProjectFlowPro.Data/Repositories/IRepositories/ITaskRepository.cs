using ProjectFlowPro.Data.Models.TaskModels;

namespace ProjectFlowPro.Data.Repositories.IRepositories
{
    public interface ITaskRepository
    {
        Task<int> AddTask(TaskModel taskModel);

        Task<TaskModel?> GetTaskById(int taskId);

        Task<TaskModel?> GetTaskDescription(int taskId);

        Task<int> DeleteTask(int taskId);
    }
}
