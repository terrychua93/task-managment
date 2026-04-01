using Microsoft.AspNetCore.Mvc;
using TaskApp.Api.Services;

namespace TaskApp.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TasksController : ControllerBase
{
    private readonly ITaskService _service;

    public TasksController(ITaskService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var tasks = await _service.GetTasksAsync();
        return Ok(tasks);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateTaskRequest request)
    {
        await _service.AddTaskAsync(request.Title, request.Description);
        return Ok();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Complete(Guid id)
    {
        await _service.CompleteTaskAsync(id);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        await _service.DeleteTaskAsync(id);
        return Ok();
    }
}

public class CreateTaskRequest
{
    public string Title { get; set; } = "";
    public string? Description { get; set; }
}