using System.Collections.Generic;


namespace DiaryAppOlga.Models.DbModels
{
    public class Month: BaseEntity
    {
        public int MonthNumber { get; private set; }

        List<MTask> wTasks = new List<MTask>();

    }
}
