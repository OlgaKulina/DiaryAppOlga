using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DiaryAppOlga.Models;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace DiaryAppOlga.Data
{
    public class ApplicationIdentityDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationIdentityDbContext(DbContextOptions<ApplicationIdentityDbContext> options)
            : base(options)
        {
        }

        //public static async Task CreateAdminAccount(IServiceProvider serviceProvider, IConfiguration configuration) {
        //    UserManager<ApplicationUser> userManager =
        //        serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
        //    RoleManager<IdentityRole> roleManager =
        //        serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
        //    string username = configuration["Data:AdminUser:Name"];
        //    string email = configuration["Data:AdminUser:Email"];
        //    string password = configuration["Data:AdminUser:Password"];
        //    string role = configuration["Data:AdminUser:Role"];
        //    if (await userManager.FindByNameAsync(username) == null) {
        //        if (await roleManager.FindByNameAsync(role) == null) {
        //            await roleManager.CreateAsync(new IdentityRole(role));
        //        }
        //        ApplicationUser user = new ApplicationUser {
        //            UserName = username,
        //            Email = email
        //        };
        //        IdentityResult result = await userManager.CreateAsync(user, password);
        //        if (result.Succeeded) {
        //            await userManager.AddToRoleAsync(user, role);
        //        }
        //    }
        //}

                                   
        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);

        //}
    }
}
