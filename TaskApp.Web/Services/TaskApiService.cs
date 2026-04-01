using System.Net.Http.Json;
using TaskApp.Web.Models;

namespace TaskApp.Web.Services;

public class TaskApiService
{
    private readonly HttpClient _http;

    public TaskApiService(HttpClient http)
    {
        _http = http;
    }

    public async Task<List<TaskItem>> GetTasks()
    {
        return await _http.GetFromJsonAsync<List<TaskItem>>("api/tasks") ?? new();
    }

    public async Task AddTask(TaskItem task)
    {
        await _http.PostAsJsonAsync("api/tasks", task);
    }

    public async Task UpdateTask(TaskItem task)
    {
        await _http.PutAsJsonAsync($"api/tasks/{task.Id}", task);
    }

    public async Task CompleteTask(Guid id)
    {
        await _http.PutAsync($"api/tasks/{id}", null);
    }

    public async Task DeleteTask(Guid id)
    {
        await _http.DeleteAsync($"api/tasks/{id}");
    }
}