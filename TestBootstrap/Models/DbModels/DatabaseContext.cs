using Microsoft.EntityFrameworkCore;

namespace DiaryAppOlga.Models.DbModels
{
    public class DatabaseContext: DbContext
    {       

        public DbSet<UserGoal> UserGoals { get; set; }
        public DbSet<MTask> MTasks { get; set; }
        public DbSet<WTask> WTasks { get; set; }
        public DbSet<DTask> DTasks { get; set; }
        public DbSet<Priorities> Priorities { get; set; }
        public DbSet<Grades> Grades { get; set; }
        

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
          : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
