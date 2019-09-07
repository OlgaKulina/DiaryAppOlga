using Microsoft.EntityFrameworkCore;


namespace DiaryAppOlga.Models
{
    public class GeneralScheduleContext : DbContext
    {

        
        public GeneralScheduleContext(DbContextOptions<GeneralScheduleContext> options)
           : base(options)
        { }

        public DbSet<Goal> Goals { get; set; }
        public DbSet<MonthlyTask> MonthlyTasks { get; set; }        
        public DbSet<WeeklyTask> WeeklyTasks { get; set; }
        //public DbSet<DailyTask> DailyTasks { get; set; }



    }

}
}
