

namespace Microsoft.DiaryAppOlga.ApplicationCore.Entities.ScheduleAggregate
{
    public class ScheduleItem : BaseEntity
    {
        public int ScheduleId { get; set; }
        public int DailyTasksId { get; set; }
        public int WeeklyTasksId { get; set; }
        public int MonthlyTasksId { get; set; }
        

    }
}
