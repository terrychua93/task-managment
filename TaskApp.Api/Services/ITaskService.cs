using TaskApp.Api.Models;

namespace TaskApp.Api.Services;

public interface ITaskService
{
    Task<List<TaskItem>> GetTasksAsync();
    Task<TaskItem?> GetTaskAsync(Guid id);
    Task AddTaskAsync(string title, string? description);
    Task CompleteTaskAsync(Guid id);
    Task DeleteTaskAsync(Guid id);
}