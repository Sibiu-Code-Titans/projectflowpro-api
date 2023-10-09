using AutoMapper;
using ProjectFlowPro.Core.Dtos.TaskDtos;
using ProjectFlowPro.Data.Models.TaskModels;

namespace ProjectFlowPro.Core.Profiles
{
    public class TaskProfiles : Profile
    {
        public TaskProfiles()
        {
            CreateMap<TaskModel, TaskDetailsDto>()
                .ForMember(dest => dest.TaskId, opt => opt.MapFrom(src => src.TaskId.ToString()));
            CreateMap<TaskModel, TaskPreviewDto>();
            CreateMap<TaskModel, TaskDescriptionDto>();

            CreateMap<TaskDetailsDto, TaskModel>();
            CreateMap<TaskPreviewDto, TaskModel>();
            CreateMap<AddTaskDto, TaskModel>();
        }
    }
}
