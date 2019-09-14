using System.Collections.Generic;


namespace DiaryAppOlga.Models.DbModels
{
    public class Day : BaseEntity
    {
        public int DayNumber { get; set; }
        public List<DTask> dTasks {get; set;}

                            
        
    }
}
