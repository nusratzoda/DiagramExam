using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Course
{
    public int Id { get; set; }
    [Required, MaxLength(100)]
    public string? Title { get; set; }
    public int Credits { get; set; }
    public int DepartmentId { get; set; }
    public Department? Department { get; set; }
    public List<Enrollment>? Enrollment { get; set; }
    public List<CourseAssignment>? CourseAssigmnment { get; set; }
}
