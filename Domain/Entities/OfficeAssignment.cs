using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class OfficeAssignment
{
    public int Id { get; set; }
    [Required, MaxLength(100)]
    public string? Location { get; set; }
    public int InstructorId { get; set; }
    public virtual Instructor? Instructor { get; set; }
}
