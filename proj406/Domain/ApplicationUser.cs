using Microsoft.AspNetCore.Identity;

namespace proj406.Domain
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public int Year { get; set; }
        
        public DirectionTraining DirectionTraining { get; set; }

        /// <summary>
        /// navigation prop которая показывает все user_ats
        /// </summary>
        public IEnumerable<UserAT> UserATs { get; set; } = [];
    }
}
