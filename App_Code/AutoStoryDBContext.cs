using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace AutoPartsStore
{

    public class AutoStoreDBContext : DbContext
    {
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            // IConfigurationRoot configuration = new ConfigurationBuilder()
            //     .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            //     .AddJsonFile("appsettings.json")
            //     .Build();
            // optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        }
    }
}