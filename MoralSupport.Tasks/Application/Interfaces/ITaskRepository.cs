using MoralSupport.Tasks.Domain.Entities;

namespace MoralSupport.Tasks.Application.Interfaces
{
    public interface ITaskRepository
    {
        Task<List<TaskItem>> GetAllTasksAsync();
        Task AddTaskAsync(TaskItem task);
        Task UpdateTaskAsync(TaskItem task);
        Task DeleteTaskAsync(int taskId);
    }
}
