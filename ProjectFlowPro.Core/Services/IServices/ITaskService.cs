using ProjectFlowPro.Core.Dtos.TaskDtos;

namespace ProjectFlowPro.Core.Services.IServices
{
    public interface ITaskService
    {
        Task<int> AddTask(AddTaskDto task);

        Task<TaskDescriptionDto> GetTaskDescription(int taskId);

        Task<int> DeleteTask(int taskId);
    }
}
