using Moq;
using MoralSupport.Tasks.Application.Interfaces;
using MoralSupport.Tasks.Application.Services;
using MoralSupport.Tasks.Domain.Enums;

namespace MoralSupport.Tasks.Tests.Services
{
    [TestFixture]
    public class TaskServiceTests
    {
        private Mock<ITaskRepository> _mockRepo = null!;
        private TaskService _service = null!;

        [SetUp]
        public void SetUp()
        {
            _mockRepo = new Mock<ITaskRepository>();
            _service = new TaskService(_mockRepo.Object);
        }

        [Test]
        public async Task GetAllTasksAsync_ShouldReturnTasksFromRepository()
        {
            // Arrange
            var fakeTasks = new List<TaskItem>
            {
                new TaskItem { Id = 1, Title = "Test Task", Description = "Example", AssignedUserId = 1, OrgId = 1 },
            };
            _mockRepo.Setup(r => r.GetAllTasksAsync()).ReturnsAsync(fakeTasks);

            // Act
            var result = await _service.GetAllTasksAsync();

            // Assert
            Assert.That(result, Is.EqualTo(fakeTasks));
            _mockRepo.Verify(r => r.GetAllTasksAsync(), Times.Once);
        }
    }
}
