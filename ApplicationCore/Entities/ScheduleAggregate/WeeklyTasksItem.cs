

namespace Microsoft.DiaryAppOlga.ApplicationCore.Entities.ScheduleAggregate
{
    public class WeeklyTasksItem : BaseEntity
    {
        //Указать имя --> Weekly Tasks
        public string Title { get; set; }
        public int UserTask_Id { get; set; }    
        public int NumberTask { get; set; }
        public int Grade_Id { get; set; }

    }
}
