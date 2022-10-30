using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Department
{
    public int Id { get; set; }
    [Required, MaxLength(100)]
    public string? Name { get; set; }
    public int Budget { get; set; }
    public DateTime StartDate { get; set; }
    public List<Instructor>? Instructors { get; set; }
    public List<Course>? Courses { get; set; }
}
