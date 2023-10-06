using ProjectFlowPro.Core.Services.IServices;
using ProjectFlowPro.Data.Repositories.IRepositories;

namespace ProjectFlowPro.Core.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;

        public TaskService(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }
    }
}
