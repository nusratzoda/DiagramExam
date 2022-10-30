namespace Domain.Dtos;

public class StudentDto
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateTime EnrollmentDate { get; set; }
}
