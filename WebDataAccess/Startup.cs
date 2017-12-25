using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using WebDataAccess.Entities;

namespace WebDataAccess
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("dbContext.json", optional: true);

            Configuration = builder.Build();
        }
        public IConfigurationRoot Configuration { get; }


        public void ConfigureServices(IServiceCollection services)
        {
            var conString = Configuration.GetConnectionString("DefaultString");

            services.AddDbContext<ArtistContext>(options => options.UseSqlServer.Configuration["ConnectionStrings:DefaultString"]);
          
        }
    }
}
