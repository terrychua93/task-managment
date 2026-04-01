using TaskApp.Api.Models;
using TaskApp.Api.Repositories;

namespace TaskApp.Api.Services;

public class TaskService : ITaskService
{
    private readonly ITaskRepository _repo;

    public TaskService(ITaskRepository repo)
    {
        _repo = repo;
    }

    public async Task<List<TaskItem>> GetTasksAsync()
    {
        return await _repo.GetAllAsync();
    }

    public async Task<TaskItem?> GetTaskAsync(Guid id)
    {
        return await _repo.GetByIdAsync(id);
    }

    public async Task AddTaskAsync(string title, string? description)
    {
        if (string.IsNullOrWhiteSpace(title))
            throw new ArgumentException("Title is required");

        var task = new TaskItem
        {
            Id = Guid.NewGuid(),
            Title = title,
            Description = description,
            CreatedAt = DateTime.UtcNow,
            IsCompleted = false
        };

        await _repo.AddAsync(task);
    }

    public async Task CompleteTaskAsync(Guid id)
    {
        var task = await _repo.GetByIdAsync(id);
        if (task == null) return;

        task.IsCompleted = true;

        await _repo.UpdateAsync(task);
    }

    public async Task DeleteTaskAsync(Guid id)
    {
        await _repo.DeleteAsync(id);
    }
}