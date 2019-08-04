using Microsoft.DiaryAppOlga.ApplicationCore.Entities;
using Microsoft.DiaryAppOlga.ApplicationCore.Entities.ScheduleAggregate;
using Microsoft.EntityFrameworkCore;

namespace Microsoft.DiaryAppOlga.Infrastructure.Data
//namespace Infrastructure.Data
{
    public class ScheduleContext : DbContext
    {
        public ScheduleContext(DbContextOptions<ScheduleContext> options) : base(options)
        {
        }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<UserTaskItem> UserTaskItems { get; set; }
        public DbSet<DailyTasksItem> DailyTasksItems { get; set; }
        public DbSet<WeeklyTasksItem> WeeklyTasksItems { get; set; }
        public DbSet<MonthlyTasksItem> MonthlyTasksItems { get; set; }
        public DbSet<ScheduleItem> ScheduleItems { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Priority> Priorities { get; set; }
    }
}
