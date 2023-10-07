using ProjectFlowPro.Data.Models.TaskModels;

namespace ProjectFlowPro.Data.Repositories.IRepositories
{
    public interface ITaskRepository
    {
        Task<int> AddTask(TaskModel taskModel);
    }
}
