using Microsoft.EntityFrameworkCore;


namespace TestBootstrap.Models
{
    public class UserAimContext : DbContext

    {
        public DbSet<UserAim> UserAims { get; set; }
        

        public UserAimContext(DbContextOptions<UserAimContext> options)
            : base(options)
        {
            //Database.EnsureCreated();
        }
    }


}

