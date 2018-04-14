using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using WebController.Entities;
using Microsoft.EntityFrameworkCore;
using WebController.Core;
using Microsoft.AspNetCore.Identity;
using System.IdentityModel.Tokens.Jwt;

namespace WebController
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<ArtistContext>(options =>
            options.UseSqlServer(Configuration["ConnectionStrings:DefaultConnection"]));

            services.AddDbContext<AppIdentity>(options =>
            options.UseSqlServer(Configuration["ConnectionStrings:IdentityConnection"]));

            // adding Identity Db
            services.AddIdentity<AppUser, IdentityRole>(opt =>
            {
                opt.Password.RequiredLength = 6;
                opt.Password.RequireNonAlphanumeric = false;
                opt.Password.RequireDigit = false;
            }).AddEntityFrameworkStores<AppIdentity>()
                .AddDefaultTokenProviders();


            services.ConfigureApplicationCookie(opt => opt.AccessDeniedPath = "/Account/AccessDenied");
           


            //JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear();


            //services.AddAuthentication(options =>
            //{
            //    options.DefaultScheme = "Cookies";
            //    options.DefaultChallengeScheme = "oidc";
            //})
            //    .AddCookie("Cookies")
            //    .AddOpenIdConnect("oidc", options =>
            //    {
            //        options.SignInScheme = "Cookies";
            //        options.Authority = "http://localhost:44380";  // identitySever

            //        options.RequireHttpsMetadata = false;

            //        // client Info
            //        options.ClientId = "mvcApp";
            //        options.SaveTokens = true;
            //    });


            services.AddMvc();
            services.AddMemoryCache();
            services.AddSession();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseStatusCodePages();
            app.UseDeveloperExceptionPage();
            app.UseStaticFiles();
            app.UseSession();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}"
                    ); 

             
            });


            SeedData.Initialize(app);
        }
    }
}
