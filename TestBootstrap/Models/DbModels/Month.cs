using System.Collections.Generic;


namespace DiaryAppOlga.Models.DbModels
{
    public class Month: BaseEntity
    {
        public int MonthNumber { get; set; }
        public virtual List<MTask> MTasks { get; set; }
       

    }
}
