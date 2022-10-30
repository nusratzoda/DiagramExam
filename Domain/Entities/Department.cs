using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Department
{
    public int Id { get; set; }
    [Required, MaxLength(100)]
    public string? Name { get; set; }
    public int Budget { get; set; }
    public DateTime StartDate { get; set; }
    public int InstructorId { get; set; }
    public virtual Instructor? Instructor { get; set; }
    public int CourseId { get; set; }
    public virtual Course? Course { get; set; }
}
