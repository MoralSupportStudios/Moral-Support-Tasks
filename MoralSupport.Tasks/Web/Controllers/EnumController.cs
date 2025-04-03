using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using MoralSupport.Tasks.Domain.Enums;
namespace MoralSupport.Tasks.Web.Controllers
{


    [ApiController]
    [Route("api/enums")]
    public class EnumController : ControllerBase
    {
        [HttpGet("task-status")]
        public IActionResult GetTaskStatus()
        {
            var values = Enum.GetValues(typeof(Domain.Enums.TaskStatus))
                .Cast<Domain.Enums.TaskStatus>()
                .Select(e => new
                {
                    Value = e.ToString(),
                    Display = e.GetType()
                        .GetMember(e.ToString())
                        .First()
                        .GetCustomAttribute<DisplayAttribute>()?.Name ?? e.ToString()
                });

            return Ok(values);
        }
    }

}

