using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace TestBootstrap.Models
{
    public class UserAimContext : IdentityDbContext

    {
        public DbSet<UserAim> UserAims { get; set; }
        

        public UserAimContext(DbContextOptions<UserAimContext> options)
            : base(options)
        {
            //Database.EnsureCreated();
        }
    }


}

