using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MoralSupport.Tasks.Domain.Entities;
using MoralSupport.Tasks.Infrastructure.Data;

namespace MoralSupport.Tasks.Web.Pages
{
    public class IndexModel(TasksDbContext context) : PageModel
    {
        private readonly TasksDbContext _context = context;

        public IList<TaskItem> TaskItem { get; set; } = default!;

        public async Task OnGetAsync()
        {
            TaskItem = await _context.Tasks.ToListAsync();
        }
    }
}
