using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Student
{
    public int Id { get; set; }
    [Required, MaxLength(100)]
    public string? FirstName { get; set; }
    [Required, MaxLength(100)]
    public string? LastName { get; set; }
    public DateTime EnrollmentDate { get; set; }
    public int EnrollmentId { get; set; }
    public virtual Enrollment? Enrollment { get; set; }
}
