using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Instructor
{
    [Required, MaxLength(100)]
    public string? FirstName { get; set; }
    [Required, MaxLength(100)]
    public string? LastName { get; set; }
    public DateTime HireDate { get; set; }
    public List<CourseAssignment>? CourseAssignment { get; set; }
    public List<OfficeAssignment>? OfficeAssignment { get; set; }
}
