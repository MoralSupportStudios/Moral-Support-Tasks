using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MoralSupport.Tasks.Domain.Enums;
using MoralSupport.Tasks.Infrastructure.Data;

namespace MoralSupport.Tasks.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly MoralSupport.Tasks.Infrastructure.Data.TasksDbContext _context;

        public IndexModel(MoralSupport.Tasks.Infrastructure.Data.TasksDbContext context)
        {
            _context = context;
        }

        public IList<TaskItem> TaskItem { get;set; } = default!;

        public async Task OnGetAsync()
        {
            TaskItem = await _context.Tasks.ToListAsync();
        }
    }
}
