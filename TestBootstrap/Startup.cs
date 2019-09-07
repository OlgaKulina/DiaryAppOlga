using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DiaryAppOlga.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore.Infrastructure;
using DiaryAppOlga.Models;
using System.Globalization;
using Microsoft.AspNetCore.Localization;
using DiaryAppOlga.Repository;

namespace DiaryAppOlga
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //Set Culture
            services.Configure<RequestLocalizationOptions>(options =>
            {
                options.DefaultRequestCulture = new RequestCulture("en-US");                
                options.SupportedCultures = new List<CultureInfo> { new CultureInfo("en-US") };                            
                options.RequestCultureProviders = new List<IRequestCultureProvider>();                
            });




            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<ApplicationIdentityDbContext> (options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("IdentityUsersConnection")));
            services.AddIdentity<ApplicationUser, IdentityRole>(opts=> {
                opts.Password.RequiredLength = 9;
                opts.Password.RequireNonAlphanumeric = true;
                opts.Password.RequireLowercase = true;
                opts.Password.RequireUppercase = true;
                opts.Password.RequireDigit = true;

                opts.User.RequireUniqueEmail = true;
            })
                .AddDefaultUI(UIFramework.Bootstrap4)
                .AddEntityFrameworkStores<ApplicationIdentityDbContext>()
                .AddDefaultTokenProviders();

                       

            services.AddDbContext<UserAimContext>(options =>
               options.UseSqlServer(Configuration.GetConnectionString("UserAimConnection")));

            
            services.AddTransient<IRepository, ScheduleRepository>();
            services.AddDbContext<ScheduleContext>(options =>
              options.UseSqlServer(Configuration.GetConnectionString("ScheduleConnection")));


            services.AddScoped<IDataRepository<Goal>, GoalRepository>();
            services.AddScoped<IDataRepository<MonthlyTask>, MonthlyScheduleRepository>();
            services.AddScoped<IDataRepository<WeeklyTask>, WeeklyScheduleRepository>();
            services.AddDbContext<GeneralScheduleContext>(options =>
              options.UseSqlServer(Configuration.GetConnectionString("MainDBConnection")));




            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            
        }



        //To do
        private void AddDefaultTokenProviders()
        {
            throw new NotImplementedException();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
                       

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();            
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseRequestLocalization();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "UserAim",
                    defaults: new { controller = "UserAim", action = "Aim" });

                //routes.MapRoute(
                //    name: "default",
                //    template: "Admin",
                //    defaults: new { controller = "Admin", action = "Aim" });


                routes.MapRoute(
                    name: "default1",
                    template: "{controller=Home}/{action=Index}/{id?}");        
                                
            });

            //ApplicationIdentityDbContext.CreateAdminAccount(app.ApplicationServices,
            //    Configuration).Wait();
        }
    }
}
