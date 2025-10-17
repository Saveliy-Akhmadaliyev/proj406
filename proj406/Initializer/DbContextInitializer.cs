using Microsoft.EntityFrameworkCore;
using proj406.Infrastructure.DataAccess; 

namespace proj406.Initializer
{
    public static class DbContextInitializer
    {
        public static void InitializeDbContext(IServiceCollection services)
        {
            var pathToDbFile = GetPathToDbFile();
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlite($"Data Source={pathToDbFile}"));

            using var serviceProvider = services.BuildServiceProvider();
            var appDbContext = serviceProvider.GetRequiredService<AppDbContext>();

            appDbContext.Database.EnsureCreated();
            appDbContext.Database.Migrate();

            string GetPathToDbFile()
            {
                var applicationFolder = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "proj406");

                if (!Directory.Exists(applicationFolder))
                {
                    Directory.CreateDirectory(applicationFolder);
                }

                return Path.Combine(applicationFolder, "proj406.db"); 
            }
        }
    }
}
