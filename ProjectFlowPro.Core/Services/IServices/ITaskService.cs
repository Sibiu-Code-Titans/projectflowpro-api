using ProjectFlowPro.Core.Dtos.TaskDtos;

namespace ProjectFlowPro.Core.Services.IServices
{
    public interface ITaskService
    {
        Task<int> AddTask(AddTaskDto task);

        Task<string> GetTaskDescriptionById(int taskId);
    }
}
