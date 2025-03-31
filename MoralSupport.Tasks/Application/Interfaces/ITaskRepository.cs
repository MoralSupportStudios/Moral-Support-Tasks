using MoralSupport.Tasks.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoralSupport.Tasks.Application.Interfaces
{
    public interface ITaskRepository
    {
        Task<List<TaskItem>> GetAllTasksAsync();
        Task AddTaskAsync(TaskItem task);
        Task UpdateTaskAsync(TaskItem task);
        Task DeleteTaskAsync(Guid taskId);




        //Task<IEnumerable<TaskItem>> GetTasks();
        //Task<TaskItem> GetTask(int id);
        //Task<TaskItem> AddTask(TaskItem task);
        //Task<TaskItem> UpdateTask(TaskItem task);
        //Task<TaskItem> DeleteTask(int id);
    }
}
