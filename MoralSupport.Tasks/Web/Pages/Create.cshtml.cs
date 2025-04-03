using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MoralSupport.Tasks.Domain.Enums;

namespace MoralSupport.Tasks.Web.Pages
{
    public class CreateModel : PageModel
    {
        private readonly MoralSupport.Tasks.Infrastructure.Data.TasksDbContext _context;

        public CreateModel(MoralSupport.Tasks.Infrastructure.Data.TasksDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public TaskItem TaskItem { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Tasks.Add(TaskItem);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
