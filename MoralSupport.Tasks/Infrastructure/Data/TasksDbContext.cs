using Microsoft.EntityFrameworkCore;
using MoralSupport.Tasks.Domain.Enums;

namespace MoralSupport.Tasks.Infrastructure.Data
{
    public class TasksDbContext(DbContextOptions<TasksDbContext> options) : DbContext(options)
    {
        public DbSet<TaskItem> Tasks { get; set; }
    }
}
