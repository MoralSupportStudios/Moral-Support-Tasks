using MoralSupport.Tasks.Application.Interfaces;
using MoralSupport.Tasks.Domain.Entities;

namespace MoralSupport.Tasks.Application.Services
{
    public class TaskService(ITaskRepository taskRepository) : ITaskService
    {
        private readonly ITaskRepository _taskRepository = taskRepository;

        public async Task<List<TaskItem>> GetAllTasksAsync()
        {
            return await _taskRepository.GetAllTasksAsync();
        }

        public async Task<TaskItem?> GetTaskByIdAsync(int id)
        {
            var tasks = await _taskRepository.GetAllTasksAsync();
            return tasks.FirstOrDefault(t => t.Id == id);
        }

        public async Task AddTaskAsync(TaskItem task)
        {
            await _taskRepository.AddTaskAsync(task);
        }

        public async Task UpdateTaskAsync(TaskItem task)
        {
            await _taskRepository.UpdateTaskAsync(task);
        }

        public async Task DeleteTaskAsync(int id)
        {
            await _taskRepository.DeleteTaskAsync(id);
        }
    }
}
