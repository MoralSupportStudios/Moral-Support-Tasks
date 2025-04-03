using System.ComponentModel.DataAnnotations;

namespace MoralSupport.Tasks.Domain.Enums
{
    public enum TaskStatus
    {
        [Display(Name = "Pending")]
        Pending,

        [Display(Name = "In Progress")]
        InProgress,

        [Display(Name = "Completed")]
        Completed
    }

}
