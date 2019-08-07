using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace AutoPartsStore
{
    public class Startup
    {
        public Startup (IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration
        {
            get;
        }

        public void ConfigureServices (IServiceCollection services)
        {
            services.AddDbContext<AutoStoreDBContext> (options =>
                options.UseSqlServer (Configuration.GetConnectionString ("StringDB")));
            RepositoriesInjection.Inject (services);
            services.AddMvc ();
        }

        public void Configure (IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseMvc ();
        }
    }
}