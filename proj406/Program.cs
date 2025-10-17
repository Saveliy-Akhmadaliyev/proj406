using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using proj406.Domain;
using proj406.Infrastructure.DataAccess;
using proj406.Initializer;

namespace proj406
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            ConfigureServices(builder.Services);

            var app = builder.Build();

            app.MapGet("/", () => "Hello World!");
            app.MapHealthChecks("helth-check");

            app.Run();
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddHealthChecks();
            services.AddIdentity<ApplicationUser, ApplicationIdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders();

            DbContextInitializer.InitializeDbContext(services);
        }
    }
}