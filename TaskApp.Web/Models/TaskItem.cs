namespace TaskApp.Web.Models;
using System.ComponentModel.DataAnnotations;

public class TaskItem
{
    public Guid Id { get; set; }

    [Required(ErrorMessage = "Title is required")]
    [MinLength(3, ErrorMessage = "Title must be at least 3 characters")]
    public string Title { get; set; } = "";
    [Required(ErrorMessage = "Description is required")]
    [MinLength(3, ErrorMessage = "Description must be at least 6 characters")]
    public string? Description { get; set; }
    public bool IsCompleted { get; set; }
    public DateTime CreatedAt { get; set; }
}