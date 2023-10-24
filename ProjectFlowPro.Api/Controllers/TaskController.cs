using Microsoft.AspNetCore.Mvc;
using ProjectFlowPro.Core.Dtos.TaskDtos;
using ProjectFlowPro.Core.Services.IServices;
using System.ComponentModel.DataAnnotations;

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

        [HttpGet("get-description")]
        public async Task<IActionResult> GetTaskDescription([Required]int taskId)
        {
            var task = await _taskService.GetTaskDescription(taskId);

            if (task == null)
                return NoContent();

            return Ok(task);
        }     
        
        [HttpGet("get-navbar")]
        public async Task<IActionResult> GetTaskNavbar([Required]int taskId)
        {
            var task = await _taskService.GetTaskNavbar(taskId);

            if (task == null)
                return NoContent();

            return Ok(task);
        }

        [HttpDelete("delete-task")]
        public async Task<IActionResult> DeleteTask([Required] int taskId)
        {
            var task = await _taskService.DeleteTask(taskId);

            if (task == 0)
                return NoContent();

            return Ok(task);
        }
    }
}
