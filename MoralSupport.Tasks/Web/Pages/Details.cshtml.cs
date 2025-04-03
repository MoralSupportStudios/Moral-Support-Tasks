using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MoralSupport.Tasks.Domain.Enums;

namespace MoralSupport.Tasks.Web.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly MoralSupport.Tasks.Infrastructure.Data.TasksDbContext _context;

        public DetailsModel(MoralSupport.Tasks.Infrastructure.Data.TasksDbContext context)
        {
            _context = context;
        }

        public TaskItem TaskItem { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taskitem = await _context.Tasks.FirstOrDefaultAsync(m => m.Id == id);
            if (taskitem == null)
            {
                return NotFound();
            }
            else
            {
                TaskItem = taskitem;
            }
            return Page();
        }
    }
}
