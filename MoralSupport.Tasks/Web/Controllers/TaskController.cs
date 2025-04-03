using Microsoft.AspNetCore.Mvc;
using MoralSupport.Tasks.Application.Interfaces;
using MoralSupport.Tasks.Domain.Entities;

namespace MoralSupport.Tasks.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly ITaskRepository _taskRepository;

        public TaskController(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TaskItem>>> GetAll()
        {
            var tasks = await _taskRepository.GetAllTasksAsync();
            return Ok(tasks);
        }
        [HttpPost]
        public async Task<ActionResult<TaskItem>> Create([FromBody] TaskItem task)
        {
            if (task == null)
                return BadRequest();

            await _taskRepository.AddTaskAsync(task);
            return CreatedAtAction(nameof(GetAll), new { id = task.Id }, task);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] TaskItem task)
        {
            if (id != task.Id)
                return BadRequest();

            await _taskRepository.UpdateTaskAsync(task);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _taskRepository.DeleteTaskAsync(id);
            return NoContent();
        }
    }
}
