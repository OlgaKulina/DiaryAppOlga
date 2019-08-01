

namespace Microsoft.DiaryAppOlga.ApplicationCore.Entities.ScheduleAggregate
{
    public class MonthlyTasksItem : BaseEntity
    {
        //Указать имя --> Monthly Tasks
        public string Title { get; set; }
        public int WeeklyTasks_Id { get; set; }
        public int MonthlylyTasks_Id { get; set; }
        public int NumberTask { get; set; }
        public int Grade_Id { get; set; }


    }
}
