namespace proj406.Domain
{
    public class Courses
    {
        public int Id { get; set; }

        public int DisciplineId { get; set; }

        public Disciplines Discipline { get; set; }

        public required string Name { get; set; }

        public string? CourseCard { get; set; }

        public Format Format { get; set; }

        public string? Presentation { get; set; }

        public int Limit { get; set; }

        /// <summary>
        /// navigation prop которая показывает все course_ATs
        /// </summary>
        public IEnumerable<ATs> ATs { get; set; } = [];
    }
}
