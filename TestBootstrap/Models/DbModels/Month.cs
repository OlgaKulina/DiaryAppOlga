using System.Collections.Generic;


namespace DiaryAppOlga.Models.DbModels
{
    public class Month: BaseEntity
    {
        public int MonthNumber { get; set; }
        public List<MTask> mTasks { get; set; }


        //List<MTask> wTasks = new List<MTask>();

    }
}
