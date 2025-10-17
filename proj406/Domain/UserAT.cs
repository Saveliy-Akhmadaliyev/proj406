namespace proj406.Domain
{
    public class UserAT
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public ApplicationUser User { get; set; }

        public int ATId { get; set; }

        public ATs AT { get; set; }
    }
}
