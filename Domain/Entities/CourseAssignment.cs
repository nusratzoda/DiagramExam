namespace Domain.Entities;

public class CourseAssignment
{
    public int Id { get; set; }
    public int CourseId { get; set; }
    public virtual Course? Course { get; set; }
    public int InstructorId { get; set; }
    public virtual Instructor? Instructor { get; set; }
}
