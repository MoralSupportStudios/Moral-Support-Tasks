using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoralSupport.Tasks.Domain.Enums;
using TaskStatus = MoralSupport.Tasks.Domain.Enums.TaskStatus;

namespace MoralSupport.Tasks.Domain.Entities
{
    public class TaskItem
    {
        public int Id { get; set; }
        public required string Title { get; set; }

        public required string Description { get; set; }

        public DateTime DueDate { get; set; }

        public TaskStatus Status { get; set; } = TaskStatus.Pending;

        public int AssignedUserId { get; set; }

        public int OrgId { get; set; }


    }
}
