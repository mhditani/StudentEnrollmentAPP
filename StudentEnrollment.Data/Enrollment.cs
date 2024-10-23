namespace StudentEnrollment.Data
{
    public class Enrollment : BaseEntity
    {
        public int CourseId { get; set; } 
        public int StudentId { get; set; }

        public virtual Course Course { get; set; } = new Course();

        public virtual Student Student { get; set; } = new Student();

    }
}
