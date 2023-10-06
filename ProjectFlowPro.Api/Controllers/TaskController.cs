using Microsoft.AspNetCore.Mvc;
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
    }
}
