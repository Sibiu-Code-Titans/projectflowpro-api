using Microsoft.AspNetCore.Mvc;
using ProjectFlowPro.Core.Dtos.TaskDtos;
using ProjectFlowPro.Core.Services.IServices;

namespace ProjectFlowPro._Api.Controllers
{
    [Route("task")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ITaskService _taskService;

        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpPost("add-task")]
        public async Task<IActionResult> AddTask(AddTaskDto addTask)
        {
            return Ok(await _taskService.AddTask(addTask));
        }
    }
}
