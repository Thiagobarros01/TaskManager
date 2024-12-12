using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Application.Interfaces;
using TaskManager.Domain.Entities;

namespace TaskManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly ITaskService _taskService;

        public TasksController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetAll()
        {
            var tasks = await _taskService.GetAllTasksAsync();
            return Ok(tasks);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(Tasks task)
        {
            var newTask = await _taskService.AddTaskAsync(task);
            return CreatedAtAction(nameof(GetAll), new { id = newTask.Id }, newTask);
        }
    }
}

