namespace MoralSupport.Tasks.Domain.Enums
{
    public class TaskItem
    {
        public int Id { get; set; }
        public required string Title { get; set; }

        public required string Description { get; set; }

        public DateTime DueDate { get; set; }

        public TaskStatus Status { get; set; }

        public int AssignedUserId { get; set; }

        public int OrgId { get; set; }


    }
}
