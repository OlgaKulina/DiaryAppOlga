
namespace Microsoft.DiaryAppOlga.ApplicationCore.Entities.ScheduleAggregate
{
    public class DailyTasksItem : BaseEntity
    {
        //Указать имя --> Daily Tasks 
        public string Title { get; set; }
        public int UserTaskId { get; set; }
        public int NumberTask { get; set; } //номер задачи
        public int GradeId {get ; set; }
        public int ScheduleId { get; set; }



    }
}
