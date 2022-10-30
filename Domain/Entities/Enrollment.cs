namespace Domain.Entities;

public class Enrollment
{
    public int Id { get; set; }
    public int StudentId { get; set; }
    public virtual Student? Student { get; set; }
    public List<Course>? Courses { get; set; }
}
