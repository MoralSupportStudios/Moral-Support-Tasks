using Microsoft.EntityFrameworkCore;
using MoralSupport.Tasks.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoralSupport.Tasks.Infrastructure.Data
{
    public class TasksDbContext : DbContext
    {
        public TasksDbContext(DbContextOptions<TasksDbContext> options) : base(options)
        {
        }
        public DbSet<TaskItem> Tasks { get; set; }
    }
}
