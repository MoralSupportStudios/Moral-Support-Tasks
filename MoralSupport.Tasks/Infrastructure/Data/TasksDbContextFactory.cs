using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace MoralSupport.Tasks.Infrastructure.Data
{
    public class TasksDbContextFactory : IDesignTimeDbContextFactory<TasksDbContext>
    {
        public TasksDbContext CreateDbContext(string[] args)
        {
            // Go up two levels to the solution root
            var currentDir = Directory.GetCurrentDirectory();
            var solutionRoot = Directory.GetParent(Directory.GetParent(currentDir).FullName).FullName;

            // Now point to the actual path: MoralSupport.Tasks\Web
            var webProjectPath = Path.Combine(solutionRoot, "MoralSupport.Tasks", "Web");

            // Debug output to verify
            Console.WriteLine("Searching for webProjectPath: " + webProjectPath);

            if (!Directory.Exists(webProjectPath))
            {
                throw new DirectoryNotFoundException($"Could not find expected web project path: {webProjectPath}");
            }

            var config = new ConfigurationBuilder()
                .SetBasePath(webProjectPath)
                .AddJsonFile("appsettings.json", optional: false)
                .AddJsonFile("appsettings.Development.json", optional: true)
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<TasksDbContext>();
            optionsBuilder.UseSqlServer(config.GetConnectionString("LocalConnection"));

            return new TasksDbContext(optionsBuilder.Options);
        }
    }
}