using Microsoft.EntityFrameworkCore;


namespace DiaryAppOlga.Models
{
    public class GeneralScheduleContext : DbContext
    {

        
        public GeneralScheduleContext(DbContextOptions<GeneralScheduleContext> options)
           : base(options)
        { }

        public DbSet<Goals> Goals { get; set; }
        public DbSet<MonthlyTask> MonthlyTasks { get; set; }
        
        public DbSet<WeeklyTask> WeeklyTasks { get; set; }
        public DbSet<FirstWeek> FirstWeeks { get; set; }
        public DbSet<SecondWeek> SecondWeeks { get; set; }
        public DbSet<ThirdWeek> ThirdWeeks { get; set; }
        public DbSet<FourthWeek> FourthWeeks { get; set; }
        public DbSet<Grade> Grades { get; set; }
        //public DbSet<DailyTask> DailyTasks { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FirstWeek>();
            modelBuilder.Entity<SecondWeek>();
            modelBuilder.Entity<ThirdWeek>();
            modelBuilder.Entity<FourthWeek>();
                

            modelBuilder.Entity<WeeklyTask>()
                .ToTable("First Week");
            modelBuilder.Entity<WeeklyTask>()
               .ToTable("Second Week");
            modelBuilder.Entity<WeeklyTask>()
               .ToTable("Third Week");
            modelBuilder.Entity<WeeklyTask>()
               .ToTable("Fourth Week");

            // using the Fluent API
            base.OnModelCreating(modelBuilder);
        }





    }

}

