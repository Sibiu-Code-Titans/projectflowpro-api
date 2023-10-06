using AutoMapper;
using ProjectFlowPro.Core.Dtos.TaskDtos;

namespace ProjectFlowPro.Core.Profiles
{
    public class TaskProfiles : Profile
    {
        public TaskProfiles()
        {
            CreateMap<Task, TaskDetailsDto>();
            CreateMap<Task, TaskPreviewDto>();

            CreateMap<TaskDetailsDto, Task>();
            CreateMap<TaskPreviewDto, Task>();
        }
    }
}
