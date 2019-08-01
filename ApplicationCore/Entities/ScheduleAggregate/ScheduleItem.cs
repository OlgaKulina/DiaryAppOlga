

namespace Microsoft.DiaryAppOlga.ApplicationCore.Entities.ScheduleAggregate
{
    public class ScheduleItem : BaseEntity
    {
        public int DailyTasksId { get; set; }
        public int WeeklyTasksId { get; set; }
        public int MonthlyTasksId { get; set; }
        public int ScheduleId { get; set; }

    }
}
