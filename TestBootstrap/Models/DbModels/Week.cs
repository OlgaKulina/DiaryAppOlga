using System.Collections.Generic;


namespace DiaryAppOlga.Models.DbModels
{
    public class Week: BaseEntity
    {
        public int WeekNumber { get; private set; }
        //List<DTask> dTasks = new List<DTask>(7);

        List<WTask> wTasks = new List<WTask>();

    }
}
