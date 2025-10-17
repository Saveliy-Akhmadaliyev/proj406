namespace proj406.Domain
{
    public class ATs
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public int CourseId { get; set; }

        public Courses Course { get; set; }

        public LessonType LessonType { get; set; }

        public bool IsOnline { get; set; }

        public DayOfWeek DayOfWeek { get; set; }

        public int ClassNumber { get; set; }

        public int TeacherId { get; set; }

        public Teachers Teacher { get; set; }

        public int Limit { get; set; }

        public WeekFrequency WeekFrequency { get; set; }
    }
}
