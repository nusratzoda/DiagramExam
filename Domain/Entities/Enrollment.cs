namespace Domain.Entities;

public class Enrollment
{
    public int Id { get; set; }
    public int CourseId { get; set; }
    public virtual Course? Course { get; set; }
    public List<Student>? Student { get; set; }
}
