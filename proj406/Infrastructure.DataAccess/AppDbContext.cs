using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using proj406.Domain;

namespace proj406.Infrastructure.DataAccess
{
    public class AppDbContext : IdentityDbContext<ApplicationUser, ApplicationIdentityRole, Guid>
    {
        public DbSet<ApplicationIdentityRole> ApplicationRoles { get; private set; }

        public DbSet<ApplicationUser> ApplicationUsers { get; private set; }

        public DbSet<UserAT> UserATs { get; private set; }

        public DbSet<Disciplines> Disciplines { get; private set; }

        public DbSet<Courses> Courses { get; private set; }

        public DbSet<ATs> ATs { get; private set; }

        public DbSet<Teachers> Teachers { get; private set; }

        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<UserAT>()
                .HasOne(UserAT => UserAT.User)
                .WithMany()
                .HasForeignKey(p => p.UserId);

            builder.Entity<UserAT>()
                .HasOne(UserAT => UserAT.AT)
                .WithMany()
                .HasForeignKey(p => p.ATId);

            builder.Entity<Courses>()
                .HasOne(Courses => Courses.Discipline)
                .WithMany()
                .HasForeignKey(p => p.DisciplineId);

            builder.Entity<ATs>()
                .HasOne(ATs => ATs.Course)
                .WithMany()
                .HasForeignKey(p => p.CourseId);

            builder.Entity<ATs>()
                .HasOne(ATs => ATs.Teacher)
                .WithMany()
                .HasForeignKey(p => p.TeacherId);
        }
    }
}
