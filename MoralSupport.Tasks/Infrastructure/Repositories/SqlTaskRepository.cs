using Microsoft.EntityFrameworkCore;
using MoralSupport.Tasks.Application.Interfaces;
using MoralSupport.Tasks.Domain.Enums;
using MoralSupport.Tasks.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoralSupport.Tasks.Infrastructure.Repositories
{
    public class SqlTaskRepository : ITaskRepository
    {
        private readonly TasksDbContext _context;

        public SqlTaskRepository(TasksDbContext context)
        {
            _context = context;
        }
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
        public async Task DeleteTaskAsync(Guid taskId)
        {
            TaskItem? task = await _context.Tasks.FindAsync(taskId);
            if (task is not null) 
            { 
                _context.Tasks.Remove(task); 
                await _context.SaveChangesAsync(); 
            }
        }
        //public Task AddTaskAsync(TaskItem task)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task DeleteTaskAsync(Guid taskId)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<List<TaskItem>> GetAllTasksAsync()
        //{
        //    throw new NotImplementedException();
        //}

        //public Task UpdateTaskAsync(TaskItem task)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
