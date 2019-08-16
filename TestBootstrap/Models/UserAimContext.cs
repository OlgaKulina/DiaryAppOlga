using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace DiaryAppOlga.Models
{
    //1
    public class UserAimContext : IdentityDbContext
    //2
        //public class UserAimContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<UserAim> UserAims { get; set; }
        

        public UserAimContext(DbContextOptions<UserAimContext> options)
            : base(options)
        {
            //Database.EnsureCreated();
        }
    }


}

