using AutoMapper;
using ProjectFlowPro.Core.Dtos.TaskDtos;
using ProjectFlowPro.Core.Services.IServices;
using ProjectFlowPro.Data.Models.TaskModels;
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
            return(_mapper.Map<TaskDescriptionDto>(await _taskRepository.GetTaskDescription(taskId)));
        }
    }
}
