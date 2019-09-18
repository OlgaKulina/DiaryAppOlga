using System.Collections.Generic;


namespace DiaryAppOlga.Models.DbModels
{
    public class Week: BaseEntity
    {
        public int WeekNumber { get; set; }        
        public virtual List<WTask> WTasks { get; set; }
        
    }
}
