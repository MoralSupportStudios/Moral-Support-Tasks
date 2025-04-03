using Microsoft.EntityFrameworkCore;
using MoralSupport.Tasks.Application.Interfaces;
using MoralSupport.Tasks.Domain.Entities;
using MoralSupport.Tasks.Infrastructure.Data;

namespace MoralSupport.Tasks.Infrastructure.Repositories
{
    public class SqlTaskRepository(TasksDbContext context) : ITaskRepository
    {
        private readonly TasksDbContext _context = context;

        public async Task<List<TaskItem>> GetAllTasksAsync() => await _context.Tasks.ToListAsync();
        public async Task AddTaskAsync(TaskItem task)
        {
            _context.Tasks.Add(task);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateTaskAsync(TaskItem task)
        {
            _context.Tasks.Update(task);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteTaskAsync(int taskId)
        {
            TaskItem? task = await _context.Tasks.FindAsync(taskId);
            if (task is not null)
            {
                _context.Tasks.Remove(task);
                await _context.SaveChangesAsync();
            }
        }
    }
}
