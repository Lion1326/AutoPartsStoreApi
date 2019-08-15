using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace AutoPartsStore
{

    public class AutoStoreDBContext : DbContext
    {
        public AutoStoreDBContext (DbContextOptions<AutoStoreDBContext> options) : base (options)
        {

        }

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            // IConfigurationRoot configuration = new ConfigurationBuilder()
            //     .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            //     .AddJsonFile("appsettings.json")
            //     .Build();
            //  optionsBuilder.UseSqlServer(configuration.GetConnectionString("StringDB"));
        }

        public DbSet<User> Users { get; set; }
        public DbSet<passanger_car_attribute> passanger_car_attributes { get; set; }
    }
}