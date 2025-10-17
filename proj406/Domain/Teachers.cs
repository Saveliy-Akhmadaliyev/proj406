namespace proj406.Domain
{
    public class Teachers
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public string? Info { get; set; }

        /// <summary>
        /// navigation prop которая показывает все teacher_ATs
        /// </summary>
        public IEnumerable<ATs> ATs { get; set; } = [];
    }
}
