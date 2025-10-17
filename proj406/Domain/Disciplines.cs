namespace proj406.Domain
{
    public class Disciplines
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public int Year { get; set; }

        public DirectionTraining DirectionTraining { get; set; }

        /// <summary>
        /// navigation prop которая показывает все discipline_courses
        /// </summary>
        public IEnumerable<Courses> Courses { get; set; } = [];
    }
}
