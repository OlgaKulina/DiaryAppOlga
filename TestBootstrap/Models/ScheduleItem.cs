

namespace DiaryAppOlga.Models
{
    public class ScheduleItem
    {
        public int ScheduleId { get; set; }
        public string UserId { get; set; }

        public int MonthlyTasksId { get; set; }
        public MonthlyTask MonthlyTasks { get; set; }

    }
}
