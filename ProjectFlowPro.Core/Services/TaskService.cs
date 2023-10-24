using AutoMapper;
using ProjectFlowPro.Core.Dtos.TaskDtos;
using ProjectFlowPro.Core.Services.IServices;
using ProjectFlowPro.Data.Models;
using ProjectFlowPro.Data.Repositories.IRepositories;

namespace ProjectFlowPro.Core.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;
        private readonly IMapper _mapper;

        public TaskService(ITaskRepository taskRepository, IMapper mapper)
        {
            _taskRepository = taskRepository;
            _mapper = mapper;
        }

        public async Task<int> AddTask(AddTaskDto task)
        {
            return await _taskRepository.AddTask(_mapper.Map<TaskModel>(task));
        }

        public async Task<TaskDescriptionDto> GetTaskDescription(int taskId)
        {
            return (_mapper.Map<TaskDescriptionDto>(await _taskRepository.GetTaskDescription(taskId)));
        }

        public async Task<TaskNavbar?> GetTaskNavbar(int taskId)
        {
            var task = await _taskRepository.GetTaskById(taskId);

            if (task == null)
            {
                return null;
            }

            return _mapper.Map<TaskNavbar>(task);
        }

        public async Task<int> DeleteTask(int taskId)
        {
            return await _taskRepository.DeleteTask(taskId);
        }
    }
}
